﻿using System.Collections.Generic;
using System.Data.HashFunction.Test.Mocks;
using System.IO;
using System.Linq;
using System.Threading;

namespace System.Data.HashFunction.Test {

    using Diagnostics;
    using Xunit;

    public abstract class IHashFunction_SpeedTest {
        private const Int32 MULTIPLE_ITEMS_COUNT = 0x10000;

        private const Int32 MULTIPLE_ITEMS_SIZE = 0x80;

        private const Int32 SINGLE_BLOCK_SIZE = 12000000;

        // xUnit doesn't have a better way to do this
        private readonly Boolean _SkipAllTests = true;

        protected abstract IReadOnlyDictionary<String, IHashFunction> TestHashFunctions { get; }

        // 32 MB

        private void IHashFunction_SpeedTest_SingleBlock( Func<Stopwatch, IHashFunction, Byte[], Boolean> computeHash ) {
            if ( _SkipAllTests ) {
                Console.Write( "Skipped, unset _SkipAllTests in IHashFunction_SpeedTest.cs" );
                return;
            }

            var testBytes = new Byte[SINGLE_BLOCK_SIZE];

            ( new Random() )
                .NextBytes( testBytes );

            var sw = new Stopwatch();

            foreach ( var testHashFunction in TestHashFunctions.OrderBy( kv => kv.Key ) ) {

                // Test if computeHash results in a valid test and initialize any lazy settings
                if ( !computeHash( sw, testHashFunction.Value, testBytes ) )
                    continue;

                sw.Reset();

                Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
                Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;

                // Real test
                var computeCount = 0;
                while ( sw.Elapsed < new TimeSpan( 0, 0, 0, 1, 0 ) || computeCount < 3 ) {
                    computeHash( sw, testHashFunction.Value, testBytes );
                    ++computeCount;
                }

                Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.Normal;
                Thread.CurrentThread.Priority = ThreadPriority.Normal;

                var totalBytesComputedAgainst = ( ( Int64 )testBytes.Length ) * computeCount;

                Console.WriteLine( "{0, -40} {1:F2} MB/s ({2} B in {3:F3} ms)",
                    testHashFunction.Key + ":",
                    totalBytesComputedAgainst / 1048576.0d / sw.Elapsed.TotalSeconds,
                    totalBytesComputedAgainst,
                    sw.ElapsedMilliseconds );

                sw.Reset();
            }
        }

        protected void IHashFunction_SpeedTest_MultipleItems( Func<Stopwatch, IHashFunction, Int32, Byte[], Boolean> computeHash ) {
            if ( _SkipAllTests ) {
                Console.Write( "Skipped, unset _SkipAllTests in IHashFunction_SpeedTest.cs" );
                return;
            }

            var testBytes = new Byte[MULTIPLE_ITEMS_SIZE];

            ( new Random() )
                .NextBytes( testBytes );

            var sw = new Stopwatch();

            foreach ( var testHashFunction in TestHashFunctions.OrderBy( kv => kv.Key ) ) {

                // Test if computeHash results in a valid test and initialize any lazy settings
                if ( !computeHash( sw, testHashFunction.Value, 1, testBytes ) )
                    continue;

                sw.Reset();

                // Real test
                computeHash( sw, testHashFunction.Value, MULTIPLE_ITEMS_COUNT, testBytes );

                Console.WriteLine( "{0, -40} {1:F2} MB/s ({2} B in {3:F3} ms)",
                    testHashFunction.Key + ":",
                    ( testBytes.Length * MULTIPLE_ITEMS_COUNT ) / ( 1048510.0d ) / ( ( Double )sw.ElapsedTicks / TimeSpan.TicksPerSecond ),
                    testBytes.Length * MULTIPLE_ITEMS_COUNT,
                    ( ( Double )sw.ElapsedTicks / TimeSpan.TicksPerMillisecond ) );

                sw.Reset();
            }
        }

        [Fact]
        public void IHashFunction_SpeedTest_MultipleItems_ComputeHash_ByteArray() {
            IHashFunction_SpeedTest_MultipleItems( ( sw, testHashFunction, count, testBytes ) => {
                sw.Start();

                for ( Int32 x = 0; x < count; ++x )
                    testHashFunction.ComputeHash( testBytes );

                sw.Stop();

                return true;
            } );
        }

        [Fact]
        public void IHashFunction_SpeedTest_MultipleItems_ComputeHash_Stream_NonSeekable() {
            IHashFunction_SpeedTest_MultipleItems( ( sw, testHashFunction, count, testBytes ) => {
                using ( var ms = new NonSeekableMemoryStream( testBytes ) ) {
                    sw.Start();

                    for ( Int32 x = 0; x < count; ++x ) {
                        testHashFunction.ComputeHash( ms );

                        ms.Real_Seek( 0, SeekOrigin.Begin );
                    }

                    sw.Stop();
                }

                return true;
            } );
        }

