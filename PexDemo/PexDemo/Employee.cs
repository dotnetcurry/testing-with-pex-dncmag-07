using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Diagnostics.Contracts;

namespace PexDemo
{

    public class Employee
    {
        public decimal CalculateSalary(int experience)
        {
            if (experience > 20)
                throw new ArgumentException("Experince cannot be greater then 20");

            decimal baseSalary = 1000.00m;

            if (experience < 5)
                return baseSalary / experience;

            if (experience >= 5 && experience <= 10)
                return baseSalary + 500.00m;

            if (experience > 10)
                return baseSalary + 1000.00m;

            return baseSalary;
        }



        public string GetMd5Hash(MD5 md5Hash, string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            if (md5Hash == null)
                return string.Empty;

            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes 
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string. 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }
    }




   
}
