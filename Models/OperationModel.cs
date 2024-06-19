using System;
namespace Calculator.Models
{
    public class OperationModel
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public string operation { get; set; }

        public void Addition()
        {
            z = x + y;
        }

        public void Subtract()
        {
            z = x - y;
        }

        public void Multiply()
        {
            z = x * y;
        }

        public void Division()
        {
            if (y != 0)
            {
                z = x / y;

            }
        
        }
    }
}

