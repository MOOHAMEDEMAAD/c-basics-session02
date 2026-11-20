namespace s2_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            Book book = new Book();
            book.Pages = 15;
            book.Title = "C#";
            Console.WriteLine(book.Pages);
            Console.WriteLine(book.Title);
            #endregion

            #region q2
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
            #endregion

            #region q4
            try
            {
                int a = 10;
                int b = 0;
                int res = a / b;
                Console.WriteLine(res);
            }
            catch (Exception) {
                Console.WriteLine("Cannot divide by zero");
            }
            finally { Console.WriteLine("Done"); }

            #endregion

            #region q5
            int pages = 300;
            double Dpages = pages;
            Console.WriteLine(Dpages);
            #endregion

            #region q6
            double price = 49.99;
            int Iprice=(int)price;
            Console.WriteLine(Iprice);
            #endregion

            #region q7
            string pagesText = "464";
            int IpagesText = Convert.ToInt32(pagesText);
            Console.WriteLine(IpagesText);
            #endregion

            #region q8
            string yearText = "2023";
            int IyearText=int.Parse(yearText);
            Console.WriteLine(IyearText);
            string badText = "abc";
            int IbadText;
            bool resault = int.TryParse(badText, out IbadText);
            if (resault)
            {
                Console.WriteLine($"Vaild number -> {IbadText}");
            }
            else { Console.WriteLine("Invalid number"); }
            #endregion

            #region q9
            int newpages = 464;
            string Snewpages = newpages.ToString();
            Console.WriteLine(Snewpages.GetType());
            #endregion

            #region q10
            int copies = 100;
            object Objcopies = copies;
            Console.WriteLine($"box contains->{Objcopies}");
            int copyofCopies=(int)Objcopies;
            Console.WriteLine($"my new int->{copyofCopies}");
            #endregion





        }
    }
}
