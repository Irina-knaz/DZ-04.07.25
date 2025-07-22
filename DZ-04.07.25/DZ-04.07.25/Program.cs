using DZ_04._07._25;
using static DZ_04._07._25.Book;



Book book1 = new Book ("Записки охотника", "Иван Тургенев", Genre.Novel, 0, false);
Book book2 = new Book ("Капитанская дочка", "Александр Пушкин", Genre.Novel, 0, false);
Book book3 = new Book ("Война и мир", "Лев Толстой", Genre.Fiction, 1867, true);

book1.DisplayInfo(); //вывожу информацию книги 1
book2.DisplayInfo(); //вывожу информацию книги 2
book3.DisplayInfo(); //вывожу информацию книги 3

book1.Berrow();
book2.Berrow();
book3.Return();



