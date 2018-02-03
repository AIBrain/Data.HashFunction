namespace System.Data.HashFunction.Test {

    internal sealed class TestConstants {

        // Constant values available for KnownValues to use.
        public static readonly Byte[] Empty = new Byte[0];

        public static readonly Byte[] FooBar = "foobar".ToBytes();

        public static readonly Byte[] LoremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.  Ut ornare aliquam mauris, at volutpat massa.  Phasellus pulvinar purus eu venenatis commodo.".ToBytes();

        public static readonly Byte[] RandomLong = "1122eeba86d52989b26b0efd2be8d091d3ad307b771ff8d1208104f9aa40b12ab057a0d78656ba037e475178c159bf3ee64dcd279610d64bb7888a97211884c7a894378263135124720ef6ef560da6c85fb491cb732b331e89bcb00e7daef271e127483e91b189ceeaf2f6711394e2eca07fb4db62c5a8fd8195ae3b39da63".HexToBytes();
        public static readonly Byte[] RandomShort = "55d0e01ec669dc69".HexToBytes();
    }
}
