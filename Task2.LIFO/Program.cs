// See https://aka.ms/new-console-template for more information

using Task2.LIFO;

int max = 5;
var myStack = new Task2.LIFO.Stack<int>(max);
for (int i = 1; i <= max; i++)
{
    myStack.Push(i);
    Console.WriteLine($"Push({i})");
}
Console.WriteLine($"LAST IN:{max}. Item stack is now full.");
try
{
    //myStack.Push(6);

}
catch (IndexOutOfRangeException ex)
{

    throw new ArgumentException("Index is out of range", nameof(max), ex);
}
int stackLength = myStack.Count;
Console.WriteLine($"FIRST OUT: {max}");
for (int i = 0; i < stackLength; i++)
{
    Console.WriteLine($"Pop() attempt No.{i + 1} result: {myStack.Pop()}");
}
Console.WriteLine($"Stack is now empty?: {myStack.IsEmpty()}");
try
{
    //myStack.Pop();
}
catch (InvalidOperationException)
{

    throw new ArgumentException("Stack is empty. Cannot Pop anymore elements");
}
var myReversedStack = new Task2.LIFO.Stack<int>(max);
Console.WriteLine();
Console.WriteLine("Displaying Reversed Stack:");
StackExtensions.Reverse(myReversedStack);
for (int i = 1; i <= max; i++)
{
    myReversedStack.Push(i);
    Console.WriteLine($"Push({i})");
}