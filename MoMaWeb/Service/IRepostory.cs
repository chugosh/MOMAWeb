using System.Collections.Generic;
using MoMaWeb.ServiceImpl;

namespace MoMaWeb.Service
{
    public interface IRepostory<T> where T : class
    {
        IEnumerable<T> GetList();
        T Add(T s);
    } 
}