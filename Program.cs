using System;

namespace EstructurasEjemplosG2_2022_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente;

            cliente.Nombre = "Armando";
            cliente.Edad = 50;

            Console.WriteLine(" Nombre: {0} \n Edad: {1} ",cliente.Nombre,cliente.Edad);
            


            Cliente[] clientes = new Cliente[2];

            for (int i = 0; i < clientes.Length; i ++)
            {
                Console.WriteLine("Ingresa el nombre: ");
                clientes[i].Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad");
                clientes[i].Edad = byte.Parse( Console.ReadLine());
                Console.WriteLine("Ingresa la calle donde vive:");
                clientes[i].direccion.Calle = Console.ReadLine();
                Console.WriteLine("Ingresa el número interior: ");
                clientes[i].direccion.numInterior = byte.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el número exterior");
                clientes[i].direccion.numExterior = short.Parse(Console.ReadLine());

            }

            foreach(Cliente otroCliente in clientes )
            {
                Console.WriteLine(" Nombre del cliente: {0} \n Edad del cliente {1}", otroCliente.Nombre, otroCliente.Edad);
                Console.WriteLine("Direccción: \n\t Calle: {0}\n\t Número Interior: {1} \n\t Número Exterior: {2}",otroCliente.direccion.Calle,otroCliente.direccion.numInterior,otroCliente.direccion.numExterior);
            }
            Console.ReadLine();


        }
    }

    struct Cliente
    {
        public string Nombre;
        public byte Edad;
        public Direccion direccion;

    }

    struct Direccion
    {
        public string Calle;
        public byte numInterior;
        public short numExterior;
    }

}
