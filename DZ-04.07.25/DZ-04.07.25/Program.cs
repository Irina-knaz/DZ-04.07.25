using DZ_04._07._25;
using static DZ_04._07._25.Book;

    
Book book1 = new Book { title = "Записки охотника", author = "Иван Тургенев", genre = Genre.Novel };
Book book2 = new Book { title = "Капитанская дочка", author = "Александр Пушкин", genre = Genre.Novel };
Book book3 = new Book { title = "Война и мир", author = "Лев Толстой", genre = Genre.Fiction, year = 1867, IsAvailable = true };

book1.DisplayInfo(); //вывожу информацию книги 1
book2.DisplayInfo(); //вывожу информацию книги 2
book3.DisplayInfo(); //вывожу информацию книги 3

book1.Berrow();
book2.Berrow();
book3.Return();



