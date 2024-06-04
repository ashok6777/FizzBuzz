namespace FizzBuzzMvcApp.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public List<string> ProcessArray(string[] values)
        {
            List<string> results = new List<string>();

            foreach (var value in values)
            {
                if (int.TryParse(value, out int number))
                {
                    bool divisibleBy3 = number % 3 == 0;
                    bool divisibleBy5 = number % 5 == 0;

                    if (divisibleBy3 && divisibleBy5)
                    {
                        results.Add("FizzBuzz");
                    }
                    else if (divisibleBy3)
                    {
                        results.Add("Fizz");
                    }
                    else if (divisibleBy5)
                    {
                        results.Add("Buzz");
                    }
                    else
                    {
                        results.Add($"Divided {number} by 3");
                        results.Add($"Divided {number} by 5");
                    }
                }
                else
                {
                    results.Add("Invalid item");
                }
            }

            return results;
        }
    }
}
