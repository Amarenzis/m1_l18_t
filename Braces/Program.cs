using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку со скобками");
            string task = Console.ReadLine();

            Stack<char> reverseBracesStack = new Stack<char>();
            char compareBraces;
            bool rightBraces = true;

            foreach (char symbol in task)
            {
                switch (symbol)
                {
                    //Делаем обратные скобки в stack
                    case '{':
                        reverseBracesStack.Push('}');
                        break;
                    case '(':
                        reverseBracesStack.Push(')');
                        break;
                    case '[':
                        reverseBracesStack.Push(']');
                        break;

                    //Сравниваем обратные скобки с последними добавленными в stack
                    case '}':
                        compareBraces = reverseBracesStack.Pop();
                        if (symbol != compareBraces)
                        {
                            rightBraces = false;
                        }
                        break;
                    case ')':
                        compareBraces = reverseBracesStack.Pop();
                        if (symbol != compareBraces)
                        {
                            rightBraces = false;
                        }
                        break;
                    case ']':
                        compareBraces = reverseBracesStack.Pop();
                        if (symbol != compareBraces)
                        {
                            rightBraces = false;
                        }
                        break;
                    default:
                        break;
                }
            }
            if (rightBraces)
            {
                Console.WriteLine("Скобки расставлены верно.");
            }
            else
            {
                Console.WriteLine("Скобки расставлены неверно.");
            }
            Console.ReadKey();


        }
    }
}
