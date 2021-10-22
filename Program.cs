using System;
using System.Text;

namespace Demo_userdefined_Aattribute
{
    [Author_Attributes("P.Hanselman")]
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Demo user Define Attributes...!!!");
            Author_Attributes A1 = new Author_Attributes("Manjith Singh");

            Console.WriteLine("By Default Version of Author is : \t{0}", A1.Version_name);
        }
    }
    [System.AttributeUsage(System.AttributeTargets.Class|System.AttributeTargets.Struct)]

    public class Author_Attributes : System.Attribute
    {
        private string AuthorName;
        public Double Version_name;

        public Author_Attributes(string name)
        {
            this.AuthorName = name;
            this.Version_name = 5.0;
            Console.WriteLine("Author name is : \t{0}", name);

        }
    }
}
