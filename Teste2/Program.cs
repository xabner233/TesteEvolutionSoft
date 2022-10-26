using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //Teste 2.1
        Console.WriteLine("Digite o numero para realizar a soma: ");
        int x = int.Parse(Console.ReadLine());
        int soma = 0;
        int cont = x;

        for (int i = 0; i <= cont; i++)
        {
            soma += x;
            x--;
        }

        Console.WriteLine(soma);


        // Teste 2.2
        String[] array = { "abracadabra","allottee","assessee" };
        String[] result = new String[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            String atual = array[i];
            StringBuilder sb = new StringBuilder();
            char anterior = (char)0;
            for (int j = 0; j < atual.Length; j++)
            {
                char c = atual[j];
                if (c != anterior)
                {
                    sb.Append(c);
                }
                anterior = c;
            }
            result[i] = sb.ToString();
            Console.WriteLine(result[i]);
        }
    }
}