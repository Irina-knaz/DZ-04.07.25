using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace DZ_04._07._25;

internal class Book //создание класса с полями
{
    private string? title;  //поля
    private string? author;
    private int? year;
    private bool IsAvailable;
    private Genre genre;
    
    /// <summary>
    /// Метод, который выводит инфу на консоль
    /// </summary>
    public void DisplayInfo()
    {
        Console.WriteLine($"\nНазвание книги: {title}. Автор: {author}. Жанр: {GenreBook()}. Год издания: {YearBook()}. Доступна ли книга: {IsAvailableText()}.");
    }

    public void Berrow() //Доступна ли книга
    {
        if (IsAvailable == false)
        {
            Console.WriteLine($"Книга <{title}> была выдана.");
        }
    }

    public void Return() //Доступна ли книга
    {
        if (IsAvailable == true)
        {
            Console.WriteLine($"Книга <{title}> возвращена в библиотеку.");
        }
    }

    private string IsAvailableText() // Доступна ли книга
    {
        return IsAvailable ? "Книга в библиотеке" : "Книга была выдана";
    }

    public string YearBook() // Год издания
    {
        string resultIf = null;
        string resultElse = null;

        if (year != null)
        {
            resultIf = resultIf + Convert.ToString(year);
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
        switch (genre)
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