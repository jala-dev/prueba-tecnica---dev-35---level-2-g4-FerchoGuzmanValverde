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
            input.fields.Add("CodigoSocio", InputMemberCode());
            Console.WriteLine("2. Ingrese primer nombre del nuevo socio: ");
            input.fields.Add("PrimerNombre", InputMemberName());
            Console.WriteLine("3. Ingrese segundo nombre del nuevo socio: ");
            input.fields.Add("SegundoNombre", Console.ReadLine());
            return input;
        }

        private string InputMemberCode()
        {
            int memberCode = int.Parse(Console.ReadLine());
            while(memberCode < 5000 || memberCode > 5999)
            {
                Console.WriteLine("Codigo de miembro debe ser un valor entre 5000 y 5999");
                Console.WriteLine("1. Ingrese codigo de nuevo socio: ");
                memberCode = int.Parse(Console.ReadLine());
            }

            return memberCode.ToString();

        }

        private string InputMemberName()
        {
            string memberName = Console.ReadLine();
            while (memberName.Length < 4)
            {
                Console.WriteLine("El nombre de socio debe tener minimo 4 caractéres!!");
                Console.WriteLine("2. Ingrese primer nombre del nuevo socio: ");
                memberName = Console.ReadLine();
            }

            return memberName;
        }
    }
}
