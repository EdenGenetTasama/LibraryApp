//1:

using LibraryApp;

string[] arrayOf7Names = new string[7] { "Eden", "Daniel", "Avner", "Monica", "Avi", "Oshra", "Joey" };
var listOfNames = (from nameWithe in arrayOf7Names
                   where nameWithe[0] == 'E'
                   select nameWithe).ToList();

//foreach(var name in listOfNames)
//{
//    Console.WriteLine(name);
//}


//2:
Random rnd = new Random();
int[] randomAgeArray = new int[10];

for (int i = 0; i < 10; i++)
{
    int random = rnd.Next(1, 50);
    randomAgeArray[i] = random;
    //Console.WriteLine(randomAgeArray[i]);
}

var over20List = (from over20Age in randomAgeArray
                  where over20Age > 20
                  select over20Age).ToList();

//foreach(int over20 in over20List)
//{
//    Console.WriteLine(over20);
//}

//4:

Random randomPages = new Random();


Book[] arrayOfBookOb = new Book[] { new Book("Harry Potter", "JK Rolling", randomPages.Next(1,500)),
    new Book("Harry Potter", "JK Rolling", randomPages.Next(1,500)),
    new Book("Spaider-Mam", "Marvel",randomPages.Next(1,500)),
    new Book("Bond", "Movie", randomPages.Next(1,500)),
    new Book("Black PantherY", "MARVEL",randomPages.Next(1,500)),
    new Book("Iron", "MARVEL", randomPages.Next(1,500)),};




//5:

var over200Pages = (from item in arrayOfBookOb
                    where item.NumbersOfPages > 200
                    select item).ToList();

//foreach (var itemPages in over200Pages)
//{
//    Console.WriteLine(itemPages.NumbersOfPages);
//}



//6:
var over4Length = (from name in arrayOfBookOb
                   where name.Writter.Length > 4
                   select name).ToList();
//foreach (var over4 in arrayOfBookOb)
//{
//    Console.WriteLine(over4.Name);
//}



//7:

var shorterThen150Pages = (from book in arrayOfBookOb
                           where book.NumbersOfPages < 150
                           select book).ToList();

Book bookObj = shorterThen150Pages.Find(item => item.NumbersOfPages < 150);
//Console.WriteLine($"{ bookObj.Name} , {bookObj.NumbersOfPages}");

//8:

var endedWithY = (from nameObj in arrayOfBookOb
                  where nameObj.Name[nameObj.Name.Length - 1] == 'Y'
                  select nameObj).ToList();

//foreach (var item in endedWithY)
//{
//    Console.WriteLine(item.Name);
//}

//9:
Book[] arrayOfBookObTwo = new Book[] { new Book("Harry Potter", "JK Rolling", randomPages.Next(1,500)),
    new Book("Harry Potter", "JK Rolling", randomPages.Next(1,500)),
    new Book("Spaider-Mam", "Movie", randomPages.Next(1,500)),
    new Book("Spaider-Mam", "Movie", randomPages.Next(1,500)),
    new Book("Black PantherY", "MARVEL",randomPages.Next(1,500)),
    new Book("Spaider-Mam", "Movie", randomPages.Next(1,500)) };

//10:

var groupByWritterPrintAllInfo = from book in arrayOfBookObTwo
                     group book by book.Writter;
foreach (var gropWritter in groupByWritterPrintAllInfo)
{
    Console.WriteLine($"group Name:{gropWritter.Key}");
    foreach (Book i in gropWritter)
    {
        Console.WriteLine($"{i.Name} , {i.NumbersOfPages} , {i.Writter}");
    }
}


//11:

var groupByWritter = from book in arrayOfBookObTwo
                     group book by book.Writter;
foreach (var gropWritter in groupByWritter)
{
    Console.WriteLine($"group Name:{gropWritter.Key}");
    foreach (Book i in gropWritter)
    {
        Console.WriteLine(i.Name);
    }
}
