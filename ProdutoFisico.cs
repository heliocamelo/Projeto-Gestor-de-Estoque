using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_estoque
{
    [System.Serializable]
    class ProdutoFisico : Produto, IEstoque
    {
        public float frete;
        private int estoque;

        public ProdutoFisico(string nome, float preco, float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete; 
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar entrada do produto {nome}");
            Console.WriteLine("Digite a qunatidade que você quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            estoque = estoque + entrada;
            Console.WriteLine("Entrada registrada");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar saída no estoque do produto {nome}");
            Console.WriteLine("Digite a quantidade que você quer dar baixa: ");
            int entrada = int.Parse(Console.ReadLine());
            estoque = estoque - entrada;
            Console.WriteLine("Saída registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Frete: {frete}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Quantidade em estoque: {estoque}");
            Console.WriteLine("===============================");
        }
    }
}
