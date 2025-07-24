using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using static DZ_04._07._25.Book;

namespace DZ_04._07._25;

internal class Book //создание класса с полями
{
    private string? _title;  //поля
    private string? _author;
    private int? _year;
    private bool _IsAvailable;
    private Genre _genre;

    public Book(string title, string author, Genre genre, int year, bool IsAvailable) //конструктор
    {
        _title = title;       //инициализация полей
        _author = author;
        _genre = genre;
        _year = year;
        _IsAvailable = IsAvailable;
    }

    public string? GetTitle() //метод для возврата поля
    {
        return _title;
    }
    public string? GetAuthor()   //метод для возврата поля
    {
        return _author;
    }
    public Genre GetGenre()   //метод для возврата поля
    {
        return _genre;
    }
    public int? GetYear()   //метод для возврата поля
    {
        return _year;

    }
    public bool GetIsAvailable()   //метод для возврата поля
    {
        return _IsAvailable;
    }

    /// <summary>
    /// Метод, который выводит инфу на консоль
    /// </summary>
    public void DisplayInfo()
    {
        Console.WriteLine($"\nНазвание книги: {_title}. Автор: {_author}. Жанр: {GenreBook()}. Год издания: {YearBook()}. Доступна ли книга: {IsAvailableText()}. Идентификатор: {Id}");
    }
    private string Id = Guid.NewGuid().ToString();

    public void Berrow() //Доступна ли книга
    {
        if (_IsAvailable == false)
        {
            Console.WriteLine($"Книга <{_title}> была выдана.");
        }
    }

    public void Return() //Доступна ли книга
    {
        if (_IsAvailable == true)
        {
            Console.WriteLine($"Книга <{_title}> возвращена в библиотеку.");
        }
    }

    private string IsAvailableText() // Доступна ли книга
    {
        return _IsAvailable ? "Книга в библиотеке" : "Книга была выдана";
    }

    public string YearBook() // Год издания
    {
        string resultIf = null;
        string resultElse = null;

        if (_year != null || _year != 0)
        {
            resultIf = resultIf + Convert.ToString(_year);
            return resultIf;
        }
        else
        {
            resultElse = resultElse + Convert.ToString("Неизвестный год издания.");
            return resultElse;
        }
    }

    public string GenreBook()
    {
        switch (_genre)
        {
            case Genre.Novel:
                return "Роман";
                
            case Genre.Fiction:
                return "Фикшн";

            default:
                return "Неизвестный жанр";                
        }  
    }

    public enum Genre //Жанры
    {
       Novel,
       Fiction
    }
}