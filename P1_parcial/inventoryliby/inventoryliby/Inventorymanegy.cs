using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventoryliby
{
    public class Inventorymanegy
    {
        private List<Produto> _produtos;
        private int _nextId = 1;

        public Inventorymanegy()
        {
            _produtos = new List<Produto>();
        }

        public void AdicionarProduto(string nome, string descricao, decimal preco)
        {
            var produto = new Produto
            {
                Id = _nextId++,
                Nome = nome,
                Descricao = descricao,
                Preco = preco
            };
            _produtos.Add(produto);
        }

        public void RemoverProduto(int id)
        {
            var produto = _produtos.FirstOrDefault(p => p.Id == id);
            if (produto != null)
            {
                _produtos.Remove(produto);
            }
        }

        public Produto? obterProdutosPorId(int Id)
        {
            return _produtos.FirstOrDefault(p => p.Id == Id);
        }

        public List<Produto> ObterTodosProdutos()
        {
            return _produtos;
        }

    }
}
