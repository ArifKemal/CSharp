internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("*******INTERFACE*******");
        Focus focus = new Focus();
        System.Console.WriteLine(focus.HangiMarka().ToString());
        System.Console.WriteLine(focus.KacTeker().ToString());
        System.Console.WriteLine(focus.HangiRenk().ToString());


        System.Console.WriteLine("**********ABSTRACT**********");

        NewFocus focus1 = new NewFocus();
        System.Console.WriteLine(focus1.HangiMarka().ToString());
        System.Console.WriteLine(focus1.KacTeker().ToString());
        System.Console.WriteLine(focus1.HangiRenk().ToString());




    }
}