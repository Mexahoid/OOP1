using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStructs.Interfaces
{
    /// <summary>
    /// Базовый интерфейс для стеков и очередей.
    /// </summary>
    /// <typeparam name="T">Тип элемента.</typeparam>
    public interface IStructure<T> : IEnumerable<T>
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
        int Count { get; }

        /// <summary>
        /// Свойство для получения заполненности структуры.
        /// </summary>
        bool IsEmpty { get; }
    }
}
