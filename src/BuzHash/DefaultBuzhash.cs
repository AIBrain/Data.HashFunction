﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.HashFunction
{
    /// <summary>
    /// Basic implementation of <see cref="BuzHashBase" /> class.  
    /// 
    /// Uses randomly generated table and left circular shift.
    /// </summary>
    public class DefaultBuzHash
        : BuzHashBase
    {
        /// <summary>
        /// Array of 256 random and distinct UInt64 values.
        /// </summary>
#if !NET40
        private static readonly IReadOnlyList<UInt64> _Rtab = 
#else
        private static readonly IList<UInt64> _Rtab =
#endif
            new UInt64[] {
                0xBDBF3FFFDEEF8A14, 0xFFB5AC3C0DB31F7F, 0x7BF7207BF73C4D2E, 0xADBFFF96358377F6,
                0xC6BF8D442C4FD166, 0x7EB1EFF12B7D81F9, 0x88024802AB9F22C2, 0x2191221208E98495,
                0xA9377F55EBA6AE60, 0x2954721569FD66AE, 0xB109C13854720646, 0x42088A01BE975A1D,
                0xF92FE5C643CB474B, 0x1B2600A8603CFEFB, 0x02042A11B642620A, 0x96FD78D6F98DE9FF,
                0x84C3BDFE7BAD886C, 0x202340C0CB5918DE, 0x008203C342B3CF21, 0xC3C62DBEDC433FFB,
                0xD5DDB64C2474A600, 0x804A3380F7DF01A1, 0x39C3FDE506D02ADA, 0xB84CE5F2BF804325,
                0x7716EAD9F1EBD693, 0x7BE96E7C939FDDFD, 0x4BBF845D8D01114A, 0xBCF70EF509FF5BE4,
                0x09304628A16326F9, 0xBAFC7E1FE7095D14, 0x024C1200E0750521, 0xEF3D2EEFFD0D8818,
                0x4ECEAF0C5599E3FA, 0x09428020FE781238, 0x6800083E30A844BF, 0x484DDBF62CB950D3,
                0xB3B267F53AED1920, 0x63DD7C51D0A92E3E, 0xFD550CE7A53E5761, 0x7D5F99FEB7925A09,
                0x0992330C5BDF740E, 0x990000406A727796, 0xD7A4DFFC9FCA57B4, 0xF59AFCC43B30F4C3,
                0x7D5EBE76D1D24BDF, 0xA2A4FB1AEC2EC537, 0xAFC0B6CF3E03025C, 0xE208702CF499C9CB,
                0x75CA6F4F0C8A4DDC, 0xF8F9F878D66754FF, 0x3FF75EF5C1DE3053, 0x53BAE3A5A905128B,
                0xB1BFDF70CC0F7112, 0x135EEF7C7A3E8DF8, 0xD8ACF95E8BA1C9D2, 0xDBD5602734815B77,
                0x1023920CDF4C139A, 0xA7E6DB1D67C9AD76, 0x0D128006E457F2B3, 0x0C2C21E104548FC8,
                0x018C802135E0A3BC, 0x081288411A14E549, 0x6AD9EE993380DF74, 0xF5AF72D81916A3C6,
                0x000701006AAA31A2, 0x2A000458E11A3187, 0xF92ED72D3391382F, 0xD7CD5769816E75DA,
                0xE0A20891B6B62235, 0xD94FFF5957AC4B63, 0xDEFE79E0A2EB8EAA, 0x8F25868005B09923,
                0x47FB033FF9ACC364, 0xD6FFBE2BB9D0CE96, 0x29822E20DA779D26, 0x52321C00BBD3AB35,
                0x40284B9D8DF33680, 0x0029D1201309A49C, 0x0144368AA5DF9E71, 0xFF2FB62F52C3EFCC,
                0x81000C00A538674F, 0x02F5E5EFBF3DAF09, 0xC80840A55A62254B, 0x6EF951BA5CD0BBA5,
                0xF7AAEAFE40C20D99, 0xE87431B3F39C0F58, 0x75BFB3DBC936C0DA, 0x2C0082B1060FA821,
                0x86230011152586B6, 0xB4DB5ABDAB01FABB, 0xE692EF3BD281D8A7, 0x2F35B2DB521E4CCD,
                0x30540540CD3DD3D2, 0x0011D0145B0DA5B8, 0x7980408459603ECD, 0x9D85FFF7D5473E44,
                0x8091CA3229D981C5, 0xB937FDA194197B12, 0x678EDBE160935014, 0x001200A0AF993605,
                0x0A161200FE13B420, 0x8B64FD762D57B8D1, 0xFBDC643D65C00E0A, 0x21FAFB67DE23714C,
                0xF513404C2D74183A, 0x5C3EDDDD898EB496, 0x080D01A1A8230EF2, 0x8A0842444891281C,
                0xB3E4BF87382225C6, 0xFB5CDEF580CE7B8F, 0x3EF149D8574CD77A, 0xBDB935C57B90774C,
                0x9EE6DF5E6FC3B84A, 0x28008C81B519AF29, 0x7D7D92CED4EE9DD5, 0x481100110D6BC434,
                0x7B9FE78BDC3511E1, 0x04F40862682DF110, 0x01980E0927A6C110, 0xC3FCFDF6913A463A,
                0xEF49CE170BD3C001, 0xFF6B35E4DCC47200, 0x000054C062F8ECA4, 0xD6AD0BEB45A1FD23,
                0x86E8176870686CFD, 0xA6575169D427B781, 0x3EFE91FC06ED42FA, 0xF647FDEF1AE7BEAD,
                0x8F8FFBAC78DE6DE9, 0x030044210AE13603, 0xEC9A921E694A7BA9, 0x0B36808222DA2D65,
                0x5F79DFB292EA3274, 0x6F9AF3B345025EB2, 0xE7D5FAB26C70D599, 0x35EBDF7D7E0A72D3,
                0x000030606D945BD8, 0x79BEF77FC0B62B01, 0xD9D7335E57195393, 0x720001E8BEBF825C,
                0x4F1BED5F746DCDFC, 0xFFF71737877AA9F6, 0xBFD76BD3C5EA90B6, 0x06FE7FDBD130FC88,
                0x669E67F7B2C3E024, 0xC62280A8BC600D30, 0xF37246153F29409B, 0x1C00A01C604CC6F5,
                0x5F9F345A437264A3, 0x40014082BA0C8473, 0xE4F6BE368A35C987, 0xEF49BCDF20BDD1CE,
                0x00832E81621989C6, 0xDA4DD8B58BCCB9A9, 0xF4D3BF1353F98FE5, 0x53C06D0880747E6D,
                0x5F727E631FF49D3B, 0xF632FBFA5CE0CFD5, 0x028E6C010B3BE280, 0xB2EF73BD6BF434C8,
                0xE6DD2AE316501406, 0xBEFA64FF447E843D, 0xCFFDEC3BB4F8FE4D, 0x1A20217BCC57E881,
                0x01400946DE76AED7, 0xEB73B7775ECED509, 0x80F88E40AF1DF242, 0xD6DD0DD37A550A3F,
                0xC04508102A640CED, 0xA9EEF6DD658B9CEB, 0x85E7D7CE9789F3B6, 0xFEFFB9CB109FF8B6,
                0x6E7F17325A7077F9, 0xDB8491CFE1D4ED2B, 0x014A3002CEC42B3B, 0x777BD6741774E035,
                0xAEF77407616C8E0A, 0x26B4650FDFAC5B9D, 0xF579B0D397D4D773, 0xF4F93F9F522459EA,
                0x84342AC460578177, 0x3413ADFA27401535, 0xDF7FDBBB9DA14F2C, 0x5D9AA44FAC77B715,
                0x55FFFB3E816757A1, 0xBDFD576FBE620C15, 0x9EF25F9D4425F446, 0x98F91EAF6E2B7D02,
                0xBC4E91C76196E2FA, 0xC3EAC7F6F588504F, 0xCFC8F6FE5A663BBB, 0xA0882023307FC824,
                0xB5F6BBEB8CC3D194, 0x61EF3DB74DF56CF2, 0x9C00C0082FB16792, 0xFC71D9117C3C0422,
                0x28FEDFFDA66087A9, 0x358F0242116E9145, 0x8502A48CDF1E3E21, 0x410D03A4CA7A8FC0,
                0x35E3EBDD0CA338FB, 0x40201300FC29816F, 0x14C01500D25B560E, 0x800A00114EF4E934,
                0x1E09EDCFA816C60E, 0xC0E1D51F506FEAFB, 0x6B6FD5BF28BCBA5C, 0x102004027457305E,
                0x4620E1C8EF6E5CC7, 0x02444A4F08D7BD5C, 0x3E2EBB7839012427, 0x5590548E9F4AAC57,
                0xC2D6DA6FB0802DA9, 0x02330010E0BB92DA, 0x7ED90FEF79CDF8CB, 0x385AE04F3D98B02E,
                0xD67FB42AF49EC23D, 0x2FC76EFDDD5E3F4E, 0xE00200B016D33664, 0x9A77F8BBB782695B,
                0x5FEDD3D936A38378, 0xDF19F3ABA42B7C80, 0xFEF0867CD9D9686A, 0xBD19C875A298FB90,
                0x10E68FAB7965C3CD, 0x67F98FFACE95BBAC, 0xF73D99FFD24CA24F, 0xBFED3FBA8DB66C93,
                0x08200592E7DF255F, 0x0A7B317FB02CC8C1, 0x9A4902118F501102, 0xCB751DEA3EE6F295,
                0xB4D93AB7657FD5D6, 0x7107FE6CF610F16D, 0x5F6CD7DA898AA310, 0xD8061C819850A37E,
                0x20D302209ADAA873, 0x18CF44768221A077, 0x7FABEB8FC42E75ED, 0xF7F73DCE13E65789,
                0x64000410838268FE, 0xFEE1D93637319A58, 0xA7186FE743AE37DC, 0x3B2F380F590F5AFD,
                0x30C1A0C0CB03AAA9, 0x00080D88746C14B5, 0xD4B1FBDE8B376876, 0x2004200247C5DB47,
                0xDD645E45898E166D, 0x80000D38B28D2BC0, 0xF7ADA101A6F34F0F, 0x04404000A27DB2F2,
                0x7B79E1EC83874C2A, 0x6B2FFD2662DA5E68, 0xCF3EEBA20B383BCE, 0x4503C00A838F9989
            };


        
        /// <remarks>
        /// Defaults <see cref="BuzHashBase.ShiftDirection" /> to <see cref="BuzHashBase.CircularShiftDirection.Left" />.
        /// <inheritdoc cref="DefaultBuzHash(CircularShiftDirection)" />
        /// </remarks>
        /// <inheritdoc cref="DefaultBuzHash(CircularShiftDirection)" />
        public DefaultBuzHash()
            : this(CircularShiftDirection.Left)
        {

        }

#if !NET40
        /// <param name="shiftDirection">The shift direction.</param>
        /// <remarks>
        /// Defaults <see cref="BuzHashBase.InitVal" /> to 0x3CD05367FD0337D3.
        /// <inheritdoc cref="BuzHashBase(IReadOnlyList{UInt64}, CircularShiftDirection, UInt64)" />
        /// </remarks>
        /// <inheritdoc cref="BuzHashBase(IReadOnlyList{UInt64}, CircularShiftDirection, UInt64)" />
#else
        /// <param name="shiftDirection">The shift direction.</param>
        /// <remarks>
        /// Defaults <see cref="BuzHashBase.InitVal" /> to 0x3CD05367FD0337D3.
        /// <inheritdoc cref="BuzHashBase(IList{UInt64}, CircularShiftDirection, UInt64)" />
        /// </remarks>
        /// <inheritdoc cref="BuzHashBase(IList{UInt64}, CircularShiftDirection, UInt64)" />
#endif
        public DefaultBuzHash(CircularShiftDirection shiftDirection)
            : base(_Rtab, shiftDirection, 0x3CD05367FD0337D3)
        {

        }

        /// <remarks>
        /// Defaults <see cref="BuzHashBase.ShiftDirection" /> to <see cref="BuzHashBase.CircularShiftDirection.Left" />.
        /// <inheritdoc cref="DefaultBuzHash(CircularShiftDirection, int)" />
        /// </remarks>
        /// <inheritdoc cref="DefaultBuzHash(CircularShiftDirection, int)" />
        public DefaultBuzHash(int hashSize)
            : this(CircularShiftDirection.Left, hashSize)
        {

        }

#if !NET40
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultBuzHash"/> class.
        /// </summary>
        /// <remarks>
        /// Defaults <see cref="BuzHashBase.InitVal" /> to 0x3CD05367FD0337D3.
        /// </remarks>
        /// <inheritdoc cref="BuzHashBase(IReadOnlyList{UInt64}, CircularShiftDirection, UInt64, int)" />
#else
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultBuzHash"/> class.
        /// </summary>
        /// <remarks>
        /// Defaults <see cref="BuzHashBase.InitVal" /> to 0x3CD05367FD0337D3.
        /// </remarks>
        /// <inheritdoc cref="BuzHashBase(IList{UInt64}, CircularShiftDirection, UInt64, int)" />
#endif
        public DefaultBuzHash(CircularShiftDirection shiftDirection, int hashSize)
            : base(_Rtab, shiftDirection, 0x3CD05367FD0337D3, hashSize)
        {

        }
    }
}
