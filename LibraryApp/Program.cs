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
    new Book("Black Panther", "MARVEL",randomPages.Next(1,500)),
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

var shorterThen150Pages = (from bookShort150pages in arrayOfBookOb
                          where arrayOfBookOb[0].NumbersOfPages <150
                          select bookShort150pages).ToList().Find(item=>item);