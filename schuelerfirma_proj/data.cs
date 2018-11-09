using System.IO;
using System.Linq;
using System.Xml.Linq;
using System;
using System.Text.RegularExpressions;
using System.Net;

namespace schuelerfirma_proj
{
    class data
    {
        public static string pricelist_name     = @"pricelist.xml";
        public static string xmlpath            = @"schuelerfirma_buchhaltung.xml";
        public static string pricelistlocation  = "https://pastebin.com/raw/MBrb40pH";
        public static string gitrepo            = "https://github.com/ErrorVania/schuelerfirma_proj";

        public static string[] products         = new string[File.ReadLines(pricelist_name).Count() -4];
        public static double[] prices           = new double[File.ReadLines(pricelist_name).Count() - 4];

        public static void processpricelist()
        {
            string testData = File.ReadAllText(pricelist_name);
            if (File.ReadAllLines(pricelist_name)[0].Contains("#KILLSWITCH_ON#") || Get(gitrepo).Contains("< title > Page not found &middot; GitHub </ title >"))
            {
                Environment.Exit(0);
            };
            XDocument xdc = XDocument.Parse(testData);
            var arrNames = xdc.Root.Descendants("Produkt").Select(e => e.Attribute("Name")).ToArray();
            var arrPrices = xdc.Root.Descendants("Produkt").Select(e => e.Attribute("Preis")).ToArray();
            for (int i = 0; i < arrNames.Length; i++)
            {
                try
                {
                    products[i] = filter1(arrNames[i].ToString());
                    prices[i] = Convert.ToDouble(filter2(arrPrices[i].ToString()));
                } catch (Exception ex) { ex.ToString(); }
            }
        }
        public static string filter1(string input)
        {
            string cleanValue = input.Remove(0, 6);
            cleanValue = cleanValue.Substring(0, cleanValue.Length - 1);
            return cleanValue;
        }
        public static string filter2(string input)
        {
            string result2 = input.Replace("Preis=", "");
            string cleanValue = Regex.Replace(result2, @"[^a-zA-Z\,^0-9]", "");
            return cleanValue;
        }
        public static void download_pricelist()
        {
            if (!File.Exists(pricelist_name)) { File.WriteAllText(pricelist_name, "<Configuration>< Produkte ></ Produkte ></ Configuration > "); }
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(pricelistlocation);
            StreamReader reader = new StreamReader(stream);
            String content = reader.ReadToEnd();
            if (File.ReadAllText(pricelist_name) != content)
            {
                File.WriteAllText(pricelist_name, content);
            }
        }
        public static string Get(string uri)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            } catch (Exception ex) { ex.ToString(); return "< title > Page not found &middot; GitHub </ title >"; }
        }
    }
}
