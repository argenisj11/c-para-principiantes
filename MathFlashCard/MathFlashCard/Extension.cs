using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathFlashCard
{
    public static class Extension
    {
        public static string GetSymbol(this OperationEnum _operation) {
            switch (_operation)
            {
                case OperationEnum.Multiplication: return "x";
                  
                case OperationEnum.Addition:  return "+";
                    
                default:
                    throw new Exception("Operation not supported");
            }

        }


        public static int getResul(this OperationEnum operation ,int _number1,  int _number2)
        {
            switch (operation)
            {
                case OperationEnum.Multiplication: return _number1 * _number2;
                case OperationEnum.Addition: return _number1 + _number2;
                default: throw new Exception("Operation Null");
            }
        }
    }
}
