using System.ComponentModel.Design;
using System.Linq;

Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(10);
pilha.Push(20);
pilha.Push(12);
pilha.Push(6);

var ultimoItem = pilha.Peek();

for (int i = 0; i < 10; i++)
{
    if (pilha.ElementAt(i) % 2 == 0)
    {
    Console.WriteLine($"Linha {i} - [{pilha.ElementAt(i)}]");
    }

    if (pilha.ElementAt(i) % 3 == 0)
    {
        Console.WriteLine($"Linha {i} - [{pilha.ElementAt(i)}]");
    }
}

