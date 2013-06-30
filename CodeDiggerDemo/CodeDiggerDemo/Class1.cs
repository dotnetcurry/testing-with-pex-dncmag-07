using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDiggerDemo
{
    public class CodeDiggerDemo
    {
        public bool ListContainNames(List<string> listNames)
        {
            if (listNames == null) return false;

            if (listNames.Any())
            {
                if (listNames.ElementAt(0).Contains("smith")) {
                    throw new Exception("should not contain smith");
                }

                if (listNames.ElementAt(0).Contains("david")) {
                    return true;
                }
            }

            return false;
        }

    }
}
