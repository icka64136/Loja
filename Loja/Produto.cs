using System;
using System.Globalization;

namespace Loja
{
    class Produto
    {
        private string _nome; // Encapsulamento
        private double _preco;
        private int _quantidade;

        public Produto()//CONSTRUTOR
        {

        }
        public Produto(string nome, double preco, int quantidade) // Contrutor tem o mesmo Nome que a Classe .
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string GetNome()//Autorização Para o Usuario Exibir o Nome do Produto
        {
            return _nome;
        }
        public void SetNome(string nome) //Autorização Para o Usuario Mudar o Nome do Produto
        {
            if (nome != null && nome.Length > 1) // só faz a Atribuição se o nome Recebido não for Nulo e Tiver mais de um Caracteres.
            {
                _nome = nome;
            }
        }
        public double GetPreco()//Autorização Para o Usuario Exibir o Preço do Produto
        {
            return _preco;
        }
        public void SetPreco(double preco)//Autorização Para o Usuario Modificar o Preço do Produto
        {
            _preco = preco;
        }
        public int GetQuantitade()//Autorização Para o Usuario Exibir a Quantidade do Produto
        {
            return _quantidade;
        }
        public void SetQuantidade(int quantidade)//Autorização Para o Usuario Modificar a Quantidade do Produto
        {
            _quantidade = quantidade;
        }
        public double ValorTotal()
        {

            return _preco * _quantidade;
        }
        public void AdicionarProduto(int quantidade)// a Função vai ser Void Pous não vai retornar valor de Saida
        {
            _quantidade = _quantidade + quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            _quantidade = _quantidade - quantidade;
        }
        public override string ToString() // Serve para Fazer a Re Ultilização  dO Código, e Deixar o Programa Mais Limpo.
        {
            return "Produto : " + _nome + " , Preço : $" + _preco.ToString("F2", CultureInfo.InvariantCulture)
               + ", Quantidade : " + _quantidade + ", Valor Total : $" + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
