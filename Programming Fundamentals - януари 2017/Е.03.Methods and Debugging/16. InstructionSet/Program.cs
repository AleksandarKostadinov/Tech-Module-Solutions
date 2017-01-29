using System;

class InstructionSet_broken
{
    static void Main()
    {
        do
        {
            string input = Console.ReadLine();

            string[] codeArgs = input.Split(' ');

            long result = 0;

            if (codeArgs[0] == "END")
            {
                break;
            }
            else if (codeArgs[0] == "INC")
            {
                long operandOne = long.Parse(codeArgs[1]);
                result = operandOne + 1;
            }
            else if (codeArgs[0] == "DEC")
            {
                long operandOne = long.Parse(codeArgs[1]);
                result = --operandOne;
            }
            else if (codeArgs[0] == "ADD")
            {
                long operandOne = long.Parse(codeArgs[1]);
                long operandTwo = long.Parse(codeArgs[2]);
                result = operandOne + operandTwo;
            }
            else if (codeArgs[0] == "MLA")
            {
                long operandOne = long.Parse(codeArgs[1]);
                long operandTwo = long.Parse(codeArgs[2]);
                result = operandOne * operandTwo;
            }
            
            Console.WriteLine(result);
        } while (true);
    }
}