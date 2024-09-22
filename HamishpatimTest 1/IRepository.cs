using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamishpatimTest_1
{
    public interface IRepository<T>
    {
        public List<T> getAll();
        public T get(int id);
        public void AddItem(T item);
        public void UpdateItem(int id, T item);
        public void DeleteItem(int id);
    }
}
