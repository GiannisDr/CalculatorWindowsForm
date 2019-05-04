using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class ActionClass
    {
        public float AdditionAct(float a ,float b)
        {
            return a + b;
        }

        public float MultiplicationAct(float a, float b)
        {
            return a * b;
        }

        public float SubtractionAct(float a , float b)
        {
            return a - b;
        }

        public float DivisionAct(float a, float b)
        {
            return a / b;
        }

        public string Results(int status , float numbOne , string numbTwoStr)
        {
            string resultStr = " ";
            float resultFloat;
            float secondNumber;
            secondNumber = float.Parse(numbTwoStr);
           switch(status)
            {
                case 1:
                     resultFloat  = AdditionAct(numbOne, secondNumber);
                    resultStr = numbOne + "+" + secondNumber + "=" + resultFloat.ToString();
                    break;
                case 2:
                    resultFloat = MultiplicationAct(numbOne, secondNumber);
                    resultStr = numbOne + "*" + secondNumber + "=" + resultFloat.ToString();
                    break;
                case 3:
                    resultFloat = DivisionAct(numbOne, secondNumber);
                    resultStr = numbOne + "/" + secondNumber + "=" + resultFloat.ToString();
                    break;
                case 4:
                    resultFloat = SubtractionAct(numbOne, secondNumber);
                    resultStr = numbOne + "-" + secondNumber + "=" + resultFloat.ToString();
                    break;
            }


            
            return resultStr;
        }

    }
}
