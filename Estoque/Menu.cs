using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    internal class Menu
    {
        List<Estoque> listaDeEstoque = new List<Estoque>();
        public void MenuPrincipal()
        {
            Console.WriteLine($"Guardador de produtos!\n\n");
            Console.WriteLine("Digite 1 para para cadastrar um estoque.");
            Console.WriteLine("Digite 2 para para cadastrar um produto.");
            Console.WriteLine("Digite 3 para ver lista de estoque.");
            Console.WriteLine("Digite 4 para ver lista de produtos.\n");
            string numeroLetra = Console.ReadLine()!;
            int opcao;

            bool sucesso = int.TryParse(numeroLetra, out opcao);

            if (sucesso)
            {
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        CadastrarEstoque();
                        break;
                    case 2:
                        Console.Clear();
                        CadastrarProduto();
                        break;
                    case 3:
                        Console.Clear();
                        ListaEstoques();
                        break;
                    case 4:
                        Console.Clear();
                        ListaProdutos();
                        break;
                    default:
                        Console.WriteLine("Número digitado incorreto, digite 1,2,3 ou 4");
                        Thread.Sleep(4000);
                        Console.Clear();
                        MenuPrincipal();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Você deve digitar apenas um dos número 1,2,3 ou 4");
                Thread.Sleep(4000);
                Console.Clear();
                MenuPrincipal();
            }
        }

        public void CadastrarEstoque()
        {
            Console.WriteLine("Digite o nome do estoque de deseja cadastrar\n");
            string nomeEstoque = Console.ReadLine()!;
            Estoque novoEstoque = new Estoque();
            novoEstoque.estoqueNome = nomeEstoque;
            listaDeEstoque.Add(novoEstoque);
            Console.WriteLine($"\nO estoque {nomeEstoque} foi cadastrado com sucesso!");
            Thread.Sleep (3000);
            Console.Clear();
            MenuPrincipal();
        }
        public void CadastrarProduto()
        {

        }
        public void ListaEstoques()
        {
            Console.WriteLine("Lista de estoque cadastrados \n\n");
            foreach (Estoque estoqueCadastrado in listaDeEstoque)
            {
                Console.WriteLine(estoqueCadastrado.estoqueNome);
            }
            Console.WriteLine("\nDigite qualquer tecla para sair!");
            Console.ReadKey();
            MenuPrincipal();
        }
        public void ListaProdutos()
        {

        }

    }
}
