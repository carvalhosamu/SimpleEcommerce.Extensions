using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEcommerce.Extensions
{
    public static class StringExtensions
    {
        public static string PaddingZerosLeft(this string val, int qtdZeros)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < qtdZeros; i++)
            {
                sb.Append("0");
            }
            sb.Append(val);
            return sb.ToString();  
        }
    }
}
