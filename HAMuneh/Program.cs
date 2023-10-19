namespace HAMuneh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm here for muneh! MUNEH!");
            Console.WriteLine();
            try
            {
                Money money1 = new Money(10, 50);
                Money money2 = new Money(5, 75);

                Console.WriteLine($"Счет 1: {money1.ToString()}");
                Console.WriteLine($"Счет 2: {money2.ToString()}");

                Money sum = money1 + money2;
                Console.WriteLine($"Сумма: {sum.ToString()}");

                Money difference = money1 - money2;
                Console.WriteLine($"Разность: {difference.ToString()}");

                Money quotient = money1 / 2;
                Console.WriteLine($"Коэффициент: {quotient.ToString()}");

                Money product = money2 * 3;
                Console.WriteLine($"Рез-т умножения: {product.ToString()}");

                Money increment = ++money1;
                Console.WriteLine($"Инкремент: {increment.ToString()}");

                Money decrement = --money2;
                Console.WriteLine($"Декремент: {decrement.ToString()}");

                bool isLess = money1 < money2;
                Console.WriteLine($"Счет 1 < Счет 2: {isLess}");

                bool isGreater = money1 > money2;
                Console.WriteLine($"Счет 1 > Счет 2: {isGreater}");

                bool isEqual = money1 == money2;
                Console.WriteLine($"Счет 1 == Счет2: {isEqual}");

                bool isNotEqual = money1 != money2;
                Console.WriteLine($"Счет 1 != Счет 2: {isNotEqual}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}