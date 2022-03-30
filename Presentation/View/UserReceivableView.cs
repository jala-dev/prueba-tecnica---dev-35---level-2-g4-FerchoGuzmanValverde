using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.View
{
    public class UserReceivableView
    {
        public InputData RequestData()
        {
            return this.GetData();
        }

        private InputData GetData()
        {
            InputData input = new InputData();
            Console.WriteLine("======================================");
            Console.WriteLine("1. Ingrese el codigo del socio: ");
            input.fields.Add("CodigoSocio", Console.ReadLine());
            return input;
        }

        public void ShowResult(int memberCode, string memberName, int totalBuckets, double amountDebt)
        {
            Console.WriteLine("El consumo del socio {0}, correspondiente a {1} es de {2} cubos. La deuda total es de {3} Bs.", memberCode, memberName, totalBuckets, amountDebt);
            Console.WriteLine("======================================");
        }
    }
}
