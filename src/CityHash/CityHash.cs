﻿using System.Collections.Generic;
using System.Data.HashFunction.Utilities;
using System.Data.HashFunction.Utilities.IntegerManipulation;
using System.Data.HashFunction.Utilities.UnifiedData;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Data.HashFunction {

    /// <summary>
    /// Implementation of CityHash as specified at https://code.google.com/p/cityhash/.
    ///
    /// " CityHash provides hash functions for strings. The functions mix the input bits thoroughly
    /// but are not suitable for cryptography.
    ///
    /// [Hash size of 128-bits is] tuned for strings of at least a few hundred bytes. Depending on
    /// your compiler and hardware, it's likely faster than [the hash size of 64-bits] on
    /// sufficiently long strings. It's slower than necessary on shorter strings, but we expect that
    /// case to be relatively unimportant. "
    /// </summary>
    public class CityHash
#if !NET40 || INCLUDE_ASYNC
        : HashFunctionAsyncBase
#else
        : HashFunctionBase
#endif
    {
        /// <summary>
        /// The list of possible hash sizes that can be provided to the <see cref="CityHash"/> constructor.
        /// </summary>
        /// <value>The list of valid hash sizes.</value>
        public static IEnumerable<Int32> ValidHashSizes { get { return _ValidHashSizes; } }

        /// <inheritdoc/>
        protected override Boolean RequiresSeekableStream { get { return true; } }

        /// <summary>
        /// Constant k0 as defined by CityHash specification.
        /// </summary>
        protected const UInt64 k0 = 0xc3a5c85c97cb3127;

        /// <summary>
        /// Constant k1 as defined by CityHash specification.
        /// </summary>
        protected const UInt64 k1 = 0xb492b66fbe98f273;

        /// <summary>
        /// Constant k2 as defined by CityHash specification.
        /// </summary>
        protected const UInt64 k2 = 0x9ae16a3b2f90404f;

        /// <summary>
        /// Constant c1 as defined by CityHash specification.
        /// </summary>
        protected const UInt32 c1 = 0xcc9e2d51;

        /// <summary>
        /// Constant c2 as defined by CityHash specification.
        /// </summary>
        protected const UInt32 c2 = 0x1b873593;

        private static readonly IEnumerable<Int32> _ValidHashSizes = new[] { 32, 64, 128 };

        /// <remarks>Defaults <see cref="HashFunctionBase.HashSize"/> to 32. <inheritdoc cref="CityHash(int)"/></remarks>
        /// <inheritdoc cref="CityHash(int)"/>
        public CityHash()
            : this( 32 ) {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CityHash"/> class.
        /// </summary>
        /// <param name="hashSize"><inheritdoc cref="HashFunctionBase(int)" select="param[name=hashSize]"/></param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// hashSize;hashSize must be contained within CityHash.ValidHashSizes.
        /// </exception>
        /// <inheritdoc cref="HashFunctionBase(int)"/>
        public CityHash( Int32 hashSize )
            : base( hashSize ) {
            if ( !ValidHashSizes.Contains( hashSize ) ) {
                throw new ArgumentOutOfRangeException( nameof(hashSize), "hashSize must be contained within CityHash.ValidHashSizes." );
            }
        }

        /// <exception cref="System.InvalidOperationException">HashSize set to an invalid value.</exception>
        /// <inheritdoc/>
        protected override Byte[] ComputeHashInternal( UnifiedData data ) {
            Byte[] hash = null;
            var dataArray = data.ToArray();

            switch ( HashSize ) {
                case 32:
                    hash = BitConverter.GetBytes(
                        ComputeHash32( dataArray ) );

                    break;

                case 64:
                    hash = BitConverter.GetBytes(
                        ComputeHash64( dataArray ) );

                    break;

                case 128:
                    var result = ComputeHash128( dataArray );

                    hash = new Byte[16];

                    BitConverter.GetBytes( result.Low )
                        .CopyTo( hash, 0 );

                    BitConverter.GetBytes( result.High )
                        .CopyTo( hash, 8 );

                    break;
            }

            return hash;
        }

#if !NET40 || INCLUDE_ASYNC

        /// <exception cref="System.InvalidOperationException">HashSize set to an invalid value.</exception>
        /// <inheritdoc/>
        protected override async Task<Byte[]> ComputeHashAsyncInternal( UnifiedData data ) {
            Byte[] hash = null;
            var dataArray = await data.ToArrayAsync()
                .ConfigureAwait( false );

            switch ( HashSize ) {
                case 32:
                    hash = BitConverter.GetBytes(
                        ComputeHash32( dataArray ) );

                    break;

                case 64:
                    hash = BitConverter.GetBytes(
                        ComputeHash64( dataArray ) );

                    break;

                case 128:
                    var result = ComputeHash128( dataArray );

                    hash = new Byte[16];

                    BitConverter.GetBytes( result.Low )
                        .CopyTo( hash, 0 );

                    BitConverter.GetBytes( result.High )
                        .CopyTo( hash, 8 );

                    break;
            }

            return hash;
        }

#endif

        /// <summary>
        /// 32-bit implementation of ComputeHash.
        /// </summary>
        /// <param name="data">Data to be hashed.</param>
        /// <returns>UInt32 value representing the hash value.</returns>
        protected virtual UInt32 ComputeHash32( Byte[] data ) {
            if ( data.Length <= 24 ) {
                if ( data.Length <= 12 ) {
                    return ( data.Length <= 4 ? Hash32Len0to4( data ) : Hash32Len5to12( data ) );
                }
                else {
                    return Hash32Len13to24( data );
                }
            }

            // data.Length > 24
            var h = ( UInt32 )data.Length;
            var g = ( UInt32 )data.Length * c1;
            var f = g;

            {
                var a0 = ( BitConverter.ToUInt32( data, data.Length - 4 ) * c1 ).RotateRight( 17 ) * c2;
                var a1 = ( BitConverter.ToUInt32( data, data.Length - 8 ) * c1 ).RotateRight( 17 ) * c2;
                var a2 = ( BitConverter.ToUInt32( data, data.Length - 16 ) * c1 ).RotateRight( 17 ) * c2;
                var a3 = ( BitConverter.ToUInt32( data, data.Length - 12 ) * c1 ).RotateRight( 17 ) * c2;
                var a4 = ( BitConverter.ToUInt32( data, data.Length - 20 ) * c1 ).RotateRight( 17 ) * c2;

                h ^= a0;
                h = h.RotateRight( 19 );
                h = h * 5 + 0xe6546b64;
                h ^= a2;
                h = h.RotateRight( 19 );
                h = h * 5 + 0xe6546b64;

                g ^= a1;
                g = g.RotateRight( 19 );
                g = g * 5 + 0xe6546b64;
                g ^= a3;
                g = g.RotateRight( 19 );
                g = g * 5 + 0xe6546b64;

                f += a4;
                f = f.RotateRight( 19 );
                f = f * 5 + 0xe6546b64;
            }

            for ( var x = 0; x < ( data.Length - 1 ) / 20; ++x ) {
                var a0 = ( BitConverter.ToUInt32( data, 20 * x + 0 ) * c1 ).RotateRight( 17 ) * c2;
                var a1 = BitConverter.ToUInt32( data, 20 * x + 4 );
                var a2 = ( BitConverter.ToUInt32( data, 20 * x + 8 ) * c1 ).RotateRight( 17 ) * c2;
                var a3 = ( BitConverter.ToUInt32( data, 20 * x + 12 ) * c1 ).RotateRight( 17 ) * c2;
                var a4 = BitConverter.ToUInt32( data, 20 * x + 16 );

                h ^= a0;
                h = h.RotateRight( 18 );
                h = h * 5 + 0xe6546b64;

                f += a1;
                f = f.RotateRight( 19 );
                f = f * c1;

                g += a2;
                g = g.RotateRight( 18 );
                g = g * 5 + 0xe6546b64;

                h ^= a3 + a1;
                h = h.RotateRight( 19 );
                h = h * 5 + 0xe6546b64;

                g ^= a4;
                g = g.ReverseByteOrder() * 5;

                h += a4 * 5;
                h = h.ReverseByteOrder();

                f += a0;

                Permute3( ref f, ref h, ref g );
            }

            g = g.RotateRight( 11 ) * c1;
            g = g.RotateRight( 17 ) * c1;

            f = f.RotateRight( 11 ) * c1;
            f = f.RotateRight( 17 ) * c1;

            h = ( h + g ).RotateRight( 19 );
            h = h * 5 + 0xe6546b64;
            h = h.RotateRight( 17 ) * c1;
            h = ( h + f ).RotateRight( 19 );
            h = h * 5 + 0xe6546b64;
            h = h.RotateRight( 17 ) * c1;

            return h;
        }

#if !NET40

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
#endif
        private static UInt32 Hash32Len0to4( Byte[] data ) {
            UInt32 b = 0;
            UInt32 c = 9;

            foreach ( var v in data ) {
                b = b * c1 + v;
                c ^= b;
            }

            return Mix( Mur( b, Mur( ( UInt32 )data.Length, c ) ) );
        }

#if !NET40

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
#endif
        private static UInt32 Hash32Len5to12( Byte[] data ) {
            var a = ( UInt32 )data.Length;
            var b = ( UInt32 )data.Length * 5;

            UInt32 c = 9;
            var d = b;

            a += BitConverter.ToUInt32( data, 0 );
            b += BitConverter.ToUInt32( data, data.Length - 4 );
            c += BitConverter.ToUInt32( data, ( data.Length >> 1 ) & 4 );

            return Mix( Mur( c, Mur( b, Mur( a, d ) ) ) );
        }

#if !NET40

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
#endif
        private static UInt32 Hash32Len13to24( Byte[] data ) {
            var a = BitConverter.ToUInt32( data, ( data.Length >> 1 ) - 4 );
            var b = BitConverter.ToUInt32( data, 4 );
            var c = BitConverter.ToUInt32( data, data.Length - 8 );
            var d = BitConverter.ToUInt32( data, data.Length >> 1 );
            var e = BitConverter.ToUInt32( data, 0 );
            var f = BitConverter.ToUInt32( data, data.Length - 4 );
            var h = ( UInt32 )data.Length;

            return Mix( Mur( f, Mur( e, Mur( d, Mur( c, Mur( b, Mur( a, h ) ) ) ) ) ) );
        }

        /// <summary>
        /// 64-bit implementation of ComputeHash.
        /// </summary>
        /// <param name="data">Data to be hashed.</param>
        /// <returns>UInt64 value representing the hash value.</returns>
        protected virtual UInt64 ComputeHash64( Byte[] data ) {
            if ( data.Length <= 32 ) {
                if ( data.Length <= 16 ) {
                    return HashLen0to16( data );
                }
                else {
                    return HashLen17to32( data );
                }
            }
            else if ( data.Length <= 64 ) {
                return HashLen33to64( data );
            }

            // For strings over 64 bytes we hash the end first, and then as we loop we keep 56 bytes
            // of state: v, w, x, y, and z.
            var x = BitConverter.ToUInt64( data, data.Length - 40 );
            var y = BitConverter.ToUInt64( data, data.Length - 16 ) + BitConverter.ToUInt64( data, data.Length - 56 );
            var z = HashLen16(
                BitConverter.ToUInt64( data, data.Length - 48 ) + ( UInt64 )data.Length,
                BitConverter.ToUInt64( data, data.Length - 24 ) );

            var v = WeakHashLen32WithSeeds( data, data.Length - 64, ( UInt64 )data.Length, z );
            var w = WeakHashLen32WithSeeds( data, data.Length - 32, y + k1, x );

            x = x * k1 + BitConverter.ToUInt64( data, 0 );

            for ( var i = 0; i < data.Length >> 6; ++i ) {
                x = ( x + y + v.Low + BitConverter.ToUInt64( data, 64 * i + 8 ) ).RotateRight( 37 ) * k1;
                y = ( y + v.High + BitConverter.ToUInt64( data, 64 * i + 48 ) ).RotateRight( 42 ) * k1;
                x ^= w.High;
                y += v.Low + BitConverter.ToUInt64( data, 64 * i + 40 );
                z = ( z + w.Low ).RotateRight( 33 ) * k1;
                v = WeakHashLen32WithSeeds( data, 64 * i, v.High * k1, x + w.Low );
                w = WeakHashLen32WithSeeds( data, 64 * i + 32, z + w.High, y + BitConverter.ToUInt64( data, 64 * i + 16 ) );

                var temp = x;
                x = z;
                z = temp;
            }

            return HashLen16( HashLen16( v.Low, w.Low ) + Mix( y ) * k1 + z,
                            HashLen16( v.High, w.High ) + x );
        }

#if !NET40

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
#endif
        private static UInt64 HashLen16( UInt64 u, UInt64 v ) {
            return Hash128to64( new UInt128() { Low = u, High = v } );
        }

#if !NET40

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
#endif
        private static UInt64 HashLen16( UInt64 u, UInt64 v, UInt64 mul ) {
            var a = ( u ^ v ) * mul;
            a ^= ( a >> 47 );

            var b = ( v ^ a ) * mul;
            b ^= ( b >> 47 );
            b *= mul;

            return b;
        }

#if !NET40

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
#endif
        private static UInt64 HashLen0to16( Byte[] data ) {
            if ( data.Length >= 8 ) {
                var mul = k2 + ( UInt64 )data.Length * 2;
                var a = BitConverter.ToUInt64( data, 0 ) + k2;
                var b = BitConverter.ToUInt64( data, data.Length - 8 );
                var c = b.RotateRight( 37 ) * mul + a;
                var d = ( a.RotateRight( 25 ) + b ) * mul;

                return HashLen16( c, d, mul );
            }

            if ( data.Length >= 4 ) {
                var mul = k2 + ( UInt64 )data.Length * 2;
                UInt64 a = BitConverter.ToUInt32( data, 0 );
                return HashLen16( ( UInt64 )data.Length + ( a << 3 ), BitConverter.ToUInt32( data, data.Length - 4 ), mul );
            }

            if ( data.Length > 0 ) {
                var a = data[0];
                var b = data[data.Length >> 1];
                var c = data[data.Length - 1];

                var y = ( UInt32 )a + ( ( UInt32 )b << 8 );
                var z = ( UInt32 )data.Length + ( ( UInt32 )c << 2 );

                return Mix( ( UInt64 )( y * k2 ^ z * k0 ) ) * k2;
            }

            return k2;
        }

        // This probably works well for 16-byte strings as well, but it may be overkill in that case.
#if !NET40

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
#endif
        private static UInt64 HashLen17to32( Byte[] data ) {
            var mul = k2 + ( UInt64 )data.Length * 2;
            var a = BitConverter.ToUInt64( data, 0 ) * k1;
            var b = BitConverter.ToUInt64( data, 8 );
            var c = BitConverter.ToUInt64( data, data.Length - 8 ) * mul;
            var d = BitConverter.ToUInt64( data, data.Length - 16 ) * k2;

            return HashLen16( ( a + b ).RotateRight( 43 ) + c.RotateRight( 30 ) + d,
                             a + ( b + k2 ).RotateRight( 18 ) + c, mul );
        }

        // Return a 16-byte hash for 48 bytes. Quick and dirty. Callers do best to use
        // "random-looking" values for a and b.
#if !NET40

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
#endif
        private static UInt128 WeakHashLen32WithSeeds(
            UInt64 w, UInt64 x, UInt64 y, UInt64 z, UInt64 a, UInt64 b ) {
            a += w;
            b = ( b + a + z ).RotateRight( 21 );

            var c = a;
            a += x;
            a += y;

            b += a.RotateRight( 44 );

            return new UInt128() { Low = a + z, High = b + c };
        }

        // Return a 16-byte hash for s[0] ... s[31], a, and b. Quick and dirty.
#if !NET40

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
#endif
        private static UInt128 WeakHashLen32WithSeeds( Byte[] data, Int32 startIndex, UInt64 a, UInt64 b ) {
            return WeakHashLen32WithSeeds(
                BitConverter.ToUInt64( data, startIndex ),
                BitConverter.ToUInt64( data, startIndex + 8 ),
                BitConverter.ToUInt64( data, startIndex + 16 ),
                BitConverter.ToUInt64( data, startIndex + 24 ),
                a,
                b );
        }

        // Return an 8-byte hash for 33 to 64 bytes.
#if !NET40

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
#endif
        private static UInt64 HashLen33to64( Byte[] data ) {
            var mul = k2 + ( UInt64 )data.Length * 2;
            var a = BitConverter.ToUInt64( data, 0 ) * k2;
            var b = BitConverter.ToUInt64( data, 8 );
            var c = BitConverter.ToUInt64( data, data.Length - 24 );
            var d = BitConverter.ToUInt64( data, data.Length - 32 );
            var e = BitConverter.ToUInt64( data, 16 ) * k2;
            var f = BitConverter.ToUInt64( data, 24 ) * 9;
            var g = BitConverter.ToUInt64( data, data.Length - 8 );
            var h = BitConverter.ToUInt64( data, data.Length - 16 ) * mul;

            var u = ( a + g ).RotateRight( 43 ) + ( b.RotateRight( 30 ) + c ) * 9;
            var v = ( ( a + g ) ^ d ) + f + 1;
            var w = ( ( u + v ) * mul ).ReverseByteOrder() + h;
            var x = ( e + f ).RotateRight( 42 ) + c;
            var y = ( ( ( v + w ) * mul ).ReverseByteOrder() + g ) * mul;
            var z = e + f + c;

            a = ( ( x + z ) * mul + y ).ReverseByteOrder() + b;
            b = Mix( ( z + a ) * mul + d + h ) * mul;
            return b + x;
        }

        /// <summary>
        /// 128-bit implementation of ComputeHash.
        /// </summary>
        /// <param name="data">Data to be hashed.</param>
        /// <returns>UInt128 value representing the hash value.</returns>
        protected virtual UInt128 ComputeHash128( Byte[] data ) {
            return
                data.Length >= 16 ?
                CityHash128WithSeed(
                    data.Skip( 16 ).ToArray(),
                    new UInt128() {
                        Low = BitConverter.ToUInt64( data, 0 ),
                        High = BitConverter.ToUInt64( data, 8 ) + k0
                    } ) :
                CityHash128WithSeed(
                    data,
                    new UInt128() {
                        Low = k0,
                        High = k1
                    } );
        }

        // A subroutine for CityHash128(). Returns a decent 128-bit hash for strings of any length
        // representable in signed long. Based on City and Murmur.
#if !NET40

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
#endif
        private static UInt128 CityMurmur( Byte[] data, UInt128 seed ) {
            var a = seed.Low;
            var b = seed.High;
            UInt64 c = 0;
            UInt64 d = 0;

            var l = data.Length - 16;
            if ( l <= 0 ) {  // len <= 16
                a = Mix( a * k1 ) * k1;
                c = b * k1 + HashLen0to16( data );
                d = Mix( a + ( data.Length >= 8 ? BitConverter.ToUInt64( data, 0 ) : c ) );
            }
            else {  // len > 16
                c = HashLen16( BitConverter.ToUInt64( data, data.Length - 8 ) + k1, a );
                d = HashLen16( b + ( UInt64 )data.Length, c + BitConverter.ToUInt64( data, data.Length - 16 ) );
                a += d;

                for ( var i = 0; i < ( data.Length - 1 ) / 16; ++i ) {
                    a ^= Mix( BitConverter.ToUInt64( data, i * 16 ) * k1 ) * k1;
                    a *= k1;
                    b ^= a;
                    c ^= Mix( BitConverter.ToUInt64( data, i * 16 + 8 ) * k1 ) * k1;
                    c *= k1;
                    d ^= c;
                }
            }
            a = HashLen16( a, c );
            b = HashLen16( d, b );
            return new UInt128() { Low = a ^ b, High = HashLen16( b, a ) };
        }

#if !NET40

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
#endif
        private static UInt128 CityHash128WithSeed( Byte[] data, UInt128 seed ) {
            if ( data.Length < 128 ) {
                return CityMurmur( data, seed );
            }

            // We expect len >= 128 to be the common case. Keep 56 bytes of state: v, w, x, y, and z.
            var v = new UInt128();
            v.Low = ( seed.High ^ k1 ).RotateRight( 49 ) * k1 + BitConverter.ToUInt64( data, 0 );
            v.High = ( v.Low ).RotateRight( 42 ) * k1 + BitConverter.ToUInt64( data, 8 );

            var w = new UInt128();
            w.Low = ( seed.High + ( ( UInt64 )data.LongLength * k1 ) ).RotateRight( 35 ) * k1 + seed.Low;
            w.High = ( seed.Low + BitConverter.ToUInt64( data, 88 ) ).RotateRight( 53 ) * k1;

            var x = seed.Low;
            var y = seed.High;
            var z = ( UInt64 )data.LongLength * k1;

            // This is the same inner loop as CityHash64(), manually unrolled.
            for ( var i = 0; i < data.Length / 128; ++i ) {
                x = ( x + y + v.Low + BitConverter.ToUInt64( data, ( 128 * i ) + 8 ) ).RotateRight( 37 ) * k1;
                y = ( y + v.High + BitConverter.ToUInt64( data, ( 128 * i ) + 48 ) ).RotateRight( 42 ) * k1;
                x ^= w.High;
                y += v.Low + BitConverter.ToUInt64( data, ( 128 * i ) + 40 );
                z = ( z + w.Low ).RotateRight( 33 ) * k1;
                v = WeakHashLen32WithSeeds( data, 128 * i, v.High * k1, x + w.Low );
                w = WeakHashLen32WithSeeds( data, ( 128 * i ) + 32, z + w.High, y + BitConverter.ToUInt64( data, ( 128 * i ) + 16 ) );

                {
                    var temp = z;
                    z = x;
                    x = temp;
                }

                x = ( x + y + v.Low + BitConverter.ToUInt64( data, ( 128 * i ) + 72 ) ).RotateRight( 37 ) * k1;
                y = ( y + v.High + BitConverter.ToUInt64( data, ( 128 * i ) + 112 ) ).RotateRight( 42 ) * k1;
                x ^= w.High;
                y += v.Low + BitConverter.ToUInt64( data, ( 128 * i ) + 104 );
                z = ( z + w.Low ).RotateRight( 33 ) * k1;
                v = WeakHashLen32WithSeeds( data, ( 128 * i ) + 64, v.High * k1, x + w.Low );
                w = WeakHashLen32WithSeeds( data, ( 128 * i ) + 96, z + w.High, y + BitConverter.ToUInt64( data, ( 128 * i ) + 80 ) );

                {
                    var temp = z;
                    z = x;
                    x = temp;
                }
            }

            x += ( v.Low + z ).RotateRight( 49 ) * k0;
            y = y * k0 + ( w.High ).RotateRight( 37 );
            z = z * k0 + ( w.Low ).RotateRight( 27 );
            w.Low *= 9;
            v.Low *= k0;

            // If 0 < len < 128, hash up to 4 chunks of 32 bytes each from the end of s.
            for ( var i = 1; i <= ( ( ( data.Length % 128 ) + 31 ) / 32 ); ++i ) {
                y = ( x + y ).RotateRight( 42 ) * k0 + v.High;
                w.Low += BitConverter.ToUInt64( data, data.Length - ( 32 * i ) + 16 );
                x = x * k0 + w.Low;
                z += w.High + BitConverter.ToUInt64( data, data.Length - ( 32 * i ) );
                w.High += v.Low;
                v = WeakHashLen32WithSeeds( data, data.Length - ( 32 * i ), v.Low + z, v.High );
                v.Low *= k0;
            }

            // At this point our 56 bytes of state should contain more than enough information for a
            // strong 128-bit hash. We use two different 56-byte-to-8-byte hashes to get a 16-byte
            // final result.
            x = HashLen16( x, v.Low );
            y = HashLen16( y + z, w.Low );

            return new UInt128() {
                Low = HashLen16( x + v.High, w.High ) + y,
                High = HashLen16( x + w.High, y + v.High )
            };
        }

#if !NET40

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
#endif
        private static UInt32 Mix( UInt32 h ) {
            h ^= h >> 16;
            h *= 0x85ebca6b;
            h ^= h >> 13;
            h *= 0xc2b2ae35;
            h ^= h >> 16;
            return h;
        }

#if !NET40

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
#endif
        private static UInt64 Mix( UInt64 val ) {
            return val ^ ( val >> 47 );
        }

#if !NET40

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
#endif
        private static UInt32 Mur( UInt32 a, UInt32 h ) {

            // Helper from Murmur3 for combining two 32-bit values.
            a *= c1;
            a = a.RotateRight( 17 );
            a *= c2;
            h ^= a;
            h = h.RotateRight( 19 );
            return h * 5 + 0xe6546b64;
        }

#if !NET40

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
#endif
        private static void Permute3( ref UInt32 a, ref UInt32 b, ref UInt32 c ) {
            var temp = a;

            a = c;
            c = b;
            b = temp;
        }

#if !NET40

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
#endif
        private static UInt64 Hash128to64( UInt128 x ) {
            const UInt64 kMul = 0x9ddfea08eb382d69;

            var a = ( x.Low ^ x.High ) * kMul;
            a ^= ( a >> 47 );

            var b = ( x.High ^ a ) * kMul;
            b ^= ( b >> 47 );
            b *= kMul;

            return b;
        }
    }
}
