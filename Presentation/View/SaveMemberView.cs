using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.View
{
    public class SaveMemberView
    {
        public InputData RequestData()
        {
            return this.Show();
        }

        private InputData Show()
        {
            InputData input = new InputData();
            Console.WriteLine("======================================");
            Console.WriteLine("1. Ingrese codigo de nuevo socio: ");
            input.fields.Add("CodigoSocio", Console.ReadLine());
            Console.WriteLine("2. Ingrese primer nombre del nuevo socio: ");
            input.fields.Add("PrimerNombre", Console.ReadLine());
            Console.WriteLine("3. Ingrese segundo nombre del nuevo socio: ");
            input.fields.Add("SegundoNombre", Console.ReadLine());
            return input;
        }
    }
}
