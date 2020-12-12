using System;

namespace CsFundamentals
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i * 2);

            }


            string teste = "teste string";
            int teste2 = 555;
            bool teste3 = true;
            float teste4 = 5.55f;//float precisa do f no final
            char teste5 = 'A';
            double teste6 = 6.66;//double não precisa do f no final

            Console.Write("informe o seu nome: ");
            string name = Console.ReadLine();
            Console.Write("informe o sua idade: ");
            int age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("--- {0} --- {1} --- {2} --- {3} --- {4} --- {5} --- {6} --- {7}", teste, teste2, teste3, teste4, teste5, teste6, name, age);

            //arrays

            int[] luckyNumbers = {4, 8, 15, 16, 23, 42 };

            PrintArray(luckyNumbers);

            string[] languages = new string[3]; // cria uma array vazia com 3 posições
            for (int i = 0; i < languages.Length; i++)
            {
                Console.Write("informe uma linguagem de sua preferencia: ");
                languages[i] = Console.ReadLine();
            }

            PrintArray(languages);
            

            //2d arrays
            int[,] numberGrid =
            {
                {1, 2, 3, 123},
                {4, 5, 6, 456},
                {7, 8, 9, 789}
            };

            PrintMat(numberGrid);
            

            try
            {
                Console.Write("digite um numero: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("digite outro numero: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("O resultado é {0}", num1 + num2);
            }
            catch(Exception e)
            {
                Console.WriteLine("errouuu {0}", e.Message);
            }
            

            //Classes and objects
            Book livro1 = new Book("harry potter", "jk rowling", 300, "errado");
            Book livro2 = new Book("senhor dos aneis", "tolkien", 5689045, "exemplo qualquer de atributo privado");
            Console.WriteLine("livro: {0}, author: {1}, paginas: {2}", livro1.title, livro1.author, livro1.pages);
            Console.WriteLine("livro: {0}, author: {1}, paginas: {2}", livro2.title, livro2.author, livro2.pages);

            Console.WriteLine(livro1.IsLongBook());
            Console.WriteLine(livro1.AtributoPrivado);
            livro1.AtributoPrivado = "agora está correto";
            Console.WriteLine(livro1.AtributoPrivado);

            Console.WriteLine(livro2.IsLongBook());
            Console.WriteLine(livro2.AtributoPrivado);

            Console.WriteLine(Book.testeAtributoEstatico);

            TesteClasseEstatica.SayHi();

            ClassHerdaBook obj1 = new ClassHerdaBook("herdou title", "herdou author", 5400, "qualquer");
            Console.WriteLine("livro: {0}, author: {1}, paginas: {2}", obj1.title, obj1.author, obj1.pages);
            Console.Write("exemplo de method override: ");
            Console.WriteLine(obj1.IsLongBook());
        }


        //polimorfismo
        static void PrintArray( int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("indice: {0} valor: {1}", i, arr[i]);
            }

        }
        static void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("indice: {0} valor: {1}", i, arr[i]);
            }

        }
        static void PrintMat(int[,] arr){
            
            int uBound0 = arr.GetUpperBound(0);
            int uBound1 = arr.GetUpperBound(1);

            for (int i = 0; i <= uBound0; i++){
                for(int j = 0; j <= uBound1; j++){

                    Console.WriteLine("indice: [{0}][{1}] valor: {2}", i, j, arr[i, j]);
                }      
            }
        }
    }
}
