using System;

namespace SyntaxSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            int anwser = 4;
            string response;

            if (anwser < 9)
            {
                response = anwser + "is less than 9";
            }
            else
            {
                response = anwser + "greater than or equal to 9";
            }
            {// im not sure why the response is underlined in red??
                var response = (anwser < 9) ? $"{anwser} is less than 9" : $"{anwser} is greater than or equal to 9";
            }
            {//but a cap "R" is good???
                var Response = (anwser < 9) ? $"{anwser} is less than 9" : $"{anwser} is greater than or equal to 9";
            }
            

            
            
            




        }
    }
}
