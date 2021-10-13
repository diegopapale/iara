using System;

public class Program
{
    public static void Main()
    {
        string[] array = { "abracadabra", "allottee", "assessee", "papagaio", "gato", "cachorro", "papagaio" };

        for (int i = 0; i < array.Length; i++) // Length qtde de palavras ou registros do array
        {
            Console.WriteLine(RemoverCaracteresDuplicados(array[i]));
        }
    }

    static string RemoverCaracteresDuplicados(string texto) // recebe que está correndo no for
    {
        // Armazena as letras, somente um caractere
        char anterior = ' ' ;

        // armazena o resultado
        string resultado = "";

        // Percorre cada caractere do texto
        foreach (char valor in texto)
        {
            if (anterior != valor)
            {
                anterior = valor;
                resultado += valor;
            }
        }

        return resultado;
    }
}