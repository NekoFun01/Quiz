class Quiz
{
    static void Main(string[]args)
    {
        Console.WriteLine("input number of singer");
        int Nsinger = int.Parse(Console.ReadLine());
        Console.Write("");
        int Krubsinger = int.Parse(Console.ReadLine());
        int i = 0;
       if(1 < Nsinger && Nsinger <= 10000 && 1 <= Krubsinger && Krubsinger <=1000)
       {
        while (i < Nsinger)
        {
            i++;
            Console.WriteLine("input gender singer");
           int gender = int.Parse(Console.ReadLine());
            Console.WriteLine("input Point singer");
            int point1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input Point singer");
            int point2 = int.Parse(Console.ReadLine());
            Pointer(point1,point2);
        }
        

       }


    }
    static int Pointer(int x,int y)
    {
        int point1 = x;
        int point2 = y;
        return point1;
    }
}