using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._02.UsingParse_TryParse_And_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            // Listing 3.4 - Using Parse
            #region Listing 3.4
            //var listing = new MainListing3X4();
            #endregion

            // Listing 3.5 - Using TryParse
            // The CultureInfo class can be found in the System.Globalization namespace. | Usaremos no próximo "listing"
            #region Listing 3.5
            //var listing = new MainListing3X5();
            #endregion

            // Listing 3.6 - Using configuration options when parsing a number
            #region Listing 3.6
            //var listing = new MainListing3X6();
            #endregion

            // Listing 3.7 - Using Convert with a null value
            // A grande diferença entre "Parse/TryParse" e "Covert" é que o "Convert" aceita valores Null
            // outro grande ponto é que o Convert só aceita "string" como input já "Parse/TryParse" aceita outras entradas.
            #region Listing 3.7
            //var listing = new MainListing3X7();
            #endregion

            // Listing 3.8 - Using Convert with a null value
            // Using Convert to convert from double to int
            #region Listing 3.8
            //var listing = new MainListing3X8();
            #endregion
        }
    }
}
