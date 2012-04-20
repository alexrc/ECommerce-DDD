using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Domain.Repository
{
    public interface IRepository<T> where T : new()
    {
        void Inserir(T t);
        void Atualizar(T t);
        void Deletar(T t);
        T BuscarPorId(object id);
        IQueryable<T> BuscarLista();
    }
}
