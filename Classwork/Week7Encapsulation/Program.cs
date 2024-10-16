namespace Week7Encapsulation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----------Private Bank  Account----------");
        PrivateBankAccount pba1 = new PrivateBankAccount();
        pba1.SaveMoney(1000);
        Console.WriteLine($"Private Account Balance is: {pba1.ShowBalance()}");
        pba1.TakeMoney(500);
        Console.WriteLine($"Private Account Balance is now: {pba1.ShowBalance()}");

        Console.WriteLine();

        Console.WriteLine("----------Credit Card----------");
        CreditCard card1 = new CreditCard();
        card1.SetCardNumber(132645798);
        Console.WriteLine($"Card Number is: {card1.GetCardNumber()}");
        card1.cardPin = 1324;
        Console.WriteLine($"Card Pin is: {card1.cardPin}");

    }
}
