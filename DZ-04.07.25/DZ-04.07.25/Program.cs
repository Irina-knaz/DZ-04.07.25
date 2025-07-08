using DZ_04._07._25;

Book book1 = new Book { title = "Записки охотника", author = "Иван Тургенев"};
Book book2 = new Book { title = "Капитанская дочка", author = "Александр Пушкин", year = 1836 };
Book book3 = new Book { title = "Война и мир", author = "Лев Толстой", year = 1867, IsAvailable = true};

book1.DisplayInfo(); //вывожу информацию книги 1
book2.DisplayInfo(); //вывожу информацию книги 2
book3.DisplayInfo(); //вывожу информацию книги 3

book1.YearBook();


    


