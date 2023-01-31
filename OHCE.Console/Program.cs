using OHCE;

namespace OHCE.Program;
public class Program
{
        //Test manuelle par rapport au information système
        static void Main(string[] args)
        {
            var ohce = new Ohce();
            Console.WriteLine(ohce.Palindrome());
        }
    
}


