using System;  
  
namespace DateTimeFormatInCSharpSample  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
              
            DateTime aDate = DateTime.Now;  
              Console.WriteLine(aDate.ToString("MMMM/dddd"));  
              
            Console.ReadKey();  
        }  
    }  
}  
  