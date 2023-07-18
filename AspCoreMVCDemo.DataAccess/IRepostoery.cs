using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspCoreMVCDemo.DataAccess
{
    public interface IRepostoery<T>
    {
        List<T> GetAll();
        List<T> Search(String search);
        T Finde(int Id);

        void Add(T item);
        void Remove(T item);
        void Edit (int Id, T item);
    }
}
