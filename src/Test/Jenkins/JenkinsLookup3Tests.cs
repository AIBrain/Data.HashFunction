﻿using System.IO;

namespace System.Data.HashFunction.Test.Jenkins {

    using Xunit;

    public class JenkinsLookup3Tests {

        [Fact]
        public void JenkinsLookup3_32bit_ComputeHash_ExtremelyLongStream_Works() {
            Byte[] knownValue;

            {
                var loremIpsumRepeatCount = 800;
                var loremIpsumLength = TestConstants.LoremIpsum.Length;

                knownValue = new Byte[loremIpsumLength * loremIpsumRepeatCount];

                for ( var x = 0; x < loremIpsumRepeatCount; ++x )
                    Array.Copy( TestConstants.LoremIpsum, 0, knownValue, loremIpsumLength * x, loremIpsumLength );
            }

            var jenkinsLookup3 = new JenkinsLookup3( 32 );
            using ( var ms = new MemoryStream( knownValue ) ) {
                var resultBytes = jenkinsLookup3.ComputeHash( ms );

                Assert.Equal(
                    0x85c64fdU,
                    BitConverter.ToUInt32( resultBytes, 0 ) );
            }
        }
    }
}
