using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace _3._1._04.ValidatingJsonAndXml
{
    // Deserializing an object with the JavaScriptSerializer
    public class MainListing3X13
    {
        public MainListing3X13()
        {
            try
            {
                var json = "'email': 'carlos.ribeiro@gmail.com','firstName': 'Carlos'}";
                var serializer = new JavaScriptSerializer();
                var result = serializer.Deserialize<Dictionary<string, object>>(json);

            }
            catch (Exception e)
            {
                Console.WriteLine("Ação de serializar um Json para um Object concluída com erros :(");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Ação de serializar um Json para um Object concluída com sucesso !");
            Console.ReadKey();
        }

        
    }

}