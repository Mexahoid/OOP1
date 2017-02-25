using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStructs.Stacks
{
    /// <summary>
    /// Класс исключений для стеков.
    /// </summary>
    public class StackException
    {
        public class EmptyStackException : Exception
        {
            public override string Message => "Исключение заполненности. Стек пуст.";
        }
        public class NullCollectionException : Exception
        {
            public override string Message => "Исключение входного параметра. Пустая коллекция.";
        }
    }
}
