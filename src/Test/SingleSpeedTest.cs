using System.Collections.Generic;

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
