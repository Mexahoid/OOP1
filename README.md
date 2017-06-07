# OOP1

Разработать библиотеку обобщенных классов для работы с ассоциативными множествами. В структуру классов входят как минимум:

•	IStack<T>: IEnumerable<T> – базовый интерфейс для всех стеков;

  •	методы:
  
    	void Push(T value);
    
    	void Clear();
    
    	T Pop();
    
    	T Peek();
    
  o	свойства:
  
    	int Count;
    
    	bool isEmpty;
    
•	StackException – класс, описывающий исключения, которые могут происходить в ходе работы cо стеком (также можно написать ряд наследников от StackException);

•	ArrayStack<T>: IStack<T> – класс стека на основе массива;

•	LinkedStack<T>: IStack<T> – класс стека на основе связанного списка;

•	IQueue<T>: IEnumerable<T> – базовый интерфейс для всех очередей;

  •	методы:
  
    	void Enqueue(T value);
    
    	void Clear();
    
    	T Dequeue();
    
    	T Peek();
    
  •	свойства:
  
    	int Count;
    
    	bool isEmpty;
    
•	ArrayQueue<T>: IQueue<T> – класс очереди на основе массива;

•	LinkedQueue<T>: IQueue<T> – класс очереди на основе связанного списка;

•	PriorityQueue<T>: IQueue<T> where T: IComparable – класс очереди с приоритетами объектов;

Также необходимо разработать серию примеров, демострирующих основные аспекты работы с данной библиотекой стеков и очередей.
