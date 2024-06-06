namespace quiz.net_intermediate;

public class Stack : IQuizz
{
  /* 
  A) {stack.Pop()},{stack.Peek()},{stack.Pop()}
  B) 4,3,3
  C) 1,2,2
  D) Une erreur de compilation lors de l'initialisation de la propriété '=' token invalid 
  dans class struc ou declaration de membre d'interface
  */

    public static int stackLine { get; set; } = 4;

    public void runQuizz()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(stackLine);
        Console.WriteLine($"{stack.Pop()},{stack.Peek()},{stack.Pop()}");
    }
}
