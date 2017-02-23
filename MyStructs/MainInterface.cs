using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStructs
{
    /// <summary>
    /// Базовый интерфейс для стеков и очередей.
    /// </summary>
    /// <typeparam name="T">Тип элемента.</typeparam>
    public interface IStructurable<T> : IEnumerable<T>
    {
        /// <summary>
        /// Очищает стек.
        /// </summary>
        void Clear();

        /// <summary>
        /// Возвращает ссылку на первый элемент, не удаляя его.
        /// </summary>
        /// <returns></returns>
        T Peek();

        /// <summary>
        /// Свойство для получения количества элементов в структуре.
        /// </summary>
        int Count { get; set; }

        /// <summary>
        /// Свойство для получения заполненности структуры.
        /// </summary>
        bool isEmpty { get; set; }
    }
}
