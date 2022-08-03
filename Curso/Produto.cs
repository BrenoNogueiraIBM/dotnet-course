using System;
using System.Globalization;

namespace Curso
{
    internal class Produto
    {
        public string _nome;
        public int Quantidade { get; set; }

        public double Preco { get; private set; }


        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1   )
                    _nome = value;
            }
        }

        public Produto(string nome)
        {
            _nome = nome ?? throw new ArgumentNullException(nameof(nome));
        }

        public Produto(string nome, double preco, int quantidade) : this(nome)
        {
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) : this(nome)
        {
            Preco = preco;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }



        public override string ToString()
        {
            return _nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
