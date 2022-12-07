
using System.ComponentModel.Design;

namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }
        else
        {
            var numbers2 = numbers.Split(',');
            var solution = 0;
            foreach (var number in numbers2)
            {

                solution += int.Parse(number);



            }
                return solution;
        }
    }
}
