using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace System.Data.HashFunction.Test {

    public static class UtilityExtensions {

        /// <summary>
        /// Recursively resolves all base types.
        /// </summary>
        /// <param name="parentType">       Type to resolve base types of.</param>
        /// <param name="includeParentType">If true, includes original type in the returned enumeration.</param>
        /// <returns>
        /// Enumeration yielding each of the base types of the parent type, descending the hierarchy
        /// of types.
        /// </returns>
        public static IEnumerable<Type> GetBaseTypes( this Type parentType, Boolean includeParentType = false ) {
            if ( parentType == null )
                throw new ArgumentNullException( "parentType" );

            if ( includeParentType )
                yield return parentType;

            var currentType = parentType;

            while ( currentType != null ) {
                yield return currentType;

                currentType = currentType.BaseType;
            }
        }

        /// <summary>
        /// Converts a hex string to byte array.
        /// </summary>
        /// <param name="hexString">String containing a hexadecimal value, [0-9a-fA-F _-] allowed.</param>
        /// <returns>Byte array of the binary representation of the hexString.</returns>
        public static Byte[] HexToBytes( this String hexString ) {
            var chars = hexString
                .Replace( " ", "" )
                .Replace( "-", "" )
                .Replace( "_", "" )
                .ToCharArray();

            if ( chars.Length % 2 == 1 )
                throw new ArgumentException( "hexString's length must be divisible by 2 after removing spaces, underscores, and dashes.", "hexString" );

            var bytes = new Byte[chars.Length / 2];

            for ( Int32 x = 0; x < chars.Length; ++x ) {
                if ( x % 2 == 0 )
                    bytes[x / 2] = 0;
                else
                    bytes[x / 2] <<= 4;

                if ( chars[x] >= '0' && chars[x] <= '9' )
                    bytes[x / 2] |= ( Byte )( chars[x] - '0' );
                else if ( chars[x] >= 'a' && chars[x] <= 'f' )
                    bytes[x / 2] |= ( Byte )( chars[x] - 'a' + 10 );
                else if ( chars[x] >= 'A' && chars[x] <= 'F' )
                    bytes[x / 2] |= ( Byte )( chars[x] - 'A' + 10 );
                else
                    throw new ArgumentException( "hexString contains an invalid character, only [0-9a-fA-F _-] expected", "hexString" );
            }

            return bytes;
        }

        public static void LoadAllReferencedAssemblies( this AppDomain domain ) {
            IEnumerable<AssemblyName> referencedAssemblies;

            var loadedAssemblies = new HashSet<String>();

            do {
                referencedAssemblies = domain.GetAssemblies()
                    .SelectMany( a => a.GetReferencedAssemblies() )
                    .Select( an => an.FullName )
                    .Except( domain.GetAssemblies()
                        .Select( a => a.GetName().FullName ) )
                    .Except( loadedAssemblies )
                    .Select( fn => new AssemblyName( fn ) );

                foreach ( var referencedAssembly in referencedAssemblies ) {
                    domain.Load( referencedAssembly );
                    loadedAssemblies.Add( referencedAssembly.FullName );
                }
            } while ( referencedAssemblies.Any() );
        }

        /// <summary>
        /// Converts string to byte array.
        /// </summary>
        /// <param name="value">String to encode into bytes.</param>
        /// <returns>UTF-8 encoding of the string as a byte array.</returns>
        public static Byte[] ToBytes( this String value ) {
            return Encoding.UTF8.GetBytes( value );
        }
    }
}
