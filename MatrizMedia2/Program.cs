using System.Dynamic;

internal class Program
{
    private static void Main(string[] args)
    {
        double[,] mat = new double[5, 3];
        Random sorteio = new Random();
        //Carregar valores na matriz
        // .GetLength(1)  --> pega o tamanho da coluna ( tem o 1 dentro pq é coluna, se fosse linha era 0);
        // GetLength(1) -1  ( o -1 é nesse exemplo especifico, pois a terceira coluna sera a media dos valores das 2 primeiras colunas)
        for (int c=0; c< mat.GetLength(1) -1; c++)
        {
            for(int l=0; l< mat.GetLength(0);l++)
            {
                mat[l,c] =  (double) sorteio.Next(1000)/100;
            }
        }


        //Calculo da 3ª coluna
        Console.WriteLine("Calculando...");
        
            for (int l = 0; l < mat.GetLength(0); l++)
            {
                mat[l,2] = (mat[l,0] + mat[l,1]) /2 ;
            }
        



        //Impressão da Matriz
        Console.WriteLine("Os valores da matriz são: ");
        for (int l = 0; l < mat.GetLength(0) ; l++)
        {
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                Console.Write("\tmat["+l+"]["+c+"]=" + mat[l,c].ToString("f2"));
            }
            Console.WriteLine();
        }



    }
}