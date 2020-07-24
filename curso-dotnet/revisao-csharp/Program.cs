using System;
using System.Collections.Generic;

namespace revisao_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Opcoes op = new Opcoes();
            string opcaoUser = "";
            while (true)
            {
                opcaoUser = ObterOpcaoUsuario().ToUpper();
                if (opcaoUser == "X") break;
                Console.WriteLine(op.SelecionarOpcao(opcaoUser));
            }
        }
        private static string ObterOpcaoUsuario(){
            string[] mensagens = new string[]
            {
                "Informe a opção desejada:",
                "1- Inserir novo aluno",
                "2- Listar alunos",
                "3- Calcular média geral",
                "X- Sair"
            };
            foreach (var msg in mensagens)
            {
                Console.WriteLine(msg);
            }
            
            return Console.ReadLine();
        }
        public class Opcoes{
            public Opcoes (){
                this.opcoes_dict["1"] = this.InserirAluno();
                this.opcoes_dict["2"] = this.ListarAluno();
                this.opcoes_dict["3"] = this.CalcularMedia();
            }
            public string SelecionarOpcao(string opcao){
                return this.opcoes_dict[opcao];
            }
            private Dictionary<string,string> opcoes_dict = new Dictionary<string,string>();
            private string InserirAluno(){return "Inserir aluno";}
            private string ListarAluno(){return "listar aluno";}
            private string CalcularMedia(){return "calcular Media";}
            }
    }
}
