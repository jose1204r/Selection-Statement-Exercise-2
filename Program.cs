namespace SelectionStatementExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***School Subject***");


            Console.WriteLine("What is your faverotite subject ?");
            var usersubject = Console.ReadLine();

            switch (usersubject)

                // 5 case created 
            {

                case "math":

                    {

                        Console.WriteLine($"Incredible!  {usersubject} provides an effective way of building mental discipline and encourages logical reasoning and mental rigor. In addition, mathematical knowledge plays a crucial role in understanding the contents of other school subjects such as science, social studies, and even music and art. ");
                        break;

                    }


                case "science":

                    {
                        Console.WriteLine($" Great!    {usersubject} education gives students the opportunity to gain a better knowledge of how and why things function.");
                        break;


                    }

                case "language arts":
                    {

                        Console.WriteLine($"Exellent!  {usersubject}, we learn to appreciate, integrate, and apply what is learned for real purposes in our homes, schools, communities, and workplaces.");
                        break;
                    }

                case "social studies":
                    {
                        Console.WriteLine($"Awsome!   {usersubject} is to help young people develop the ability to make informed and reasoned decisions for the public good as citizens of a culturally diverse, democratic society in an interdependent world. ");
                        break;
                    }


                case "writting":
                    {
                        Console.WriteLine($"Fantastic!   {usersubject} improves a student's ability to recall information, make connections between different concepts, and synthesize information in new ways.");
                        break;
                    }

                default:

                    {  
                        Console.WriteLine($"Opps! {usersubject} subject is not included in the categories!");
                        break;

                    }

            }
        }
    }
}