        [Fact]
        public void IHashFunction_SpeedTest_MultipleItems_ComputeHash_Stream_Seekable() {
            IHashFunction_SpeedTest_MultipleItems( ( sw, testHashFunction, count, testBytes ) => {
                using ( var ms = new MemoryStream( testBytes ) ) {
                    sw.Start();

                    for ( Int32 x = 0; x < count; ++x ) {
                        testHashFunction.ComputeHash( ms );

                        ms.Seek( 0, SeekOrigin.Begin );
                    }

                    sw.Stop();

                    return true;
                }
            } );
        }

        [Fact]
        public void IHashFunction_SpeedTest_MultipleItems_ComputeHashAsync_Stream_NonSeekable() {
            IHashFunction_SpeedTest_MultipleItems( ( sw, testHashFunction, count, testBytes ) => {
                var testHashFunctionAsync = testHashFunction as IHashFunctionAsync;

                if ( testHashFunctionAsync == null )
                    return false;

                using ( var ms = new NonSeekableMemoryStream( testBytes ) ) {
                    sw.Start();

                    for ( Int32 x = 0; x < count; ++x ) {
                        testHashFunctionAsync.ComputeHashAsync( ms )
                            .Wait();

                        ms.Real_Seek( 0, SeekOrigin.Begin );
                    }

                    sw.Stop();
                }

                return true;
            } );
        }

        [Fact]
        public void IHashFunction_SpeedTest_MultipleItems_ComputeHashAsync_Stream_Seekable() {
            IHashFunction_SpeedTest_MultipleItems( ( sw, testHashFunction, count, testBytes ) => {
                var testHashFunctionAsync = testHashFunction as IHashFunctionAsync;

                if ( testHashFunctionAsync == null )
                    return false;

                using ( var ms = new MemoryStream( testBytes ) ) {
                    sw.Start();

                    for ( Int32 x = 0; x < count; ++x ) {
                        testHashFunctionAsync.ComputeHashAsync( ms )
                            .Wait();

                        ms.Seek( 0, SeekOrigin.Begin );
                    }

                    sw.Stop();
                }

                return true;
            } );
        }

        // 128 B 64 K
        [Fact]
        public void IHashFunction_SpeedTest_SingleBlock_ComputeHash_ByteArray() {
            IHashFunction_SpeedTest_SingleBlock( ( sw, testHashFunction, testBytes ) => {
                sw.Start();
                {
                    testHashFunction.ComputeHash( testBytes );
                }
                sw.Stop();

                return true;
            } );
        }

        [Fact]
        public void IHashFunction_SpeedTest_SingleBlock_ComputeHash_Stream_NonSeekable() {
            IHashFunction_SpeedTest_SingleBlock( ( sw, testHashFunction, testBytes ) => {
                using ( var ms = new NonSeekableMemoryStream( testBytes ) ) {
                    sw.Start();
                    {
                        testHashFunction.ComputeHash( ms );
                    }
                    sw.Stop();
                }

                return true;
            } );
        }

        [Fact]
        public void IHashFunction_SpeedTest_SingleBlock_ComputeHash_Stream_Seekable() {
            IHashFunction_SpeedTest_SingleBlock( ( sw, testHashFunction, testBytes ) => {
                using ( var ms = new MemoryStream( testBytes ) ) {
                    sw.Start();
                    {
                        testHashFunction.ComputeHash( ms );
                    }
                    sw.Stop();

                    return true;
                }
            } );
        }

        // Note:  SpeedTests should run non-async to get the most accurate results

        [Fact]
        public void IHashFunction_SpeedTest_SingleBlock_ComputeHashAsync_Stream_NonSeekable() {
            IHashFunction_SpeedTest_SingleBlock( ( sw, testHashFunction, testBytes ) => {
                var testHashFunctionAsync = testHashFunction as IHashFunctionAsync;

                if ( testHashFunctionAsync == null )
                    return false;

                using ( var ms = new NonSeekableMemoryStream( testBytes ) ) {
                    sw.Start();
                    {
                        testHashFunctionAsync.ComputeHashAsync( ms )
                            .Wait();
                    }
                    sw.Stop();
                }

                return true;
            } );
        }

        [Fact]
        public void IHashFunction_SpeedTest_SingleBlock_ComputeHashAsync_Stream_Seekable() {
            IHashFunction_SpeedTest_SingleBlock( ( sw, testHashFunction, testBytes ) => {
                var testHashFunctionAsync = testHashFunction as IHashFunctionAsync;

                if ( testHashFunctionAsync == null )
                    return false;

                using ( var ms = new MemoryStream( testBytes ) ) {
                    sw.Start();
                    {
                        testHashFunctionAsync.ComputeHashAsync( ms )
                            .Wait();
                    }
                    sw.Stop();
                }

                return true;
            } );
        }
    }
}
