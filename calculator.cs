using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorWithClass
{
    class calculator
    {
        int num1, num2, result; // decline the variables
        public string add( string firstnumber, string secondnumber) // Function to perfrom addition of two numbers
        {
            num1 = int.Parse(firstnumber);
            num2 = int.Parse(secondnumber);
            result = num1 + num2;
            return result.ToString();
        }

        public string sub(string firstnumber, string secondnumber)//function to perferom subration
        {
            num1 = int.Parse(firstnumber);
            num2 = int.Parse(secondnumber);
            result = num1 - num2;
            return result.ToString();
        }

        public string mul(string firstnumber, string secondnumber) //function to perform multipilcation
        {
            num1 = int.Parse(firstnumber);
            num2 = int.Parse(secondnumber);
            result = num1 * num2;
            return result.ToString();
        }

        public string div(string firstnumber, string secondnumber)// function to perfrom division
        {
            num1 = int.Parse(firstnumber);
            num2 = int.Parse(secondnumber);
            result = num1 / num2;
            return result.ToString();
        }

     
    }
}
