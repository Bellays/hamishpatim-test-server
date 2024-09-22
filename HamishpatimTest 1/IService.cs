using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HamishpatimTest_1
{
    public interface IService<T>
    {
        public T GetById(int id);
        public List<T> GetAll();
        public void AddItem(T item);
        public void UpdateItem(int id, T item);
        public void DeleteItem(int id);
    }
}

