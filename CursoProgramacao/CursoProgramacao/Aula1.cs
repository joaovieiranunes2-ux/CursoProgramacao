namespace CursoProgramacao
{
    public class Aula1
    {
        //Metodo Somar
        public void Soma()
        {
            int valor1;
            int valor2;

            Console.WriteLine("informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor2");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Total: {valor1 + valor2}");

        }

        //Metodo Multiplicar
        public void Multiplicar()
        {

            int valor1;
            int valor2;

            Console.WriteLine("informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor2");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Total: {valor1 * valor2}");

        }

        //Metodo Subtrair
        public void Subtrair() {
            int valor1;
            int valor2;

            Console.WriteLine("informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor2");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Total: {valor1 - valor2}");
        }

        //Metodo Dividir
        public void Dividir() {


            int valor1;
            int valor2;

            Console.WriteLine("informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor2");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Total: {valor1 / valor2}");
        }
    }
}
