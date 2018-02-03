﻿//! Automatically generated from IHashFunctionTests_HashFunctionBase.tt
//! Direct modifications to this file will be lost.

using System.Collections.Generic;
using System.Data.HashFunction.Test.Mocks;
using System.Linq;
using System.Security.Cryptography;

namespace System.Data.HashFunction.Test
{

    #pragma warning disable 0618 // Disable ObsoleteAttribute warnings

    #region IHashFunctionTests

    #region Data.HashFunction.BernsteinHash

    public class IHashFunctionAsyncTests_BernsteinHash
        : IHashFunctionAsyncTests<BernsteinHash>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.Empty, 0x00000000),
                    new KnownValue(32, TestConstants.FooBar, 0xf6055bf9),
                    new KnownValue(32, TestConstants.LoremIpsum, 0x24bdc248),
                };
            }
        }

        protected override BernsteinHash CreateHashFunction(Int32 hashSize)
        {
            return new BernsteinHash();
        }
    }
    

    public class IHashFunctionAsyncTests_ModifiedBernsteinHash
        : IHashFunctionAsyncTests<ModifiedBernsteinHash>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.Empty, 0x00000000),
                    new KnownValue(32, TestConstants.FooBar, 0xf030b397),
                    new KnownValue(32, TestConstants.LoremIpsum, 0xfeceaf2a),
                };
            }
        }

        protected override ModifiedBernsteinHash CreateHashFunction(Int32 hashSize)
        {
            return new ModifiedBernsteinHash();
        }
    }
    

    #endregion

    #region Data.HashFunction.Blake2B

    public class IHashFunctionAsyncTests_Blake2B
        : IHashFunctionAsyncTests<Blake2B>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(8, TestConstants.Empty, 0x2E),
                    new KnownValue(16, TestConstants.Empty, 0xFEB1),
                    new KnownValue(32, TestConstants.Empty, 0x25CF7112),
                    new KnownValue(64, TestConstants.Empty, 0xB4B2797457A0A6E4L),
                    new KnownValue(128, TestConstants.Empty, "CAE66941D9EFBD404E4D88758EA67670"),
                    new KnownValue(256, TestConstants.Empty, "0E5751C026E543B2E8AB2EB06099DAA1D1E5DF47778F7787FAAB45CDF12FE3A8"),
                    new KnownValue(512, TestConstants.Empty, "786A02F742015903C6C6FD852552D272912F4740E15847618A86E217F71F5419D25E1031AFEE585313896444934EB04B903A685B1448B755D56F701AFE9BE2CE"),
                    new KnownValue(8, TestConstants.FooBar, 0x13),
                    new KnownValue(16, TestConstants.FooBar, 0xDF5F),
                    new KnownValue(32, TestConstants.FooBar, 0xD839266A),
                    new KnownValue(64, TestConstants.FooBar, 0xF9514A257F2F219DL),
                    new KnownValue(128, TestConstants.FooBar, "13B16EEC2597E4D5616A70B1ABD318B0"),
                    new KnownValue(256, TestConstants.FooBar, "93A0E84A8CDD4166267DBE1263E937F08087723AC24E7DCC35B3D5941775EF47"),
                    new KnownValue(512, TestConstants.FooBar, "8DF31F60D6AEABD01B7DC83F277D0E24CBE104F7290FF89077A7EB58646068EDFE1A83022866C46F65FB91612E516E0ECFA5CB25FC16B37D2C8D73732FE74CB2"),
                    new KnownValue(8, TestConstants.LoremIpsum, 0xC8),
                    new KnownValue(16, TestConstants.LoremIpsum, 0xA0A7),
                    new KnownValue(32, TestConstants.LoremIpsum, 0xE8C02DA7),
                    new KnownValue(64, TestConstants.LoremIpsum, 0x3BEDA4F6319326A0L),
                    new KnownValue(128, TestConstants.LoremIpsum, "FAF29FE101A0014E917BB8CA6F6F42B1"),
                    new KnownValue(256, TestConstants.LoremIpsum, "07DEFAFE398706F9FBD5FABBE63F38D2177D5FE10710B633A1B2A1EF585DBD41"),
                    new KnownValue(512, TestConstants.LoremIpsum, "F90D2E28E3A7E834FE6C3D27886D0E3E070586D1B6E5128FC260A909AB0176A17FB7D4AAF8396A6329C39B786BAF49E8393FDD986A08F6E5BC263F0CA4BF625A"),
                    new KnownValue(8, new Byte[4096], "FC"),
                    new KnownValue(16, new Byte[4096], "A031"),
                    new KnownValue(32, new Byte[4096], "228F3ACF"),
                    new KnownValue(64, new Byte[4096], "E218CB050E9903AC"),
                    new KnownValue(128, new Byte[4096], "5F6DF6002BC71CA2D81A7492DE37025D"),
                    new KnownValue(256, new Byte[4096], "686EDE9288C391E7E05026E56F2F91BFD879987A040EA98445DABC76F55B8E5F"),
                    new KnownValue(512, new Byte[4096], "F18C1BA69B093034FAA8EF722382F086547FDD178186AE216B5AE2434A318691032F3E7F55E8ACC841D07E7519E33C0F850AFBA006EC4EF9E2FC6CD91C7D5DFB"),
                };
            }
        }

        protected override Blake2B CreateHashFunction(Int32 hashSize)
        {
            return new Blake2B(hashSize);
        }
    }
    

    public class IHashFunctionAsyncTests_Blake2B_DefaultConstructor
        : IHashFunctionAsyncTests<Blake2B>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(512, TestConstants.Empty, "786A02F742015903C6C6FD852552D272912F4740E15847618A86E217F71F5419D25E1031AFEE585313896444934EB04B903A685B1448B755D56F701AFE9BE2CE"),
                    new KnownValue(512, TestConstants.FooBar, "8DF31F60D6AEABD01B7DC83F277D0E24CBE104F7290FF89077A7EB58646068EDFE1A83022866C46F65FB91612E516E0ECFA5CB25FC16B37D2C8D73732FE74CB2"),
                    new KnownValue(512, TestConstants.LoremIpsum, "F90D2E28E3A7E834FE6C3D27886D0E3E070586D1B6E5128FC260A909AB0176A17FB7D4AAF8396A6329C39B786BAF49E8393FDD986A08F6E5BC263F0CA4BF625A"),
                };
            }
        }

        protected override Blake2B CreateHashFunction(Int32 hashSize)
        {
            return new Blake2B();
        }
    }
    

    public class IHashFunctionAsyncTests_Blake2B_WithHashSizeAndFoobarAsKey
        : IHashFunctionAsyncTests<Blake2B>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(8, TestConstants.Empty, 0x1D),
                    new KnownValue(16, TestConstants.Empty, 0x73DC),
                    new KnownValue(32, TestConstants.Empty, 0x9A87498C),
                    new KnownValue(64, TestConstants.Empty, 0x9BFBF5F924B0A10DL),
                    new KnownValue(128, TestConstants.Empty, "1071A42316E10C29AE052635FDBB14F2"),
                    new KnownValue(256, TestConstants.Empty, "1DADAC7EA5D7F4122A26ABFD4171283EAD456C812ABA8BF089CC4C314F1BF9F2"),
                    new KnownValue(512, TestConstants.Empty, "B757DDC6AE9629278C5EF7747EA2FBB3324B88398F45C057CE5E3B23732CF35C627C948E07EA70CED77E77528F30A6F178FF59777C05D8D12F341A10A5AB2430"),
                    new KnownValue(8, TestConstants.FooBar, 0x42),
                    new KnownValue(16, TestConstants.FooBar, 0x891E),
                    new KnownValue(32, TestConstants.FooBar, 0x3B616D45),
                    new KnownValue(64, TestConstants.FooBar, 0x6F9D9A4C9AFD3F5EL),
                    new KnownValue(128, TestConstants.FooBar, "3D1760C86A25EB9C924ECCBB13076ECE"),
                    new KnownValue(256, TestConstants.FooBar, "73A66C48D128055BB22BCFF0D6316D3D5E829A2A1D9CB261581A7672803A6454"),
                    new KnownValue(512, TestConstants.FooBar, "47DC3AC6E0B7BFD83C653A92C8CBD9FF16A758DE82690483D90A6A905C917DF39691D54F3AF919A717379A87DEDF716192160BCE2EB5C02C775819ABD4066A12"),
                    new KnownValue(8, TestConstants.LoremIpsum, 0xB8),
                    new KnownValue(16, TestConstants.LoremIpsum, 0x80B6),
                    new KnownValue(32, TestConstants.LoremIpsum, 0x936D150E),
                    new KnownValue(64, TestConstants.LoremIpsum, 0xB630C582812A78FDL),
                    new KnownValue(128, TestConstants.LoremIpsum, "0E50AA3684C8B28871073DC540B8A36B"),
                    new KnownValue(256, TestConstants.LoremIpsum, "C065D225BD499FE9E7D2BEFD7588679AE9697EB3F0E43B63A474145720F33F74"),
                    new KnownValue(512, TestConstants.LoremIpsum, "B38035457007274B9BE1AAE5628744763E5D52F48CEF583A0FF24327630CDCE2D951C421E7350585782A92D0EA5C3F8DA20ECB1A04E6C25C5E8395C76589BCF2"),
                };
            }
        }

        protected override Blake2B CreateHashFunction(Int32 hashSize)
        {
            return new Blake2B(hashSize, TestConstants.FooBar, null, null);
        }
    }
    

    public class IHashFunctionAsyncTests_Blake2B_WithHashSizeAndFoobarAsKey_2
        : IHashFunctionAsyncTests<Blake2B>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(8, TestConstants.Empty, 0x1D),
                    new KnownValue(16, TestConstants.Empty, 0x73DC),
                    new KnownValue(32, TestConstants.Empty, 0x9A87498C),
                    new KnownValue(64, TestConstants.Empty, 0x9BFBF5F924B0A10DL),
                    new KnownValue(128, TestConstants.Empty, "1071A42316E10C29AE052635FDBB14F2"),
                    new KnownValue(256, TestConstants.Empty, "1DADAC7EA5D7F4122A26ABFD4171283EAD456C812ABA8BF089CC4C314F1BF9F2"),
                    new KnownValue(512, TestConstants.Empty, "B757DDC6AE9629278C5EF7747EA2FBB3324B88398F45C057CE5E3B23732CF35C627C948E07EA70CED77E77528F30A6F178FF59777C05D8D12F341A10A5AB2430"),
                    new KnownValue(8, TestConstants.FooBar, 0x42),
                    new KnownValue(16, TestConstants.FooBar, 0x891E),
                    new KnownValue(32, TestConstants.FooBar, 0x3B616D45),
                    new KnownValue(64, TestConstants.FooBar, 0x6F9D9A4C9AFD3F5EL),
                    new KnownValue(128, TestConstants.FooBar, "3D1760C86A25EB9C924ECCBB13076ECE"),
                    new KnownValue(256, TestConstants.FooBar, "73A66C48D128055BB22BCFF0D6316D3D5E829A2A1D9CB261581A7672803A6454"),
                    new KnownValue(512, TestConstants.FooBar, "47DC3AC6E0B7BFD83C653A92C8CBD9FF16A758DE82690483D90A6A905C917DF39691D54F3AF919A717379A87DEDF716192160BCE2EB5C02C775819ABD4066A12"),
                    new KnownValue(8, TestConstants.LoremIpsum, 0xB8),
                    new KnownValue(16, TestConstants.LoremIpsum, 0x80B6),
                    new KnownValue(32, TestConstants.LoremIpsum, 0x936D150E),
                    new KnownValue(64, TestConstants.LoremIpsum, 0xB630C582812A78FDL),
                    new KnownValue(128, TestConstants.LoremIpsum, "0E50AA3684C8B28871073DC540B8A36B"),
                    new KnownValue(256, TestConstants.LoremIpsum, "C065D225BD499FE9E7D2BEFD7588679AE9697EB3F0E43B63A474145720F33F74"),
                    new KnownValue(512, TestConstants.LoremIpsum, "B38035457007274B9BE1AAE5628744763E5D52F48CEF583A0FF24327630CDCE2D951C421E7350585782A92D0EA5C3F8DA20ECB1A04E6C25C5E8395C76589BCF2"),
                };
            }
        }

        protected override Blake2B CreateHashFunction(Int32 hashSize)
        {
            return new Blake2B(hashSize, TestConstants.FooBar);
        }
    }
    

    public class IHashFunctionAsyncTests_Blake2B_WithHashSizeAndFoobarAsKey_3
        : IHashFunctionAsyncTests<Blake2B>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(8, TestConstants.Empty, 0x1D),
                    new KnownValue(16, TestConstants.Empty, 0x73DC),
                    new KnownValue(32, TestConstants.Empty, 0x9A87498C),
                    new KnownValue(64, TestConstants.Empty, 0x9BFBF5F924B0A10DL),
                    new KnownValue(128, TestConstants.Empty, "1071A42316E10C29AE052635FDBB14F2"),
                    new KnownValue(256, TestConstants.Empty, "1DADAC7EA5D7F4122A26ABFD4171283EAD456C812ABA8BF089CC4C314F1BF9F2"),
                    new KnownValue(512, TestConstants.Empty, "B757DDC6AE9629278C5EF7747EA2FBB3324B88398F45C057CE5E3B23732CF35C627C948E07EA70CED77E77528F30A6F178FF59777C05D8D12F341A10A5AB2430"),
                    new KnownValue(8, TestConstants.FooBar, 0x42),
                    new KnownValue(16, TestConstants.FooBar, 0x891E),
                    new KnownValue(32, TestConstants.FooBar, 0x3B616D45),
                    new KnownValue(64, TestConstants.FooBar, 0x6F9D9A4C9AFD3F5EL),
                    new KnownValue(128, TestConstants.FooBar, "3D1760C86A25EB9C924ECCBB13076ECE"),
                    new KnownValue(256, TestConstants.FooBar, "73A66C48D128055BB22BCFF0D6316D3D5E829A2A1D9CB261581A7672803A6454"),
                    new KnownValue(512, TestConstants.FooBar, "47DC3AC6E0B7BFD83C653A92C8CBD9FF16A758DE82690483D90A6A905C917DF39691D54F3AF919A717379A87DEDF716192160BCE2EB5C02C775819ABD4066A12"),
                    new KnownValue(8, TestConstants.LoremIpsum, 0xB8),
                    new KnownValue(16, TestConstants.LoremIpsum, 0x80B6),
                    new KnownValue(32, TestConstants.LoremIpsum, 0x936D150E),
                    new KnownValue(64, TestConstants.LoremIpsum, 0xB630C582812A78FDL),
                    new KnownValue(128, TestConstants.LoremIpsum, "0E50AA3684C8B28871073DC540B8A36B"),
                    new KnownValue(256, TestConstants.LoremIpsum, "C065D225BD499FE9E7D2BEFD7588679AE9697EB3F0E43B63A474145720F33F74"),
                    new KnownValue(512, TestConstants.LoremIpsum, "B38035457007274B9BE1AAE5628744763E5D52F48CEF583A0FF24327630CDCE2D951C421E7350585782A92D0EA5C3F8DA20ECB1A04E6C25C5E8395C76589BCF2"),
                };
            }
        }

        protected override Blake2B CreateHashFunction(Int32 hashSize)
        {
            return new Blake2B(hashSize, key: TestConstants.FooBar);
        }
    }
    

    public class IHashFunctionAsyncTests_Blake2B_WithHashSizeAndFoobarAsKeySaltAndPersonalization
        : IHashFunctionAsyncTests<Blake2B>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(8, TestConstants.Empty, "FB"),
                    new KnownValue(16, TestConstants.Empty, "3D5F"),
                    new KnownValue(32, TestConstants.Empty, "DFADCB7A"),
                    new KnownValue(64, TestConstants.Empty, "92F9C87CE0FCEE18"),
                    new KnownValue(128, TestConstants.Empty, "5CCF9F50113584F685D11D6943B46CD0"),
                    new KnownValue(256, TestConstants.Empty, "ADCB400042AEBCE889504FCDB0CB03C0FA70759A4B82862E519EC660B7BB9FA2"),
                    new KnownValue(512, TestConstants.Empty, "CFA41ED7BB76DB018B437D3CCB8CAE173F6D1E263E14AD81FAFB15A7C021B7632A41EA466B2144A7D3AD81A38D606B493A262DAD3CA744D1B05137FACCF41AAD"),
                    new KnownValue(8, TestConstants.FooBar, "49"),
                    new KnownValue(16, TestConstants.FooBar, "F28B"),
                    new KnownValue(32, TestConstants.FooBar, "4953D80E"),
                    new KnownValue(64, TestConstants.FooBar, "8FBC1C12EA6719DC"),
                    new KnownValue(128, TestConstants.FooBar, "566381448006C6DC007AA394C8AC9A61"),
                    new KnownValue(256, TestConstants.FooBar, "0D08F3D0A7BD049910DC69F6F60C97FA78F7606A1C207AA86E91DEC8448BC3E5"),
                    new KnownValue(512, TestConstants.FooBar, "4AEAEBF914DA5536EC8B6A28A90B757D609EC3C3F88385F088821750E977ED452066A31E0B6C0ED6A3768441E64415D1CCBD794FC5576523F3C8136FDEE6C48B"),
                    new KnownValue(8, TestConstants.LoremIpsum, "4E"),
                    new KnownValue(16, TestConstants.LoremIpsum, "0886"),
                    new KnownValue(32, TestConstants.LoremIpsum, "F94F00E5"),
                    new KnownValue(64, TestConstants.LoremIpsum, "3184BEF8C6E8B921"),
                    new KnownValue(128, TestConstants.LoremIpsum, "A3301719E74429EBC01437A774A5B144"),
                    new KnownValue(256, TestConstants.LoremIpsum, "7B6D7B7B48800C5742DF2234611874F454FA88E56ABE17AE5EF80C3C0CA98C80"),
                    new KnownValue(512, TestConstants.LoremIpsum, "8116975D05A7B13F2BE9CAF7F676AF94FC2F2ED1AB1255154DF7E0BE43A352DD925029C9B4ACF7429A5C6E348DB28902F29D903B00F9B8B12B048624B2F4C91B"),
                };
            }
        }

        protected override Blake2B CreateHashFunction(Int32 hashSize)
        {
            return new Blake2B(hashSize, TestConstants.FooBar, TestConstants.FooBar.Concat(new Byte[10]), TestConstants.FooBar.Concat(new Byte[10]));
        }
    }
    

    public class IHashFunctionAsyncTests_Blake2B_WithHashSizeAndFoobarAsKeySaltAndPersonalization_2
        : IHashFunctionAsyncTests<Blake2B>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(8, TestConstants.Empty, "FB"),
                    new KnownValue(16, TestConstants.Empty, "3D5F"),
                    new KnownValue(32, TestConstants.Empty, "DFADCB7A"),
                    new KnownValue(64, TestConstants.Empty, "92F9C87CE0FCEE18"),
                    new KnownValue(128, TestConstants.Empty, "5CCF9F50113584F685D11D6943B46CD0"),
                    new KnownValue(256, TestConstants.Empty, "ADCB400042AEBCE889504FCDB0CB03C0FA70759A4B82862E519EC660B7BB9FA2"),
                    new KnownValue(512, TestConstants.Empty, "CFA41ED7BB76DB018B437D3CCB8CAE173F6D1E263E14AD81FAFB15A7C021B7632A41EA466B2144A7D3AD81A38D606B493A262DAD3CA744D1B05137FACCF41AAD"),
                    new KnownValue(8, TestConstants.FooBar, "49"),
                    new KnownValue(16, TestConstants.FooBar, "F28B"),
                    new KnownValue(32, TestConstants.FooBar, "4953D80E"),
                    new KnownValue(64, TestConstants.FooBar, "8FBC1C12EA6719DC"),
                    new KnownValue(128, TestConstants.FooBar, "566381448006C6DC007AA394C8AC9A61"),
                    new KnownValue(256, TestConstants.FooBar, "0D08F3D0A7BD049910DC69F6F60C97FA78F7606A1C207AA86E91DEC8448BC3E5"),
                    new KnownValue(512, TestConstants.FooBar, "4AEAEBF914DA5536EC8B6A28A90B757D609EC3C3F88385F088821750E977ED452066A31E0B6C0ED6A3768441E64415D1CCBD794FC5576523F3C8136FDEE6C48B"),
                    new KnownValue(8, TestConstants.LoremIpsum, "4E"),
                    new KnownValue(16, TestConstants.LoremIpsum, "0886"),
                    new KnownValue(32, TestConstants.LoremIpsum, "F94F00E5"),
                    new KnownValue(64, TestConstants.LoremIpsum, "3184BEF8C6E8B921"),
                    new KnownValue(128, TestConstants.LoremIpsum, "A3301719E74429EBC01437A774A5B144"),
                    new KnownValue(256, TestConstants.LoremIpsum, "7B6D7B7B48800C5742DF2234611874F454FA88E56ABE17AE5EF80C3C0CA98C80"),
                    new KnownValue(512, TestConstants.LoremIpsum, "8116975D05A7B13F2BE9CAF7F676AF94FC2F2ED1AB1255154DF7E0BE43A352DD925029C9B4ACF7429A5C6E348DB28902F29D903B00F9B8B12B048624B2F4C91B"),
                };
            }
        }

        protected override Blake2B CreateHashFunction(Int32 hashSize)
        {
            return new Blake2B(hashSize, key: TestConstants.FooBar, salt: TestConstants.FooBar.Concat(new Byte[10]), personalization: TestConstants.FooBar.Concat(new Byte[10]));
        }
    }
    

    public class IHashFunctionAsyncTests_Blake2B_CanonicalUnKeyed
        : IHashFunctionAsyncTests<Blake2B>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(512, Enumerable.Range(0,   0).Select(i => (Byte) i), "786A02F742015903C6C6FD852552D272912F4740E15847618A86E217F71F5419D25E1031AFEE585313896444934EB04B903A685B1448B755D56F701AFE9BE2CE"),
                    new KnownValue(512, Enumerable.Range(0,   1).Select(i => (Byte) i), "2FA3F686DF876995167E7C2E5D74C4C7B6E48F8068FE0E44208344D480F7904C36963E44115FE3EB2A3AC8694C28BCB4F5A0F3276F2E79487D8219057A506E4B"),
                    new KnownValue(512, Enumerable.Range(0,   2).Select(i => (Byte) i), "1C08798DC641ABA9DEE435E22519A4729A09B2BFE0FF00EF2DCD8ED6F8A07D15EAF4AEE52BBF18AB5608A6190F70B90486C8A7D4873710B1115D3DEBBB4327B5"),
                    new KnownValue(512, Enumerable.Range(0,   3).Select(i => (Byte) i), "40A374727302D9A4769C17B5F409FF32F58AA24FF122D7603E4FDA1509E919D4107A52C57570A6D94E50967AEA573B11F86F473F537565C66F7039830A85D186"),
                    new KnownValue(512, Enumerable.Range(0,   4).Select(i => (Byte) i), "77DDF4B14425EB3D053C1E84E3469D92C4CD910ED20F92035E0C99D8A7A86CECAF69F9663C20A7AA230BC82F60D22FB4A00B09D3EB8FC65EF547FE63C8D3DDCE"),
                    new KnownValue(512, Enumerable.Range(0,   5).Select(i => (Byte) i), "CBAA0BA7D482B1F301109AE41051991A3289BC1198005AF226C5E4F103B66579F461361044C8BA3439FF12C515FB29C52161B7EB9C2837B76A5DC33F7CB2E2E8"),
                    new KnownValue(512, Enumerable.Range(0,   6).Select(i => (Byte) i), "F95D45CF69AF5C2023BDB505821E62E85D7CAEDF7BEDA12C0248775B0C88205EEB35AF3A90816F6608CE7DD44EC28DB1140614E1DDEBF3AA9CD1843E0FAD2C36"),
                    new KnownValue(512, Enumerable.Range(0,   7).Select(i => (Byte) i), "8F945BA700F2530E5C2A7DF7D5DCE0F83F9EFC78C073FE71AE1F88204A4FD1CF70A073F5D1F942ED623AA16E90A871246C90C45B621B3401A5DDBD9DF6264165"),
                    new KnownValue(512, Enumerable.Range(0,   8).Select(i => (Byte) i), "E998E0DC03EC30EB99BB6BFAAF6618ACC620320D7220B3AF2B23D112D8E9CB1262F3C0D60D183B1EE7F096D12DAE42C958418600214D04F5ED6F5E718BE35566"),
                    new KnownValue(512, Enumerable.Range(0,   9).Select(i => (Byte) i), "6A9A090C61B3410AEDE7EC9138146CEB2C69662F460C3DA53C6515C1EB31F41CA3D280E567882F95CF664A94147D78F42CFC714A40D22EF19470E053493508A2"),
                    new KnownValue(512, Enumerable.Range(0,  10).Select(i => (Byte) i), "29102511D749DB3CC9B4E335FA1F5E8FACA8421D558F6A3F3321D50D044A248BA595CFC3EFD3D2ADC97334DA732413F5CBF4751C362BA1D53862AC1E8DABEEE8"),
                    new KnownValue(512, Enumerable.Range(0,  11).Select(i => (Byte) i), "C97A4779D47E6F77729B5917D0138ABB35980AB641BD73A8859EB1AC98C05362ED7D608F2E9587D6BA9E271D343125D40D933A8ED04EC1FE75EC407C7A53C34E"),
                    new KnownValue(512, Enumerable.Range(0,  12).Select(i => (Byte) i), "10F0DC91B9F845FB95FAD6860E6CE1ADFA002C7FC327116D44D047CD7D5870D772BB12B5FAC00E02B08AC2A0174D0446C36AB35F14CA31894CD61C78C849B48A"),
                    new KnownValue(512, Enumerable.Range(0,  13).Select(i => (Byte) i), "DEA9101CAC62B8F6A3C650F90EEA5BFAE2653A4EAFD63A6D1F0F132DB9E4F2B1B662432EC85B17BCAC41E775637881F6AAB38DD66DCBD080F0990A7A6E9854FE"),
                    new KnownValue(512, Enumerable.Range(0,  14).Select(i => (Byte) i), "441FFAA08CD79DFF4AFC9B9E5B5620EEC086730C25F661B1D6FBFBD1CEC3148DD72258C65641F2FCA5EB155FADBCABB13C6E21DC11FAF72C2A281B7D56145F19"),
                    new KnownValue(512, Enumerable.Range(0,  15).Select(i => (Byte) i), "444B240FE3ED86D0E2EF4CE7D851EDDE22155582AA0914797B726CD058B6F45932E0E129516876527B1DD88FC66D7119F4AB3BED93A61A0E2D2D2AEAC336D958"),
                    new KnownValue(512, Enumerable.Range(0,  16).Select(i => (Byte) i), "BFBABBEF45554CCFA0DC83752A19CC35D5920956B301D558D772282BC867009168E9E98606BB5BA73A385DE5749228C925A85019B71F72FE29B3CD37CA52EFE6"),
                    new KnownValue(512, Enumerable.Range(0,  17).Select(i => (Byte) i), "9C4D0C3E1CDBBF485BEC86F41CEC7C98373F0E09F392849AAA229EBFBF397B22085529CB7EF39F9C7C2222A514182B1EFFAA178CC3687B1B2B6CBCB6FDEB96F8"),
                    new KnownValue(512, Enumerable.Range(0,  18).Select(i => (Byte) i), "477176B3BFCBADD7657C23C24625E4D0D674D1868F006006398AF97AA41877C8E70D3D14C3BBC9BBCDCEA801BD0E1599AF1F3EEC67405170F4E26C964A57A8B7"),
                    new KnownValue(512, Enumerable.Range(0,  19).Select(i => (Byte) i), "A78C490EDA3173BB3F10DEE52F110FB1C08E0302230B85DDD7C11257D92DE148785EF00C039C0BB8EB9808A35B2D8C080F572859714C9D4069C5BCAF090E898E"),
                    new KnownValue(512, Enumerable.Range(0,  20).Select(i => (Byte) i), "58D023397BEB5B4145CB2255B07D74290B36D9FD1E594AFBD8EEA47C205B2EFBFE6F46190FAF95AF504AB072E36F6C85D767A321BFD7F22687A4ABBF494A689C"),
                    new KnownValue(512, Enumerable.Range(0,  21).Select(i => (Byte) i), "4001EC74D5A46FD29C2C3CDBE5D1B9F20E51A941BE98D2A4E1E2FBF866A672121DB6F81A514CFD10E7358D571BDBA48E4CE708B9D124894BC0B5ED554935F73A"),
                    new KnownValue(512, Enumerable.Range(0,  22).Select(i => (Byte) i), "CCD1B22DAB6511225D2401EA2D8625D206A12473CC732B615E5640CEFFF0A4ADF971B0E827A619E0A80F5DB9CCD0962329010D07E34A2064E731C520817B2183"),
                    new KnownValue(512, Enumerable.Range(0,  23).Select(i => (Byte) i), "B4A0A9E3574EDB9E1E72AA31E39CC5F30DBF943F8CABC408449654A39131E66D718A18819143E3EA96B4A1895988A1C0056CF2B6E04F9AC19D657383C2910C44"),
                    new KnownValue(512, Enumerable.Range(0,  24).Select(i => (Byte) i), "447BECAB16630608D39F4F058B16F7AF95B85A76AA0FA7CEA2B80755FB76E9C804F2CA78F02643C915FBF2FCE5E19DE86000DE03B18861815A83126071F8A37B"),
                    new KnownValue(512, Enumerable.Range(0,  25).Select(i => (Byte) i), "54E6DAB9977380A5665822DB93374EDA528D9BEB626F9B94027071CB26675E112B4A7FEC941EE60A81E4D2EA3FF7BC52CFC45DFBFE735A1C646B2CF6D6A49B62"),
                    new KnownValue(512, Enumerable.Range(0,  26).Select(i => (Byte) i), "3EA62625949E3646704D7E3C906F82F6C028F540F5F72A794B0C57BF97B7649BFEB90B01D3CA3E829DE21B3826E6F87014D3C77350CB5A15FF5D468A81BEC160"),
                    new KnownValue(512, Enumerable.Range(0,  27).Select(i => (Byte) i), "213CFE145C54A33691569980E5938C8883A46D84D149C8FF1A67CD287B4D49C6DA69D3A035443DB085983D0EFE63706BD5B6F15A7DA459E8D50A19093DB55E80"),
                    new KnownValue(512, Enumerable.Range(0,  28).Select(i => (Byte) i), "5716C4A38F38DB104E494A0A27CBE89A26A6BB6F499EC01C8C01AA7CB88497E75148CD6EEE12A7168B6F78AB74E4BE749251A1A74C38C86D6129177E2889E0B6"),
                    new KnownValue(512, Enumerable.Range(0,  29).Select(i => (Byte) i), "030460A98BDF9FF17CD96404F28FC304F2B7C04EAADE53677FD28F788CA22186B8BC80DD21D17F8549C711AFF0E514E19D4E15F5990252A03E082F28DC2052F6"),
                    new KnownValue(512, Enumerable.Range(0,  30).Select(i => (Byte) i), "19E7F1CCEE88A10672333E390CF22013A8C734C6CB9EAB41F17C3C8032A2E4ACA0569EA36F0860C7A1AF28FA476840D66011168859334A9E4EF9CC2E61A0E29E"),
                    new KnownValue(512, Enumerable.Range(0,  31).Select(i => (Byte) i), "29F8B8C78C80F2FCB4BDF7825ED90A70D625FF785D262677E250C04F3720C888D03F8045E4EDF3F5285BD39D928A10A7D0A5DF00B8484AC2868142A1E8BEA351"),
                    new KnownValue(512, Enumerable.Range(0,  32).Select(i => (Byte) i), "5C52920A7263E39D57920CA0CB752AC6D79A04FEF8A7A216A1ECB7115CE06D89FD7D735BD6F4272555DBA22C2D1C96E6352322C62C5630FDE0F4777A76C3DE2C"),
                    new KnownValue(512, Enumerable.Range(0,  33).Select(i => (Byte) i), "83B098F262251BF660064A9D3511CE7687A09E6DFBB878299C30E93DFB43A9314DB9A600337DB26EBEEDAF2256A96DABE9B29E7573AD11C3523D874DDE5BE7ED"),
                    new KnownValue(512, Enumerable.Range(0,  34).Select(i => (Byte) i), "9447D98AA5C9331352F43D3E56D0A9A9F9581865998E2885CC56DD0A0BD5A7B50595BD10F7529BCD31F37DC16A1465D594079667DA2A3FCB70401498837CEDEB"),
                    new KnownValue(512, Enumerable.Range(0,  35).Select(i => (Byte) i), "867732F2FEEB23893097561AC710A4BFF453BE9CFBEDBA8BA324F9D312A82D732E1B83B829FDCD177B882CA0C1BF544B223BE529924A246A63CF059BFDC50A1B"),
                    new KnownValue(512, Enumerable.Range(0,  36).Select(i => (Byte) i), "F15AB26D4CDFCF56E196BB6BA170A8FCCC414DE9285AFD98A3D3CF2FB88FCBC0F19832AC433A5B2CC2392A4CE34332987D8D2C2BEF6C3466138DB0C6E42FA47B"),
                    new KnownValue(512, Enumerable.Range(0,  37).Select(i => (Byte) i), "2813516D68ED4A08B39D648AA6AACD81E9D655ECD5F0C13556C60FDF0D333EA38464B36C02BACCD746E9575E96C63014F074AE34A0A25B320F0FBEDD6ACF7665"),
                    new KnownValue(512, Enumerable.Range(0,  38).Select(i => (Byte) i), "D3259AFCA8A48962FA892E145ACF547F26923AE8D4924C8A531581526B04B44C7AF83C643EF5A0BC282D36F3FB04C84E28B351F40C74B69DC7840BC717B6F15F"),
                    new KnownValue(512, Enumerable.Range(0,  39).Select(i => (Byte) i), "F14B061AE359FA31B989E30332BFE8DE8CC8CDB568E14BE214A2223B84CAAB7419549ECFCC96CE2ACEC119485D87D157D3A8734FC426597D64F36570CEAF224D"),
                    new KnownValue(512, Enumerable.Range(0,  40).Select(i => (Byte) i), "55E70B01D1FBF8B23B57FB62E26C2CE54F13F8FA2464E6EB98D16A6117026D8B90819012496D4071EBE2E59557ECE3519A7AA45802F9615374877332B73490B3"),
                    new KnownValue(512, Enumerable.Range(0,  41).Select(i => (Byte) i), "25261EB296971D6E4A71B2928E64839C67D422872BF9F3C31993615222DE9F8F0B2C4BE8548559B4B354E736416E3218D4E8A1E219A4A6D43E1A9A521D0E75FC"),
                    new KnownValue(512, Enumerable.Range(0,  42).Select(i => (Byte) i), "08307F347C41294E34BB54CB42B1522D22F824F7B6E5DB50FDA096798E181A8F026FA27B4AE45D52A62CAF9D5198E24A4913C6671775B2D723C1239BFBF016D7"),
                    new KnownValue(512, Enumerable.Range(0,  43).Select(i => (Byte) i), "1E5C62E7E9BFA1B118747A2DE08B3CA10112AF96A46E4B22C3FC06F9BFEE4EB5C49E057A4A4886234324572576BB9B5ECFDE0D99B0DE4F98EC16E4D1B85FA947"),
                    new KnownValue(512, Enumerable.Range(0,  44).Select(i => (Byte) i), "C74A77395FB8BC126447454838E561E962853DC7EB49A1E3CB67C3D0851F3E39517BE8C350AC910903D49CD2BFDF545C99316D0346170B739F0ADD5D533C2CFC"),
                    new KnownValue(512, Enumerable.Range(0,  45).Select(i => (Byte) i), "0DD57B423CC01EB2861391EB886A0D17079B933FC76EB3FC08A19F8A74952CB68F6BCDC644F77370966E4D13E80560BCF082EF0479D48FBBAB4DF03B53A4E178"),
                    new KnownValue(512, Enumerable.Range(0,  46).Select(i => (Byte) i), "4D8DC3923EDCCDFCE70072398B8A3DA5C31FCB3EE3B645C85F717CBAEB4B673A19394425A585BFB464D92F1597D0B754D163F97CED343B25DB5A70EF48EBB34F"),
                    new KnownValue(512, Enumerable.Range(0,  47).Select(i => (Byte) i), "F0A50553E4DFB0C4E3E3D3BA82034857E3B1E50918F5B8A7D698E10D242B0FB544AF6C92D0C3AAF9932220416117B4E78ECB8A8F430E13B82A5915290A5819C5"),
                    new KnownValue(512, Enumerable.Range(0,  48).Select(i => (Byte) i), "B15543F3F736086627CC5365E7E8988C2EF155C0FD4F428961B00D1526F04D6D6A658B4B8ED32C5D8621E7F4F8E8A933D9ECC9DD1B8333CBE28CFC37D9719E1C"),
                    new KnownValue(512, Enumerable.Range(0,  49).Select(i => (Byte) i), "7B4FA158E415FEF023247264CBBE15D16D91A44424A8DB707EB1E2033C30E9E1E7C8C0864595D2CB8C580EB47E9D16ABBD7E44E824F7CEDB7DEF57130E52CFE9"),
                    new KnownValue(512, Enumerable.Range(0,  50).Select(i => (Byte) i), "60424FF23234C34DC9687AD502869372CC31A59380186BC2361C835D972F49666EB1AC69629DE646F03F9B4DB9E2ACE093FBFDF8F20AB5F98541978BE8EF549F"),
                    new KnownValue(512, Enumerable.Range(0,  51).Select(i => (Byte) i), "7406018CE704D84F5EB9C79FEA97DA345699468A350EE0B2D0F3A4BF2070304EA862D72A51C57D3064947286F531E0EAF7563702262E6C724ABF5ED8C8398D17"),
                    new KnownValue(512, Enumerable.Range(0,  52).Select(i => (Byte) i), "14EF5C6D647B3BD1E6E32006C231199810DE5C4DC88E70240273B0EA18E651A3EB4F5CA3114B8A56716969C7CDA27E0C8DB832AD5E89A2DC6CB0ADBE7D93ABD1"),
                    new KnownValue(512, Enumerable.Range(0,  53).Select(i => (Byte) i), "38CF6C24E3E08BCF1F6CF3D1B1F65B905239A3118033249E448113EC632EA6DC346FEEB2571C38BD9A7398B2221280328002B23E1A45ADAFFE66D93F6564EAA2"),
                    new KnownValue(512, Enumerable.Range(0,  54).Select(i => (Byte) i), "6CD7208A4BC7E7E56201BBBA02A0F489CD384ABE40AFD4222F158B3D986EE72A54C50FB64FD4ED2530EDA2C8AF2928A0DA6D4F830AE1C9DB469DFD970F12A56F"),
                    new KnownValue(512, Enumerable.Range(0,  55).Select(i => (Byte) i), "659858F0B5C9EDAB5B94FD732F6E6B17C51CC096104F09BEB3AFC3AA467C2ECF885C4C6541EFFA9023D3B5738AE5A14D867E15DB06FE1F9D1127B77E1AABB516"),
                    new KnownValue(512, Enumerable.Range(0,  56).Select(i => (Byte) i), "26CCA0126F5D1A813C62E5C71001C046F9C92095704550BE5873A495A999AD010A4F79491F24F286500ADCE1A137BC2084E4949F5B7294CEFE51ECAFF8E95CBA"),
                    new KnownValue(512, Enumerable.Range(0,  57).Select(i => (Byte) i), "4147C1F55172788C5567C561FEEF876F621FFF1CE87786B8467637E70DFBCD0DBDB6415CB600954AB9C04C0E457E625B407222C0FE1AE21B2143688ADA94DC58"),
                    new KnownValue(512, Enumerable.Range(0,  58).Select(i => (Byte) i), "5B1BF154C62A8AF6E93D35F18F7F90ABB16A6EF0E8D1AECD118BF70167BAB2AF08935C6FDC0663CE74482D17A8E54B546D1C296631C65F3B522A515839D43D71"),
                    new KnownValue(512, Enumerable.Range(0,  59).Select(i => (Byte) i), "9F600419A4E8F4FB834C24B0F7FC13BF4E279D98E8A3C765EE934917403E3A66097182EA21453CB63EBBE8B73A9C2167596446438C57627F330BADD4F569F7D6"),
                    new KnownValue(512, Enumerable.Range(0,  60).Select(i => (Byte) i), "457EF6466A8924FD8011A34471A5A1AC8CCD9BD0D07A97414AC943021CE4B9E4B9C8DB0A28F016ED43B1542481990022147B313E194671131E708DD43A3ED7DC"),
                    new KnownValue(512, Enumerable.Range(0,  61).Select(i => (Byte) i), "9997B2194D9AF6DFCB9143F41C0ED83D3A3F4388361103D38C2A49B280A581212715FD908D41C651F5C715CA38C0CE2830A37E00E508CED1BCDC320E5E4D1E2E"),
                    new KnownValue(512, Enumerable.Range(0,  62).Select(i => (Byte) i), "5C6BBF16BAA180F986BD40A1287ED4C549770E7284858FC47BC21AB95EBBF3374B4EE3FD9F2AF60F3395221B2ACC76F2D34C132954049F8A3A996F1E32EC84E5"),
                    new KnownValue(512, Enumerable.Range(0,  63).Select(i => (Byte) i), "D10BF9A15B1C9FC8D41F89BB140BF0BE08D2F3666176D13BAAC4D381358AD074C9D4748C300520EB026DAEAEA7C5B158892FDE4E8EC17DC998DCD507DF26EB63"),
                    new KnownValue(512, Enumerable.Range(0,  64).Select(i => (Byte) i), "2FC6E69FA26A89A5ED269092CB9B2A449A4409A7A44011EECAD13D7C4B0456602D402FA5844F1A7A758136CE3D5D8D0E8B86921FFFF4F692DD95BDC8E5FF0052"),
                    new KnownValue(512, Enumerable.Range(0,  65).Select(i => (Byte) i), "FCBE8BE7DCB49A32DBDF239459E26308B84DFF1EA480DF8D104EEFF34B46FAE98627B450C2267D48C0946A697C5B59531452AC0484F1C84E3A33D0C339BB2E28"),
                    new KnownValue(512, Enumerable.Range(0,  66).Select(i => (Byte) i), "A19093A6E3BCF5952F850F2030F69B9606F147F90B8BAEE3362DA71D9F35B44EF9D8F0A7712BA1877FDDCD2D8EA8F1E5A773D0B745D4725605983A2DE901F803"),
                    new KnownValue(512, Enumerable.Range(0,  67).Select(i => (Byte) i), "3C2006423F73E268FA59D2920377EB29A4F9A8B462BE15983EE3B85AE8A78E992633581A9099893B63DB30241C34F643027DC878279AF5850D7E2D4A2653073A"),
                    new KnownValue(512, Enumerable.Range(0,  68).Select(i => (Byte) i), "D0F2F2E3787653F77CCE2FA24835785BBD0C433FC779465A115149905A9DD1CB827A628506D457FCF124A0C2AEF9CE2D2A0A0F63545570D8667FF9E2EBA07334"),
                    new KnownValue(512, Enumerable.Range(0,  69).Select(i => (Byte) i), "78A9FC048E25C6DCB5DE45667DE8FFDD3A93711141D594E9FA62A959475DA6075EA8F0916E84E45AD911B75467077EE52D2C9AEBF4D58F20CE4A3A00458B05D4"),
                    new KnownValue(512, Enumerable.Range(0,  70).Select(i => (Byte) i), "45813F441769AB6ED37D349FF6E72267D76AE6BB3E3C612EC05C6E02A12AF5A37C918B52BF74267C3F6A3F183A8064FF84C07B193D08066789A01ACCDB6F9340"),
                    new KnownValue(512, Enumerable.Range(0,  71).Select(i => (Byte) i), "956DA1C68D83A7B881E01B9A966C3C0BF27F68606A8B71D457BD016D4C41DD8A380C709A296CB4C6544792920FD788835771A07D4A16FB52ED48050331DC4C8B"),
                    new KnownValue(512, Enumerable.Range(0,  72).Select(i => (Byte) i), "DF186C2DC09CAA48E14E942F75DE5AC1B7A21E4F9F072A5B371E09E07345B0740C76177B01278808FEC025EDED9822C122AFD1C63E6F0CE2E32631041063145C"),
                    new KnownValue(512, Enumerable.Range(0,  73).Select(i => (Byte) i), "87475640966A9FDCD6D3A3B5A2CCA5C08F0D882B10243C0EC1BF3C6B1C37F2CD3212F19A057864477D5EAF8FAED73F2937C768A0AF415E84BBCE6BD7DE23B660"),
                    new KnownValue(512, Enumerable.Range(0,  74).Select(i => (Byte) i), "C3B573BBE10949A0FBD4FF884C446F2229B76902F9DFDBB8A0353DA5C83CA14E8151BBAAC82FD1576A009ADC6F1935CF26EDD4F1FB8DA483E6C5CD9D8923ADC3"),
                    new KnownValue(512, Enumerable.Range(0,  75).Select(i => (Byte) i), "B09D8D0BBA8A7286E43568F7907550E42036D674E3C8FC34D8CA46F771D6466B70FB605875F6A863C877D12F07063FDC2E90CCD459B1910DCD52D8F10B2B0A15"),
                    new KnownValue(512, Enumerable.Range(0,  76).Select(i => (Byte) i), "AF3A22BF75B21ABFB0ACD54422BA1B7300A952EFF02EBEB65B5C234471A98DF32F4F9643CE1904108A168767924280BD76C83F8C82D9A79D9259B195362A2A04"),
                    new KnownValue(512, Enumerable.Range(0,  77).Select(i => (Byte) i), "BF4FF2221B7E6957A724CD964AA3D5D0D9941F540413752F4699D8101B3E537508BF09F8508B317736FFD265F2847AA7D84BD2D97569C49D632AED9945E5FA5E"),
                    new KnownValue(512, Enumerable.Range(0,  78).Select(i => (Byte) i), "9C6B6B78199B1BDACB4300E31479FA622A6B5BC80D4678A6078F88A8268CD7206A2799E8D4621A464EF6B43DD8ADFFE97CAF221B22B6B8778B149A822AEFBB09"),
                    new KnownValue(512, Enumerable.Range(0,  79).Select(i => (Byte) i), "890656F09C99D280B5ECB381F56427B813751BC652C7828078B23A4AF83B4E3A61FDBAC61F89BEE84EA6BEE760C047F25C6B0A201C69A38FD6FD971AF18588BB"),
                    new KnownValue(512, Enumerable.Range(0,  80).Select(i => (Byte) i), "31A046F7882FFE6F83CE472E9A0701832EC7B3F76FBCFD1DF60FE3EA48FDE1651254247C3FD95E100F9172731E17FD5297C11F4BB328363CA361624A81AF797C"),
                    new KnownValue(512, Enumerable.Range(0,  81).Select(i => (Byte) i), "27A60B2D00E7A671D47D0AEC2A686A0AC04B52F40AB6629028EB7D13F4BAA99AC0FE46EE6C814944F2F4B4D20E9378E4847EA44C13178091E277B87EA7A55711"),
                    new KnownValue(512, Enumerable.Range(0,  82).Select(i => (Byte) i), "8B5CCEF194162C1F19D68F91E0B0928F289EC5283720840C2F73D253111238DCFE94AF2B59C2C1CA2591901A7BC060E7459B6C47DF0F71701A35CC0AA831B5B6"),
                    new KnownValue(512, Enumerable.Range(0,  83).Select(i => (Byte) i), "57AB6C4B2229AEB3B70476D803CD63812F107CE6DA17FED9B17875E8F86C724F49E024CBF3A1B8B119C50357652B81879D2ADE2D588B9E4F7CEDBA0E4644C9EE"),
                    new KnownValue(512, Enumerable.Range(0,  84).Select(i => (Byte) i), "0190A8DAC320A739F322E15731AA140DDAF5BED294D5C82E54FEF29F214E18AAFAA84F8BE99AF62950266B8F901F15DD4C5D35516FC35B4CAB2E96E4695BBE1C"),
                    new KnownValue(512, Enumerable.Range(0,  85).Select(i => (Byte) i), "D14D7C4C415EEB0E10B159224BEA127EBD84F9591C702A330F5BB7BB7AA44EA39DE6ED01F18DA7ADF40CFB97C5D152C27528824B21E239526AF8F36B214E0CFB"),
                    new KnownValue(512, Enumerable.Range(0,  86).Select(i => (Byte) i), "BE28C4BE706970488FAC7D29C3BD5C4E986085C4C3332F1F3FD30973DB614164BA2F31A78875FFDC150325C88327A9443ED04FDFE5BE93876D1628560C764A80"),
                    new KnownValue(512, Enumerable.Range(0,  87).Select(i => (Byte) i), "031DA1069E3A2E9C3382E436FFD79DF74B1CA6A8ADB2DEABE676AB45994CBC054F037D2F0EACE858D32C14E2D1C8B46077308E3BDC2C1B53172ECF7A8C14E349"),
                    new KnownValue(512, Enumerable.Range(0,  88).Select(i => (Byte) i), "4665CEF8BA4DB4D0ACB118F2987F0BB09F8F86AA445AA3D5FC9A8B346864787489E8FCECC125D17E9B56E12988EAC5ECC7286883DB0661B8FF05DA2AFFF30FE4"),
                    new KnownValue(512, Enumerable.Range(0,  89).Select(i => (Byte) i), "63B7032E5F930CC9939517F9E986816CFBEC2BE59B9568B13F2EAD05BAE7777CAB620C6659404F7409E4199A3BE5F7865AA7CBDF8C4253F7E8219B1BD5F46FEA"),
                    new KnownValue(512, Enumerable.Range(0,  90).Select(i => (Byte) i), "9F09BF093A2B0FF8C2634B49E37F1B2135B447AA9144C9787DBFD92129316C99E88AAB8A21FDEF2372D1189AEC500F95775F1F92BFB45545E4259FB9B7B02D14"),
                    new KnownValue(512, Enumerable.Range(0,  91).Select(i => (Byte) i), "F9F8493C68088807DF7F6A2693D64EA59F03E9E05A223E68524CA32195A4734B654FCEA4D2734C866CF95C889FB10C49159BE2F5043DC98BB55E02EF7BDCB082"),
                    new KnownValue(512, Enumerable.Range(0,  92).Select(i => (Byte) i), "3C9A7359AB4FEBCE07B20AC447B06A240B7FE1DAE5439C49B60B5819F7812E4C172406C1AAC316713CF0DDED1038077258E2EFF5B33913D9D95CAEB4E6C6B970"),
                    new KnownValue(512, Enumerable.Range(0,  93).Select(i => (Byte) i), "AD6AAB8084510E822CFCE8625D62CF4DE655F4763884C71E80BAB9AC9D5318DBA4A6033ED29084E65216C031606CA17615DCFE3BA11D26851AE0999CA6E232CF"),
                    new KnownValue(512, Enumerable.Range(0,  94).Select(i => (Byte) i), "156E9E6261374C9DC884F36E70F0FE1AB9297997B836FA7D170A9C9EBF575B881E7BCEA44D6C0248D35597907154828955BE19135852F9228815ECA024A8ADFB"),
                    new KnownValue(512, Enumerable.Range(0,  95).Select(i => (Byte) i), "4215407633F4CCA9B6788BE93E6AA3D963C7D6CE4B147247099F46A3ACB500A30038CB3E788C3D29F132AD844E80E9E99251F6DB96ACD8A091CFC770AF53847B"),
                    new KnownValue(512, Enumerable.Range(0,  96).Select(i => (Byte) i), "1C077E279DE6548523502B6DF800FFDAB5E2C3E9442EB838F58C295F3B147CEF9D701C41C321283F00C71AFFA0619310399126295B78DD4D1A74572EF9ED5135"),
                    new KnownValue(512, Enumerable.Range(0,  97).Select(i => (Byte) i), "F07A555F49FE481CF4CD0A87B71B82E4A95064D06677FDD90A0EB598877BA1C83D4677B393C3A3B6661C421F5B12CB99D20376BA7275C2F3A8F5A9B7821720DA"),
                    new KnownValue(512, Enumerable.Range(0,  98).Select(i => (Byte) i), "B5911B380D20C7B04323E4026B38E200F534259233B581E02C1E3E2D8438D6C66D5A4EB201D5A8B75072C4EC29106334DA70BC79521B0CED2CFD533F5FF84F95"),
                    new KnownValue(512, Enumerable.Range(0,  99).Select(i => (Byte) i), "01F070A09BAE911296361F91AA0E8E0D09A7725478536D9D48C5FE1E5E7C3C5B9B9D6EB07796F6DA57AE562A7D70E882E37ADFDE83F0C433C2CD363536BB22C8"),
                    new KnownValue(512, Enumerable.Range(0, 100).Select(i => (Byte) i), "6F793EB4374A48B0775ACAF9ADCF8E45E54270C9475F004AD8D5973E2ACA52747FF4ED04AE967275B9F9EB0E1FF75FB4F794FA8BE9ADD7A41304868D103FAB10"),
                    new KnownValue(512, Enumerable.Range(0, 101).Select(i => (Byte) i), "965F20F139765FCC4CE4BA3794675863CAC24DB472CD2B799D035BCE3DBEA502DA7B524865F6B811D8C5828D3A889646FE64A380DA1AA7C7044E9F245DCED128"),
                    new KnownValue(512, Enumerable.Range(0, 102).Select(i => (Byte) i), "EC295B5783601244C30E4641E3B45BE222C4DCE77A58700F53BC8EC52A941690B4D0B087FB6FCB3F39832B9DE8F75EC20BD43079811749CDC907EDB94157D180"),
                    new KnownValue(512, Enumerable.Range(0, 103).Select(i => (Byte) i), "61C72F8CCC91DBB54CA6750BC489672DE09FAEDB8FDD4F94FF2320909A303F5D5A98481C0BC1A625419FB4DEBFBF7F8A53BB07EC3D985E8EA11E72D559940780"),
                    new KnownValue(512, Enumerable.Range(0, 104).Select(i => (Byte) i), "AFD8145B259EEFC8D12620C3C5B03E1ED8FD2CCEFE0365078C80FD42C1770E28B44948F27E65A1886690110DB814397B68E43D80D1BA16DFA358E739C898CFA3"),
                    new KnownValue(512, Enumerable.Range(0, 105).Select(i => (Byte) i), "552FC7893CF1CE933ADA35C0DA98844E41545E244C3157A1428D7B4C21F9CD7E4071AED77B7CA9F1C38FBA32237412EF21A342742EC8324378F21E507FAFDD88"),
                    new KnownValue(512, Enumerable.Range(0, 106).Select(i => (Byte) i), "467A33FBADF5EBC52596EF86AAAEFC6FABA8EE651B1CE04DE368A03A5A9040EF2835E00ADB09ABB3FBD2BCE818A2413D0B0253B5BDA4FC5B2F6F85F3FD5B55F2"),
                    new KnownValue(512, Enumerable.Range(0, 107).Select(i => (Byte) i), "22EFF8E6DD5236F5F57D94EDE874D6C9428E8F5D566F17CD6D1848CD752FE13C655CB10FBAAFF76872F2BF2DA99E15DC624075E1EC2F58A3F64072121838569E"),
                    new KnownValue(512, Enumerable.Range(0, 108).Select(i => (Byte) i), "9CEC6BBF62C4BCE4138ABAE1CBEC8DAD31950444E90321B1347196834C114B864AF3F3CC3508F83751FFB4EDA7C84D140734BB4263C3625C00F04F4C8068981B"),
                    new KnownValue(512, Enumerable.Range(0, 109).Select(i => (Byte) i), "A8B60FA4FC2442F6F1514AD7402626920CC7C2C9F72124B8CBA8EE2CB7C4586F658A4410CFFCC0AB88343955E094C6AF0D20D0C714FB0A988F543F300F58D389"),
                    new KnownValue(512, Enumerable.Range(0, 110).Select(i => (Byte) i), "8271CC45DFA5E4170E847E8630B952CF9C2AA777D06F26A7585B8381F188DACC7337391CFCC94B053DC4EC29CC17F077870428F1AC23FDDDA165EF5A3F155F39"),
                    new KnownValue(512, Enumerable.Range(0, 111).Select(i => (Byte) i), "BF23C0C25C8060E4F6995F1623A3BEBECAA96E308680000A8AA3CD56BB1A6DA099E10D9231B37F4519B2EFD2C24DE72F31A5F19535241B4A59FA3C03CEB790E7"),
                    new KnownValue(512, Enumerable.Range(0, 112).Select(i => (Byte) i), "877FD652C05281009C0A5250E7A3A671F8B18C108817FE4A874DE22DA8E45DB11958A600C5F62E67D36CBF84474CF244A9C2B03A9FB9DC711CD1A2CAB6F3FAE0"),
                    new KnownValue(512, Enumerable.Range(0, 113).Select(i => (Byte) i), "29DF4D87EA444BAF5BCDF5F4E41579E28A67DE84149F06C03F110EA84F572A9F676ADDD04C4878F49C5C00ACCDA441B1A387CACEB2E993BB7A10CD8C2D6717E1"),
                    new KnownValue(512, Enumerable.Range(0, 114).Select(i => (Byte) i), "710DACB166844639CD7B637C274209424E2449DC35D790BBFA4F76177054A36B3B76FAC0CA6E61DF1E687000678AC0746DF75D0A3954897681FD393A155A1BB4"),
                    new KnownValue(512, Enumerable.Range(0, 115).Select(i => (Byte) i), "C1D5F93B8DEA1F2571BABCCBC01764541A0CDA87E444D673C50966CA559C33354B3ACB26E5D5781FFB28847A4B4754D77008C62A835835F500DEA7C3B58BDAE2"),
                    new KnownValue(512, Enumerable.Range(0, 116).Select(i => (Byte) i), "A41E41271CDAB8AF4D72B104BFB2AD041AC4DF14677DA671D85640C4B187F50C2B66513C4619FBD5D5DC4FE65DD37B9042E9848DDA556A504CAA2B1C6AFE4730"),
                    new KnownValue(512, Enumerable.Range(0, 117).Select(i => (Byte) i), "E7BCBACDC379C43D81EBADCB37781552FC1D753E8CF310D968392D06C91F1D64CC9E90CE1D22C32D277FC6CDA433A4D442C762E9EACF2C259F32D64CF9DA3A22"),
                    new KnownValue(512, Enumerable.Range(0, 118).Select(i => (Byte) i), "51755B4AC5456B13218A19C5B9242F57C4A981E4D4ECDCE09A3193362B808A579345D4881C2607A56534DD7F21956AFF72C2F4173A6E7B6CC2212BA0E3DAEE1F"),
                    new KnownValue(512, Enumerable.Range(0, 119).Select(i => (Byte) i), "DCC2C4BEB9C1F2607B786C20C631972347034C1CC02FCC7D02FF01099CFE1C6989840AC213923629113AA8BAD713CCF0FE4CE13264FB32B8B0FE372DA382544A"),
                    new KnownValue(512, Enumerable.Range(0, 120).Select(i => (Byte) i), "3D55176ACEA4A7E3A65FFA9FB10A7A1767199CF077CEE9F71532D67CD7C73C9F93CFC37CCDCC1FDEF50AAD46A504A650D298D597A3A9FA95C6C40CB71FA5E725"),
                    new KnownValue(512, Enumerable.Range(0, 121).Select(i => (Byte) i), "D07713C005DE96DD21D2EB8BBECA66746EA51A31AE922A3E74864889540A48DB27D7E4C90311638B224BF0201B501891754848113C266108D0ADB13DB71909C7"),
                    new KnownValue(512, Enumerable.Range(0, 122).Select(i => (Byte) i), "58983C21433D950CAA23E4BC18543B8E601C204318532152DAF5E159A0CD1480183D29285C05F129CB0CC3164687928086FFE380158DF1D394C6AC0D4288BCA8"),
                    new KnownValue(512, Enumerable.Range(0, 123).Select(i => (Byte) i), "8100A8DC528D2B682AB4250801BA33F02A3E94C54DAC0AE1482AA21F51EF3A82F3807E6FACB0AEB05947BF7AA2ADCB034356F90FA4560EDE02201A37E411EC1A"),
                    new KnownValue(512, Enumerable.Range(0, 124).Select(i => (Byte) i), "07025F1BB6C784F3FE49DE5C14B936A5ACACACAAB33F6AC4D0E00AB6A12483D6BEC00B4FE67C7CA5CC508C2A53EFB5BFA5398769D843FF0D9E8B14D36A01A77F"),
                    new KnownValue(512, Enumerable.Range(0, 125).Select(i => (Byte) i), "BA6AEFD972B6186E027A76273A4A723321A3F580CFA894DA5A9CE8E721C828552C64DACEE3A7FD2D743B5C35AD0C8EFA71F8CE99BF96334710E2C2346E8F3C52"),
                    new KnownValue(512, Enumerable.Range(0, 126).Select(i => (Byte) i), "E0721E02517AEDFA4E7E9BA503E025FD46E714566DC889A84CBFE56A55DFBE2FC4938AC4120588335DEAC8EF3FA229ADC9647F54AD2E3472234F9B34EFC46543"),
                    new KnownValue(512, Enumerable.Range(0, 127).Select(i => (Byte) i), "B6292669CCD38D5F01CAAE96BA272C76A879A45743AFA0725D83B9EBB26665B731F1848C52F11972B6644F554C064FA90780DBBBF3A89D4FC31F67DF3E5857EF"),
                    new KnownValue(512, Enumerable.Range(0, 128).Select(i => (Byte) i), "2319E3789C47E2DAA5FE807F61BEC2A1A6537FA03F19FF32E87EECBFD64B7E0E8CCFF439AC333B040F19B0C4DDD11A61E24AC1FE0F10A039806C5DCC0DA3D115"),
                    new KnownValue(512, Enumerable.Range(0, 129).Select(i => (Byte) i), "F59711D44A031D5F97A9413C065D1E614C417EDE998590325F49BAD2FD444D3E4418BE19AEC4E11449AC1A57207898BC57D76A1BCF3566292C20C683A5C4648F"),
                    new KnownValue(512, Enumerable.Range(0, 130).Select(i => (Byte) i), "DF0A9D0C212843A6A934E3902B2DD30D17FBA5F969D2030B12A546D8A6A45E80CF5635F071F0452E9C919275DA99BED51EB1173C1AF0518726B75B0EC3BAE2B5"),
                    new KnownValue(512, Enumerable.Range(0, 131).Select(i => (Byte) i), "A3EB6E6C7BF2FB8B28BFE8B15E15BB500F781ECC86F778C3A4E655FC5869BF2846A245D4E33B7B14436A17E63BE79B36655C226A50FFBC7124207B0202342DB5"),
                    new KnownValue(512, Enumerable.Range(0, 132).Select(i => (Byte) i), "56D4CBCD070563426A017069425C2CD2AE540668287A5FB9DAC432EB8AB1A353A30F2FE1F40D83333AFE696A267795408A92FE7DA07A0C1814CF77F36E105EE8"),
                    new KnownValue(512, Enumerable.Range(0, 133).Select(i => (Byte) i), "E59B9987D428B3EDA37D80ABDB16CD2B0AEF674C2B1DDA4432EA91EE6C935C684B48B4428A8CC740E579A30DEFF35A803013820DD23F14AE1D8413B5C8672AEC"),
                    new KnownValue(512, Enumerable.Range(0, 134).Select(i => (Byte) i), "CD9FCC99F99D4CC16D031900B2A736E1508DB4B586814E6345857F354A70CCECB1DF3B50A19ADAF43C278EFA423FF4BB6C523EC7FD7859B97B168A7EBFF8467C"),
                    new KnownValue(512, Enumerable.Range(0, 135).Select(i => (Byte) i), "0602185D8C3A78738B99164B8BC6FFB21C7DEBEBBF806372E0DA44D121545597B9C662A255DC31542CF995ECBE6A50FB5E6E0EE4EF240FE557EDED1188087E86"),
                    new KnownValue(512, Enumerable.Range(0, 136).Select(i => (Byte) i), "C08AFA5B927BF08097AFC5FFF9CA4E7800125C1F52F2AF3553FA2B89E1E3015C4F87D5E0A48956AD31450B083DAD147FFB5EC03434A26830CF37D103AB50C5DA"),
                    new KnownValue(512, Enumerable.Range(0, 137).Select(i => (Byte) i), "36F1E1C11D6EF6BC3B536D505D544A871522C5C2A253067EC9933B6EC25464DAF985525F5B9560A16D890259AC1BB5CC67C0C469CDE133DEF000EA1D686F4F5D"),
                    new KnownValue(512, Enumerable.Range(0, 138).Select(i => (Byte) i), "BF2AB2E2470F5438C3B689E66E7686FFFA0CB1E1798AD3A86FF99075BF6138E33D9C0CE59AFB24AC67A02AF34428191A9A0A6041C07471B7C3B1A752D6FC0B8B"),
                    new KnownValue(512, Enumerable.Range(0, 139).Select(i => (Byte) i), "D400601F9728CCC4C92342D9787D8D28AB323AF375CA5624B4BB91D17271FBAE862E413BE73F1F68E615B8C5C391BE0DBD9144746EB339AD541547BA9C468A17"),
                    new KnownValue(512, Enumerable.Range(0, 140).Select(i => (Byte) i), "79FE2FE157EB85A038ABB8EBBC647731D2C83F51B0AC6EE14AA284CB6A3549A4DCCEB300740A825F52F5FB30B03B8C4D8B0F4AA67A63F4A94E3303C4EDA4C02B"),
                    new KnownValue(512, Enumerable.Range(0, 141).Select(i => (Byte) i), "75351313B52A8529298D8C186B1768666DCCA8595317D7A4816EB88C062020C0C8EFC554BB341B64688DB5CCAFC35F3C3CD09D6564B36D7B04A248E146980D4B"),
                    new KnownValue(512, Enumerable.Range(0, 142).Select(i => (Byte) i), "E3128B1D311D02179D7F25F97A5A8BEE2CC8C86303644FCD664E157D1FEF00F23E46F9A5E8E5C890CE565BB6ABD4302CE06469D52A5BD53E1C5A54D04649DC03"),
                    new KnownValue(512, Enumerable.Range(0, 143).Select(i => (Byte) i), "C2382A72D2D3ACE9D5933D00B60827ED380CDA08D0BA5F6DD41E29EE6DBE8ECB9235F06BE95D83B6816A2FB7A5AD47035E8A4B69A4884B99E4BECE58CAB25D44"),
                    new KnownValue(512, Enumerable.Range(0, 144).Select(i => (Byte) i), "6B1C69460BBD50AC2ED6F32E6E887CFED407D47DCF0AAA60387FE320D780BD03EAB6D7BAEB2A07D10CD552A300341354EA9A5F03183A623F92A2D4D9F00926AF"),
                    new KnownValue(512, Enumerable.Range(0, 145).Select(i => (Byte) i), "6CDA206C80CDC9C44BA990E0328C314F819B142D00630404C48C05DC76D1B00CE4D72FC6A48E1469DDEF609412C364820854214B4869AF090F00D3C1BA443E1B"),
                    new KnownValue(512, Enumerable.Range(0, 146).Select(i => (Byte) i), "7FFC8C26FBD6A0F7A609E6E1939F6A9EDF1B0B066641FB76C4F9602ED748D11602496B35355B1AA255850A509D2F8EE18C8F3E1D7DCBC37A136598F56A59ED17"),
                    new KnownValue(512, Enumerable.Range(0, 147).Select(i => (Byte) i), "70DE1F08DD4E09D5FC151F17FC991A23ABFC05104290D50468882EFAF582B6EC2F14F577C0D68C3AD06626916E3C86E6DAAB6C53E5163E82B6BD0CE49FC0D8DF"),
                    new KnownValue(512, Enumerable.Range(0, 148).Select(i => (Byte) i), "4F81935756ED35EE2058EE0C6A6110D6FAC5CB6A4F46AA9411603F99965823B6DA4838276C5C06BC7880E376D92758369EE7305BCEC8D3CFD28CCABB7B4F0579"),
                    new KnownValue(512, Enumerable.Range(0, 149).Select(i => (Byte) i), "ABCB61CB3683D18F27AD527908ED2D32A0426CB7BB4BF18061903A7DC42E7E76F982382304D18AF8C80D91DD58DD47AF76F8E2C36E28AF2476B4BCCF82E89FDF"),
                    new KnownValue(512, Enumerable.Range(0, 150).Select(i => (Byte) i), "02D261AD56A526331B643DD2186DE9A82E72A58223CD1E723686C53D869B83B94632B7B647AB2AFC0D522E29DA3A5615B741D82852E0DF41B66007DBCBA90543"),
                    new KnownValue(512, Enumerable.Range(0, 151).Select(i => (Byte) i), "C5832741FA30C5436823015383D297FF4C4A5D7276C3F902122066E04BE5431B1A85FAF73B918434F9300963D1DEA9E8AC3924EF490226EDEEA5F743E410669F"),
                    new KnownValue(512, Enumerable.Range(0, 152).Select(i => (Byte) i), "CFAEAB268CD075A5A6AED515023A032D54F2F2FF733CE0CBC78DB51DB4504D675923F82746D6594606AD5D67734B11A67CC6A468C2032E43CA1A94C6273A985E"),
                    new KnownValue(512, Enumerable.Range(0, 153).Select(i => (Byte) i), "860850F92EB268272B67D133609BD64E34F61BF03F4C1738645C17FEC818465D7ECD2BE2907641130025FDA79470AB731646E7F69440E8367EA76AC4CEE8A1DF"),
                    new KnownValue(512, Enumerable.Range(0, 154).Select(i => (Byte) i), "84B154ED29BBEDEFA648286839046F4B5AA34430E2D67F7496E4C39F2C7EA78995F69E1292200016F16AC3B37700E6C7E7861AFC396B64A59A1DBF47A55C4BBC"),
                    new KnownValue(512, Enumerable.Range(0, 155).Select(i => (Byte) i), "AEEEC260A5D8EFF5CCAB8B95DA435A63ED7A21EA7FC7559413FD617E33609F8C290E64BBACC528F6C080262288B0F0A3219BE223C991BEE92E72349593E67638"),
                    new KnownValue(512, Enumerable.Range(0, 156).Select(i => (Byte) i), "8AD78A9F26601D127E8D2F2F976E63D19A054A17DCF59E0F013AB54A6887BBDFFDE7AAAE117E0FBF3271016595B9D9C712C01B2C53E9655A382BC4522E616645"),
                    new KnownValue(512, Enumerable.Range(0, 157).Select(i => (Byte) i), "8934159DADE1AC74147DFA282C75954FCEF443EF25F80DFE9FB6EA633B8545111D08B34EF43FFF17026C7964F5DEAC6D2B3C29DACF2747F022DF5967DFDC1A0A"),
                    new KnownValue(512, Enumerable.Range(0, 158).Select(i => (Byte) i), "CD36DD0B240614CF2FA2B9E959679DCDD72EC0CD58A43DA3790A92F6CDEB9E1E795E478A0A47D371100D340C5CEDCDBBC9E68B3F460818E5BDFF7B4CDA4C2744"),
                    new KnownValue(512, Enumerable.Range(0, 159).Select(i => (Byte) i), "00DF4E099B807137A85990F49D3A94315E5A5F7F7A6076B303E96B056FB93800111F479628E2F8DB59AEB6AC70C3B61F51F9B46E80FFDEAE25EBDDB4AF6CB4EE"),
                    new KnownValue(512, Enumerable.Range(0, 160).Select(i => (Byte) i), "2B9C955E6CAED4B7C9E246B86F9A1726E810C59D126CEE66ED71BF015B83558A4B6D84D18DC3FF4620C2FFB722359FDEF85BA0D4E2D22ECBE0ED784F99AFE587"),
                    new KnownValue(512, Enumerable.Range(0, 161).Select(i => (Byte) i), "181DF0A261A2F7D29EA5A15772715105D450A4B6C236F699F462D60CA76487FEEDFC9F5EB92DF838E8FB5DC3694E84C5E0F4A10B761F506762BE052C745A6EE8"),
                    new KnownValue(512, Enumerable.Range(0, 162).Select(i => (Byte) i), "21FB203458BF3A7E9A80439F9A902899CD5DE0139DFD56F7110C9DEC8437B26BDA63DE2F565926D85EDB1D6C6825669743DD9992653D13979544D5DC8228BFAA"),
                    new KnownValue(512, Enumerable.Range(0, 163).Select(i => (Byte) i), "EF021F29C5FFB830E64B9AA9058DD660FD2FCB81C497A7E698BCFBF59DE5AD4A86FF93C10A4B9D1AE5774725F9072DCDE9E1F199BAB91F8BFF921864AA502EEE"),
                    new KnownValue(512, Enumerable.Range(0, 164).Select(i => (Byte) i), "B3CFDA40526B7F1D37569BDFCDF911E5A6EFE6B2EC90A0454C47B2C046BF130FC3B352B34DF4813D48D33AB8E269B69B075676CB6D00A8DCF9E1F967EC191B2C"),
                    new KnownValue(512, Enumerable.Range(0, 165).Select(i => (Byte) i), "B4C6C3B267071EEFB9C8C72E0E2B941293641F8673CB70C1CC26AD1E73CF141755860AD19B34C2F34ED35BB52EC4507CC1FE59047743A5F0C6FEBDE625E26091"),
                    new KnownValue(512, Enumerable.Range(0, 166).Select(i => (Byte) i), "57A34F2BCCA60D4B85103B830C9D7952A416BE5263AE429C9E5E53FE8590A8F78EC65A51109EA85DCDF7B6223F9F2B340539FAD81923DBF8EDABF95129E4DFF6"),
                    new KnownValue(512, Enumerable.Range(0, 167).Select(i => (Byte) i), "9CF46662FCD61A232277B685663B8B5DA832DFD9A3B8CCFEEC993EC6AC415AD07E048ADFE414DF272770DBA867DA5C1224C6FD0AA0C2187D426AC647E9887361"),
                    new KnownValue(512, Enumerable.Range(0, 168).Select(i => (Byte) i), "5CE1042AB4D542C2F9EE9D17262AF8164098935BEF173D0E18489B04841746CD2F2DF866BD7DA6E5EF9024C648023EC723AB9C62FD80285739D84F15D2AB515A"),
                    new KnownValue(512, Enumerable.Range(0, 169).Select(i => (Byte) i), "8488396BD4A8729B7A473178F232DADF3F0F8E22678BA5A43E041E72DA1E2CF82194C307207A54CB8156293339EAEC693FF66BFCD5EFC65E95E4ECAF54530ABD"),
                    new KnownValue(512, Enumerable.Range(0, 170).Select(i => (Byte) i), "F598DA901C3835BCA560779037DFDE9F0C51DC61C0B760FC1522D7B470EE63F5BDC6498476E86049AD86E4E21AF2854A984CC905427D2F17F66B1F41C3DA6F61"),
                    new KnownValue(512, Enumerable.Range(0, 171).Select(i => (Byte) i), "5F93269798CF02132107337660A8D7A177354C0212EB93E555E7C37A08AEF3D8DCE01217011CD965C04DD2C105F2E2B6CAE5E4E6BCAF09DFBEE3E0A6A6357C37"),
                    new KnownValue(512, Enumerable.Range(0, 172).Select(i => (Byte) i), "0ECF581D47BAC9230986FAABD70C2F5B80E91066F0EC55A842937882286D2CA007BB4E973B0B091D52167FF7C4009C7AB4AD38FFF1DCEACDB7BE81EF4A452952"),
                    new KnownValue(512, Enumerable.Range(0, 173).Select(i => (Byte) i), "5AECA8ABE1528582B2A307B4009585498A3D467CA6101CB0C5126F9976056E9FFC123CC20C302B2A737F492C75D21F01512C90CA0541DFA56E950A321DCB28D8"),
                    new KnownValue(512, Enumerable.Range(0, 174).Select(i => (Byte) i), "732FBF8F1CB2B8329263EDE27858FE46F8D3354D376BCDA0548E7CE1FA9DD11F85EB661FE950B543AA635CA4D3F04EDE5B32D6B656E5CE1C44D35C4A6C56CFF8"),
                    new KnownValue(512, Enumerable.Range(0, 175).Select(i => (Byte) i), "D5E938735D63788C80100AEFD18648D18CF272F69F20FF24CFE2895C088AD08B0104DA1672A4EB26FC52545CC7D7A01B266CF546C403C45BD129EB41BDD9200B"),
                    new KnownValue(512, Enumerable.Range(0, 176).Select(i => (Byte) i), "65A245B49352EE297D91AF8C8BE00528AC6E046DD83AC7BD465A98816DD68F3E00E1AE8F895327A7E9A8C9326598379A29C9FC91EC0C6EEF08F3E2B216C11008"),
                    new KnownValue(512, Enumerable.Range(0, 177).Select(i => (Byte) i), "C95654B63019130AB45DD0FB4941B98AEB3AF2A123913ECA2CE99B3E97410A7BF8661CC7FBAA2BC1CF2B13113B1ED40A0118B88E5FFFC3542759EA007ED4C58D"),
                    new KnownValue(512, Enumerable.Range(0, 178).Select(i => (Byte) i), "1EB262F38FA494431F017DAD44C0DFB69324AC032F04B657FC91A88647BB74760F24E7C956514F0CF002990B182C1642B9B2426E96A61187E4E012F00E217D84"),
                    new KnownValue(512, Enumerable.Range(0, 179).Select(i => (Byte) i), "3B955AEEBFA5151AC1AB8E3F5CC1E3767084C842A575D36269836E97353D41622B731DDDCD5F269550A3A5B87BE1E90326340B6E0E62555815D9600597AC6EF9"),
                    new KnownValue(512, Enumerable.Range(0, 180).Select(i => (Byte) i), "68289F6605473BA0E4F241BAF7477A9885426A858F19EF2A18B0D40EF8E41282ED5526B519799E270F13881327918278755711071D8511FE963E3B5606AA3716"),
                    new KnownValue(512, Enumerable.Range(0, 181).Select(i => (Byte) i), "80A33787542612C38F6BCD7CD86CAB460227509B1CBAD5EC408A91413D51155A0476DADBF3A2518E4A6E77CC346622E347A469BF8BAA5F04EB2D98705355D063"),
                    new KnownValue(512, Enumerable.Range(0, 182).Select(i => (Byte) i), "34629BC6D831391C4CDF8AF1B4B7B6B8E8EE17CF98C70E5DD586CD99F14B11DF945166236A9571E6D591BB83EE4D164D46F6B9D8EF86FF865A81BFB91B00424B"),
                    new KnownValue(512, Enumerable.Range(0, 183).Select(i => (Byte) i), "8B7CC339163863BB4383E542B0EF0E7CF36B84AD932CDF5A80419EC9AD692E7A7E784D2C7CB3796A18B8F800035F3AA06C824100611120A7BDEB35618CCB81B7"),
                    new KnownValue(512, Enumerable.Range(0, 184).Select(i => (Byte) i), "4F084E4939DD5A7F5A658FAD58A18A15C25C32EC1C7FD5C5C6C3E892B3971AEAAC308304EF17B1C47239EA4BB398B3FD6D4528D8DE8E768AE0F1A5A5C6B5C297"),
                    new KnownValue(512, Enumerable.Range(0, 185).Select(i => (Byte) i), "48F407A1AF5B8009B2051742E8CF5CD5656669E7D722EE8E7BD202060849442168D8FACC117C012BFB7BF449D99BEFFF6A34AEA203F1D8D352722BE5014EC818"),
                    new KnownValue(512, Enumerable.Range(0, 186).Select(i => (Byte) i), "A6AA82CD1E426F9A73BFA39A29037876114655B8C22D6D3FF8B638AE7DEA6B17843E09E52EB66FA1E475E4A8A3DE429B7D0F4A776FCB8BDC9B9FEDE7D52E815F"),
                    new KnownValue(512, Enumerable.Range(0, 187).Select(i => (Byte) i), "5817027D6BDD00C5DD10AC593CD560372270775A18526D7E6F13872A2E20EAB664625BE7168AC4BD7C9E0CE7FC4099E0F48442E2C767191C6E1284E9B2CCEA8C"),
                    new KnownValue(512, Enumerable.Range(0, 188).Select(i => (Byte) i), "08E41028340A45C74E4052B3A8D6389E22E043A1ADAB5E28D97619450D723469B620CAA519B81C14523854F619FD3027E3847BD03276E60604A80DDB4DE876D6"),
                    new KnownValue(512, Enumerable.Range(0, 189).Select(i => (Byte) i), "130B8420537EB07D72ABDA07C85ACBD8B9A44F16321DD0422145F809673D30F2B5321326E2BFF317EF3FEF983C51C4F8AB24A325D298E34AFCE569A82555774C"),
                    new KnownValue(512, Enumerable.Range(0, 190).Select(i => (Byte) i), "AC49B844AFAA012E31C474CA263648844FD2F6307992C2F752ACA02C3828965175794DEEE2D2EE95C61CD284F6B5A2D75E2EF2B29EE8149E77FB81447B2FD04B"),
                    new KnownValue(512, Enumerable.Range(0, 191).Select(i => (Byte) i), "B9D7CA81CC60BB9578E44024E5A0A0BE80F27336A6A9F4E53DF3999CB191280B090E2AC2D29C5BAAD9D71415BDC129E69AA2667AF6A7FD5E189FCCDCEE817340"),
                    new KnownValue(512, Enumerable.Range(0, 192).Select(i => (Byte) i), "A755E113386572C75CED61D719706070B9146048E42A9F8CD35667A088B42F08808ABDF77E618ABD959AFC757379CA2C00BCC1A48390FA2BFF618B1E0078A613"),
                    new KnownValue(512, Enumerable.Range(0, 193).Select(i => (Byte) i), "A73C7DEBED326F1C0DB0795EE7D6E3946894B826B1F8101C56C823BA17168312E7F53FC7DBE52C3E11E69852C40485E2EF182477862EA6A34EC136E2DFEEA6F4"),
                    new KnownValue(512, Enumerable.Range(0, 194).Select(i => (Byte) i), "6CB8F9D52C56D82CAC28F39EA1593E8BB2506293AC0D68376A1709B62A46DF14A4AE64B2D8FAB76733A1CED2D548E3F3C6FCB49D40C3D5808E449CD83D1C2AA2"),
                    new KnownValue(512, Enumerable.Range(0, 195).Select(i => (Byte) i), "683FA2B2369A10162C1C1C7B24BC970EE67DA220564F32203F625696C0352A0B9AD96624362D952D84463C1106A2DBA7A092599884B35A0B89C8F1B6A9B5A61E"),
                    new KnownValue(512, Enumerable.Range(0, 196).Select(i => (Byte) i), "AAD9AD44610118B77D508AEB1BBCD1C1B7D0171397FB510A401BBC0EC34623670D86A2DC3C8F3AB5A2044DF730256727545F0860CE21A1EAC717DFC48F5D228E"),
                    new KnownValue(512, Enumerable.Range(0, 197).Select(i => (Byte) i), "C42578DE23B4C987D5E1AC4D689ED5DE4B0417F9704BC6BCE969FA13471585D62C2CB1212A944F397FC9CA2C3747C3BEB694EC4C5BE68828DDA53EF43FAEC6C0"),
                    new KnownValue(512, Enumerable.Range(0, 198).Select(i => (Byte) i), "470F00841EE8244E63ED2C7EA30E2E419897C197462ECCCECF713B42A5065FFF5914BC9B79AFFE8F6B657875E789AE213BD914CD35BD174D46E9D18BD843773D"),
                    new KnownValue(512, Enumerable.Range(0, 199).Select(i => (Byte) i), "34FC4213730F47A5E9A3580F643E12945CFCB31BF206F6AD450CE528DA3FA432E005D6B0ECCE10DCA7C5995F6AACC5150E1B009E19751E8309F8859531844374"),
                    new KnownValue(512, Enumerable.Range(0, 200).Select(i => (Byte) i), "FB3C1F0F56A56F8E316FDF5D853C8C872C39635D083634C3904FC3AC07D1B578E85FF0E480E92D44ADE33B62E893EE32343E79DDF6EF292E89B582D312502314"),
                    new KnownValue(512, Enumerable.Range(0, 201).Select(i => (Byte) i), "C7C97FC65DD2B9E3D3D607D31598D3F84261E9919251E9C8E57BB5F829377D5F73EABBED55C6C381180F29AD02E5BE797FFEC7E57BDECBC50AD3D062F0993AB0"),
                    new KnownValue(512, Enumerable.Range(0, 202).Select(i => (Byte) i), "A57A49CDBE67AE7D9F797BB5CC7EFC2DF07F4E1B15955F85DAE74B76E2ECB85AFB6CD9EEED8888D5CA3EC5AB65D27A7B19E578475760A045AC3C92E13A938E77"),
                    new KnownValue(512, Enumerable.Range(0, 203).Select(i => (Byte) i), "C7143FCE9614A17FD653AEB140726DC9C3DBB1DE6CC581B2726897EC24B7A50359AD492243BE66D9EDD8C933B5B80E0B91BB61EA98056006516976FAE8D99A35"),
                    new KnownValue(512, Enumerable.Range(0, 204).Select(i => (Byte) i), "65BB58D07F937E2D3C7E65385F9C54730B704105CCDB691F6E146D4EE8F6C086F49511035110A9AD6031FDCEB943E0F9613BCB276DD40F0624EF0F924F809783"),
                    new KnownValue(512, Enumerable.Range(0, 205).Select(i => (Byte) i), "E540277F683B1186DD3B5B3F61433396581A35FEB12002BE8C6A6231FC40FFA70F08081BC58B2D94F7649543614A435FAA2D62110E13DABC7B86629B63AF9C24"),
                    new KnownValue(512, Enumerable.Range(0, 206).Select(i => (Byte) i), "418500878C5FBCB584C432F4285E05E49F2E3E075399A0DBFCF874EBF8C03D02BF16BC6989D161C77CA0786B05053C6C709433712319192128835CF0B660595B"),
                    new KnownValue(512, Enumerable.Range(0, 207).Select(i => (Byte) i), "889090DBB1944BDC9433EE5EF1010C7A4A24A8E71ECEA8E12A31318CE49DCAB0ACA5C3802334AAB2CC84B14C6B9321FE586BF3F876F19CD406EB1127FB944801"),
                    new KnownValue(512, Enumerable.Range(0, 208).Select(i => (Byte) i), "53B6A28910AA92E27E536FB549CF9B9918791060898E0B9FE183577FF43B5E9C7689C745B32E412269837C31B89E6CC12BF76E13CAD366B74ECE48BB85FD09E9"),
                    new KnownValue(512, Enumerable.Range(0, 209).Select(i => (Byte) i), "7C092080C6A80D672409D081D3D177106BCD63567785140719490950AE07AE8FCAABBAAAB330CFBCF7374482C220AF2EADEEB73DCBB35ED823344E144E7D4899"),
                    new KnownValue(512, Enumerable.Range(0, 210).Select(i => (Byte) i), "9CCDE566D2400509181111F32DDE4CD63209FE59A30C114546AD2776D889A41BAD8FA1BB468CB2F9D42CA9928A7770FEF8E8BA4D0C812D9A1E75C3D8D2CCD75A"),
                    new KnownValue(512, Enumerable.Range(0, 211).Select(i => (Byte) i), "6E293BF5D03FE43977CFE3F57CCDB3AE282A85455DCA33F37F4B74F8398CC612433D755CBEC412F8F82A3BD3BC4A278F7ECD0DFA9BBDC40BE7A787C8F159B2DF"),
                    new KnownValue(512, Enumerable.Range(0, 212).Select(i => (Byte) i), "C56546FB2178456F336164C18B90DEFFC83AE2B5A3ACA77B6884D36D2C1DB39501B3E65E36C758C66E3188451FDB3515EE162C001F06C3E8CB573ADF30F7A101"),
                    new KnownValue(512, Enumerable.Range(0, 213).Select(i => (Byte) i), "6F82F89F299EBCA2FE014B59BFFE1AA84E88B1915FE256AFB646FD8448AF2B8891A7FAB37A4EA6F9A50E6C317039D8CF878F4C8E1A0DD464F0B4D6FF1C7EA853"),
                    new KnownValue(512, Enumerable.Range(0, 214).Select(i => (Byte) i), "2B8599FF9C3D6198637AD51E57D1998B0D75313FE2DD61A533C964A6DD9607C6F723E9452CE46E014B1C1D6DE77BA5B88C914D1C597BF1EAE13474B4290E89B2"),
                    new KnownValue(512, Enumerable.Range(0, 215).Select(i => (Byte) i), "08BF346D38E1DF06C8260EDB1DA75579275948D5C0A0AA9ED2886F8856DE5417A156998758F5B17E52F101CA957A71137473DFD18D7D209C4C10D9233C93691D"),
                    new KnownValue(512, Enumerable.Range(0, 216).Select(i => (Byte) i), "6DF2156D773114D310B63DB9EE5350D77E6BCF25B05FCD910F9B31BC42BB13FE8225EBCB2A23A62280777B6BF74E2CD0917C7640B43DEFE468CD1E18C943C66A"),
                    new KnownValue(512, Enumerable.Range(0, 217).Select(i => (Byte) i), "7C7038BC13A91151828A5BA82B4A96040F258A4DFB1B1373F0D359168AFB0517A20B28A12D3644046BE66B8D08D8AE7F6A923EA1C00187C6D11DC502BAC71305"),
                    new KnownValue(512, Enumerable.Range(0, 218).Select(i => (Byte) i), "BCD1B30D808FB739B987CBF154BEA00DA9D40380B861D4C1D6377122DADD61C0E59018B71941CFB62E00DCD70AEB9ABF0473E80F0A7ECA6B6DEA246AB229DD2B"),
                    new KnownValue(512, Enumerable.Range(0, 219).Select(i => (Byte) i), "7ED4468D968530FE7AB2C33540B26D8C3BD3ED44B34FBE8C2A9D7F805B5ADA0EA252EEADE4FCE97F89728AD85BC8BB2430B1BEF2CDDD32C8446E59B8E8BA3C67"),
                    new KnownValue(512, Enumerable.Range(0, 220).Select(i => (Byte) i), "6D30B7C6CE8A3236C0CA2F8D728B1088CA06983A8043E621D5DCF0C537D13B08791EDEB01A3CF0943EC1C890AB6E29B146A236CD46BCB9D93BF516FB67C63FE5"),
                    new KnownValue(512, Enumerable.Range(0, 221).Select(i => (Byte) i), "97FE03CEF31438508911BDED975980A66029305DC5E3FA8AD1B4FB22FCDF5A19A733320327D8F71CCF496CB3A44A77AF56E3DDE73D3A5F176896CC57C9A5AD99"),
                    new KnownValue(512, Enumerable.Range(0, 222).Select(i => (Byte) i), "785A9D0FBD21136DBCE8FA7EAFD63C9DAD220052978416B31D9753EAA149097847ED9B30A65C70507EFF01879149ED5CF0471D37798EDC05ABD56AD4A2CCCB1D"),
                    new KnownValue(512, Enumerable.Range(0, 223).Select(i => (Byte) i), "AD408D2ABDDFD37B3BF34794C1A3371D928ED7FC8D966225333584C5665817832A37C07F0DC7CB5AA874CD7D20FE8FAB8EABCB9B33D2E0841F6E200960899D95"),
                    new KnownValue(512, Enumerable.Range(0, 224).Select(i => (Byte) i), "97668F745B6032FC815D9579322769DCCD9501A5080029B8AE826BEFB6742331BD9F76EFEB3E2B8E81A9786B282F5068A3A2424697A77C41876B7E753F4C7767"),
                    new KnownValue(512, Enumerable.Range(0, 225).Select(i => (Byte) i), "26BB985F47E7FEE0CFD252D4EF96BED42B9C370C1C6A3E8C9EB04EF7F7818B833A0D1F043EBAFB911DC779E02740A02A44D3A1EA45ED4AD55E686C927CAFE97E"),
                    new KnownValue(512, Enumerable.Range(0, 226).Select(i => (Byte) i), "5BFE2B1DCF7FE9B95088ACEDB575C19016C743B2E763BF5851AC407C9EDA43715EDFA48B4825492C5179593FFF21351B76E8B7E034E4C53C79F61F29C479BD08"),
                    new KnownValue(512, Enumerable.Range(0, 227).Select(i => (Byte) i), "C76509EF72F4A6F9C9C40618ED52B2084F83502232E0AC8BDAF3264368E4D0180F6854C4ABF4F6509C79CAAFC44CF3194AFC57BD077BD7B3C9BDA3D4B8775816"),
                    new KnownValue(512, Enumerable.Range(0, 228).Select(i => (Byte) i), "D66F2BEAB990E354CCB910E4E9C7AC618C7B63EF292A96B552341DE78DC46D3EC8CFABC699B50AF41FDA39CF1B0173660923510AD67FAEDEF5207CFFE8641D20"),
                    new KnownValue(512, Enumerable.Range(0, 229).Select(i => (Byte) i), "7D8F0672992B79BE3A364D8E5904F4AB713BBC8AB01B4F309AD8CCF223CE1034A860DCB0B00550612CC2FA17F2969E18F22E1427D254B4A82B3A03A3EB394ADF"),
                    new KnownValue(512, Enumerable.Range(0, 230).Select(i => (Byte) i), "A56D6725BFB3DE47C1414ADF25FC8F0FC9846F6987722BC06366D5CA4E89722925EBBC881418844075397A0CA89842C7B9E9E07E1D9D183EBEB39E120B483BF7"),
                    new KnownValue(512, Enumerable.Range(0, 231).Select(i => (Byte) i), "AF5E03D7FE60C67E10313344434E79485A03A758D6DCE985574745763C1C5C77D4FB3E6FB12230368370993BF90FEED0C5D1607524562D7C09C0C210ED393D7C"),
                    new KnownValue(512, Enumerable.Range(0, 232).Select(i => (Byte) i), "7A20540CC07BF72B582421FC342E82F52134B69841EC28ED189E2EA6A29DD2F82A640352D222B52F2911DC72A7DAB31CAADD80C6118F13C56B2A1E4373BE0EA3"),
                    new KnownValue(512, Enumerable.Range(0, 233).Select(i => (Byte) i), "486F02C63E5467EA1FDDE7E82BFACC2C1BA5D636D9F3D08B210DA3F372F706EC218CC17FF60AEF703BBE0C15C38AE55D286A684F864C78211CCAB4178C92ADBA"),
                    new KnownValue(512, Enumerable.Range(0, 234).Select(i => (Byte) i), "1C7A5C1DEDCD04A921788F7EB23361CA1953B04B9C7AEC35D65EA3E4996DB26F281278EA4AE666AD81027D98AF57262CDBFA4C085F4210568C7E15EEC7805114"),
                    new KnownValue(512, Enumerable.Range(0, 235).Select(i => (Byte) i), "9CE3FA9A860BDBD5378FD6D7B8B671C6CB7692910CE8F9B6CB4122CBCBE6AC06CA0422CEF1225935053B7D193A81B9E972EB85A1D3074F14CBB5EC9F0573892D"),
                    new KnownValue(512, Enumerable.Range(0, 236).Select(i => (Byte) i), "A91187BE5C371C4265C174FD4653B8AB708551F83D1FEE1CC1479581BC006D6FB78FCC9A5DEE1DB3666F508F9780A37593EBCCCF5FBED39667DC6361E921F779"),
                    new KnownValue(512, Enumerable.Range(0, 237).Select(i => (Byte) i), "4625767D7B1D3D3ED2FBC674AF14E0244152F2A4021FCF3311505D89BD81E2F9F9A500C3B199914DB49500B3C98D03EA93286751A686A3B875DAAB0CCD63B44F"),
                    new KnownValue(512, Enumerable.Range(0, 238).Select(i => (Byte) i), "43DFDFE1B014FED3A2ACABB7F3E9A182F2AA18019D27E3E6CDCF31A15B428E91E7B08CF5E5C376FCE2D8A28FF85AB0A0A1656EDB4A0A91532620096D9A5A652D"),
                    new KnownValue(512, Enumerable.Range(0, 239).Select(i => (Byte) i), "279E3202BE3989BA3112772585177487E4FE3EE3EAB49C2F7FA7FE87CFE7B80D3E0355EDFF6D031E6C96C795DB1C6F041880EC3824DEFACF9263820A8E7327DE"),
                    new KnownValue(512, Enumerable.Range(0, 240).Select(i => (Byte) i), "EA2D066AC229D4D4B616A8BEDEC734325224E4B4E58F1AE6DAD7E40C2DA29196C3B1EA9571DACC81E87328CAA0211E09027B0524AA3F4A849917B3586747EBBB"),
                    new KnownValue(512, Enumerable.Range(0, 241).Select(i => (Byte) i), "49F014F5C61822C899AB5CAE51BE4044A4495E777DEB7DA9B6D8490EFBB87530ADF293DAF079F94C33B7044EF62E2E5BB3EB11E17304F8453EE6CE24F033DDB0"),
                    new KnownValue(512, Enumerable.Range(0, 242).Select(i => (Byte) i), "9233490344E5B0DC5912671B7AE54CEE7730DBE1F4C7D92A4D3E3AAB50571708DB51DCF9C2944591DB651DB32D22935B86944969BE77D5B5FEAE6C3840A8DB26"),
                    new KnownValue(512, Enumerable.Range(0, 243).Select(i => (Byte) i), "B6E75E6F4C7F453B7465D25B5AC8C7196902EAA953875228C8634E16E2AE1F38BC3275304335F5989ECCC1E34167D4E68D7719968FBA8E2FE67947C35C48E806"),
                    new KnownValue(512, Enumerable.Range(0, 244).Select(i => (Byte) i), "CC14CA665AF1483EFBC3AF80080E650D5046A3932F4F51F3FE90A0705EC25104ADF07839265DC51D43401411246E474F0D5E5637AF94767283D53E0617E981F4"),
                    new KnownValue(512, Enumerable.Range(0, 245).Select(i => (Byte) i), "230A1C857CB2E7852E41B647E90E4585D2D881E1734DC38955356E8DD7BFF39053092C6B38E236E1899525647073DDDF6895D64206325E7647F275567B255909"),
                    new KnownValue(512, Enumerable.Range(0, 246).Select(i => (Byte) i), "CBB65321AC436E2FFDAB2936359CE49023F7DEE7614EF28D173C3D27C5D1BFFA51553D433F8EE3C9E49C05A2B883CCE954C9A8093B80612A0CDD4732E041F995"),
                    new KnownValue(512, Enumerable.Range(0, 247).Select(i => (Byte) i), "3E7E570074337275EFB51315588034C3CF0DDDCA20B4612E0BD5B881E7E5476D319CE4FE9F19186E4C0826F44F131EB048E65BE242B1172C63BADB123AB0CBE8"),
                    new KnownValue(512, Enumerable.Range(0, 248).Select(i => (Byte) i), "D32E9EC02D38D4E1B8249DF8DCB00C5B9C68EB8922672E3505393B6A210BA56F9496E5EE0490EF387C3CDEC061F06BC0382D9304CAFBB8E0CD33D57029E62DF2"),
                    new KnownValue(512, Enumerable.Range(0, 249).Select(i => (Byte) i), "8C1512466089F05B3775C262B62D22B83854A83218130B4EC91B3CCBD293D2A54302CECAAB9B100C68D1E6DDC8F07CDDBDFE6FDAAAF099CC09D6B725879C6369"),
                    new KnownValue(512, Enumerable.Range(0, 250).Select(i => (Byte) i), "91A7F61C97C2911E4C812EF71D780AD8FA788794561D08303FD1C1CB608A46A12563086EC5B39D471AED94FB0F6C678A43B8792932F9028D772A22768EA23A9B"),
                    new KnownValue(512, Enumerable.Range(0, 251).Select(i => (Byte) i), "4F6BB222A395E8B18F6BA155477AED3F0729AC9E83E16D31A2A8BC655422B837C891C6199E6F0D75799E3B691525C581953517F252C4B9E3A27A28FBAF49644C"),
                    new KnownValue(512, Enumerable.Range(0, 252).Select(i => (Byte) i), "5D06C07E7A646C413A501C3F4BB2FC38127DE7509B7077C4D9B5613201C1AA02FD5F79D2745915DD57FBCB4CE08695F6EFC0CB3D2D330E19B4B0E6004EA6471E"),
                    new KnownValue(512, Enumerable.Range(0, 253).Select(i => (Byte) i), "B96756E57909968F14B796A5D30F4C9D671472CF82C8CFB2CACA7AC7A44CA0A14C9842D00C82E337502C94D5960ACA4C492EA7B0DF919DDF1AADA2A275BB10D4"),
                    new KnownValue(512, Enumerable.Range(0, 254).Select(i => (Byte) i), "FF0A015E98DB9C99F03977710AAC3E658C0D896F6D71D618BA79DC6CF72AC75B7C038EB6862DEDE4543E145413A6368D69F5722C827BA3EF25B6AE6440D39276"),
                    new KnownValue(512, Enumerable.Range(0, 255).Select(i => (Byte) i), "5B21C5FD8868367612474FA2E70E9CFA2201FFEEE8FAFAB5797AD58FEFA17C9B5B107DA4A3DB6320BAAF2C8617D5A51DF914AE88DA3867C2D41F0CC14FA67928"),
                };
            }
        }

        protected override Blake2B CreateHashFunction(Int32 hashSize)
        {
            return new Blake2B(hashSize);
        }
    }
    

    public class IHashFunctionAsyncTests_Blake2B_CanonicalKeyed
        : IHashFunctionAsyncTests<Blake2B>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(512, Enumerable.Range(0,   0).Select(i => (Byte) i), "10EBB67700B1868EFB4417987ACF4690AE9D972FB7A590C2F02871799AAA4786B5E996E8F0F4EB981FC214B005F42D2FF4233499391653DF7AEFCBC13FC51568"),
                    new KnownValue(512, Enumerable.Range(0,   1).Select(i => (Byte) i), "961F6DD1E4DD30F63901690C512E78E4B45E4742ED197C3C5E45C549FD25F2E4187B0BC9FE30492B16B0D0BC4EF9B0F34C7003FAC09A5EF1532E69430234CEBD"),
                    new KnownValue(512, Enumerable.Range(0,   2).Select(i => (Byte) i), "DA2CFBE2D8409A0F38026113884F84B50156371AE304C4430173D08A99D9FB1B983164A3770706D537F49E0C916D9F32B95CC37A95B99D857436F0232C88A965"),
                    new KnownValue(512, Enumerable.Range(0,   3).Select(i => (Byte) i), "33D0825DDDF7ADA99B0E7E307104AD07CA9CFD9692214F1561356315E784F3E5A17E364AE9DBB14CB2036DF932B77F4B292761365FB328DE7AFDC6D8998F5FC1"),
                    new KnownValue(512, Enumerable.Range(0,   4).Select(i => (Byte) i), "BEAA5A3D08F3807143CF621D95CD690514D0B49EFFF9C91D24B59241EC0EEFA5F60196D407048BBA8D2146828EBCB0488D8842FD56BB4F6DF8E19C4B4DAAB8AC"),
                    new KnownValue(512, Enumerable.Range(0,   5).Select(i => (Byte) i), "098084B51FD13DEAE5F4320DE94A688EE07BAEA2800486689A8636117B46C1F4C1F6AF7F74AE7C857600456A58A3AF251DC4723A64CC7C0A5AB6D9CAC91C20BB"),
                    new KnownValue(512, Enumerable.Range(0,   6).Select(i => (Byte) i), "6044540D560853EB1C57DF0077DD381094781CDB9073E5B1B3D3F6C7829E12066BBACA96D989A690DE72CA3133A83652BA284A6D62942B271FFA2620C9E75B1F"),
                    new KnownValue(512, Enumerable.Range(0,   7).Select(i => (Byte) i), "7A8CFE9B90F75F7ECB3ACC053AAED6193112B6F6A4AEEB3F65D3DE541942DEB9E2228152A3C4BBBE72FC3B12629528CFBB09FE630F0474339F54ABF453E2ED52"),
                    new KnownValue(512, Enumerable.Range(0,   8).Select(i => (Byte) i), "380BEAF6EA7CC9365E270EF0E6F3A64FB902ACAE51DD5512F84259AD2C91F4BC4108DB73192A5BBFB0CBCF71E46C3E21AEE1C5E860DC96E8EB0B7B8426E6ABE9"),
                    new KnownValue(512, Enumerable.Range(0,   9).Select(i => (Byte) i), "60FE3C4535E1B59D9A61EA8500BFAC41A69DFFB1CEADD9ACA323E9A625B64DA5763BAD7226DA02B9C8C4F1A5DE140AC5A6C1124E4F718CE0B28EA47393AA6637"),
                    new KnownValue(512, Enumerable.Range(0,  10).Select(i => (Byte) i), "4FE181F54AD63A2983FEAAF77D1E7235C2BEB17FA328B6D9505BDA327DF19FC37F02C4B6F0368CE23147313A8E5738B5FA2A95B29DE1C7F8264EB77B69F585CD"),
                    new KnownValue(512, Enumerable.Range(0,  11).Select(i => (Byte) i), "F228773CE3F3A42B5F144D63237A72D99693ADB8837D0E112A8A0F8FFFF2C362857AC49C11EC740D1500749DAC9B1F4548108BF3155794DCC9E4082849E2B85B"),
                    new KnownValue(512, Enumerable.Range(0,  12).Select(i => (Byte) i), "962452A8455CC56C8511317E3B1F3B2C37DF75F588E94325FDD77070359CF63A9AE6E930936FDF8E1E08FFCA440CFB72C28F06D89A2151D1C46CD5B268EF8563"),
                    new KnownValue(512, Enumerable.Range(0,  13).Select(i => (Byte) i), "43D44BFA18768C59896BF7ED1765CB2D14AF8C260266039099B25A603E4DDC5039D6EF3A91847D1088D401C0C7E847781A8A590D33A3C6CB4DF0FAB1C2F22355"),
                    new KnownValue(512, Enumerable.Range(0,  14).Select(i => (Byte) i), "DCFFA9D58C2A4CA2CDBB0C7AA4C4C1D45165190089F4E983BB1C2CAB4AAEFF1FA2B5EE516FECD780540240BF37E56C8BCCA7FAB980E1E61C9400D8A9A5B14AC6"),
                    new KnownValue(512, Enumerable.Range(0,  15).Select(i => (Byte) i), "6FBF31B45AB0C0B8DAD1C0F5F4061379912DDE5AA922099A030B725C73346C524291ADEF89D2F6FD8DFCDA6D07DAD811A9314536C2915ED45DA34947E83DE34E"),
                    new KnownValue(512, Enumerable.Range(0,  16).Select(i => (Byte) i), "A0C65BDDDE8ADEF57282B04B11E7BC8AAB105B99231B750C021F4A735CB1BCFAB87553BBA3ABB0C3E64A0B6955285185A0BD35FB8CFDE557329BEBB1F629EE93"),
                    new KnownValue(512, Enumerable.Range(0,  17).Select(i => (Byte) i), "F99D815550558E81ECA2F96718AED10D86F3F1CFB675CCE06B0EFF02F617C5A42C5AA760270F2679DA2677C5AEB94F1142277F21C7F79F3C4F0CCE4ED8EE62B1"),
                    new KnownValue(512, Enumerable.Range(0,  18).Select(i => (Byte) i), "95391DA8FC7B917A2044B3D6F5374E1CA072B41454D572C7356C05FD4BC1E0F40B8BB8B4A9F6BCE9BE2C4623C399B0DCA0DAB05CB7281B71A21B0EBCD9E55670"),
                    new KnownValue(512, Enumerable.Range(0,  19).Select(i => (Byte) i), "04B9CD3D20D221C09AC86913D3DC63041989A9A1E694F1E639A3BA7E451840F750C2FC191D56AD61F2E7936BC0AC8E094B60CAEED878C18799045402D61CEAF9"),
                    new KnownValue(512, Enumerable.Range(0,  20).Select(i => (Byte) i), "EC0E0EF707E4ED6C0C66F9E089E4954B058030D2DD86398FE84059631F9EE591D9D77375355149178C0CF8F8E7C49ED2A5E4F95488A2247067C208510FADC44C"),
                    new KnownValue(512, Enumerable.Range(0,  21).Select(i => (Byte) i), "9A37CCE273B79C09913677510EAF7688E89B3314D3532FD2764C39DE022A2945B5710D13517AF8DDC0316624E73BEC1CE67DF15228302036F330AB0CB4D218DD"),
                    new KnownValue(512, Enumerable.Range(0,  22).Select(i => (Byte) i), "4CF9BB8FB3D4DE8B38B2F262D3C40F46DFE747E8FC0A414C193D9FCF753106CE47A18F172F12E8A2F1C26726545358E5EE28C9E2213A8787AAFBC516D2343152"),
                    new KnownValue(512, Enumerable.Range(0,  23).Select(i => (Byte) i), "64E0C63AF9C808FD893137129867FD91939D53F2AF04BE4FA268006100069B2D69DAA5C5D8ED7FDDCB2A70EEECDF2B105DD46A1E3B7311728F639AB489326BC9"),
                    new KnownValue(512, Enumerable.Range(0,  24).Select(i => (Byte) i), "5E9C93158D659B2DEF06B0C3C7565045542662D6EEE8A96A89B78ADE09FE8B3DCC096D4FE48815D88D8F82620156602AF541955E1F6CA30DCE14E254C326B88F"),
                    new KnownValue(512, Enumerable.Range(0,  25).Select(i => (Byte) i), "7775DFF889458DD11AEF417276853E21335EB88E4DEC9CFB4E9EDB49820088551A2CA60339F12066101169F0DFE84B098FDDB148D9DA6B3D613DF263889AD64B"),
                    new KnownValue(512, Enumerable.Range(0,  26).Select(i => (Byte) i), "F0D2805AFBB91F743951351A6D024F9353A23C7CE1FC2B051B3A8B968C233F46F50F806ECB1568FFAA0B60661E334B21DDE04F8FA155AC740EEB42E20B60D764"),
                    new KnownValue(512, Enumerable.Range(0,  27).Select(i => (Byte) i), "86A2AF316E7D7754201B942E275364AC12EA8962AB5BD8D7FB276DC5FBFFC8F9A28CAE4E4867DF6780D9B72524160927C855DA5B6078E0B554AA91E31CB9CA1D"),
                    new KnownValue(512, Enumerable.Range(0,  28).Select(i => (Byte) i), "10BDF0CAA0802705E706369BAF8A3F79D72C0A03A80675A7BBB00BE3A45E516424D1EE88EFB56F6D5777545AE6E27765C3A8F5E493FC308915638933A1DFEE55"),
                    new KnownValue(512, Enumerable.Range(0,  29).Select(i => (Byte) i), "B01781092B1748459E2E4EC178696627BF4EBAFEBBA774ECF018B79A68AEB84917BF0B84BB79D17B743151144CD66B7B33A4B9E52C76C4E112050FF5385B7F0B"),
                    new KnownValue(512, Enumerable.Range(0,  30).Select(i => (Byte) i), "C6DBC61DEC6EAEAC81E3D5F755203C8E220551534A0B2FD105A91889945A638550204F44093DD998C076205DFFAD703A0E5CD3C7F438A7E634CD59FEDEDB539E"),
                    new KnownValue(512, Enumerable.Range(0,  31).Select(i => (Byte) i), "EBA51ACFFB4CEA31DB4B8D87E9BF7DD48FE97B0253AE67AA580F9AC4A9D941F2BEA518EE286818CC9F633F2A3B9FB68E594B48CDD6D515BF1D52BA6C85A203A7"),
                    new KnownValue(512, Enumerable.Range(0,  32).Select(i => (Byte) i), "86221F3ADA52037B72224F105D7999231C5E5534D03DA9D9C0A12ACB68460CD375DAF8E24386286F9668F72326DBF99BA094392437D398E95BB8161D717F8991"),
                    new KnownValue(512, Enumerable.Range(0,  33).Select(i => (Byte) i), "5595E05C13A7EC4DC8F41FB70CB50A71BCE17C024FF6DE7AF618D0CC4E9C32D9570D6D3EA45B86525491030C0D8F2B1836D5778C1CE735C17707DF364D054347"),
                    new KnownValue(512, Enumerable.Range(0,  34).Select(i => (Byte) i), "CE0F4F6ACA89590A37FE034DD74DD5FA65EB1CBD0A41508AADDC09351A3CEA6D18CB2189C54B700C009F4CBF0521C7EA01BE61C5AE09CB54F27BC1B44D658C82"),
                    new KnownValue(512, Enumerable.Range(0,  35).Select(i => (Byte) i), "7EE80B06A215A3BCA970C77CDA8761822BC103D44FA4B33F4D07DCB997E36D55298BCEAE12241B3FA07FA63BE5576068DA387B8D5859AEAB701369848B176D42"),
                    new KnownValue(512, Enumerable.Range(0,  36).Select(i => (Byte) i), "940A84B6A84D109AAB208C024C6CE9647676BA0AAA11F86DBB7018F9FD2220A6D901A9027F9ABCF935372727CBF09EBD61A2A2EEB87653E8ECAD1BAB85DC8327"),
                    new KnownValue(512, Enumerable.Range(0,  37).Select(i => (Byte) i), "2020B78264A82D9F4151141ADBA8D44BF20C5EC062EEE9B595A11F9E84901BF148F298E0C9F8777DCDBC7CC4670AAC356CC2AD8CCB1629F16F6A76BCEFBEE760"),
                    new KnownValue(512, Enumerable.Range(0,  38).Select(i => (Byte) i), "D1B897B0E075BA68AB572ADF9D9C436663E43EB3D8E62D92FC49C9BE214E6F27873FE215A65170E6BEA902408A25B49506F47BABD07CECF7113EC10C5DD31252"),
                    new KnownValue(512, Enumerable.Range(0,  39).Select(i => (Byte) i), "B14D0C62ABFA469A357177E594C10C194243ED2025AB8AA5AD2FA41AD318E0FF48CD5E60BEC07B13634A711D2326E488A985F31E31153399E73088EFC86A5C55"),
                    new KnownValue(512, Enumerable.Range(0,  40).Select(i => (Byte) i), "4169C5CC808D2697DC2A82430DC23E3CD356DC70A94566810502B8D655B39ABF9E7F902FE717E0389219859E1945DF1AF6ADA42E4CCDA55A197B7100A30C30A1"),
                    new KnownValue(512, Enumerable.Range(0,  41).Select(i => (Byte) i), "258A4EDB113D66C839C8B1C91F15F35ADE609F11CD7F8681A4045B9FEF7B0B24C82CDA06A5F2067B368825E3914E53D6948EDE92EFD6E8387FA2E537239B5BEE"),
                    new KnownValue(512, Enumerable.Range(0,  42).Select(i => (Byte) i), "79D2D8696D30F30FB34657761171A11E6C3F1E64CBE7BEBEE159CB95BFAF812B4F411E2F26D9C421DC2C284A3342D823EC293849E42D1E46B0A4AC1E3C86ABAA"),
                    new KnownValue(512, Enumerable.Range(0,  43).Select(i => (Byte) i), "8B9436010DC5DEE992AE38AEA97F2CD63B946D94FEDD2EC9671DCDE3BD4CE9564D555C66C15BB2B900DF72EDB6B891EBCADFEFF63C9EA4036A998BE7973981E7"),
                    new KnownValue(512, Enumerable.Range(0,  44).Select(i => (Byte) i), "C8F68E696ED28242BF997F5B3B34959508E42D613810F1E2A435C96ED2FF560C7022F361A9234B9837FEEE90BF47922EE0FD5F8DDF823718D86D1E16C6090071"),
                    new KnownValue(512, Enumerable.Range(0,  45).Select(i => (Byte) i), "B02D3EEE4860D5868B2C39CE39BFE81011290564DD678C85E8783F29302DFC1399BA95B6B53CD9EBBF400CCA1DB0AB67E19A325F2D115812D25D00978AD1BCA4"),
                    new KnownValue(512, Enumerable.Range(0,  46).Select(i => (Byte) i), "7693EA73AF3AC4DAD21CA0D8DA85B3118A7D1C6024CFAF557699868217BC0C2F44A199BC6C0EDD519798BA05BD5B1B4484346A47C2CADF6BF30B785CC88B2BAF"),
                    new KnownValue(512, Enumerable.Range(0,  47).Select(i => (Byte) i), "A0E5C1C0031C02E48B7F09A5E896EE9AEF2F17FC9E18E997D7F6CAC7AE316422C2B1E77984E5F3A73CB45DEED5D3F84600105E6EE38F2D090C7D0442EA34C46D"),
                    new KnownValue(512, Enumerable.Range(0,  48).Select(i => (Byte) i), "41DAA6ADCFDB69F1440C37B596440165C15ADA596813E2E22F060FCD551F24DEE8E04BA6890387886CEEC4A7A0D7FC6B44506392EC3822C0D8C1ACFC7D5AEBE8"),
                    new KnownValue(512, Enumerable.Range(0,  49).Select(i => (Byte) i), "14D4D40D5984D84C5CF7523B7798B254E275A3A8CC0A1BD06EBC0BEE726856ACC3CBF516FF667CDA2058AD5C3412254460A82C92187041363CC77A4DC215E487"),
                    new KnownValue(512, Enumerable.Range(0,  50).Select(i => (Byte) i), "D0E7A1E2B9A447FEE83E2277E9FF8010C2F375AE12FA7AAA8CA5A6317868A26A367A0B69FBC1CF32A55D34EB370663016F3D2110230EBA754028A56F54ACF57C"),
                    new KnownValue(512, Enumerable.Range(0,  51).Select(i => (Byte) i), "E771AA8DB5A3E043E8178F39A0857BA04A3F18E4AA05743CF8D222B0B095825350BA422F63382A23D92E4149074E816A36C1CD28284D146267940B31F8818EA2"),
                    new KnownValue(512, Enumerable.Range(0,  52).Select(i => (Byte) i), "FEB4FD6F9E87A56BEF398B3284D2BDA5B5B0E166583A66B61E538457FF0584872C21A32962B9928FFAB58DE4AF2EDD4E15D8B35570523207FF4E2A5AA7754CAA"),
                    new KnownValue(512, Enumerable.Range(0,  53).Select(i => (Byte) i), "462F17BF005FB1C1B9E671779F665209EC2873E3E411F98DABF240A1D5EC3F95CE6796B6FC23FE171903B502023467DEC7273FF74879B92967A2A43A5A183D33"),
                    new KnownValue(512, Enumerable.Range(0,  54).Select(i => (Byte) i), "D3338193B64553DBD38D144BEA71C5915BB110E2D88180DBC5DB364FD6171DF317FC7268831B5AEF75E4342B2FAD8797BA39EDDCEF80E6EC08159350B1AD696D"),
                    new KnownValue(512, Enumerable.Range(0,  55).Select(i => (Byte) i), "E1590D585A3D39F7CB599ABD479070966409A6846D4377ACF4471D065D5DB94129CC9BE92573B05ED226BE1E9B7CB0CABE87918589F80DADD4EF5EF25A93D28E"),
                    new KnownValue(512, Enumerable.Range(0,  56).Select(i => (Byte) i), "F8F3726AC5A26CC80132493A6FEDCB0E60760C09CFC84CAD178175986819665E76842D7B9FEDF76DDDEBF5D3F56FAAAD4477587AF21606D396AE570D8E719AF2"),
                    new KnownValue(512, Enumerable.Range(0,  57).Select(i => (Byte) i), "30186055C07949948183C850E9A756CC09937E247D9D928E869E20BAFC3CD9721719D34E04A0899B92C736084550186886EFBA2E790D8BE6EBF040B209C439A4"),
                    new KnownValue(512, Enumerable.Range(0,  58).Select(i => (Byte) i), "F3C4276CB863637712C241C444C5CC1E3554E0FDDB174D035819DD83EB700B4CE88DF3AB3841BA02085E1A99B4E17310C5341075C0458BA376C95A6818FBB3E2"),
                    new KnownValue(512, Enumerable.Range(0,  59).Select(i => (Byte) i), "0AA007C4DD9D5832393040A1583C930BCA7DC5E77EA53ADD7E2B3F7C8E231368043520D4A3EF53C969B6BBFD025946F632BD7F765D53C21003B8F983F75E2A6A"),
                    new KnownValue(512, Enumerable.Range(0,  60).Select(i => (Byte) i), "08E9464720533B23A04EC24F7AE8C103145F765387D738777D3D343477FD1C58DB052142CAB754EA674378E18766C53542F71970171CC4F81694246B717D7564"),
                    new KnownValue(512, Enumerable.Range(0,  61).Select(i => (Byte) i), "D37FF7AD297993E7EC21E0F1B4B5AE719CDC83C5DB687527F27516CBFFA822888A6810EE5C1CA7BFE3321119BE1AB7BFA0A502671C8329494DF7AD6F522D440F"),
                    new KnownValue(512, Enumerable.Range(0,  62).Select(i => (Byte) i), "DD9042F6E464DCF86B1262F6ACCFAFBD8CFD902ED3ED89ABF78FFA482DBDEEB6969842394C9A1168AE3D481A017842F660002D42447C6B22F7B72F21AAE021C9"),
                    new KnownValue(512, Enumerable.Range(0,  63).Select(i => (Byte) i), "BD965BF31E87D70327536F2A341CEBC4768ECA275FA05EF98F7F1B71A0351298DE006FBA73FE6733ED01D75801B4A928E54231B38E38C562B2E33EA1284992FA"),
                    new KnownValue(512, Enumerable.Range(0,  64).Select(i => (Byte) i), "65676D800617972FBD87E4B9514E1C67402B7A331096D3BFAC22F1ABB95374ABC942F16E9AB0EAD33B87C91968A6E509E119FF07787B3EF483E1DCDCCF6E3022"),
                    new KnownValue(512, Enumerable.Range(0,  65).Select(i => (Byte) i), "939FA189699C5D2C81DDD1FFC1FA207C970B6A3685BB29CE1D3E99D42F2F7442DA53E95A72907314F4588399A3FF5B0A92BEB3F6BE2694F9F86ECF2952D5B41C"),
                    new KnownValue(512, Enumerable.Range(0,  66).Select(i => (Byte) i), "C516541701863F91005F314108CEECE3C643E04FC8C42FD2FF556220E616AAA6A48AEB97A84BAD74782E8DFF96A1A2FA949339D722EDCAA32B57067041DF88CC"),
                    new KnownValue(512, Enumerable.Range(0,  67).Select(i => (Byte) i), "987FD6E0D6857C553EAEBB3D34970A2C2F6E89A3548F492521722B80A1C21A153892346D2CBA6444212D56DA9A26E324DCCBC0DCDE85D4D2EE4399EEC5A64E8F"),
                    new KnownValue(512, Enumerable.Range(0,  68).Select(i => (Byte) i), "AE56DEB1C2328D9C4017706BCE6E99D41349053BA9D336D677C4C27D9FD50AE6AEE17E853154E1F4FE7672346DA2EAA31EEA53FCF24A22804F11D03DA6ABFC2B"),
                    new KnownValue(512, Enumerable.Range(0,  69).Select(i => (Byte) i), "49D6A608C9BDE4491870498572AC31AAC3FA40938B38A7818F72383EB040AD39532BC06571E13D767E6945AB77C0BDC3B0284253343F9F6C1244EBF2FF0DF866"),
                    new KnownValue(512, Enumerable.Range(0,  70).Select(i => (Byte) i), "DA582AD8C5370B4469AF862AA6467A2293B2B28BD80AE0E91F425AD3D47249FDF98825CC86F14028C3308C9804C78BFEEEEE461444CE243687E1A50522456A1D"),
                    new KnownValue(512, Enumerable.Range(0,  71).Select(i => (Byte) i), "D5266AA3331194AEF852EED86D7B5B2633A0AF1C735906F2E13279F14931A9FC3B0EAC5CE9245273BD1AA92905ABE16278EF7EFD47694789A7283B77DA3C70F8"),
                    new KnownValue(512, Enumerable.Range(0,  72).Select(i => (Byte) i), "2962734C28252186A9A1111C732AD4DE4506D4B4480916303EB7991D659CCDA07A9911914BC75C418AB7A4541757AD054796E26797FEAF36E9F6AD43F14B35A4"),
                    new KnownValue(512, Enumerable.Range(0,  73).Select(i => (Byte) i), "E8B79EC5D06E111BDFAFD71E9F5760F00AC8AC5D8BF768F9FF6F08B8F026096B1CC3A4C973333019F1E3553E77DA3F98CB9F542E0A90E5F8A940CC58E59844B3"),
                    new KnownValue(512, Enumerable.Range(0,  74).Select(i => (Byte) i), "DFB320C44F9D41D1EFDCC015F08DD5539E526E39C87D509AE6812A969E5431BF4FA7D91FFD03B981E0D544CF72D7B1C0374F8801482E6DEA2EF903877EBA675E"),
                    new KnownValue(512, Enumerable.Range(0,  75).Select(i => (Byte) i), "D88675118FDB55A5FB365AC2AF1D217BF526CE1EE9C94B2F0090B2C58A06CA58187D7FE57C7BED9D26FCA067B4110EEFCD9A0A345DE872ABE20DE368001B0745"),
                    new KnownValue(512, Enumerable.Range(0,  76).Select(i => (Byte) i), "B893F2FC41F7B0DD6E2F6AA2E0370C0CFF7DF09E3ACFCC0E920B6E6FAD0EF747C40668417D342B80D2351E8C175F20897A062E9765E6C67B539B6BA8B9170545"),
                    new KnownValue(512, Enumerable.Range(0,  77).Select(i => (Byte) i), "6C67EC5697ACCD235C59B486D7B70BAEEDCBD4AA64EBD4EEF3C7EAC189561A726250AEC4D48CADCAFBBE2CE3C16CE2D691A8CCE06E8879556D4483ED7165C063"),
                    new KnownValue(512, Enumerable.Range(0,  78).Select(i => (Byte) i), "F1AA2B044F8F0C638A3F362E677B5D891D6FD2AB0765F6EE1E4987DE057EAD357883D9B405B9D609EEA1B869D97FB16D9B51017C553F3B93C0A1E0F1296FEDCD"),
                    new KnownValue(512, Enumerable.Range(0,  79).Select(i => (Byte) i), "CBAA259572D4AEBFC1917ACDDC582B9F8DFAA928A198CA7ACD0F2AA76A134A90252E6298A65B08186A350D5B7626699F8CB721A3EA5921B753AE3A2DCE24BA3A"),
                    new KnownValue(512, Enumerable.Range(0,  80).Select(i => (Byte) i), "FA1549C9796CD4D303DCF452C1FBD5744FD9B9B47003D920B92DE34839D07EF2A29DED68F6FC9E6C45E071A2E48BD50C5084E96B657DD0404045A1DDEFE282ED"),
                    new KnownValue(512, Enumerable.Range(0,  81).Select(i => (Byte) i), "5CF2AC897AB444DCB5C8D87C495DBDB34E1838B6B629427CAA51702AD0F9688525F13BEC503A3C3A2C80A65E0B5715E8AFAB00FFA56EC455A49A1AD30AA24FCD"),
                    new KnownValue(512, Enumerable.Range(0,  82).Select(i => (Byte) i), "9AAF80207BACE17BB7AB145757D5696BDE32406EF22B44292EF65D4519C3BB2AD41A59B62CC3E94B6FA96D32A7FAADAE28AF7D35097219AA3FD8CDA31E40C275"),
                    new KnownValue(512, Enumerable.Range(0,  83).Select(i => (Byte) i), "AF88B163402C86745CB650C2988FB95211B94B03EF290EED9662034241FD51CF398F8073E369354C43EAE1052F9B63B08191CAA138AA54FEA889CC7024236897"),
                    new KnownValue(512, Enumerable.Range(0,  84).Select(i => (Byte) i), "48FA7D64E1CEEE27B9864DB5ADA4B53D00C9BC7626555813D3CD6730AB3CC06FF342D727905E33171BDE6E8476E77FB1720861E94B73A2C538D254746285F430"),
                    new KnownValue(512, Enumerable.Range(0,  85).Select(i => (Byte) i), "0E6FD97A85E904F87BFE85BBEB34F69E1F18105CF4ED4F87AEC36C6E8B5F68BD2A6F3DC8A9ECB2B61DB4EEDB6B2EA10BF9CB0251FB0F8B344ABF7F366B6DE5AB"),
                    new KnownValue(512, Enumerable.Range(0,  86).Select(i => (Byte) i), "06622DA5787176287FDC8FED440BAD187D830099C94E6D04C8E9C954CDA70C8BB9E1FC4A6D0BAA831B9B78EF6648681A4867A11DA93EE36E5E6A37D87FC63F6F"),
                    new KnownValue(512, Enumerable.Range(0,  87).Select(i => (Byte) i), "1DA6772B58FABF9C61F68D412C82F182C0236D7D575EF0B58DD22458D643CD1DFC93B03871C316D8430D312995D4197F0874C99172BA004A01EE295ABAC24E46"),
                    new KnownValue(512, Enumerable.Range(0,  88).Select(i => (Byte) i), "3CD2D9320B7B1D5FB9AAB951A76023FA667BE14A9124E394513918A3F44096AE4904BA0FFC150B63BC7AB1EEB9A6E257E5C8F000A70394A5AFD842715DE15F29"),
                    new KnownValue(512, Enumerable.Range(0,  89).Select(i => (Byte) i), "04CDC14F7434E0B4BE70CB41DB4C779A88EAEF6ACCEBCB41F2D42FFFE7F32A8E281B5C103A27021D0D08362250753CDF70292195A53A48728CEB5844C2D98BAB"),
                    new KnownValue(512, Enumerable.Range(0,  90).Select(i => (Byte) i), "9071B7A8A075D0095B8FB3AE5113785735AB98E2B52FAF91D5B89E44AAC5B5D4EBBF91223B0FF4C71905DA55342E64655D6EF8C89A4768C3F93A6DC0366B5BC8"),
                    new KnownValue(512, Enumerable.Range(0,  91).Select(i => (Byte) i), "EBB30240DD96C7BC8D0ABE49AA4EDCBB4AFDC51FF9AAF720D3F9E7FBB0F9C6D6571350501769FC4EBD0B2141247FF400D4FD4BE414EDF37757BB90A32AC5C65A"),
                    new KnownValue(512, Enumerable.Range(0,  92).Select(i => (Byte) i), "8532C58BF3C8015D9D1CBE00EEF1F5082F8F3632FBE9F1ED4F9DFB1FA79E8283066D77C44C4AF943D76B300364AECBD0648C8A8939BD204123F4B56260422DEC"),
                    new KnownValue(512, Enumerable.Range(0,  93).Select(i => (Byte) i), "FE9846D64F7C7708696F840E2D76CB4408B6595C2F81EC6A28A7F2F20CB88CFE6AC0B9E9B8244F08BD7095C350C1D0842F64FB01BB7F532DFCD47371B0AEEB79"),
                    new KnownValue(512, Enumerable.Range(0,  94).Select(i => (Byte) i), "28F17EA6FB6C42092DC264257E29746321FB5BDAEA9873C2A7FA9D8F53818E899E161BC77DFE8090AFD82BF2266C5C1BC930A8D1547624439E662EF695F26F24"),
                    new KnownValue(512, Enumerable.Range(0,  95).Select(i => (Byte) i), "EC6B7D7F030D4850ACAE3CB615C21DD25206D63E84D1DB8D957370737BA0E98467EA0CE274C66199901EAEC18A08525715F53BFDB0AACB613D342EBDCEEDDC3B"),
                    new KnownValue(512, Enumerable.Range(0,  96).Select(i => (Byte) i), "B403D3691C03B0D3418DF327D5860D34BBFCC4519BFBCE36BF33B208385FADB9186BC78A76C489D89FD57E7DC75412D23BCD1DAE8470CE9274754BB8585B13C5"),
                    new KnownValue(512, Enumerable.Range(0,  97).Select(i => (Byte) i), "31FC79738B8772B3F55CD8178813B3B52D0DB5A419D30BA9495C4B9DA0219FAC6DF8E7C23A811551A62B827F256ECDB8124AC8A6792CCFECC3B3012722E94463"),
                    new KnownValue(512, Enumerable.Range(0,  98).Select(i => (Byte) i), "BB2039EC287091BCC9642FC90049E73732E02E577E2862B32216AE9BEDCD730C4C284EF3968C368B7D37584F97BD4B4DC6EF6127ACFE2E6AE2509124E66C8AF4"),
                    new KnownValue(512, Enumerable.Range(0,  99).Select(i => (Byte) i), "F53D68D13F45EDFCB9BD415E2831E938350D5380D3432278FC1C0C381FCB7C65C82DAFE051D8C8B0D44E0974A0E59EC7BF7ED0459F86E96F329FC79752510FD3"),
                    new KnownValue(512, Enumerable.Range(0, 100).Select(i => (Byte) i), "8D568C7984F0ECDF7640FBC483B5D8C9F86634F6F43291841B309A350AB9C1137D24066B09DA9944BAC54D5BB6580D836047AAC74AB724B887EBF93D4B32ECA9"),
                    new KnownValue(512, Enumerable.Range(0, 101).Select(i => (Byte) i), "C0B65CE5A96FF774C456CAC3B5F2C4CD359B4FF53EF93A3DA0778BE4900D1E8DA1601E769E8F1B02D2A2F8C5B9FA10B44F1C186985468FEEB008730283A6657D"),
                    new KnownValue(512, Enumerable.Range(0, 102).Select(i => (Byte) i), "4900BBA6F5FB103ECE8EC96ADA13A5C3C85488E05551DA6B6B33D988E611EC0FE2E3C2AA48EA6AE8986A3A231B223C5D27CEC2EADDE91CE07981EE652862D1E4"),
                    new KnownValue(512, Enumerable.Range(0, 103).Select(i => (Byte) i), "C7F5C37C7285F927F76443414D4357FF789647D7A005A5A787E03C346B57F49F21B64FA9CF4B7E45573E23049017567121A9C3D4B2B73EC5E9413577525DB45A"),
                    new KnownValue(512, Enumerable.Range(0, 104).Select(i => (Byte) i), "EC7096330736FDB2D64B5653E7475DA746C23A4613A82687A28062D3236364284AC01720FFB406CFE265C0DF626A188C9E5963ACE5D3D5BB363E32C38C2190A6"),
                    new KnownValue(512, Enumerable.Range(0, 105).Select(i => (Byte) i), "82E744C75F4649EC52B80771A77D475A3BC091989556960E276A5F9EAD92A03F718742CDCFEAEE5CB85C44AF198ADC43A4A428F5F0C2DDB0BE36059F06D7DF73"),
                    new KnownValue(512, Enumerable.Range(0, 106).Select(i => (Byte) i), "2834B7A7170F1F5B68559AB78C1050EC21C919740B784A9072F6E5D69F828D70C919C5039FB148E39E2C8A52118378B064CA8D5001CD10A5478387B966715ED6"),
                    new KnownValue(512, Enumerable.Range(0, 107).Select(i => (Byte) i), "16B4ADA883F72F853BB7EF253EFCAB0C3E2161687AD61543A0D2824F91C1F81347D86BE709B16996E17F2DD486927B0288AD38D13063C4A9672C39397D3789B6"),
                    new KnownValue(512, Enumerable.Range(0, 108).Select(i => (Byte) i), "78D048F3A69D8B54AE0ED63A573AE350D89F7C6CF1F3688930DE899AFA037697629B314E5CD303AA62FEEA72A25BF42B304B6C6BCB27FAE21C16D925E1FBDAC3"),
                    new KnownValue(512, Enumerable.Range(0, 109).Select(i => (Byte) i), "0F746A48749287ADA77A82961F05A4DA4ABDB7D77B1220F836D09EC814359C0EC0239B8C7B9FF9E02F569D1B301EF67C4612D1DE4F730F81C12C40CC063C5CAA"),
                    new KnownValue(512, Enumerable.Range(0, 110).Select(i => (Byte) i), "F0FC859D3BD195FBDC2D591E4CDAC15179EC0F1DC821C11DF1F0C1D26E6260AAA65B79FAFACAFD7D3AD61E600F250905F5878C87452897647A35B995BCADC3A3"),
                    new KnownValue(512, Enumerable.Range(0, 111).Select(i => (Byte) i), "2620F687E8625F6A412460B42E2CEF67634208CE10A0CBD4DFF7044A41B7880077E9F8DC3B8D1216D3376A21E015B58FB279B521D83F9388C7382C8505590B9B"),
                    new KnownValue(512, Enumerable.Range(0, 112).Select(i => (Byte) i), "227E3AED8D2CB10B918FCB04F9DE3E6D0A57E08476D93759CD7B2ED54A1CBF0239C528FB04BBF288253E601D3BC38B21794AFEF90B17094A182CAC557745E75F"),
                    new KnownValue(512, Enumerable.Range(0, 113).Select(i => (Byte) i), "1A929901B09C25F27D6B35BE7B2F1C4745131FDEBCA7F3E2451926720434E0DB6E74FD693AD29B777DC3355C592A361C4873B01133A57C2E3B7075CBDB86F4FC"),
                    new KnownValue(512, Enumerable.Range(0, 114).Select(i => (Byte) i), "5FD7968BC2FE34F220B5E3DC5AF9571742D73B7D60819F2888B629072B96A9D8AB2D91B82D0A9AABA61BBD39958132FCC4257023D1ECA591B3054E2DC81C8200"),
                    new KnownValue(512, Enumerable.Range(0, 115).Select(i => (Byte) i), "DFCCE8CF32870CC6A503EADAFC87FD6F78918B9B4D0737DB6810BE996B5497E7E5CC80E312F61E71FF3E9624436073156403F735F56B0B01845C18F6CAF772E6"),
                    new KnownValue(512, Enumerable.Range(0, 116).Select(i => (Byte) i), "02F7EF3A9CE0FFF960F67032B296EFCA3061F4934D690749F2D01C35C81C14F39A67FA350BC8A0359BF1724BFFC3BCA6D7C7BBA4791FD522A3AD353C02EC5AA8"),
                    new KnownValue(512, Enumerable.Range(0, 117).Select(i => (Byte) i), "64BE5C6ABA65D594844AE78BB022E5BEBE127FD6B6FFA5A13703855AB63B624DCD1A363F99203F632EC386F3EA767FC992E8ED9686586AA27555A8599D5B808F"),
                    new KnownValue(512, Enumerable.Range(0, 118).Select(i => (Byte) i), "F78585505C4EAA54A8B5BE70A61E735E0FF97AF944DDB3001E35D86C4E2199D976104B6AE31750A36A726ED285064F5981B503889FEF822FCDC2898DDDB7889A"),
                    new KnownValue(512, Enumerable.Range(0, 119).Select(i => (Byte) i), "E4B5566033869572EDFD87479A5BB73C80E8759B91232879D96B1DDA36C012076EE5A2ED7AE2DE63EF8406A06AEA82C188031B560BEAFB583FB3DE9E57952A7E"),
                    new KnownValue(512, Enumerable.Range(0, 120).Select(i => (Byte) i), "E1B3E7ED867F6C9484A2A97F7715F25E25294E992E41F6A7C161FFC2ADC6DAAEB7113102D5E6090287FE6AD94CE5D6B739C6CA240B05C76FB73F25DD024BF935"),
                    new KnownValue(512, Enumerable.Range(0, 121).Select(i => (Byte) i), "85FD085FDC12A080983DF07BD7012B0D402A0F4043FCB2775ADF0BAD174F9B08D1676E476985785C0A5DCC41DBFF6D95EF4D66A3FBDC4A74B82BA52DA0512B74"),
                    new KnownValue(512, Enumerable.Range(0, 122).Select(i => (Byte) i), "AED8FA764B0FBFF821E05233D2F7B0900EC44D826F95E93C343C1BC3BA5A24374B1D616E7E7ABA453A0ADA5E4FAB5382409E0D42CE9C2BC7FB39A99C340C20F0"),
                    new KnownValue(512, Enumerable.Range(0, 123).Select(i => (Byte) i), "7BA3B2E297233522EEB343BD3EBCFD835A04007735E87F0CA300CBEE6D416565162171581E4020FF4CF176450F1291EA2285CB9EBFFE4C56660627685145051C"),
                    new KnownValue(512, Enumerable.Range(0, 124).Select(i => (Byte) i), "DE748BCF89EC88084721E16B85F30ADB1A6134D664B5843569BABC5BBD1A15CA9B61803C901A4FEF32965A1749C9F3A4E243E173939DC5A8DC495C671AB52145"),
                    new KnownValue(512, Enumerable.Range(0, 125).Select(i => (Byte) i), "AAF4D2BDF200A919706D9842DCE16C98140D34BC433DF320ABA9BD429E549AA7A3397652A4D768277786CF993CDE2338673ED2E6B66C961FEFB82CD20C93338F"),
                    new KnownValue(512, Enumerable.Range(0, 126).Select(i => (Byte) i), "C408218968B788BF864F0997E6BC4C3DBA68B276E2125A4843296052FF93BF5767B8CDCE7131F0876430C1165FEC6C4F47ADAA4FD8BCFACEF463B5D3D0FA61A0"),
                    new KnownValue(512, Enumerable.Range(0, 127).Select(i => (Byte) i), "76D2D819C92BCE55FA8E092AB1BF9B9EAB237A25267986CACF2B8EE14D214D730DC9A5AA2D7B596E86A1FD8FA0804C77402D2FCD45083688B218B1CDFA0DCBCB"),
                    new KnownValue(512, Enumerable.Range(0, 128).Select(i => (Byte) i), "72065EE4DD91C2D8509FA1FC28A37C7FC9FA7D5B3F8AD3D0D7A25626B57B1B44788D4CAF806290425F9890A3A2A35A905AB4B37ACFD0DA6E4517B2525C9651E4"),
                    new KnownValue(512, Enumerable.Range(0, 129).Select(i => (Byte) i), "64475DFE7600D7171BEA0B394E27C9B00D8E74DD1E416A79473682AD3DFDBB706631558055CFC8A40E07BD015A4540DCDEA15883CBBF31412DF1DE1CD4152B91"),
                    new KnownValue(512, Enumerable.Range(0, 130).Select(i => (Byte) i), "12CD1674A4488A5D7C2B3160D2E2C4B58371BEDAD793418D6F19C6EE385D70B3E06739369D4DF910EDB0B0A54CBFF43D54544CD37AB3A06CFA0A3DDAC8B66C89"),
                    new KnownValue(512, Enumerable.Range(0, 131).Select(i => (Byte) i), "60756966479DEDC6DD4BCFF8EA7D1D4CE4D4AF2E7B097E32E3763518441147CC12B3C0EE6D2ECABF1198CEC92E86A3616FBA4F4E872F5825330ADBB4C1DEE444"),
                    new KnownValue(512, Enumerable.Range(0, 132).Select(i => (Byte) i), "A7803BCB71BC1D0F4383DDE1E0612E04F872B715AD30815C2249CF34ABB8B024915CB2FC9F4E7CC4C8CFD45BE2D5A91EAB0941C7D270E2DA4CA4A9F7AC68663A"),
                    new KnownValue(512, Enumerable.Range(0, 133).Select(i => (Byte) i), "B84EF6A7229A34A750D9A98EE2529871816B87FBE3BC45B45FA5AE82D5141540211165C3C5D7A7476BA5A4AA06D66476F0D9DC49A3F1EE72C3ACABD498967414"),
                    new KnownValue(512, Enumerable.Range(0, 134).Select(i => (Byte) i), "FAE4B6D8EFC3F8C8E64D001DABEC3A21F544E82714745251B2B4B393F2F43E0DA3D403C64DB95A2CB6E23EBB7B9E94CDD5DDAC54F07C4A61BD3CB10AA6F93B49"),
                    new KnownValue(512, Enumerable.Range(0, 135).Select(i => (Byte) i), "34F7286605A122369540141DED79B8957255DA2D4155ABBF5A8DBB89C8EB7EDE8EEEF1DAA46DC29D751D045DC3B1D658BB64B80FF8589EDDB3824B13DA235A6B"),
                    new KnownValue(512, Enumerable.Range(0, 136).Select(i => (Byte) i), "3B3B48434BE27B9EABABBA43BF6B35F14B30F6A88DC2E750C358470D6B3AA3C18E47DB4017FA55106D8252F016371A00F5F8B070B74BA5F23CFFC5511C9F09F0"),
                    new KnownValue(512, Enumerable.Range(0, 137).Select(i => (Byte) i), "BA289EBD6562C48C3E10A8AD6CE02E73433D1E93D7C9279D4D60A7E879EE11F441A000F48ED9F7C4ED87A45136D7DCCDCA482109C78A51062B3BA4044ADA2469"),
                    new KnownValue(512, Enumerable.Range(0, 138).Select(i => (Byte) i), "022939E2386C5A37049856C850A2BB10A13DFEA4212B4C732A8840A9FFA5FAF54875C5448816B2785A007DA8A8D2BC7D71A54E4E6571F10B600CBDB25D13EDE3"),
                    new KnownValue(512, Enumerable.Range(0, 139).Select(i => (Byte) i), "E6FEC19D89CE8717B1A087024670FE026F6C7CBDA11CAEF959BB2D351BF856F8055D1C0EBDAAA9D1B17886FC2C562B5E99642FC064710C0D3488A02B5ED7F6FD"),
                    new KnownValue(512, Enumerable.Range(0, 140).Select(i => (Byte) i), "94C96F02A8F576ACA32BA61C2B206F907285D9299B83AC175C209A8D43D53BFE683DD1D83E7549CB906C28F59AB7C46F8751366A28C39DD5FE2693C9019666C8"),
                    new KnownValue(512, Enumerable.Range(0, 141).Select(i => (Byte) i), "31A0CD215EBD2CB61DE5B9EDC91E6195E31C59A5648D5C9F737E125B2605708F2E325AB3381C8DCE1A3E958886F1ECDC60318F882CFE20A24191352E617B0F21"),
                    new KnownValue(512, Enumerable.Range(0, 142).Select(i => (Byte) i), "91AB504A522DCE78779F4C6C6BA2E6B6DB5565C76D3E7E7C920CAF7F757EF9DB7C8FCF10E57F03379EA9BF75EB59895D96E149800B6AAE01DB778BB90AFBC989"),
                    new KnownValue(512, Enumerable.Range(0, 143).Select(i => (Byte) i), "D85CABC6BD5B1A01A5AFD8C6734740DA9FD1C1ACC6DB29BFC8A2E5B668B028B6B3154BFB8703FA3180251D589AD38040CEB707C4BAD1B5343CB426B61EAA49C1"),
                    new KnownValue(512, Enumerable.Range(0, 144).Select(i => (Byte) i), "D62EFBEC2CA9C1F8BD66CE8B3F6A898CB3F7566BA6568C618AD1FEB2B65B76C3CE1DD20F7395372FAF28427F61C9278049CF0140DF434F5633048C86B81E0399"),
                    new KnownValue(512, Enumerable.Range(0, 145).Select(i => (Byte) i), "7C8FDC6175439E2C3DB15BAFA7FB06143A6A23BC90F449E79DEEF73C3D492A671715C193B6FEA9F036050B946069856B897E08C00768F5EE5DDCF70B7CD6D0E0"),
                    new KnownValue(512, Enumerable.Range(0, 146).Select(i => (Byte) i), "58602EE7468E6BC9DF21BD51B23C005F72D6CB013F0A1B48CBEC5ECA299299F97F09F54A9A01483EAEB315A6478BAD37BA47CA1347C7C8FC9E6695592C91D723"),
                    new KnownValue(512, Enumerable.Range(0, 147).Select(i => (Byte) i), "27F5B79ED256B050993D793496EDF4807C1D85A7B0A67C9C4FA99860750B0AE66989670A8FFD7856D7CE411599E58C4D77B232A62BEF64D15275BE46A68235FF"),
                    new KnownValue(512, Enumerable.Range(0, 148).Select(i => (Byte) i), "3957A976B9F1887BF004A8DCA942C92D2B37EA52600F25E0C9BC5707D0279C00C6E85A839B0D2D8EB59C51D94788EBE62474A791CADF52CCCF20F5070B6573FC"),
                    new KnownValue(512, Enumerable.Range(0, 149).Select(i => (Byte) i), "EAA2376D55380BF772ECCA9CB0AA4668C95C707162FA86D518C8CE0CA9BF7362B9F2A0ADC3FF59922DF921B94567E81E452F6C1A07FC817CEBE99604B3505D38"),
                    new KnownValue(512, Enumerable.Range(0, 150).Select(i => (Byte) i), "C1E2C78B6B2734E2480EC550434CB5D613111ADCC21D475545C3B1B7E6FF12444476E5C055132E2229DC0F807044BB919B1A5662DD38A9EE65E243A3911AED1A"),
                    new KnownValue(512, Enumerable.Range(0, 151).Select(i => (Byte) i), "8AB48713389DD0FCF9F965D3CE66B1E559A1F8C58741D67683CD971354F452E62D0207A65E436C5D5D8F8EE71C6ABFE50E669004C302B31A7EA8311D4A916051"),
                    new KnownValue(512, Enumerable.Range(0, 152).Select(i => (Byte) i), "24CE0ADDAA4C65038BD1B1C0F1452A0B128777AABC94A29DF2FD6C7E2F85F8AB9AC7EFF516B0E0A825C84A24CFE492EAAD0A6308E46DD42FE8333AB971BB30CA"),
                    new KnownValue(512, Enumerable.Range(0, 153).Select(i => (Byte) i), "5154F929EE03045B6B0C0004FA778EDEE1D139893267CC84825AD7B36C63DE32798E4A166D24686561354F63B00709A1364B3C241DE3FEBF0754045897467CD4"),
                    new KnownValue(512, Enumerable.Range(0, 154).Select(i => (Byte) i), "E74E907920FD87BD5AD636DD11085E50EE70459C443E1CE5809AF2BC2EBA39F9E6D7128E0E3712C316DA06F4705D78A4838E28121D4344A2C79C5E0DB307A677"),
                    new KnownValue(512, Enumerable.Range(0, 155).Select(i => (Byte) i), "BF91A22334BAC20F3FD80663B3CD06C4E8802F30E6B59F90D3035CC9798A217ED5A31ABBDA7FA6842827BDF2A7A1C21F6FCFCCBB54C6C52926F32DA816269BE1"),
                    new KnownValue(512, Enumerable.Range(0, 156).Select(i => (Byte) i), "D9D5C74BE5121B0BD742F26BFFB8C89F89171F3F934913492B0903C271BBE2B3395EF259669BEF43B57F7FCC3027DB01823F6BAEE66E4F9FEAD4D6726C741FCE"),
                    new KnownValue(512, Enumerable.Range(0, 157).Select(i => (Byte) i), "50C8B8CF34CD879F80E2FAAB3230B0C0E1CC3E9DCADEB1B9D97AB923415DD9A1FE38ADDD5C11756C67990B256E95AD6D8F9FEDCE10BF1C90679CDE0ECF1BE347"),
                    new KnownValue(512, Enumerable.Range(0, 158).Select(i => (Byte) i), "0A386E7CD5DD9B77A035E09FE6FEE2C8CE61B5383C87EA43205059C5E4CD4F4408319BB0A82360F6A58E6C9CE3F487C446063BF813BC6BA535E17FC1826CFC91"),
                    new KnownValue(512, Enumerable.Range(0, 159).Select(i => (Byte) i), "1F1459CB6B61CBAC5F0EFE8FC487538F42548987FCD56221CFA7BEB22504769E792C45ADFB1D6B3D60D7B749C8A75B0BDF14E8EA721B95DCA538CA6E25711209"),
                    new KnownValue(512, Enumerable.Range(0, 160).Select(i => (Byte) i), "E58B3836B7D8FEDBB50CA5725C6571E74C0785E97821DAB8B6298C10E4C079D4A6CDF22F0FEDB55032925C16748115F01A105E77E00CEE3D07924DC0D8F90659"),
                    new KnownValue(512, Enumerable.Range(0, 161).Select(i => (Byte) i), "B929CC6505F020158672DEDA56D0DB081A2EE34C00C1100029BDF8EA98034FA4BF3E8655EC697FE36F40553C5BB46801644A627D3342F4FC92B61F03290FB381"),
                    new KnownValue(512, Enumerable.Range(0, 162).Select(i => (Byte) i), "72D353994B49D3E03153929A1E4D4F188EE58AB9E72EE8E512F29BC773913819CE057DDD7002C0433EE0A16114E3D156DD2C4A7E80EE53378B8670F23E33EF56"),
                    new KnownValue(512, Enumerable.Range(0, 163).Select(i => (Byte) i), "C70EF9BFD775D408176737A0736D68517CE1AAAD7E81A93C8C1ED967EA214F56C8A377B1763E676615B60F3988241EAE6EAB9685A5124929D28188F29EAB06F7"),
                    new KnownValue(512, Enumerable.Range(0, 164).Select(i => (Byte) i), "C230F0802679CB33822EF8B3B21BF7A9A28942092901D7DAC3760300831026CF354C9232DF3E084D9903130C601F63C1F4A4A4B8106E468CD443BBE5A734F45F"),
                    new KnownValue(512, Enumerable.Range(0, 165).Select(i => (Byte) i), "6F43094CAFB5EBF1F7A4937EC50F56A4C9DA303CBB55AC1F27F1F1976CD96BEDA9464F0E7B9C54620B8A9FBA983164B8BE3578425A024F5FE199C36356B88972"),
                    new KnownValue(512, Enumerable.Range(0, 166).Select(i => (Byte) i), "3745273F4C38225DB2337381871A0C6AAFD3AF9B018C88AA02025850A5DC3A42A1A3E03E56CBF1B0876D63A441F1D2856A39B8801EB5AF325201C415D65E97FE"),
                    new KnownValue(512, Enumerable.Range(0, 167).Select(i => (Byte) i), "C50C44CCA3EC3EDAAE779A7E179450EBDDA2F97067C690AA6C5A4AC7C30139BB27C0DF4DB3220E63CB110D64F37FFE078DB72653E2DAACF93AE3F0A2D1A7EB2E"),
                    new KnownValue(512, Enumerable.Range(0, 168).Select(i => (Byte) i), "8AEF263E385CBC61E19B28914243262AF5AFE8726AF3CE39A79C27028CF3ECD3F8D2DFD9CFC9AD91B58F6F20778FD5F02894A3D91C7D57D1E4B866A7F364B6BE"),
                    new KnownValue(512, Enumerable.Range(0, 169).Select(i => (Byte) i), "28696141DE6E2D9BCB3235578A66166C1448D3E905A1B482D423BE4BC5369BC8C74DAE0ACC9CC123E1D8DDCE9F97917E8C019C552DA32D39D2219B9ABF0FA8C8"),
                    new KnownValue(512, Enumerable.Range(0, 170).Select(i => (Byte) i), "2FB9EB2085830181903A9DAFE3DB428EE15BE7662224EFD643371FB25646AEE716E531ECA69B2BDC8233F1A8081FA43DA1500302975A77F42FA592136710E9DC"),
                    new KnownValue(512, Enumerable.Range(0, 171).Select(i => (Byte) i), "66F9A7143F7A3314A669BF2E24BBB35014261D639F495B6C9C1F104FE8E320ACA60D4550D69D52EDBD5A3CDEB4014AE65B1D87AA770B69AE5C15F4330B0B0AD8"),
                    new KnownValue(512, Enumerable.Range(0, 172).Select(i => (Byte) i), "F4C4DD1D594C3565E3E25CA43DAD82F62ABEA4835ED4CD811BCD975E46279828D44D4C62C3679F1B7F7B9DD4571D7B49557347B8C5460CBDC1BEF690FB2A08C0"),
                    new KnownValue(512, Enumerable.Range(0, 173).Select(i => (Byte) i), "8F1DC9649C3A84551F8F6E91CAC68242A43B1F8F328EE92280257387FA7559AA6DB12E4AEADC2D26099178749C6864B357F3F83B2FB3EFA8D2A8DB056BED6BCC"),
                    new KnownValue(512, Enumerable.Range(0, 174).Select(i => (Byte) i), "3139C1A7F97AFD1675D460EBBC07F2728AA150DF849624511EE04B743BA0A833092F18C12DC91B4DD243F333402F59FE28ABDBBBAE301E7B659C7A26D5C0F979"),
                    new KnownValue(512, Enumerable.Range(0, 175).Select(i => (Byte) i), "06F94A2996158A819FE34C40DE3CF0379FD9FB85B3E363BA3926A0E7D960E3F4C2E0C70C7CE0CCB2A64FC29869F6E7AB12BD4D3F14FCE943279027E785FB5C29"),
                    new KnownValue(512, Enumerable.Range(0, 176).Select(i => (Byte) i), "C29C399EF3EEE8961E87565C1CE263925FC3D0CE267D13E48DD9E732EE67B0F69FAD56401B0F10FCAAC119201046CCA28C5B14ABDEA3212AE65562F7F138DB3D"),
                    new KnownValue(512, Enumerable.Range(0, 177).Select(i => (Byte) i), "4CEC4C9DF52EEF05C3F6FAAA9791BC7445937183224ECC37A1E58D0132D35617531D7E795F52AF7B1EB9D147DE1292D345FE341823F8E6BC1E5BADCA5C656108"),
                    new KnownValue(512, Enumerable.Range(0, 178).Select(i => (Byte) i), "898BFBAE93B3E18D00697EAB7D9704FA36EC339D076131CEFDF30EDBE8D9CC81C3A80B129659B163A323BAB9793D4FEED92D54DAE966C77529764A09BE88DB45"),
                    new KnownValue(512, Enumerable.Range(0, 179).Select(i => (Byte) i), "EE9BD0469D3AAF4F14035BE48A2C3B84D9B4B1FFF1D945E1F1C1D38980A951BE197B25FE22C731F20AEACC930BA9C4A1F4762227617AD350FDABB4E80273A0F4"),
                    new KnownValue(512, Enumerable.Range(0, 180).Select(i => (Byte) i), "3D4D3113300581CD96ACBF091C3D0F3C310138CD6979E6026CDE623E2DD1B24D4A8638BED1073344783AD0649CC6305CCEC04BEB49F31C633088A99B65130267"),
                    new KnownValue(512, Enumerable.Range(0, 181).Select(i => (Byte) i), "95C0591AD91F921AC7BE6D9CE37E0663ED8011C1CFD6D0162A5572E94368BAC02024485E6A39854AA46FE38E97D6C6B1947CD272D86B06BB5B2F78B9B68D559D"),
                    new KnownValue(512, Enumerable.Range(0, 182).Select(i => (Byte) i), "227B79DED368153BF46C0A3CA978BFDBEF31F3024A5665842468490B0FF748AE04E7832ED4C9F49DE9B1706709D623E5C8C15E3CAECAE8D5E433430FF72F20EB"),
                    new KnownValue(512, Enumerable.Range(0, 183).Select(i => (Byte) i), "5D34F3952F0105EEF88AE8B64C6CE95EBFADE0E02C69B08762A8712D2E4911AD3F941FC4034DC9B2E479FDBCD279B902FAF5D838BB2E0C6495D372B5B7029813"),
                    new KnownValue(512, Enumerable.Range(0, 184).Select(i => (Byte) i), "7F939BF8353ABCE49E77F14F3750AF20B7B03902E1A1E7FB6AAF76D0259CD401A83190F15640E74F3E6C5A90E839C7821F6474757F75C7BF9002084DDC7A62DC"),
                    new KnownValue(512, Enumerable.Range(0, 185).Select(i => (Byte) i), "062B61A2F9A33A71D7D0A06119644C70B0716A504DE7E5E1BE49BD7B86E7ED6817714F9F0FC313D06129597E9A2235EC8521DE36F7290A90CCFC1FFA6D0AEE29"),
                    new KnownValue(512, Enumerable.Range(0, 186).Select(i => (Byte) i), "F29E01EEAE64311EB7F1C6422F946BF7BEA36379523E7B2BBABA7D1D34A22D5EA5F1C5A09D5CE1FE682CCED9A4798D1A05B46CD72DFF5C1B355440B2A2D476BC"),
                    new KnownValue(512, Enumerable.Range(0, 187).Select(i => (Byte) i), "EC38CD3BBAB3EF35D7CB6D5C914298351D8A9DC97FCEE051A8A02F58E3ED6184D0B7810A5615411AB1B95209C3C810114FDEB22452084E77F3F847C6DBAAFE16"),
                    new KnownValue(512, Enumerable.Range(0, 188).Select(i => (Byte) i), "C2AEF5E0CA43E82641565B8CB943AA8BA53550CAEF793B6532FAFAD94B816082F0113A3EA2F63608AB40437ECC0F0229CB8FA224DCF1C478A67D9B64162B92D1"),
                    new KnownValue(512, Enumerable.Range(0, 189).Select(i => (Byte) i), "15F534EFFF7105CD1C254D074E27D5898B89313B7D366DC2D7D87113FA7D53AAE13F6DBA487AD8103D5E854C91FDB6E1E74B2EF6D1431769C30767DDE067A35C"),
                    new KnownValue(512, Enumerable.Range(0, 190).Select(i => (Byte) i), "89ACBCA0B169897A0A2714C2DF8C95B5B79CB69390142B7D6018BB3E3076B099B79A964152A9D912B1B86412B7E372E9CECAD7F25D4CBAB8A317BE36492A67D7"),
                    new KnownValue(512, Enumerable.Range(0, 191).Select(i => (Byte) i), "E3C0739190ED849C9C962FD9DBB55E207E624FCAC1EB417691515499EEA8D8267B7E8F1287A63633AF5011FDE8C4DDF55BFDF722EDF88831414F2CFAED59CB9A"),
                    new KnownValue(512, Enumerable.Range(0, 192).Select(i => (Byte) i), "8D6CF87C08380D2D1506EEE46FD4222D21D8C04E585FBFD08269C98F702833A156326A0724656400EE09351D57B440175E2A5DE93CC5F80DB6DAF83576CF75FA"),
                    new KnownValue(512, Enumerable.Range(0, 193).Select(i => (Byte) i), "DA24BEDE383666D563EEED37F6319BAF20D5C75D1635A6BA5EF4CFA1AC95487E96F8C08AF600AAB87C986EBAD49FC70A58B4890B9C876E091016DAF49E1D322E"),
                    new KnownValue(512, Enumerable.Range(0, 194).Select(i => (Byte) i), "F9D1D1B1E87EA7AE753A029750CC1CF3D0157D41805E245C5617BB934E732F0AE3180B78E05BFE76C7C3051E3E3AC78B9B50C05142657E1E03215D6EC7BFD0FC"),
                    new KnownValue(512, Enumerable.Range(0, 195).Select(i => (Byte) i), "11B7BC1668032048AA43343DE476395E814BBBC223678DB951A1B03A021EFAC948CFBE215F97FE9A72A2F6BC039E3956BFA417C1A9F10D6D7BA5D3D32FF323E5"),
                    new KnownValue(512, Enumerable.Range(0, 196).Select(i => (Byte) i), "B8D9000E4FC2B066EDB91AFEE8E7EB0F24E3A201DB8B6793C0608581E628ED0BCC4E5AA6787992A4BCC44E288093E63EE83ABD0BC3EC6D0934A674A4DA13838A"),
                    new KnownValue(512, Enumerable.Range(0, 197).Select(i => (Byte) i), "CE325E294F9B6719D6B61278276AE06A2564C03BB0B783FAFE785BDF89C7D5ACD83E78756D301B445699024EAEB77B54D477336EC2A4F332F2B3F88765DDB0C3"),
                    new KnownValue(512, Enumerable.Range(0, 198).Select(i => (Byte) i), "29ACC30E9603AE2FCCF90BF97E6CC463EBE28C1B2F9B4B765E70537C25C702A29DCBFBF14C99C54345BA2B51F17B77B5F15DB92BBAD8FA95C471F5D070A137CC"),
                    new KnownValue(512, Enumerable.Range(0, 199).Select(i => (Byte) i), "3379CBAAE562A87B4C0425550FFDD6BFE1203F0D666CC7EA095BE407A5DFE61EE91441CD5154B3E53B4F5FB31AD4C7A9AD5C7AF4AE679AA51A54003A54CA6B2D"),
                    new KnownValue(512, Enumerable.Range(0, 200).Select(i => (Byte) i), "3095A349D245708C7CF550118703D7302C27B60AF5D4E67FC978F8A4E60953C7A04F92FCF41AEE64321CCB707A895851552B1E37B00BC5E6B72FA5BCEF9E3FFF"),
                    new KnownValue(512, Enumerable.Range(0, 201).Select(i => (Byte) i), "07262D738B09321F4DBCCEC4BB26F48CB0F0ED246CE0B31B9A6E7BC683049F1F3E5545F28CE932DD985C5AB0F43BD6DE0770560AF329065ED2E49D34624C2CBB"),
                    new KnownValue(512, Enumerable.Range(0, 202).Select(i => (Byte) i), "B6405ECA8EE3316C87061CC6EC18DBA53E6C250C63BA1F3BAE9E55DD3498036AF08CD272AA24D713C6020D77AB2F3919AF1A32F307420618AB97E73953994FB4"),
                    new KnownValue(512, Enumerable.Range(0, 203).Select(i => (Byte) i), "7EE682F63148EE45F6E5315DA81E5C6E557C2C34641FC509C7A5701088C38A74756168E2CD8D351E88FD1A451F360A01F5B2580F9B5A2E8CFC138F3DD59A3FFC"),
                    new KnownValue(512, Enumerable.Range(0, 204).Select(i => (Byte) i), "1D263C179D6B268F6FA016F3A4F29E943891125ED8593C81256059F5A7B44AF2DCB2030D175C00E62ECAF7EE96682AA07AB20A611024A28532B1C25B86657902"),
                    new KnownValue(512, Enumerable.Range(0, 205).Select(i => (Byte) i), "106D132CBDB4CD2597812846E2BC1BF732FEC5F0A5F65DBB39EC4E6DC64AB2CE6D24630D0F15A805C3540025D84AFA98E36703C3DBEE713E72DDE8465BC1BE7E"),
                    new KnownValue(512, Enumerable.Range(0, 206).Select(i => (Byte) i), "0E79968226650667A8D862EA8DA4891AF56A4E3A8B6D1750E394F0DEA76D640D85077BCEC2CC86886E506751B4F6A5838F7F0B5FEF765D9DC90DCDCBAF079F08"),
                    new KnownValue(512, Enumerable.Range(0, 207).Select(i => (Byte) i), "521156A82AB0C4E566E5844D5E31AD9AAF144BBD5A464FDCA34DBD5717E8FF711D3FFEBBFA085D67FE996A34F6D3E4E60B1396BF4B1610C263BDBB834D560816"),
                    new KnownValue(512, Enumerable.Range(0, 208).Select(i => (Byte) i), "1ABA88BEFC55BC25EFBCE02DB8B9933E46F57661BAEABEB21CC2574D2A518A3CBA5DC5A38E49713440B25F9C744E75F6B85C9D8F4681F676160F6105357B8406"),
                    new KnownValue(512, Enumerable.Range(0, 209).Select(i => (Byte) i), "5A9949FCB2C473CDA968AC1B5D08566DC2D816D960F57E63B898FA701CF8EBD3F59B124D95BFBBEDC5F1CF0E17D5EAED0C02C50B69D8A402CABCCA4433B51FD4"),
                    new KnownValue(512, Enumerable.Range(0, 210).Select(i => (Byte) i), "B0CEAD09807C672AF2EB2B0F06DDE46CF5370E15A4096B1A7D7CBB36EC31C205FBEFCA00B7A4162FA89FB4FB3EB78D79770C23F44E7206664CE3CD931C291E5D"),
                    new KnownValue(512, Enumerable.Range(0, 211).Select(i => (Byte) i), "BB6664931EC97044E45B2AE420AE1C551A8874BC937D08E969399C3964EBDBA8346CDD5D09CAAFE4C28BA7EC788191CECA65DDD6F95F18583E040D0F30D0364D"),
                    new KnownValue(512, Enumerable.Range(0, 212).Select(i => (Byte) i), "65BC770A5FAA3792369803683E844B0BE7EE96F29F6D6A35568006BD5590F9A4EF639B7A8061C7B0424B66B60AC34AF3119905F33A9D8C3AE18382CA9B689900"),
                    new KnownValue(512, Enumerable.Range(0, 213).Select(i => (Byte) i), "EA9B4DCA333336AAF839A45C6EAA48B8CB4C7DDABFFEA4F643D6357EA6628A480A5B45F2B052C1B07D1FEDCA918B6F1139D80F74C24510DCBAA4BE70EACC1B06"),
                    new KnownValue(512, Enumerable.Range(0, 214).Select(i => (Byte) i), "E6342FB4A780AD975D0E24BCE149989B91D360557E87994F6B457B895575CC02D0C15BAD3CE7577F4C63927FF13F3E381FF7E72BDBE745324844A9D27E3F1C01"),
                    new KnownValue(512, Enumerable.Range(0, 215).Select(i => (Byte) i), "3E209C9B33E8E461178AB46B1C64B49A07FB745F1C8BC95FBFB94C6B87C69516651B264EF980937FAD41238B91DDC011A5DD777C7EFD4494B4B6ECD3A9C22AC0"),
                    new KnownValue(512, Enumerable.Range(0, 216).Select(i => (Byte) i), "FD6A3D5B1875D80486D6E69694A56DBB04A99A4D051F15DB2689776BA1C4882E6D462A603B7015DC9F4B7450F05394303B8652CFB404A266962C41BAE6E18A94"),
                    new KnownValue(512, Enumerable.Range(0, 217).Select(i => (Byte) i), "951E27517E6BAD9E4195FC8671DEE3E7E9BE69CEE1422CB9FECFCE0DBA875F7B310B93EE3A3D558F941F635F668FF832D2C1D033C5E2F0997E4C66F147344E02"),
                    new KnownValue(512, Enumerable.Range(0, 218).Select(i => (Byte) i), "8EBA2F874F1AE84041903C7C4253C82292530FC8509550BFDC34C95C7E2889D5650B0AD8CB988E5C4894CB87FBFBB19612EA93CCC4C5CAD17158B9763464B492"),
                    new KnownValue(512, Enumerable.Range(0, 219).Select(i => (Byte) i), "16F712EAA1B7C6354719A8E7DBDFAF55E4063A4D277D947550019B38DFB564830911057D50506136E2394C3B28945CC964967D54E3000C2181626CFB9B73EFD2"),
                    new KnownValue(512, Enumerable.Range(0, 220).Select(i => (Byte) i), "C39639E7D5C7FB8CDD0FD3E6A52096039437122F21C78F1679CEA9D78A734C56ECBEB28654B4F18E342C331F6F7229EC4B4BC281B2D80A6EB50043F31796C88C"),
                    new KnownValue(512, Enumerable.Range(0, 221).Select(i => (Byte) i), "72D081AF99F8A173DCC9A0AC4EB3557405639A29084B54A40172912A2F8A395129D5536F0918E902F9E8FA6000995F4168DDC5F893011BE6A0DBC9B8A1A3F5BB"),
                    new KnownValue(512, Enumerable.Range(0, 222).Select(i => (Byte) i), "C11AA81E5EFD24D5FC27EE586CFD8847FBB0E27601CCECE5ECCA0198E3C7765393BB74457C7E7A27EB9170350E1FB53857177506BE3E762CC0F14D8C3AFE9077"),
                    new KnownValue(512, Enumerable.Range(0, 223).Select(i => (Byte) i), "C28F2150B452E6C0C424BCDE6F8D72007F9310FED7F2F87DE0DBB64F4479D6C1441BA66F44B2ACCEE61609177ED340128B407ECEC7C64BBE50D63D22D8627727"),
                    new KnownValue(512, Enumerable.Range(0, 224).Select(i => (Byte) i), "F63D88122877EC30B8C8B00D22E89000A966426112BD44166E2F525B769CCBE9B286D437A0129130DDE1A86C43E04BEDB594E671D98283AFE64CE331DE9828FD"),
                    new KnownValue(512, Enumerable.Range(0, 225).Select(i => (Byte) i), "348B0532880B88A6614A8D7408C3F913357FBB60E995C60205BE9139E74998AEDE7F4581E42F6B52698F7FA1219708C14498067FD1E09502DE83A77DD281150C"),
                    new KnownValue(512, Enumerable.Range(0, 226).Select(i => (Byte) i), "5133DC8BEF725359DFF59792D85EAF75B7E1DCD1978B01C35B1B85FCEBC63388AD99A17B6346A217DC1A9622EBD122ECF6913C4D31A6B52A695B86AF00D741A0"),
                    new KnownValue(512, Enumerable.Range(0, 227).Select(i => (Byte) i), "2753C4C0E98ECAD806E88780EC27FCCD0F5C1AB547F9E4BF1659D192C23AA2CC971B58B6802580BAEF8ADC3B776EF7086B2545C2987F348EE3719CDEF258C403"),
                    new KnownValue(512, Enumerable.Range(0, 228).Select(i => (Byte) i), "B1663573CE4B9D8CAEFC865012F3E39714B9898A5DA6CE17C25A6A47931A9DDB9BBE98ADAA553BEED436E89578455416C2A52A525CF2862B8D1D49A2531B7391"),
                    new KnownValue(512, Enumerable.Range(0, 229).Select(i => (Byte) i), "64F58BD6BFC856F5E873B2A2956EA0EDA0D6DB0DA39C8C7FC67C9F9FEEFCFF3072CDF9E6EA37F69A44F0C61AA0DA3693C2DB5B54960C0281A088151DB42B11E8"),
                    new KnownValue(512, Enumerable.Range(0, 230).Select(i => (Byte) i), "0764C7BE28125D9065C4B98A69D60AEDE703547C66A12E17E1C618994132F5EF82482C1E3FE3146CC65376CC109F0138ED9A80E49F1F3C7D610D2F2432F20605"),
                    new KnownValue(512, Enumerable.Range(0, 231).Select(i => (Byte) i), "F748784398A2FF03EBEB07E155E66116A839741A336E32DA71EC696001F0AD1B25CD48C69CFCA7265ECA1DD71904A0CE748AC4124F3571076DFA7116A9CF00E9"),
                    new KnownValue(512, Enumerable.Range(0, 232).Select(i => (Byte) i), "3F0DBC0186BCEB6B785BA78D2A2A013C910BE157BDAFFAE81BB6663B1A73722F7F1228795F3ECADA87CF6EF0078474AF73F31ECA0CC200ED975B6893F761CB6D"),
                    new KnownValue(512, Enumerable.Range(0, 233).Select(i => (Byte) i), "D4762CD4599876CA75B2B8FE249944DBD27ACE741FDAB93616CBC6E425460FEB51D4E7ADCC38180E7FC47C89024A7F56191ADB878DFDE4EAD62223F5A2610EFE"),
                    new KnownValue(512, Enumerable.Range(0, 234).Select(i => (Byte) i), "CD36B3D5B4C91B90FCBBA79513CFEE1907D8645A162AFD0CD4CF4192D4A5F4C892183A8EACDB2B6B6A9D9AA8C11AC1B261B380DBEE24CA468F1BFD043C58EEFE"),
                    new KnownValue(512, Enumerable.Range(0, 235).Select(i => (Byte) i), "98593452281661A53C48A9D8CD790826C1A1CE567738053D0BEE4A91A3D5BD92EEFDBABEBE3204F2031CA5F781BDA99EF5D8AE56E5B04A9E1ECD21B0EB05D3E1"),
                    new KnownValue(512, Enumerable.Range(0, 236).Select(i => (Byte) i), "771F57DD2775CCDAB55921D3E8E30CCF484D61FE1C1B9C2AE819D0FB2A12FAB9BE70C4A7A138DA84E8280435DAADE5BBE66AF0836A154F817FB17F3397E725A3"),
                    new KnownValue(512, Enumerable.Range(0, 237).Select(i => (Byte) i), "C60897C6F828E21F16FBB5F15B323F87B6C8955EABF1D38061F707F608ABDD993FAC3070633E286CF8339CE295DD352DF4B4B40B2F29DA1DD50B3A05D079E6BB"),
                    new KnownValue(512, Enumerable.Range(0, 238).Select(i => (Byte) i), "8210CD2C2D3B135C2CF07FA0D1433CD771F325D075C6469D9C7F1BA0943CD4AB09808CABF4ACB9CE5BB88B498929B4B847F681AD2C490D042DB2AEC94214B06B"),
                    new KnownValue(512, Enumerable.Range(0, 239).Select(i => (Byte) i), "1D4EDFFFD8FD80F7E4107840FA3AA31E32598491E4AF7013C197A65B7F36DD3AC4B478456111CD4309D9243510782FA31B7C4C95FA951520D020EB7E5C36E4EF"),
                    new KnownValue(512, Enumerable.Range(0, 240).Select(i => (Byte) i), "AF8E6E91FAB46CE4873E1A50A8EF448CC29121F7F74DEEF34A71EF89CC00D9274BC6C2454BBB3230D8B2EC94C62B1DEC85F3593BFA30EA6F7A44D7C09465A253"),
                    new KnownValue(512, Enumerable.Range(0, 241).Select(i => (Byte) i), "29FD384ED4906F2D13AA9FE7AF905990938BED807F1832454A372AB412EEA1F5625A1FCC9AC8343B7C67C5ABA6E0B1CC4644654913692C6B39EB9187CEACD3EC"),
                    new KnownValue(512, Enumerable.Range(0, 242).Select(i => (Byte) i), "A268C7885D9874A51C44DFFED8EA53E94F78456E0B2ED99FF5A3924760813826D960A15EDBEDBB5DE5226BA4B074E71B05C55B9756BB79E55C02754C2C7B6C8A"),
                    new KnownValue(512, Enumerable.Range(0, 243).Select(i => (Byte) i), "0CF8545488D56A86817CD7ECB10F7116B7EA530A45B6EA497B6C72C997E09E3D0DA8698F46BB006FC977C2CD3D1177463AC9057FDD1662C85D0C126443C10473"),
                    new KnownValue(512, Enumerable.Range(0, 244).Select(i => (Byte) i), "B39614268FDD8781515E2CFEBF89B4D5402BAB10C226E6344E6B9AE000FB0D6C79CB2F3EC80E80EAEB1980D2F8698916BD2E9F747236655116649CD3CA23A837"),
                    new KnownValue(512, Enumerable.Range(0, 245).Select(i => (Byte) i), "74BEF092FC6F1E5DBA3663A3FB003B2A5BA257496536D99F62B9D73F8F9EB3CE9FF3EEC709EB883655EC9EB896B9128F2AFC89CF7D1AB58A72F4A3BF034D2B4A"),
                    new KnownValue(512, Enumerable.Range(0, 246).Select(i => (Byte) i), "3A988D38D75611F3EF38B8774980B33E573B6C57BEE0469BA5EED9B44F29945E7347967FBA2C162E1C3BE7F310F2F75EE2381E7BFD6B3F0BAEA8D95DFB1DAFB1"),
                    new KnownValue(512, Enumerable.Range(0, 247).Select(i => (Byte) i), "58AEDFCE6F67DDC85A28C992F1C0BD0969F041E66F1EE88020A125CBFCFEBCD61709C9C4EBA192C15E69F020D462486019FA8DEA0CD7A42921A19D2FE546D43D"),
                    new KnownValue(512, Enumerable.Range(0, 248).Select(i => (Byte) i), "9347BD291473E6B4E368437B8E561E065F649A6D8ADA479AD09B1999A8F26B91CF6120FD3BFE014E83F23ACFA4C0AD7B3712B2C3C0733270663112CCD9285CD9"),
                    new KnownValue(512, Enumerable.Range(0, 249).Select(i => (Byte) i), "B32163E7C5DBB5F51FDC11D2EAC875EFBBCB7E7699090A7E7FF8A8D50795AF5D74D9FF98543EF8CDF89AC13D0485278756E0EF00C817745661E1D59FE38E7537"),
                    new KnownValue(512, Enumerable.Range(0, 250).Select(i => (Byte) i), "1085D78307B1C4B008C57A2E7E5B234658A0A82E4FF1E4AAAC72B312FDA0FE27D233BC5B10E9CC17FDC7697B540C7D95EB215A19A1A0E20E1ABFA126EFD568C7"),
                    new KnownValue(512, Enumerable.Range(0, 251).Select(i => (Byte) i), "4E5C734C7DDE011D83EAC2B7347B373594F92D7091B9CA34CB9C6F39BDF5A8D2F134379E16D822F6522170CCF2DDD55C84B9E6C64FC927AC4CF8DFB2A17701F2"),
                    new KnownValue(512, Enumerable.Range(0, 252).Select(i => (Byte) i), "695D83BD990A1117B3D0CE06CC888027D12A054C2677FD82F0D4FBFC93575523E7991A5E35A3752E9B70CE62992E268A877744CDD435F5F130869C9A2074B338"),
                    new KnownValue(512, Enumerable.Range(0, 253).Select(i => (Byte) i), "A6213743568E3B3158B9184301F3690847554C68457CB40FC9A4B8CFD8D4A118C301A07737AEDA0F929C68913C5F51C80394F53BFF1C3E83B2E40CA97EBA9E15"),
                    new KnownValue(512, Enumerable.Range(0, 254).Select(i => (Byte) i), "D444BFA2362A96DF213D070E33FA841F51334E4E76866B8139E8AF3BB3398BE2DFADDCBC56B9146DE9F68118DC5829E74B0C28D7711907B121F9161CB92B69A9"),
                    new KnownValue(512, Enumerable.Range(0, 255).Select(i => (Byte) i), "142709D62E28FCCCD0AF97FAD0F8465B971E82201DC51070FAA0372AA43E92484BE1C1E73BA10906D5D1853DB6A4106E0A7BF9800D373D6DEE2D46D62EF2A461"),
                };
            }
        }

        protected override Blake2B CreateHashFunction(Int32 hashSize)
        {
            return new Blake2B(hashSize, key: Enumerable.Range(0, 64).Select(i => (Byte) i));
        }
    }
    

    #endregion

    #region Data.HashFunction.BuzHash

    public class IHashFunctionAsyncTests_DefaultBuzHash
        : IHashFunctionAsyncTests<DefaultBuzHash>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(8, TestConstants.Empty, 0xd3),
                    new KnownValue(8, TestConstants.FooBar, 0xb2),
                    new KnownValue(8, TestConstants.LoremIpsum, 0x83),
                    new KnownValue(16, TestConstants.Empty, 0x37d3),
                    new KnownValue(16, TestConstants.FooBar, 0xd088),
                    new KnownValue(16, TestConstants.LoremIpsum, 0x284a),
                    new KnownValue(32, TestConstants.Empty, 0xfd0337d3),
                    new KnownValue(32, TestConstants.FooBar, 0xe3d9d0b6),
                    new KnownValue(32, TestConstants.LoremIpsum, 0x2f16d6a7),
                    new KnownValue(64, TestConstants.Empty, 0x3cd05367fd0337d3),
                    new KnownValue(64, TestConstants.FooBar, 0xe8ebaa27e3d9d09f),
                    new KnownValue(64, TestConstants.LoremIpsum, 0xfad1d8bf5108c8dd),
                };
            }
        }

        protected override DefaultBuzHash CreateHashFunction(Int32 hashSize)
        {
            return new DefaultBuzHash(hashSize);
        }
    }
    

    public class IHashFunctionAsyncTests_DefaultBuzHash_DefaultConstructor
        : IHashFunctionAsyncTests<DefaultBuzHash>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(64, TestConstants.Empty, 0x3cd05367fd0337d3),
                    new KnownValue(64, TestConstants.FooBar, 0xe8ebaa27e3d9d09f),
                    new KnownValue(64, TestConstants.LoremIpsum, 0xfad1d8bf5108c8dd),
                };
            }
        }

        protected override DefaultBuzHash CreateHashFunction(Int32 hashSize)
        {
            return new DefaultBuzHash();
        }
    }
    

    public class IHashFunctionAsyncTests_DefaultBuzHash_RightShift
        : IHashFunctionAsyncTests<DefaultBuzHash>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(8, TestConstants.Empty, 0xd3),
                    new KnownValue(8, TestConstants.FooBar, 0x8b),
                    new KnownValue(8, TestConstants.LoremIpsum, 0x97),
                    new KnownValue(16, TestConstants.Empty, 0x37d3),
                    new KnownValue(16, TestConstants.FooBar, 0xe16b),
                    new KnownValue(16, TestConstants.LoremIpsum, 0x076f),
                    new KnownValue(32, TestConstants.Empty, 0xfd0337d3),
                    new KnownValue(32, TestConstants.FooBar, 0xd2d7f16b),
                    new KnownValue(32, TestConstants.LoremIpsum, 0x36d306ab),
                    new KnownValue(64, TestConstants.Empty, 0x3cd05367fd0337d3),
                    new KnownValue(64, TestConstants.FooBar, 0x7f44cd6ecad7f16b),
                    new KnownValue(64, TestConstants.LoremIpsum, 0xb826c048cb5399a3),
                };
            }
        }

        protected override DefaultBuzHash CreateHashFunction(Int32 hashSize)
        {
            return new DefaultBuzHash(BuzHashBase.CircularShiftDirection.Right, hashSize);
        }
    }
    

    public class IHashFunctionAsyncTests_DefaultBuzHash_RightShift_DefaultConstructor
        : IHashFunctionAsyncTests<DefaultBuzHash>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(64, TestConstants.Empty, 0x3cd05367fd0337d3),
                    new KnownValue(64, TestConstants.FooBar, 0x7f44cd6ecad7f16b),
                    new KnownValue(64, TestConstants.LoremIpsum, 0xb826c048cb5399a3),
                };
            }
        }

        protected override DefaultBuzHash CreateHashFunction(Int32 hashSize)
        {
            return new DefaultBuzHash(BuzHashBase.CircularShiftDirection.Right);
        }
    }
    

    public class IHashFunctionAsyncTests_BuzHashBaseImpl
        : IHashFunctionAsyncTests<BuzHashBaseImpl>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(8, TestConstants.Empty, 0x00),
                    new KnownValue(8, TestConstants.FooBar, 0x00),
                    new KnownValue(8, TestConstants.LoremIpsum, 0x00),
                    new KnownValue(16, TestConstants.Empty, 0x0000),
                    new KnownValue(16, TestConstants.FooBar, 0x0000),
                    new KnownValue(16, TestConstants.LoremIpsum, 0x0000),
                    new KnownValue(32, TestConstants.Empty, 0x00000000),
                    new KnownValue(32, TestConstants.FooBar, 0x00000000),
                    new KnownValue(32, TestConstants.LoremIpsum, 0x00000000),
                    new KnownValue(64, TestConstants.Empty, 0x0000000000000000L),
                    new KnownValue(64, TestConstants.FooBar, 0x0000000000000000L),
                    new KnownValue(64, TestConstants.LoremIpsum, 0x0000000000000000L),
                };
            }
        }

        protected override BuzHashBaseImpl CreateHashFunction(Int32 hashSize)
        {
            return new BuzHashBaseImpl(hashSize);
        }
    }
    

    public class IHashFunctionAsyncTests_BuzHashBaseImpl_DefaultConstructor
        : IHashFunctionAsyncTests<BuzHashBaseImpl>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(64, TestConstants.Empty, 0x0000000000000000L),
                    new KnownValue(64, TestConstants.FooBar, 0x0000000000000000L),
                    new KnownValue(64, TestConstants.LoremIpsum, 0x0000000000000000L),
                };
            }
        }

        protected override BuzHashBaseImpl CreateHashFunction(Int32 hashSize)
        {
            return new BuzHashBaseImpl();
        }
    }
    

    #endregion

    #region Data.HashFunction.CityHash

    public class IHashFunctionAsyncTests_CityHash
        : IHashFunctionAsyncTests<CityHash>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.Empty, 0xdc56d17a),
                    new KnownValue(32, TestConstants.FooBar, 0xe2f34cdf),
                    new KnownValue(32, TestConstants.LoremIpsum, 0xc2ebd64e),
                    new KnownValue(32, TestConstants.RandomShort, 0x1fcea779),
                    new KnownValue(32, TestConstants.RandomLong, 0x9dba44d0),
                    new KnownValue(64, TestConstants.Empty, 0x9ae16a3b2f90404f),
                    new KnownValue(64, TestConstants.FooBar, 0xc43fb29ab5effcfe),
                    new KnownValue(64, TestConstants.LoremIpsum, 0x764df1e17d92d1eb),
                    new KnownValue(64, TestConstants.RandomShort, 0x3ef8698eae651b16),
                    new KnownValue(64, TestConstants.RandomLong, 0x39e9fcdba69979b0),
                    new KnownValue(128, TestConstants.Empty, "2b9ac064fc9df03d291ee592c340b53c"),
                    new KnownValue(128, TestConstants.FooBar, "5064c017cf2c1672daa1f13a15b78c98"),
                    new KnownValue(128, TestConstants.LoremIpsum, "31dd5cb57a6c29dc0826565eeb0cf6a4"),
                    new KnownValue(128, TestConstants.RandomShort, "67cbf6f803487e7e09bffce371172c13"),
                    new KnownValue(128, TestConstants.RandomLong, "98999f077f446a5ee962148d86279ea0"),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(3), 0xd83c2fa0),
                    new KnownValue(64, TestConstants.LoremIpsum.Take(3), 0xfa10ac780bf932dd),
                    new KnownValue(128, TestConstants.LoremIpsum.Take(3), "8b5529b80301a1c414cc313959fd5255"),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(23), 0xa6480aae),
                    new KnownValue(64, TestConstants.LoremIpsum.Take(23), 0x3a03aa21105c4286),
                    new KnownValue(128, TestConstants.LoremIpsum.Take(23), "658f52c24d66d71d844823de90c3d9ac"),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(64), 0x8ace2a1a),
                    new KnownValue(64, TestConstants.LoremIpsum.Take(64), 0x2167be8daa61f94d),
                    new KnownValue(128, TestConstants.LoremIpsum.Take(64), "50e89788e0dbb5d6784fbcbdf57264d1"),
                };
            }
        }

        protected override CityHash CreateHashFunction(Int32 hashSize)
        {
            return new CityHash(hashSize);
        }
    }
    

    public class IHashFunctionAsyncTests_CityHash_DefaultConstructor
        : IHashFunctionAsyncTests<CityHash>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.Empty, 0xdc56d17a),
                    new KnownValue(32, TestConstants.FooBar, 0xe2f34cdf),
                    new KnownValue(32, TestConstants.LoremIpsum, 0xc2ebd64e),
                    new KnownValue(32, TestConstants.RandomShort, 0x1fcea779),
                    new KnownValue(32, TestConstants.RandomLong, 0x9dba44d0),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(3), 0xd83c2fa0),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(23), 0xa6480aae),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(64), 0x8ace2a1a),
                };
            }
        }

        protected override CityHash CreateHashFunction(Int32 hashSize)
        {
            return new CityHash();
        }
    }
    

    #endregion

    #region Data.HashFunction.Core

    public class IHashFunctionAsyncTests_HashFunctionImpl
        : IHashFunctionAsyncTests<HashFunctionImpl>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(0, TestConstants.Empty, new Byte[0]),
                };
            }
        }

        protected override HashFunctionImpl CreateHashFunction(Int32 hashSize)
        {
            return new HashFunctionImpl(hashSize);
        }
    }
    

    public class IHashFunctionTests_HashAlgorithmWrapper_SHA1
        : IHashFunctionTests<HashAlgorithmWrapper>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(160, TestConstants.Empty, "da39a3ee5e6b4b0d3255bfef95601890afd80709"),
                    new KnownValue(160, TestConstants.FooBar, "8843d7f92416211de9ebb963ff4ce28125932878"),
                    new KnownValue(160, TestConstants.LoremIpsum, "2dd4010f15f21c9e26e31a693ba31c6ab78a5a4c"),
                    new KnownValue(160, TestConstants.RandomShort, "d64df40c72068b01e7dfb5ceb2b519ad3b483eb0"),
                    new KnownValue(160, TestConstants.RandomLong, "e5901cb4679133729c5555210c3cfe3e5851a2aa"),
                };
            }
        }

        protected override HashAlgorithmWrapper CreateHashFunction(Int32 hashSize)
        {
            return new HashAlgorithmWrapper(new SHA1Managed());
        }
    }
    

    public class IHashFunctionTests_HashAlgorithmWrapper_SHA256
        : IHashFunctionTests<HashAlgorithmWrapper>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(256, TestConstants.FooBar, "c3ab8ff13720e8ad9047dd39466b3c8974e592c2fa383d4a3960714caef0c4f2"),
                };
            }
        }

        protected override HashAlgorithmWrapper CreateHashFunction(Int32 hashSize)
        {
            return new HashAlgorithmWrapper(new SHA256Managed());
        }
    }
    

    public class IHashFunctionTests_HashAlgorithmWrapper_SHA384
        : IHashFunctionTests<HashAlgorithmWrapper>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(384, TestConstants.FooBar, "3c9c30d9f665e74d515c842960d4a451c83a0125fd3de7392d7b37231af10c72ea58aedfcdf89a5765bf902af93ecf06"),
                };
            }
        }

        protected override HashAlgorithmWrapper CreateHashFunction(Int32 hashSize)
        {
            return new HashAlgorithmWrapper(new SHA384Managed());
        }
    }
    

    public class IHashFunctionTests_HashAlgorithmWrapper_SHA512
        : IHashFunctionTests<HashAlgorithmWrapper>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(512, TestConstants.FooBar, "0a50261ebd1a390fed2bf326f2673c145582a6342d523204973d0219337f81616a8069b012587cf5635f6925f1b56c360230c19b273500ee013e030601bf2425"),
                };
            }
        }

        protected override HashAlgorithmWrapper CreateHashFunction(Int32 hashSize)
        {
            return new HashAlgorithmWrapper(new SHA512Managed());
        }
    }
    

    public class IHashFunctionTests_HashAlgorithmWrapper_MD5
        : IHashFunctionTests<HashAlgorithmWrapper>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(128, TestConstants.FooBar, "3858f62230ac3c915f300c664312c63f"),
                };
            }
        }

        protected override HashAlgorithmWrapper CreateHashFunction(Int32 hashSize)
        {
            return new HashAlgorithmWrapper(new MD5CryptoServiceProvider());
        }
    }
    

    public class IHashFunctionTests_HashAlgorithmWrapper_RIPEMD160
        : IHashFunctionTests<HashAlgorithmWrapper>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(160, TestConstants.FooBar, "a06e327ea7388c18e4740e350ed4e60f2e04fc41"),
                };
            }
        }

        protected override HashAlgorithmWrapper CreateHashFunction(Int32 hashSize)
        {
            return new HashAlgorithmWrapper(new RIPEMD160Managed());
        }
    }
    

    public class IHashFunctionTests_HashAlgorithmWrapper_SHA1Managed
        : IHashFunctionTests<HashAlgorithmWrapper<SHA1Managed>>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(160, TestConstants.Empty, "da39a3ee5e6b4b0d3255bfef95601890afd80709"),
                    new KnownValue(160, TestConstants.FooBar, "8843d7f92416211de9ebb963ff4ce28125932878"),
                    new KnownValue(160, TestConstants.LoremIpsum, "2dd4010f15f21c9e26e31a693ba31c6ab78a5a4c"),
                    new KnownValue(160, TestConstants.RandomShort, "d64df40c72068b01e7dfb5ceb2b519ad3b483eb0"),
                    new KnownValue(160, TestConstants.RandomLong, "e5901cb4679133729c5555210c3cfe3e5851a2aa"),
                };
            }
        }

        protected override HashAlgorithmWrapper<SHA1Managed> CreateHashFunction(Int32 hashSize)
        {
            return new HashAlgorithmWrapper<SHA1Managed>();
        }
    }
    

    public class IHashFunctionTests_HashAlgorithmWrapper_SHA256Managed
        : IHashFunctionTests<HashAlgorithmWrapper<SHA256Managed>>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(256, TestConstants.FooBar, "c3ab8ff13720e8ad9047dd39466b3c8974e592c2fa383d4a3960714caef0c4f2"),
                };
            }
        }

        protected override HashAlgorithmWrapper<SHA256Managed> CreateHashFunction(Int32 hashSize)
        {
            return new HashAlgorithmWrapper<SHA256Managed>();
        }
    }
    

    public class IHashFunctionTests_HashAlgorithmWrapper_SHA384Managed
        : IHashFunctionTests<HashAlgorithmWrapper<SHA384Managed>>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(384, TestConstants.FooBar, "3c9c30d9f665e74d515c842960d4a451c83a0125fd3de7392d7b37231af10c72ea58aedfcdf89a5765bf902af93ecf06"),
                };
            }
        }

        protected override HashAlgorithmWrapper<SHA384Managed> CreateHashFunction(Int32 hashSize)
        {
            return new HashAlgorithmWrapper<SHA384Managed>();
        }
    }
    

    public class IHashFunctionTests_HashAlgorithmWrapper_SHA512Managed
        : IHashFunctionTests<HashAlgorithmWrapper<SHA512Managed>>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(512, TestConstants.FooBar, "0a50261ebd1a390fed2bf326f2673c145582a6342d523204973d0219337f81616a8069b012587cf5635f6925f1b56c360230c19b273500ee013e030601bf2425"),
                };
            }
        }

        protected override HashAlgorithmWrapper<SHA512Managed> CreateHashFunction(Int32 hashSize)
        {
            return new HashAlgorithmWrapper<SHA512Managed>();
        }
    }
    

    public class IHashFunctionTests_HashAlgorithmWrapper_MD5CryptoServiceProvider
        : IHashFunctionTests<HashAlgorithmWrapper<MD5CryptoServiceProvider>>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(128, TestConstants.FooBar, "3858f62230ac3c915f300c664312c63f"),
                };
            }
        }

        protected override HashAlgorithmWrapper<MD5CryptoServiceProvider> CreateHashFunction(Int32 hashSize)
        {
            return new HashAlgorithmWrapper<MD5CryptoServiceProvider>();
        }
    }
    

    public class IHashFunctionTests_HashAlgorithmWrapper_RIPEMD160Managed
        : IHashFunctionTests<HashAlgorithmWrapper<RIPEMD160Managed>>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(160, TestConstants.FooBar, "a06e327ea7388c18e4740e350ed4e60f2e04fc41"),
                };
            }
        }

        protected override HashAlgorithmWrapper<RIPEMD160Managed> CreateHashFunction(Int32 hashSize)
        {
            return new HashAlgorithmWrapper<RIPEMD160Managed>();
        }
    }
    

    #endregion

    #region Data.HashFunction.ELF64

    public class IHashFunctionAsyncTests_ELF64
        : IHashFunctionAsyncTests<ELF64>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.Empty, 0x00000000),
                    new KnownValue(32, TestConstants.FooBar, 0x06d65882),
                    new KnownValue(32, TestConstants.LoremIpsum, 0x09e0a53e),
                };
            }
        }

        protected override ELF64 CreateHashFunction(Int32 hashSize)
        {
            return new ELF64();
        }
    }
    

    #endregion

    #region Data.HashFunction.FNV

    public class IHashFunctionAsyncTests_FNV1
        : IHashFunctionAsyncTests<FNV1>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.Empty, 0x811c9dc5),
                    new KnownValue(32, TestConstants.FooBar, 0x31f0b262),
                    new KnownValue(32, TestConstants.LoremIpsum, 0xe1fb1efb),
                    new KnownValue(64, TestConstants.Empty, 0xcbf29ce484222325),
                    new KnownValue(64, TestConstants.FooBar, 0x340d8765a4dda9c2),
                    new KnownValue(64, TestConstants.LoremIpsum, 0xe1d37010556d091b),
                    new KnownValue(128, TestConstants.Empty, "8dc595627521b8624201bb072e27626c"),
                    new KnownValue(128, TestConstants.FooBar, "aa93c2d25383c56dbf643c9ceabf9678"),
                    new KnownValue(128, TestConstants.LoremIpsum, "130c122234e097c352c819800a56ea75"),
                };
            }
        }

        protected override FNV1 CreateHashFunction(Int32 hashSize)
        {
            return new FNV1(hashSize);
        }
    }
    

    public class IHashFunctionAsyncTests_FNV1_DefaultConstructor
        : IHashFunctionAsyncTests<FNV1>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(64, TestConstants.Empty, 0xcbf29ce484222325),
                    new KnownValue(64, TestConstants.FooBar, 0x340d8765a4dda9c2),
                    new KnownValue(64, TestConstants.LoremIpsum, 0xe1d37010556d091b),
                };
            }
        }

        protected override FNV1 CreateHashFunction(Int32 hashSize)
        {
            return new FNV1();
        }
    }
    

    public class IHashFunctionAsyncTests_FNV1a
        : IHashFunctionAsyncTests<FNV1a>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.Empty, 0x811c9dc5),
                    new KnownValue(32, TestConstants.FooBar, 0xbf9cf968),
                    new KnownValue(32, TestConstants.LoremIpsum, 0x15cc3fdb),
                    new KnownValue(64, TestConstants.Empty, 0xcbf29ce484222325),
                    new KnownValue(64, TestConstants.FooBar, 0x85944171f73967e8),
                    new KnownValue(64, TestConstants.LoremIpsum, 0xd9daf73d6af17cfb),
                    new KnownValue(128, TestConstants.Empty, "8dc595627521b8624201bb072e27626c"),
                    new KnownValue(128, TestConstants.FooBar, "186f44ba97350d6fbf643c7962163e34"),
                    new KnownValue(128, TestConstants.LoremIpsum, "b3db4ee71f492ed1c2166a4bccdce8b6"),
                };
            }
        }

        protected override FNV1a CreateHashFunction(Int32 hashSize)
        {
            return new FNV1a(hashSize);
        }
    }
    

    public class IHashFunctionAsyncTests_FNV1a_DefaultConstructor
        : IHashFunctionAsyncTests<FNV1a>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(64, TestConstants.Empty, 0xcbf29ce484222325),
                    new KnownValue(64, TestConstants.FooBar, 0x85944171f73967e8),
                    new KnownValue(64, TestConstants.LoremIpsum, 0xd9daf73d6af17cfb),
                };
            }
        }

        protected override FNV1a CreateHashFunction(Int32 hashSize)
        {
            return new FNV1a();
        }
    }
    

    #endregion

    #region Data.HashFunction.Jenkins

    public class IHashFunctionAsyncTests_JenkinsOneAtATime
        : IHashFunctionAsyncTests<JenkinsOneAtATime>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.FooBar, 0xf952fde7),
                };
            }
        }

        protected override JenkinsOneAtATime CreateHashFunction(Int32 hashSize)
        {
            return new JenkinsOneAtATime();
        }
    }
    

    public class IHashFunctionAsyncTests_JenkinsLookup2
        : IHashFunctionAsyncTests<JenkinsLookup2>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.Empty, 0xbd49d10d),
                    new KnownValue(32, TestConstants.FooBar, 0x9d3ffa02),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(15), 0x0c39787e),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(19), 0x2a06cf89),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(23), 0xa4fd862c),
                };
            }
        }

        protected override JenkinsLookup2 CreateHashFunction(Int32 hashSize)
        {
            return new JenkinsLookup2();
        }
    }
    

    public class IHashFunctionAsyncTests_JenkinsLookup2_WithInitVal
        : IHashFunctionAsyncTests<JenkinsLookup2>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.FooBar, 0x6117ff85),
                };
            }
        }

        protected override JenkinsLookup2 CreateHashFunction(Int32 hashSize)
        {
            return new JenkinsLookup2(0x7da236b9U);
        }
    }
    

    public class IHashFunctionAsyncTests_JenkinsLookup3
        : IHashFunctionAsyncTests<JenkinsLookup3>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.FooBar, 0xaeb72b0c),
                    new KnownValue(64, TestConstants.FooBar, 0xacf2fd4caeb72b0c),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(12), 0x8e663aee),
                    new KnownValue(64, TestConstants.LoremIpsum.Take(12), 0xb6d69c8c8e663aee),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(15), 0x9b484ed5),
                    new KnownValue(64, TestConstants.LoremIpsum.Take(15), 0x14b71e4d9b484ed5),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(19), 0xad9cba6f),
                    new KnownValue(64, TestConstants.LoremIpsum.Take(19), 0x2807920ead9cba6f),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(23), 0x57c46621),
                    new KnownValue(64, TestConstants.LoremIpsum.Take(23), 0x01e860f357c46621),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(24), 0xf2b662ef),
                    new KnownValue(64, TestConstants.LoremIpsum.Take(24), 0xcad6d781f2b662ef),
                };
            }
        }

        protected override JenkinsLookup3 CreateHashFunction(Int32 hashSize)
        {
            return new JenkinsLookup3(hashSize);
        }
    }
    

    public class IHashFunctionAsyncTests_JenkinsLookup3_DefaultConstructor
        : IHashFunctionAsyncTests<JenkinsLookup3>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.FooBar, 0xaeb72b0c),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(12), 0x8e663aee),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(15), 0x9b484ed5),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(19), 0xad9cba6f),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(23), 0x57c46621),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(24), 0xf2b662ef),
                };
            }
        }

        protected override JenkinsLookup3 CreateHashFunction(Int32 hashSize)
        {
            return new JenkinsLookup3();
        }
    }
    

    public class IHashFunctionAsyncTests_JenkinsLookup3_WithInitVals
        : IHashFunctionAsyncTests<JenkinsLookup3>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.FooBar, 0x7306b2fc),
                    new KnownValue(64, TestConstants.FooBar, 0x28b9e020444d6de2),
                };
            }
        }

        protected override JenkinsLookup3 CreateHashFunction(Int32 hashSize)
        {
            return new JenkinsLookup3(hashSize, 0x7da236b9U, 0x87930b75U);
        }
    }
    

    public class IHashFunctionAsyncTests_JenkinsLookup3_WithInitVals_DefaultHashSize
        : IHashFunctionAsyncTests<JenkinsLookup3>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.FooBar, 0x7306b2fc),
                };
            }
        }

        protected override JenkinsLookup3 CreateHashFunction(Int32 hashSize)
        {
            return new JenkinsLookup3(0x7da236b9U, 0x87930b75U);
        }
    }
    

    #endregion

    #region Data.HashFunction.MurmurHash

    public class IHashFunctionAsyncTests_MurmurHash1
        : IHashFunctionAsyncTests<MurmurHash1>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.FooBar, 0x5c45f49b),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(7), 0xff3a37aa),
                };
            }
        }

        protected override MurmurHash1 CreateHashFunction(Int32 hashSize)
        {
            return new MurmurHash1();
        }
    }
    

    public class IHashFunctionAsyncTests_MurmurHash2
        : IHashFunctionAsyncTests<MurmurHash2>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.FooBar, 0x6715a92e),
                    new KnownValue(64, TestConstants.FooBar, 0xd49f461720d7a196),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(15), 0x384025b5),
                    new KnownValue(64, TestConstants.LoremIpsum.Take(11), 0xa4d1d1c83f3125d2),
                    new KnownValue(64, TestConstants.LoremIpsum.Take(15), 0xfa38fed50a3dc771),
                    new KnownValue(64, TestConstants.LoremIpsum.Take(23), 0x82d0eccc1172c984),
                };
            }
        }

        protected override MurmurHash2 CreateHashFunction(Int32 hashSize)
        {
            return new MurmurHash2(hashSize);
        }
    }
    

    public class IHashFunctionAsyncTests_MurmurHash2_DefaultConstructor
        : IHashFunctionAsyncTests<MurmurHash2>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(64, TestConstants.FooBar, 0xd49f461720d7a196),
                    new KnownValue(64, TestConstants.LoremIpsum.Take(15), 0xfa38fed50a3dc771),
                };
            }
        }

        protected override MurmurHash2 CreateHashFunction(Int32 hashSize)
        {
            return new MurmurHash2();
        }
    }
    

    public class IHashFunctionAsyncTests_MurmurHash3
        : IHashFunctionAsyncTests<MurmurHash3>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.FooBar, 0xa4c4d4bd),
                    new KnownValue(128, TestConstants.FooBar, "455ac81671aed2bdafd6f8bae055a274"),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(7), 0x5a1d7378),
                    new KnownValue(128, TestConstants.LoremIpsum.Take(7), "1689190f13f3290b3c5ead34c751ea8a"),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(31), 0x8d50f530),
                    new KnownValue(128, TestConstants.LoremIpsum.Take(31), "5c769a439b78878e8640e16335e4313f"),
                    new KnownValue(128, TestConstants.LoremIpsum.Take(33), "7fdc48ea7913cb074565f43f4c1e1356"),
                };
            }
        }

        protected override MurmurHash3 CreateHashFunction(Int32 hashSize)
        {
            return new MurmurHash3(hashSize);
        }
    }
    

    public class IHashFunctionAsyncTests_MurmurHash3_DefaultConstructor
        : IHashFunctionAsyncTests<MurmurHash3>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.FooBar, 0xa4c4d4bd),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(7), 0x5a1d7378),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(31), 0x8d50f530),
                };
            }
        }

        protected override MurmurHash3 CreateHashFunction(Int32 hashSize)
        {
            return new MurmurHash3();
        }
    }
    

    #endregion

    #region Data.HashFunction.Pearson

    public class IHashFunctionAsyncTests_WikipediaPearson
        : IHashFunctionAsyncTests<WikipediaPearson>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(8, TestConstants.Empty, 0x00),
                    new KnownValue(16, TestConstants.Empty, 0x0000),
                    new KnownValue(24, TestConstants.Empty, 0x000000),
                    new KnownValue(32, TestConstants.Empty, 0x00000000),
                    new KnownValue(40, TestConstants.Empty, 0x0000000000L),
                    new KnownValue(48, TestConstants.Empty, 0x000000000000L),
                    new KnownValue(56, TestConstants.Empty, 0x00000000000000L),
                    new KnownValue(64, TestConstants.Empty, 0x0000000000000000L),
                    new KnownValue(128, TestConstants.Empty, "00000000000000000000000000000000"),
                    new KnownValue(256, TestConstants.Empty, "0000000000000000000000000000000000000000000000000000000000000000"),
                    new KnownValue(512, TestConstants.Empty, "00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000"),
                    new KnownValue(1024, TestConstants.Empty, "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000"),
                    new KnownValue(2040, TestConstants.Empty, "000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000"),
                    new KnownValue(8, TestConstants.FooBar, 0xac),
                    new KnownValue(16, TestConstants.FooBar, 0xcfac),
                    new KnownValue(24, TestConstants.FooBar, 0xf2cfac),
                    new KnownValue(32, TestConstants.FooBar, 0x36f2cfac),
                    new KnownValue(40, TestConstants.FooBar, 0x0136f2cfac),
                    new KnownValue(48, TestConstants.FooBar, 0xc20136f2cfac),
                    new KnownValue(56, TestConstants.FooBar, 0xa3c20136f2cfac),
                    new KnownValue(64, TestConstants.FooBar, 0xdda3c20136f2cfac),
                    new KnownValue(128, TestConstants.FooBar, "accff23601c2a3dd42eee467c3c0953f"),
                    new KnownValue(256, TestConstants.FooBar, "accff23601c2a3dd42eee467c3c0953f4cd1359c80c9ad8c5232e29b6d5df7a4"),
                    new KnownValue(512, TestConstants.FooBar, "accff23601c2a3dd42eee467c3c0953f4cd1359c80c9ad8c5232e29b6d5df7a4b4e9695a04db341c64d53723b1dcb631e5de72b2626c3d4ad3c1df1d3c89f0f5"),
                    new KnownValue(1024, TestConstants.FooBar, "accff23601c2a3dd42eee467c3c0953f4cd1359c80c9ad8c5232e29b6d5df7a4b4e9695a04db341c64d53723b1dcb631e5de72b2626c3d4ad3c1df1d3c89f0f5dae0befd498428c465d6a6186a1f51d492a2edf44ea12d2774f95e1798b8588f0bf1e1a082a7ca85ae55593a078b60d9914b6f4353e87341766824b097b92996"),
                    new KnownValue(2040, TestConstants.FooBar, "accff23601c2a3dd42eee467c3c0953f4cd1359c80c9ad8c5232e29b6d5df7a4b4e9695a04db341c64d53723b1dcb631e5de72b2626c3d4ad3c1df1d3c89f0f5dae0befd498428c465d6a6186a1f51d492a2edf44ea12d2774f95e1798b8588f0bf1e1a082a7ca85ae55593a078b60d9914b6f4353e87341766824b097b92996149dbf20d8af8eec56619afb19e3005f471e7c25c80a939f3b1bba5cbcb77eaa7a8a83d0e7992112eab5bdc605775433882bd77fcbabc7a52c0d70eb3938661a098d7b5081fc4445b371c5ef9e0ce602782a1506cefa0fa9164d7dcd86030e9075f62611ccd22ef8081379a863ff30bb6e104f2f229487f357406b463e485b"),
                    new KnownValue(8, TestConstants.LoremIpsum, 0x92),
                    new KnownValue(16, TestConstants.LoremIpsum, 0x9f92),
                    new KnownValue(24, TestConstants.LoremIpsum, 0xba9f92),
                    new KnownValue(32, TestConstants.LoremIpsum, 0x73ba9f92),
                    new KnownValue(40, TestConstants.LoremIpsum, 0x1073ba9f92),
                    new KnownValue(48, TestConstants.LoremIpsum, 0xc91073ba9f92),
                    new KnownValue(56, TestConstants.LoremIpsum, 0x58c91073ba9f92),
                    new KnownValue(64, TestConstants.LoremIpsum, 0xdf58c91073ba9f92),
                    new KnownValue(128, TestConstants.LoremIpsum, "929fba7310c958df517cf4dbfd760a8c"),
                    new KnownValue(256, TestConstants.LoremIpsum, "929fba7310c958df517cf4dbfd760a8c9c871fe9aef875ed848ebbdd2bf505e3"),
                    new KnownValue(512, TestConstants.LoremIpsum, "929fba7310c958df517cf4dbfd760a8c9c871fe9aef875ed848ebbdd2bf505e343b9ea988152abace8a54d1b784828674199a2b1e5324779868012694c2fda44"),
                    new KnownValue(1024, TestConstants.LoremIpsum, "929fba7310c958df517cf4dbfd760a8c9c871fe9aef875ed848ebbdd2bf505e343b9ea988152abace8a54d1b784828674199a2b1e5324779868012694c2fda4416de2ad7a76c4f19043e62087ec00230ccc53be4661c9eb0944bca3a886af26bb5fed0e714bd978f3cd489a9d1574a45c1d2bf7deb27c7617b9359ef9d9631a8"),
                    new KnownValue(2040, TestConstants.LoremIpsum, "929fba7310c958df517cf4dbfd760a8c9c871fe9aef875ed848ebbdd2bf505e343b9ea988152abace8a54d1b784828674199a2b1e5324779868012694c2fda4416de2ad7a76c4f19043e62087ec00230ccc53be4661c9eb0944bca3a886af26bb5fed0e714bd978f3cd489a9d1574a45c1d2bf7deb27c7617b9359ef9d9631a877182d83cb03ff251ef6132cf7503dd811266d538535d60639c8f37fe164faa69024c6ada10e2334cd0c4936fc420fe00154918bf0c24007f1b3b6705c56156fd355eed900fb097460711de29a461ac45e9b22d5e68d0bafa3c3955d68823fec205b21b8b2dca0cf5f65aa29637a2e0dce8a3772bea4b46e4ebc17b7f93833"),
                };
            }
        }

        protected override WikipediaPearson CreateHashFunction(Int32 hashSize)
        {
            return new WikipediaPearson(hashSize);
        }
    }
    

    public class IHashFunctionAsyncTests_WikipediaPearson_DefaultConstructor
        : IHashFunctionAsyncTests<WikipediaPearson>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(8, TestConstants.Empty, 0x00),
                    new KnownValue(8, TestConstants.FooBar, 0xac),
                    new KnownValue(8, TestConstants.LoremIpsum, 0x92),
                };
            }
        }

        protected override WikipediaPearson CreateHashFunction(Int32 hashSize)
        {
            return new WikipediaPearson();
        }
    }
    

    #endregion

    #region Data.HashFunction.SpookyHash

    public class IHashFunctionAsyncTests_SpookyHashV1
        : IHashFunctionAsyncTests<SpookyHashV1>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.FooBar, 0xd019a52d),
                    new KnownValue(64, TestConstants.FooBar, 0x52919208d019a52d),
                    new KnownValue(128, TestConstants.FooBar, "2da519d0089291529c22f24a80017a5e"),
                    new KnownValue(32, TestConstants.LoremIpsum, 0xcc79cd7e),
                    new KnownValue(64, TestConstants.LoremIpsum, 0x1c7efd4ccc79cd7e),
                    new KnownValue(128, TestConstants.LoremIpsum, "7ecd79cc4cfd7e1c5c15710c2d261311"),
                };
            }
        }

        protected override SpookyHashV1 CreateHashFunction(Int32 hashSize)
        {
            return new SpookyHashV1(hashSize);
        }
    }
    

    public class IHashFunctionAsyncTests_SpookyHashV1_DefaultConstructor
        : IHashFunctionAsyncTests<SpookyHashV1>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(128, TestConstants.FooBar, "2da519d0089291529c22f24a80017a5e"),
                    new KnownValue(128, TestConstants.LoremIpsum, "7ecd79cc4cfd7e1c5c15710c2d261311"),
                };
            }
        }

        protected override SpookyHashV1 CreateHashFunction(Int32 hashSize)
        {
            return new SpookyHashV1();
        }
    }
    

    public class IHashFunctionAsyncTests_SpookyHashV1_WithInitVals
        : IHashFunctionAsyncTests<SpookyHashV1>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.FooBar, 0xddf2894b),
                    new KnownValue(64, TestConstants.FooBar, 0x35d04f6cddf2894b),
                    new KnownValue(128, TestConstants.FooBar, "2ffa3a68544614fc258f142b35dfb07a"),
                };
            }
        }

        protected override SpookyHashV1 CreateHashFunction(Int32 hashSize)
        {
            return new SpookyHashV1(hashSize, 0x7da236b987930b75U, 0x2eb994a3851d2f54U);
        }
    }
    

    public class IHashFunctionAsyncTests_SpookyHashV1_WithInitVals_DefaultHashSize
        : IHashFunctionAsyncTests<SpookyHashV1>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(128, TestConstants.FooBar, "2ffa3a68544614fc258f142b35dfb07a"),
                };
            }
        }

        protected override SpookyHashV1 CreateHashFunction(Int32 hashSize)
        {
            return new SpookyHashV1(0x7da236b987930b75U, 0x2eb994a3851d2f54U);
        }
    }
    

    public class IHashFunctionAsyncTests_SpookyHashV2
        : IHashFunctionAsyncTests<SpookyHashV2>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.FooBar, 0xcef04070),
                    new KnownValue(64, TestConstants.FooBar, 0x1f9b9f79cef04070),
                    new KnownValue(128, TestConstants.FooBar, "7040f0ce799f9b1f22020c7b2be86797"),
                    new KnownValue(32, TestConstants.LoremIpsum, 0xded54c84),
                    new KnownValue(64, TestConstants.LoremIpsum, 0xbb6b988bded54c84),
                    new KnownValue(128, TestConstants.LoremIpsum, "844cd5de8b986bbb1062913785ea1fa2"),
                };
            }
        }

        protected override SpookyHashV2 CreateHashFunction(Int32 hashSize)
        {
            return new SpookyHashV2(hashSize);
        }
    }
    

    public class IHashFunctionAsyncTests_SpookyHashV2_DefaultConstructor
        : IHashFunctionAsyncTests<SpookyHashV2>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(128, TestConstants.FooBar, "7040f0ce799f9b1f22020c7b2be86797"),
                    new KnownValue(128, TestConstants.LoremIpsum, "844cd5de8b986bbb1062913785ea1fa2"),
                };
            }
        }

        protected override SpookyHashV2 CreateHashFunction(Int32 hashSize)
        {
            return new SpookyHashV2();
        }
    }
    

    public class IHashFunctionAsyncTests_SpookyHashV2_WithInitVals
        : IHashFunctionAsyncTests<SpookyHashV2>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.FooBar, 0x7acaff2f),
                    new KnownValue(64, TestConstants.FooBar, 0x080cdf197acaff2f),
                    new KnownValue(128, TestConstants.FooBar, "275e9e8cb0cc53c1d604509a253730a9"),
                };
            }
        }

        protected override SpookyHashV2 CreateHashFunction(Int32 hashSize)
        {
            return new SpookyHashV2(hashSize, 0x7da236b987930b75U, 0x2eb994a3851d2f54U);
        }
    }
    

    public class IHashFunctionAsyncTests_SpookyHashV2_WithInitVals_DefaultHashSize
        : IHashFunctionAsyncTests<SpookyHashV2>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(128, TestConstants.FooBar, "275e9e8cb0cc53c1d604509a253730a9"),
                };
            }
        }

        protected override SpookyHashV2 CreateHashFunction(Int32 hashSize)
        {
            return new SpookyHashV2(0x7da236b987930b75U, 0x2eb994a3851d2f54U);
        }
    }
    

    #endregion

    #region Data.HashFunction.xxHash

    public class IHashFunctionAsyncTests_xxHash
        : IHashFunctionAsyncTests<xxHash>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.Empty, 0x02cc5d05),
                    new KnownValue(32, TestConstants.FooBar, 0xeda34aaf),
                    new KnownValue(32, TestConstants.LoremIpsum, 0x92ea46ac),
                    new KnownValue(32, TestConstants.LoremIpsum.Take(4), 0x0df3e9ea),
                    new KnownValue(64, TestConstants.Empty, 0xef46db3751d8e999),
                    new KnownValue(64, TestConstants.FooBar, 0xa2aa05ed9085aaf9),
                    new KnownValue(64, TestConstants.LoremIpsum, 0xaf35642971419cbe),
                    new KnownValue(64, TestConstants.LoremIpsum.Take(4), 0x103460bb4a599cab),
                };
            }
        }

        protected override xxHash CreateHashFunction(Int32 hashSize)
        {
            return new xxHash(hashSize);
        }
    }
    

    public class IHashFunctionAsyncTests_xxHash_DefaultConstructor
        : IHashFunctionAsyncTests<xxHash>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.Empty, 0x02cc5d05),
                    new KnownValue(32, TestConstants.FooBar, 0xeda34aaf),
                    new KnownValue(32, TestConstants.LoremIpsum, 0x92ea46ac),
                };
            }
        }

        protected override xxHash CreateHashFunction(Int32 hashSize)
        {
            return new xxHash();
        }
    }
    

    public class IHashFunctionAsyncTests_xxHash_WithInitVal
        : IHashFunctionAsyncTests<xxHash>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.Empty, 0xff52b36b),
                    new KnownValue(32, TestConstants.FooBar, 0x294f6b05),
                    new KnownValue(32, TestConstants.LoremIpsum, 0x01f950ab),
                    new KnownValue(64, TestConstants.Empty, 0x985e09f666271418),
                    new KnownValue(64, TestConstants.FooBar, 0x947ebc3ef380d35d),
                    new KnownValue(64, TestConstants.LoremIpsum, 0xf6b6e74f681d3e5b),
                };
            }
        }

        protected override xxHash CreateHashFunction(Int32 hashSize)
        {
            return new xxHash(hashSize, 0x78fef705b7c769faU);
        }
    }
    

    public class IHashFunctionAsyncTests_xxHash_WithInitVal_DefaultHashSize
        : IHashFunctionAsyncTests<xxHash>
    {
        protected override IEnumerable<KnownValue> KnownValues
        {
            get
            {
                return new KnownValue[] {
                    new KnownValue(32, TestConstants.Empty, 0xff52b36b),
                    new KnownValue(32, TestConstants.FooBar, 0x294f6b05),
                    new KnownValue(32, TestConstants.LoremIpsum, 0x01f950ab),
                };
            }
        }

        protected override xxHash CreateHashFunction(Int32 hashSize)
        {
            return new xxHash(0x78fef705b7c769faU);
        }
    }
    

    #endregion


    #endregion

    #region IHashFunction_SpeedTest

    public class IHashFunction_SpeedTests_HashFunctionBase
        : IHashFunction_SpeedTest
    {
        protected override IReadOnlyDictionary<String, IHashFunction> TestHashFunctions { get { return _TestHashFunctions; } }

        private readonly IReadOnlyDictionary<String, IHashFunction> _TestHashFunctions = new Dictionary<String, IHashFunction>() {
                { 
                    @"BernsteinHash()", 
                    new BernsteinHash() 
                },
                { 
                    @"ModifiedBernsteinHash()", 
                    new ModifiedBernsteinHash() 
                },
                { 
                    @"Blake2B(8)", 
                    new Blake2B(8) 
                },
                { 
                    @"Blake2B(16)", 
                    new Blake2B(16) 
                },
                { 
                    @"Blake2B(32)", 
                    new Blake2B(32) 
                },
                { 
                    @"Blake2B(64)", 
                    new Blake2B(64) 
                },
                { 
                    @"Blake2B(128)", 
                    new Blake2B(128) 
                },
                { 
                    @"Blake2B(256)", 
                    new Blake2B(256) 
                },
                { 
                    @"Blake2B(512)", 
                    new Blake2B(512) 
                },
                { 
                    @"Blake2B()", 
                    new Blake2B() 
                },
                { 
                    @"Blake2B(8, TestConstants.FooBar, null, null)", 
                    new Blake2B(8, TestConstants.FooBar, null, null) 
                },
                { 
                    @"Blake2B(16, TestConstants.FooBar, null, null)", 
                    new Blake2B(16, TestConstants.FooBar, null, null) 
                },
                { 
                    @"Blake2B(32, TestConstants.FooBar, null, null)", 
                    new Blake2B(32, TestConstants.FooBar, null, null) 
                },
                { 
                    @"Blake2B(64, TestConstants.FooBar, null, null)", 
                    new Blake2B(64, TestConstants.FooBar, null, null) 
                },
                { 
                    @"Blake2B(128, TestConstants.FooBar, null, null)", 
                    new Blake2B(128, TestConstants.FooBar, null, null) 
                },
                { 
                    @"Blake2B(256, TestConstants.FooBar, null, null)", 
                    new Blake2B(256, TestConstants.FooBar, null, null) 
                },
                { 
                    @"Blake2B(512, TestConstants.FooBar, null, null)", 
                    new Blake2B(512, TestConstants.FooBar, null, null) 
                },
                { 
                    @"Blake2B(8, TestConstants.FooBar)", 
                    new Blake2B(8, TestConstants.FooBar) 
                },
                { 
                    @"Blake2B(16, TestConstants.FooBar)", 
                    new Blake2B(16, TestConstants.FooBar) 
                },
                { 
                    @"Blake2B(32, TestConstants.FooBar)", 
                    new Blake2B(32, TestConstants.FooBar) 
                },
                { 
                    @"Blake2B(64, TestConstants.FooBar)", 
                    new Blake2B(64, TestConstants.FooBar) 
                },
                { 
                    @"Blake2B(128, TestConstants.FooBar)", 
                    new Blake2B(128, TestConstants.FooBar) 
                },
                { 
                    @"Blake2B(256, TestConstants.FooBar)", 
                    new Blake2B(256, TestConstants.FooBar) 
                },
                { 
                    @"Blake2B(512, TestConstants.FooBar)", 
                    new Blake2B(512, TestConstants.FooBar) 
                },
                { 
                    @"Blake2B(8, key: TestConstants.FooBar)", 
                    new Blake2B(8, key: TestConstants.FooBar) 
                },
                { 
                    @"Blake2B(16, key: TestConstants.FooBar)", 
                    new Blake2B(16, key: TestConstants.FooBar) 
                },
                { 
                    @"Blake2B(32, key: TestConstants.FooBar)", 
                    new Blake2B(32, key: TestConstants.FooBar) 
                },
                { 
                    @"Blake2B(64, key: TestConstants.FooBar)", 
                    new Blake2B(64, key: TestConstants.FooBar) 
                },
                { 
                    @"Blake2B(128, key: TestConstants.FooBar)", 
                    new Blake2B(128, key: TestConstants.FooBar) 
                },
                { 
                    @"Blake2B(256, key: TestConstants.FooBar)", 
                    new Blake2B(256, key: TestConstants.FooBar) 
                },
                { 
                    @"Blake2B(512, key: TestConstants.FooBar)", 
                    new Blake2B(512, key: TestConstants.FooBar) 
                },
                { 
                    @"Blake2B(8, TestConstants.FooBar, TestConstants.FooBar.Concat(new byte[10]), TestConstants.FooBar.Concat(new byte[10]))", 
                    new Blake2B(8, TestConstants.FooBar, TestConstants.FooBar.Concat(new Byte[10]), TestConstants.FooBar.Concat(new Byte[10])) 
                },
                { 
                    @"Blake2B(16, TestConstants.FooBar, TestConstants.FooBar.Concat(new byte[10]), TestConstants.FooBar.Concat(new byte[10]))", 
                    new Blake2B(16, TestConstants.FooBar, TestConstants.FooBar.Concat(new Byte[10]), TestConstants.FooBar.Concat(new Byte[10])) 
                },
                { 
                    @"Blake2B(32, TestConstants.FooBar, TestConstants.FooBar.Concat(new byte[10]), TestConstants.FooBar.Concat(new byte[10]))", 
                    new Blake2B(32, TestConstants.FooBar, TestConstants.FooBar.Concat(new Byte[10]), TestConstants.FooBar.Concat(new Byte[10])) 
                },
                { 
                    @"Blake2B(64, TestConstants.FooBar, TestConstants.FooBar.Concat(new byte[10]), TestConstants.FooBar.Concat(new byte[10]))", 
                    new Blake2B(64, TestConstants.FooBar, TestConstants.FooBar.Concat(new Byte[10]), TestConstants.FooBar.Concat(new Byte[10])) 
                },
                { 
                    @"Blake2B(128, TestConstants.FooBar, TestConstants.FooBar.Concat(new byte[10]), TestConstants.FooBar.Concat(new byte[10]))", 
                    new Blake2B(128, TestConstants.FooBar, TestConstants.FooBar.Concat(new Byte[10]), TestConstants.FooBar.Concat(new Byte[10])) 
                },
                { 
                    @"Blake2B(256, TestConstants.FooBar, TestConstants.FooBar.Concat(new byte[10]), TestConstants.FooBar.Concat(new byte[10]))", 
                    new Blake2B(256, TestConstants.FooBar, TestConstants.FooBar.Concat(new Byte[10]), TestConstants.FooBar.Concat(new Byte[10])) 
                },
                { 
                    @"Blake2B(512, TestConstants.FooBar, TestConstants.FooBar.Concat(new byte[10]), TestConstants.FooBar.Concat(new byte[10]))", 
                    new Blake2B(512, TestConstants.FooBar, TestConstants.FooBar.Concat(new Byte[10]), TestConstants.FooBar.Concat(new Byte[10])) 
                },
                { 
                    @"Blake2B(8, key: TestConstants.FooBar, salt: TestConstants.FooBar.Concat(new byte[10]), personalization: TestConstants.FooBar.Concat(new byte[10]))", 
                    new Blake2B(8, key: TestConstants.FooBar, salt: TestConstants.FooBar.Concat(new Byte[10]), personalization: TestConstants.FooBar.Concat(new Byte[10])) 
                },
                { 
                    @"Blake2B(16, key: TestConstants.FooBar, salt: TestConstants.FooBar.Concat(new byte[10]), personalization: TestConstants.FooBar.Concat(new byte[10]))", 
                    new Blake2B(16, key: TestConstants.FooBar, salt: TestConstants.FooBar.Concat(new Byte[10]), personalization: TestConstants.FooBar.Concat(new Byte[10])) 
                },
                { 
                    @"Blake2B(32, key: TestConstants.FooBar, salt: TestConstants.FooBar.Concat(new byte[10]), personalization: TestConstants.FooBar.Concat(new byte[10]))", 
                    new Blake2B(32, key: TestConstants.FooBar, salt: TestConstants.FooBar.Concat(new Byte[10]), personalization: TestConstants.FooBar.Concat(new Byte[10])) 
                },
                { 
                    @"Blake2B(64, key: TestConstants.FooBar, salt: TestConstants.FooBar.Concat(new byte[10]), personalization: TestConstants.FooBar.Concat(new byte[10]))", 
                    new Blake2B(64, key: TestConstants.FooBar, salt: TestConstants.FooBar.Concat(new Byte[10]), personalization: TestConstants.FooBar.Concat(new Byte[10])) 
                },
                { 
                    @"Blake2B(128, key: TestConstants.FooBar, salt: TestConstants.FooBar.Concat(new byte[10]), personalization: TestConstants.FooBar.Concat(new byte[10]))", 
                    new Blake2B(128, key: TestConstants.FooBar, salt: TestConstants.FooBar.Concat(new Byte[10]), personalization: TestConstants.FooBar.Concat(new Byte[10])) 
                },
                { 
                    @"Blake2B(256, key: TestConstants.FooBar, salt: TestConstants.FooBar.Concat(new byte[10]), personalization: TestConstants.FooBar.Concat(new byte[10]))", 
                    new Blake2B(256, key: TestConstants.FooBar, salt: TestConstants.FooBar.Concat(new Byte[10]), personalization: TestConstants.FooBar.Concat(new Byte[10])) 
                },
                { 
                    @"Blake2B(512, key: TestConstants.FooBar, salt: TestConstants.FooBar.Concat(new byte[10]), personalization: TestConstants.FooBar.Concat(new byte[10]))", 
                    new Blake2B(512, key: TestConstants.FooBar, salt: TestConstants.FooBar.Concat(new Byte[10]), personalization: TestConstants.FooBar.Concat(new Byte[10])) 
                },
                { 
                    @"Blake2B(512, key: Enumerable.Range(0, 64).Select(i => (byte) i))", 
                    new Blake2B(512, key: Enumerable.Range(0, 64).Select(i => (Byte) i)) 
                },
                { 
                    @"DefaultBuzHash(8)", 
                    new DefaultBuzHash(8) 
                },
                { 
                    @"DefaultBuzHash(16)", 
                    new DefaultBuzHash(16) 
                },
                { 
                    @"DefaultBuzHash(32)", 
                    new DefaultBuzHash(32) 
                },
                { 
                    @"DefaultBuzHash(64)", 
                    new DefaultBuzHash(64) 
                },
                { 
                    @"DefaultBuzHash()", 
                    new DefaultBuzHash() 
                },
                { 
                    @"DefaultBuzHash(BuzHashBase.CircularShiftDirection.Right, 8)", 
                    new DefaultBuzHash(BuzHashBase.CircularShiftDirection.Right, 8) 
                },
                { 
                    @"DefaultBuzHash(BuzHashBase.CircularShiftDirection.Right, 16)", 
                    new DefaultBuzHash(BuzHashBase.CircularShiftDirection.Right, 16) 
                },
                { 
                    @"DefaultBuzHash(BuzHashBase.CircularShiftDirection.Right, 32)", 
                    new DefaultBuzHash(BuzHashBase.CircularShiftDirection.Right, 32) 
                },
                { 
                    @"DefaultBuzHash(BuzHashBase.CircularShiftDirection.Right, 64)", 
                    new DefaultBuzHash(BuzHashBase.CircularShiftDirection.Right, 64) 
                },
                { 
                    @"DefaultBuzHash(BuzHashBase.CircularShiftDirection.Right)", 
                    new DefaultBuzHash(BuzHashBase.CircularShiftDirection.Right) 
                },
                { 
                    @"BuzHashBaseImpl(8)", 
                    new BuzHashBaseImpl(8) 
                },
                { 
                    @"BuzHashBaseImpl(16)", 
                    new BuzHashBaseImpl(16) 
                },
                { 
                    @"BuzHashBaseImpl(32)", 
                    new BuzHashBaseImpl(32) 
                },
                { 
                    @"BuzHashBaseImpl(64)", 
                    new BuzHashBaseImpl(64) 
                },
                { 
                    @"BuzHashBaseImpl()", 
                    new BuzHashBaseImpl() 
                },
                { 
                    @"CityHash(32)", 
                    new CityHash(32) 
                },
                { 
                    @"CityHash(64)", 
                    new CityHash(64) 
                },
                { 
                    @"CityHash(128)", 
                    new CityHash(128) 
                },
                { 
                    @"CityHash()", 
                    new CityHash() 
                },
                { 
                    @"HashFunctionImpl(0)", 
                    new HashFunctionImpl(0) 
                },
                { 
                    @"HashAlgorithmWrapper(new SHA1Managed())", 
                    new HashAlgorithmWrapper(new SHA1Managed()) 
                },
                { 
                    @"HashAlgorithmWrapper(new SHA256Managed())", 
                    new HashAlgorithmWrapper(new SHA256Managed()) 
                },
                { 
                    @"HashAlgorithmWrapper(new SHA384Managed())", 
                    new HashAlgorithmWrapper(new SHA384Managed()) 
                },
                { 
                    @"HashAlgorithmWrapper(new SHA512Managed())", 
                    new HashAlgorithmWrapper(new SHA512Managed()) 
                },
                { 
                    @"HashAlgorithmWrapper(new MD5CryptoServiceProvider())", 
                    new HashAlgorithmWrapper(new MD5CryptoServiceProvider()) 
                },
                { 
                    @"HashAlgorithmWrapper(new RIPEMD160Managed())", 
                    new HashAlgorithmWrapper(new RIPEMD160Managed()) 
                },
                { 
                    @"HashAlgorithmWrapper<SHA1Managed>()", 
                    new HashAlgorithmWrapper<SHA1Managed>() 
                },
                { 
                    @"HashAlgorithmWrapper<SHA256Managed>()", 
                    new HashAlgorithmWrapper<SHA256Managed>() 
                },
                { 
                    @"HashAlgorithmWrapper<SHA384Managed>()", 
                    new HashAlgorithmWrapper<SHA384Managed>() 
                },
                { 
                    @"HashAlgorithmWrapper<SHA512Managed>()", 
                    new HashAlgorithmWrapper<SHA512Managed>() 
                },
                { 
                    @"HashAlgorithmWrapper<MD5CryptoServiceProvider>()", 
                    new HashAlgorithmWrapper<MD5CryptoServiceProvider>() 
                },
                { 
                    @"HashAlgorithmWrapper<RIPEMD160Managed>()", 
                    new HashAlgorithmWrapper<RIPEMD160Managed>() 
                },
                { 
                    @"ELF64()", 
                    new ELF64() 
                },
                { 
                    @"FNV1(32)", 
                    new FNV1(32) 
                },
                { 
                    @"FNV1(64)", 
                    new FNV1(64) 
                },
                { 
                    @"FNV1(128)", 
                    new FNV1(128) 
                },
                { 
                    @"FNV1()", 
                    new FNV1() 
                },
                { 
                    @"FNV1a(32)", 
                    new FNV1a(32) 
                },
                { 
                    @"FNV1a(64)", 
                    new FNV1a(64) 
                },
                { 
                    @"FNV1a(128)", 
                    new FNV1a(128) 
                },
                { 
                    @"FNV1a()", 
                    new FNV1a() 
                },
                { 
                    @"JenkinsOneAtATime()", 
                    new JenkinsOneAtATime() 
                },
                { 
                    @"JenkinsLookup2()", 
                    new JenkinsLookup2() 
                },
                { 
                    @"JenkinsLookup2(0x7da236b9U)", 
                    new JenkinsLookup2(0x7da236b9U) 
                },
                { 
                    @"JenkinsLookup3(32)", 
                    new JenkinsLookup3(32) 
                },
                { 
                    @"JenkinsLookup3(64)", 
                    new JenkinsLookup3(64) 
                },
                { 
                    @"JenkinsLookup3()", 
                    new JenkinsLookup3() 
                },
                { 
                    @"JenkinsLookup3(32, 0x7da236b9U, 0x87930b75U)", 
                    new JenkinsLookup3(32, 0x7da236b9U, 0x87930b75U) 
                },
                { 
                    @"JenkinsLookup3(64, 0x7da236b9U, 0x87930b75U)", 
                    new JenkinsLookup3(64, 0x7da236b9U, 0x87930b75U) 
                },
                { 
                    @"JenkinsLookup3(0x7da236b9U, 0x87930b75U)", 
                    new JenkinsLookup3(0x7da236b9U, 0x87930b75U) 
                },
                { 
                    @"MurmurHash1()", 
                    new MurmurHash1() 
                },
                { 
                    @"MurmurHash2(32)", 
                    new MurmurHash2(32) 
                },
                { 
                    @"MurmurHash2(64)", 
                    new MurmurHash2(64) 
                },
                { 
                    @"MurmurHash2()", 
                    new MurmurHash2() 
                },
                { 
                    @"MurmurHash3(32)", 
                    new MurmurHash3(32) 
                },
                { 
                    @"MurmurHash3(128)", 
                    new MurmurHash3(128) 
                },
                { 
                    @"MurmurHash3()", 
                    new MurmurHash3() 
                },
                { 
                    @"WikipediaPearson(8)", 
                    new WikipediaPearson(8) 
                },
                { 
                    @"WikipediaPearson(16)", 
                    new WikipediaPearson(16) 
                },
                { 
                    @"WikipediaPearson(24)", 
                    new WikipediaPearson(24) 
                },
                { 
                    @"WikipediaPearson(32)", 
                    new WikipediaPearson(32) 
                },
                { 
                    @"WikipediaPearson(40)", 
                    new WikipediaPearson(40) 
                },
                { 
                    @"WikipediaPearson(48)", 
                    new WikipediaPearson(48) 
                },
                { 
                    @"WikipediaPearson(56)", 
                    new WikipediaPearson(56) 
                },
                { 
                    @"WikipediaPearson(64)", 
                    new WikipediaPearson(64) 
                },
                { 
                    @"WikipediaPearson(128)", 
                    new WikipediaPearson(128) 
                },
                { 
                    @"WikipediaPearson(256)", 
                    new WikipediaPearson(256) 
                },
                { 
                    @"WikipediaPearson(512)", 
                    new WikipediaPearson(512) 
                },
                { 
                    @"WikipediaPearson(1024)", 
                    new WikipediaPearson(1024) 
                },
                { 
                    @"WikipediaPearson(2040)", 
                    new WikipediaPearson(2040) 
                },
                { 
                    @"WikipediaPearson()", 
                    new WikipediaPearson() 
                },
                { 
                    @"SpookyHashV1(32)", 
                    new SpookyHashV1(32) 
                },
                { 
                    @"SpookyHashV1(64)", 
                    new SpookyHashV1(64) 
                },
                { 
                    @"SpookyHashV1(128)", 
                    new SpookyHashV1(128) 
                },
                { 
                    @"SpookyHashV1()", 
                    new SpookyHashV1() 
                },
                { 
                    @"SpookyHashV1(32, 0x7da236b987930b75U, 0x2eb994a3851d2f54U)", 
                    new SpookyHashV1(32, 0x7da236b987930b75U, 0x2eb994a3851d2f54U) 
                },
                { 
                    @"SpookyHashV1(64, 0x7da236b987930b75U, 0x2eb994a3851d2f54U)", 
                    new SpookyHashV1(64, 0x7da236b987930b75U, 0x2eb994a3851d2f54U) 
                },
                { 
                    @"SpookyHashV1(128, 0x7da236b987930b75U, 0x2eb994a3851d2f54U)", 
                    new SpookyHashV1(128, 0x7da236b987930b75U, 0x2eb994a3851d2f54U) 
                },
                { 
                    @"SpookyHashV1(0x7da236b987930b75U, 0x2eb994a3851d2f54U)", 
                    new SpookyHashV1(0x7da236b987930b75U, 0x2eb994a3851d2f54U) 
                },
                { 
                    @"SpookyHashV2(32)", 
                    new SpookyHashV2(32) 
                },
                { 
                    @"SpookyHashV2(64)", 
                    new SpookyHashV2(64) 
                },
                { 
                    @"SpookyHashV2(128)", 
                    new SpookyHashV2(128) 
                },
                { 
                    @"SpookyHashV2()", 
                    new SpookyHashV2() 
                },
                { 
                    @"SpookyHashV2(32, 0x7da236b987930b75U, 0x2eb994a3851d2f54U)", 
                    new SpookyHashV2(32, 0x7da236b987930b75U, 0x2eb994a3851d2f54U) 
                },
                { 
                    @"SpookyHashV2(64, 0x7da236b987930b75U, 0x2eb994a3851d2f54U)", 
                    new SpookyHashV2(64, 0x7da236b987930b75U, 0x2eb994a3851d2f54U) 
                },
                { 
                    @"SpookyHashV2(128, 0x7da236b987930b75U, 0x2eb994a3851d2f54U)", 
                    new SpookyHashV2(128, 0x7da236b987930b75U, 0x2eb994a3851d2f54U) 
                },
                { 
                    @"SpookyHashV2(0x7da236b987930b75U, 0x2eb994a3851d2f54U)", 
                    new SpookyHashV2(0x7da236b987930b75U, 0x2eb994a3851d2f54U) 
                },
                { 
                    @"xxHash(32)", 
                    new xxHash(32) 
                },
                { 
                    @"xxHash(64)", 
                    new xxHash(64) 
                },
                { 
                    @"xxHash()", 
                    new xxHash() 
                },
                { 
                    @"xxHash(32, 0x78fef705b7c769faU)", 
                    new xxHash(32, 0x78fef705b7c769faU) 
                },
                { 
                    @"xxHash(64, 0x78fef705b7c769faU)", 
                    new xxHash(64, 0x78fef705b7c769faU) 
                },
                { 
                    @"xxHash(0x78fef705b7c769faU)", 
                    new xxHash(0x78fef705b7c769faU) 
                },
        };
    }

    #endregion

    #pragma warning restore 0618 // Restore ObsoleteAttribute warnings

}

