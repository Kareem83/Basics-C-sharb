namespace switchh_statement
{
    internal class Program
    {
        /* [control flow : switch statement]
                                    syntax =>    switch (# variable to check on it <must be string>) {
                                                        case "# the condition" :
                                                              # body of the case
                                                         break;  <<= to close the scope of the current case
                                                         
                                                         default:   <= its like else to end the switch statement
                                                          # body of the case
                                                         break; 
         */
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("please enter a string :");
                string s = Console.ReadLine();

                Console.WriteLine(@"              ##  MENU  ##
                      
                               press '1' to convert the string to uppercase
                               press '2' to convert the string to lowercase
                               press '3' to convert the string to show string");

                Console.WriteLine("please enter your choice =");
                string x = Console.ReadLine();

                switch (x)
                {
                    case "1":
                        Console.WriteLine(s.ToUpper());
                        break;

                    case "2":
                        Console.WriteLine(s.ToLower());
                        break;

                    case "3":
                        Console.WriteLine(s);
                        break;

                    default:
                        Console.WriteLine("invalid input ! ");
                        break;

                }
            }
        }
    }
}
