using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BigHealthTakeHomeTest.Helper
{
    public static class TableExtensions
    {
        public static List<string> ToList(Table table)
        {
            return table.Rows.Select(t => t[0]).ToList();
        }

        public static Dictionary<string,string> ToDictionary(Table table)
        {
            return table.Rows.ToDictionary(t => t[0], t => t[1]);
        }
    }
}
