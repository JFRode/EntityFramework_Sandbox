using EntitySandbox.context;
using EntitySandbox.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySandbox.application
{
    class ClienteAplicacao
    {
        public DbContext banco { get; set; }

        public ClienteAplicacao()
        {
            banco = new DbContext();
        }

        public void salvar(Cliente cliente)
        {
            banco.Clientes.Add(cliente);
            banco.SaveChanges();
        }

        public IEnumerable<Cliente> listar()
        {
            return from c in banco.Clientes select c;
        }

        public void alterar(Cliente cliente)
        {
            Cliente clienteAux = banco.Clientes.Where(x => x.Id == cliente.Id).First();
            clienteAux.nome = cliente.nome;
            clienteAux.cpf = cliente.cpf;
            banco.SaveChanges();
        }

        public void excluir(int Id)
        {
            Cliente clienteExclusao = banco.Clientes.Where(x => x.Id == Id).First();
            banco.Set<Cliente>().Remove(clienteExclusao);
            banco.SaveChanges();
        }
    }
}
