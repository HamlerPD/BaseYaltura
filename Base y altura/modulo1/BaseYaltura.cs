namespace Base_y_altura.modulo1
{
    public class BaseYaltura
    {
       

        public void BayALTriangulo()
        {
            int x = 0;
            int Cantidad = 0;
            int altura = 0;
            int bas = 0;
            int mayor = 0;
            int menor = 0;
            string linea = string.Empty;
            int area = 0;

            Console.WriteLine(" Ingrese catidad de triangulos que desea medir");
            linea = Console.ReadLine();

            if (int.TryParse(linea, out int myCantidad))
            {
                Cantidad = myCantidad;
            }
            else
            {
                Console.WriteLine(" La cantidad ingresada no es validad ");
            }

            Console.WriteLine("---------------------------------------CANTIDAD INGRESADA---------------------------------------------------");

            while (x <= Cantidad)
            {
                Console.WriteLine(" Ingrese la altura del triangulo");
                linea = Console.ReadLine();

                if (int.TryParse(linea, out int myAltura))
                {
                    altura = myAltura;
                }
                else
                {

                }

                Console.WriteLine(" Ingrese la base del triangulo");
                linea = Console.ReadLine();

                if (int.TryParse(linea, out int myBas))
                {
                    bas = myBas;
                }
                else
                {
                    Console.WriteLine(" El valor ingresa no es valido");
                    return;
                }
                area = bas * altura / 2;
                Console.WriteLine($"La base es igual {bas} y la altura igual a {altura} y la superficie es igual a {area}");

                if ( area > 12)
                {
                    mayor += 1;
                }
                else
                {
                    menor += 1;
                }
                x += 1;
            }

            Console.WriteLine($"Cantidad de triangulos con la superficie superior a 12: {mayor}");

            Console.WriteLine($"Cantidad de triangulos con la superficie menor o igual a 12: {menor}");

        }
    }
}
