namespace MyStructs.Interfaces
{
    /// <summary>
    /// Базовый интерфейс для всех стеков.
    /// </summary>
    /// <typeparam name="T">Тип элементов структуры.</typeparam>
    public interface IStack<T> : IStructure<T>
    {
        /// <summary>
        /// Заталкивает элемент в стек.
        /// </summary>
        /// <param name="Value">Значение, добавляемое в стек.</param>
        void Push(T value);

        /// <summary>
        /// Дает ссылку на верхний, удаляя.
        /// </summary>
        /// <returns></returns>
        T Pop();
    }
}
