namespace Gali
{
    class Gopi
    {
        static void Main(string[] args)
        {
            string name,rollno;
            int s1, s2, s3, s4, s5;
            Console.WriteLine("Student marks");
            Console.Write("Name     :");
            name = Console.ReadLine();
            // Console.WriteLine(name);
            Console.Write("RollNo   :");
            rollno = Console.ReadLine();
            //Console.WriteLine("ROLL NO" + rollno);
            Console.WriteLine("        3-2 Sem result         ");
            Console.Write("S1:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("S2:");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("S3:");
            s3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("S4:");
            s4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("S5:");
            s5 = Convert.ToInt32(Console.ReadLine());
            /*Console.WriteLine("s1:" + s1);
            Console.WriteLine("s2:" + s2);
            Console.WriteLine("s3:" + s3);
            Console.WriteLine("s4:" + s4);
            Console.WriteLine("s5:" + s5);*/
            double total = s1 + s2 + s3 + s4 + s5;
            Console.WriteLine("total marks   =" + total);
            Console.WriteLine("percentage    =" + (total / 500) * 100+"%");

        }
    }
}