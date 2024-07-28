namespace Task_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter Rectangle width :  ");
            int Width = int.Parse(Console.ReadLine());
            
            Console.Write("Enter Rectangle hight:  ");
            int Hight = int.Parse(Console.ReadLine());

            if (Width == Hight) 
            {
                Console.Write("The information you inserted is for a Square ");
            }
            else
            {
                Console.Write("The information you inserted is for a Rectangle");
            }
           
        }
    }
}
