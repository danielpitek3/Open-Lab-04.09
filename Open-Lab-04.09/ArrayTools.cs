using System;
using System.Linq;
using System.Collections.Generic;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            var list = new List<string>();
            foreach (string str in strings)
            {
                if (!list.Contains(str))
                {
                    list.Add(str);
                }
            }

            return list.ToArray();
        }
    }
}
