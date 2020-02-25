using System;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace getCLLI
{
    internal class LocalCallingGuide
    {
        public async Task<DataSet> Get(string npa, string nxx, string x, string rc, string region, string clli, string lata, string ocn, string exch, string lir)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                XmlDocument doc = new XmlDocument();
                DataSet dataSet = new DataSet();
                String query = String.Empty;

                query = AddToQuery(query, @"npa", npa);
                query = AddToQuery(query, @"nxx", nxx);
                query = AddToQuery(query, @"x", x);
                query = AddToQuery(query, @"rc", rc);
                query = AddToQuery(query, @"region", region);
                query = AddToQuery(query, @"switch", clli);
                query = AddToQuery(query, @"lata", lata);
                query = AddToQuery(query, @"ocn", ocn);
                query = AddToQuery(query, @"exch", exch);
                query = AddToQuery(query, @"lir", lir);

                Uri req = new Uri(@"https://localcallingguide.com/xmlprefix.php" + query);

                String response = await httpClient.GetStringAsync(req).ConfigureAwait(false);

                using (TextReader sr = new StringReader(response))
                {
                    _ = dataSet.ReadXml(sr);
                }

                return dataSet;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static String AddToQuery(String query, String param, String data)
        {
            try
            {
                if (!String.IsNullOrEmpty(data))
                {
                    if (String.IsNullOrEmpty(query))
                    {
                        return query + @"?" + param + @"=" + data;
                    }
                    else
                    {
                        return query + @"&" + param + @"=" + data;
                    }
                }
                else
                {
                    return query;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}