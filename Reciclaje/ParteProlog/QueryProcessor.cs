using SbsSW.SwiPlCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Reciclaje.ParteProlog
{
    public static class QueryProcessor
    {

        public static List<Dictionary<string, string>> ProcessForResults(string query)
        {
            var results = new List<Dictionary<string, string>>();
            var plQuery = new PlQuery(query);

            while (plQuery.NextSolution())
            {
                var variables = new Dictionary<string, string>();

                foreach (string id in plQuery.VariableNames)
                {
                    variables[id] = plQuery.Variables[id].ToString();
                }

                results.Add(variables);
            }

            return results;
        }
    }
}