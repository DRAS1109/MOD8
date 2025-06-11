internal class Program
{
    private static void Main(string[] args)
    {
        // Variaveis();
        // LerDados();
        // OperadoresLogicos();
        // Ciclos();
        Console.WriteLine(Soma(10, 20));
    }

    /// <summary>
    /// Soma para somar 2 numeros
    /// </summary>
    /// <param name="x">Primeiro n a somar</param>
    /// <param name="y">Segundo n a somar</param>
    /// <returns>Um inteiro com o resultado da soma</returns>

    static int Soma(int x, int y)
    { return x + y; }

    static void LerDados()
    {
        Console.Write("Escreva um numero: ");
        string Texto = Console.ReadLine();
        Console.WriteLine(Texto);

        int Numero;
        Numero = Convert.ToInt32(Texto);
        Console.WriteLine(Numero);
    }

    public static void Variaveis()
    {
        //Isto é um comentario
        /* Comentario 
         * de varias 
         * linhas */

        // WriteLine escreve na consola
        Console.WriteLine("Hello, World!");

        // Variaveis
        bool Verdadeiro_Falso;
        Verdadeiro_Falso = true;

        int Inteiro = 1;
        double Mais_Casas_Decimais = 10.5;
        float Menos_Casas_Decimais = 10.4f;
        char Uma_Letra = 'a';
        string Um_Nome = "Nome";

        var o_que_e_isto = 10.5;

        // Condições (if)
        if (Verdadeiro_Falso == true)
        { Console.WriteLine("Verdadeiro ou Falso?", Verdadeiro_Falso); }

        else { Console.WriteLine("Verdadeiro ou Falso?", Verdadeiro_Falso); }
    }

    static void OperadoresLogicos()
    {
        int X = 10, Y = 20;
        // Mostrar mensagem se ambos forem maiores que 0
        // Operador logico E
        if (X > 0 && Y > 0)
            Console.WriteLine("São ambs maiores que 0");

        // Operador logico OU
        if (X > 0 || Y > 0)
            Console.WriteLine("Um dos dois é maior que 0");
    }

    static void Ciclos()
    {
        int i = 0;
        // Percorrer n inteiros de 0 < 9
        for (i = 0; i < 10; i++)
        { Console.WriteLine(i); }

        // Percorrer n inteiro de 9 a 0
        for (i = 9; i >= 0; i--)
        { Console.WriteLine(i); }

        ///////////////////////////////
        while (i < 10)
        { Console.WriteLine(i); i++; }

        ///////////////////////////////
        string Texto = "Ola Mundo";
        for (i = 0; i < Texto.Length; i++)
            Console.WriteLine(Texto[i]);

        foreach (char c in Texto)
            Console.WriteLine(c);
    }

}