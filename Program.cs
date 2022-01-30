using System;
using CadastroDio.Classes;

namespace CadastroDio{

    class Program{

        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string [] args){
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario!="X"){

                switch(opcaoUsuario){
                    case "1":
                        ListarSeries();
                        break;

                    case "2":
                        InserirSerie();
                        break;

                    case "3":
                        AtualizarSerie();
                        break;

                    case "4":
                        ExcluiSerie();
                        break;

                    case "5":
                        VisualizarSerie();
                        break;

                    case "C":
                    Console.Clear();
                        break;


                    default:
                        throw new ArgumentOutOfRangeException(); 



                }

                opcaoUsuario = ObterOpcaoUsuario();


            }

            Console.WriteLine("O projeto está sendo finalizado");
            Console.ReadLine();


        }


        private static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("Projeto DIO SERIES");
            Console.WriteLine("Informe  a opção desejada");

            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir uma nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C- Limpar console");
            Console.WriteLine("X- Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;


        }

        private static void ListarSeries(){
            Console.WriteLine("Listar séries");

            var lista = repositorio.Lista();

            if (lista.Count == 0){
                Console.WriteLine("Nennhuma série foi cadastrada");

            }
            else{
                foreach(var serie in lista){
                    
                    var excluido = serie.retornaExcluido();
                    Console.WriteLine("#ID {0}: - {1} {2}", serie.RetornaiId(), serie.RetornaTitulo(), (excluido ? "*Excluído*" : ""));

                }
            }
        }

        private static void InserirSerie(){

            Console.WriteLine("Inserir nova série");

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                
            }

            Console.WriteLine("Digite o id do genero da serie");
            int genero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo da serie");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o ano da serie");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da serie");
            string descricao = Console.ReadLine();



            Serie novaserie = new Serie(id:repositorio.ProximoID(), Ano: ano, Titulo: titulo,Descricao: descricao,genero: (Genero)genero);
            repositorio.Insere(novaserie);
            
        } 

        private static void AtualizarSerie(){
            Console.WriteLine("Digite o id da série");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));;
                
            }

            Console.WriteLine("Digite o id do genero da série");
            int genero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título da série");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o ano da série");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da da série");
            string descricao = Console.ReadLine();



            Serie AtualizaSerie = new Serie(id:indiceSerie, Ano: ano, Titulo: titulo,Descricao: descricao,genero: (Genero)genero);
            repositorio.Atualiza(indiceSerie,AtualizaSerie);





        }
        private static void ExcluiSerie(){
            Console.WriteLine("Digite o id da série que deseja excluir");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceSerie);


        }

        private static void VisualizarSerie(){

            Console.WriteLine("Digite o id da série que deseja pesquisar");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie.ToString());
        }

    }
}
