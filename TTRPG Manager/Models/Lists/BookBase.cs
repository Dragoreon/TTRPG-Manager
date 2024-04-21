using System.Collections.Generic;

namespace TTRPG_Manager.Models.Lists
{
    /// <summary>
    /// Clase base para manejar listas. Contiene los métodos de añadir y quitar, así como de devolver todos o borrar todos.
    /// </summary>
    public class BookBase<T>
    {
        protected List<T> _items;

        public BookBase()
        {
            _items = new List<T>();
        }

        public virtual void Add(T item)
        {
            _items.Add(item);
        }

        public virtual void Remove(T item)
        {
            _items.Remove(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }

        public void RemoveAll()
        {
            _items.Clear();
        }

    }
}
