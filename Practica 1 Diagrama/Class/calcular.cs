namespace Practica_1_Diagrama.Class
{ 
    public class Calcular
    {
        public void Practica_1_Diagrama()
        {
            int num1 = 0;
            int num2 = 0;
            decimal suma = 0;
            decimal producto = 0;

            Console.WriteLine("Digite el num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el num2: ");
            num2 = int.Parse(Console.ReadLine());

            suma = (num1 + num2);
            producto = (num1 * num2);

            Console.WriteLine($"La suma es:  {  suma  }");
            Console.WriteLine($"El producto es:  {  producto  }");


        }
    }






}