namespace DZ_04._07._25;

internal class Book //создание класса с полями
{
    public string? title;  //поля
    public string? author;
    public int? year;
    public bool IsAvailable;


    /// <summary>
    /// Метод, который выводит инфу на консоль
    /// </summary>
    public void DisplayInfo()
    {
        Console.WriteLine($"\nНазвание книги: {title} Автор: {author} Год издания: {YearBook()} Доступна ли книга: {IsAvailableText()}");
    }

    public void Berrow()
    {
        if (IsAvailable == false)
        {
            Console.WriteLine("Книга была выдана");
        }
    }

    public void Return()
    {
        if (IsAvailable == true)
        {
            Console.WriteLine("Книга в библиотеке");
        }
    }

    private string IsAvailableText()
    {
        return IsAvailable ? "Книга в библиотеке" : "Книга была выдана";
    }


    public string YearBook()
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
    




    enum Genre
    {
        Fiction,
        NonFiction,
        Science,
        Fantasy,
        Biography
    }
}