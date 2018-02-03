using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.HashFunction.Test
{
    public class SingleSpeedTest
        : IHashFunction_SpeedTest
    {
        protected override IReadOnlyDictionary<String, IHashFunction> TestHashFunctions
        {
            get 
            { 
                return new Dictionary<String, IHashFunction>() {
                    { "JenkinsLookup3()", new JenkinsLookup3() }
                };
            }
        }
    }
}
