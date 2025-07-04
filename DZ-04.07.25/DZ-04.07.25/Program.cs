using System.Security.Cryptography.X509Certificates;



class Book //создание класса с полями
{
    public string title;  //поля
    public string author;
    public int year;
    public bool IsAvailable;

    public void DisplayInfo() //метод, который выводит инфу на консоль
    {
        Console.WriteLine($"Название книги: {title} Автор: {author} Год издония: {year} Доступна ли книга: {IsAvailable}");
    }


    public static void Main(string[] args)
    {
        Book book1 = new Book();  // Создание объекта
        Book book2 = new Book();
        Book book3 = new Book();

        string Book1Title = book1.title;
        string Book1Author = book1.author;
        int Book1Year = book1.year;
        bool Book1IsAvailable = book1.IsAvailable;

        book1.title = "Записки охотника";
        book1.author = "Иван Тургенев";
        

        book2.title = "Капитанская дочка";
        book2.author = "Александр Пушкин";
        book2.year = 1836;
        book2.IsAvailable = true;

        book3.title = "Война и мир";
        book3.author = "Лев Толстой";
        book3.year = 1867;
        book3.IsAvailable = true;

        book1.DisplayInfo(); //вывожу информацию книги 1
        book2.DisplayInfo(); //вывожу информацию книги 2
        book3.DisplayInfo(); //вывожу информацию книги 3

    }



}

/*Book book1 = new Book {title = "Записки охотника", author = "Иван Тургенев" };
        Book book2 = new Book { title = "Капитанская дочка", author = "Александр Пушкин", year = 1836};
        Book book3 = new Book { title = "Война и мир", author = "Лев Толстой", year = 1867, IsAvailable = true };*/