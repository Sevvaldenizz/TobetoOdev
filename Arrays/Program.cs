namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            students2[3] = "Ahmet";

            string[] students2 = { "Engin", "Derin", "Salih" }; 
        

            foreach (var student in students) 
            {
                Console.WriteLine(student);            
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}