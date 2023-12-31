namespace JCD1._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de linhas: ");
            int linhas = Convert.ToInt32(Console.ReadLine());
            string arvore = "*";

            for (int i = 1; i <= linhas; i++)
            {
                Console.WriteLine(arvore);
                arvore = arvore + "*";
            }
        }
    }
}