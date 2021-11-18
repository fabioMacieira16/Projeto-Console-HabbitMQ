using System;
using System.Collections.Generic;

namespace Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            var lst2 = new List<string>()
            {
                "Hi",
                "Welcome",
                "to",
                "Tutlane"
            };

            Conexao.SendRow(lst2);
        }
    }
}
