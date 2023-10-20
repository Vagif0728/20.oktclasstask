using System.Diagnostics.SymbolStore;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            


            Libary libary = new Libary("Ad");
            Category category1 = new Category("vagif");
            //Book book = new Book("Salam", "Abdulla", category1);
            //Book book2 = new Book("Sagol", "Murad", category1);
           


            libary.ListAllBooks();

            //List<Libary> libraries = new List<Libary>();
            //List<Category> categories = new List<Category>();
            //List<Book> books = new List<Book>();




            Info();
            GetInfo();




            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Console.WriteLine("Yeni Kitabxana yarat");
                    List<Book> kitabxana = new List<Book>();

                    Book book1 = new Book("Kitab 1", "Yazar Wair 2", category1);
                    Book book2 = new Book("Kitab 2", "Yazar Wair 1", category1);

                    kitabxana.Add(book1);
                    kitabxana.Add(book2);

                    
                    Console.WriteLine("Kitabxanadaki  Kitaplar:");
                    foreach (Book book in kitabxana)
                    {
                        Console.WriteLine($"Ad: {book.Name}, Yazar: {book.Author}, ISBN: {book.Category}");
                    }
                    break;

                case 2:
                    Console.WriteLine("Yeni kategory yarat ");
                    break;

                case 3:
                    Console.WriteLine("Yeni kitab yarat");
                    break;

                case 4:
                    Console.WriteLine("Kitabxanaya daxil ol");
                    break;

                case 0:
                    Console.WriteLine("Proqramdan cix");
                    break;

                default:
                    Console.WriteLine("melumati duzgun daxil edin !!!");
                    Info();
                    GetInfo();
                    break;
            }






            








        }



        public static void Info()
        {
            Console.WriteLine("[1] Yeni Kitabxana yarat");
            Console.WriteLine("[2] Yeni kategory yarat ");
            Console.WriteLine("[3] Yeni kitab yarat");
            Console.WriteLine("[4] Kitabxanaya daxil ol");
            Console.WriteLine("[0] Proqramdan cix");


        }

        public static void GetInfo()
        {
            //int choose=int.Parse(Console.ReadLine());
          
            //switch (choose)
            //{
            //    case 1:
            //        Console.WriteLine("Yeni Kitabxana yarat");
                    
            //        break;

            //    case 2:
            //        Console.WriteLine("Yeni kategory yarat ");
            //        break;

            //    case 3:
            //        Console.WriteLine("Yeni kitab yarat");
            //        break;

            //    case 4:
            //        Console.WriteLine("Kitabxanaya daxil ol");
            //        break;

            //    case 0:
            //        Console.WriteLine("Proqramdan cix");
            //        break;

            //    default:
            //        Console.WriteLine("melumati duzgun daxil edin !!!");
            //        Info();
            //        GetInfo();
            //            break;
            //}
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }   }