using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStructs.Interfaces
{
    /// <summary>
    ///  Базовый интерфейс для всех очередей.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IQueue<T> : IStructure<T>
    {
        /// <summary>
        /// Заталкивает элемент в очередь.
        /// </summary>
        /// <param name="value">Заталкиваемый элемент.</param>
        void Enqueue(T value);

        /// <summary>
        /// Вытаскивает элемент из головы очереди.
        /// </summary>
        /// <returns></returns>
        T Dequeue();
    }
}
