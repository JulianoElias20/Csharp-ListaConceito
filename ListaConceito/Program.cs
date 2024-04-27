using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Juliano"); //Inserindo na lista com o add


            list.Insert(0,"Marco"); // Inserindo na lista com o insert, neste caso podemos escolher a posição

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Tamanho da lista "+list.Count); // Tamanho da lista



            /*Neste caso ele está procurando na lista o primeiro nome que tem a primeira letra começando com J*/
            //Sempre irá procurar o primeiro com o FIND
            string s1 = list.Find(x => x[0] == 'J'); 
            Console.WriteLine(s1);



            /*Neste caso ele está procurando na lista o último nome que tem a primeira letra começando com M*/
            //Sempre irá procurar o ultimo com o FINDLast
            string s2 = list.FindLast(x => x[0] == 'M');
            Console.WriteLine(s2);



            /*Neste caso irá procurar a posição do primeiro elemento que começa com a letra J*/
            //Find Index sempre procura o primeiro elemento
            int posi1 = list.FindIndex(x => x[0] == 'J');



            /*Neste caso irá procurar a posição do último elemento que começa com a letra M*/
            //FindLastIndex sempre procura o último elemento
            int posi2 = list.FindLastIndex(x => x[0] == 'M');



            /*Neste caso criamos uma outra lista com todos os elementos que possuam 5 caracteres*/
            /*FindAll irá filtrar a lista original com base em uma condição*/
            List<string> list2 = list.FindAll(x => x.Length == 5);


            //Remove da lista
            list.Remove("Juliano");



            /*Irá remover todos os nomes que comecam com M*/
            //Remove All irá remover todos com base em uma condição
            list.RemoveAll(x => x[0] == 'M');

            /*Remove o elemento dado a posição em que ele está*/
            list.RemoveAt(0);

            /*A partir de uma posição, remove x elementos*/
            list.RemoveRange(2, 2);


        }
    }
}