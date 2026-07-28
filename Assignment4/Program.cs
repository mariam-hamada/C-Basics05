namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            ////Add a private string password = "secret"; field to a Book class. Try to print it from Main(outside the class). What happens, and why?

            //Book book = new Book();
            ////the program will not compile as the passowrd is a private member to the class so it will be seen only inside the class scope
            //Console.WriteLine(book.password);
            #endregion

            #region Question2
            ////Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile?Why ?

            //Book book = new Book();
            ////yes it will compile and print 5 , as the member is internal so it is seen inside our solution (same namespace)
            //Console.WriteLine(book.copiesInStock);
            #endregion

            #region Question3
            //Add a public string Title; field to Book. Set it and print it from Main.

            //Book book = new Book();
            //book.Title = "C# course";
            //Console.WriteLine($"the Title is: {book.Title}");
            #endregion


        }
    }
}
