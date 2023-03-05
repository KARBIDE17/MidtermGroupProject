

using MidtermGroupProject;
using static System.Reflection.Metadata.BlobBuilder;

string filePath = "C:\\Users\\scott\\Desktop\\GrandCircus\\Repositories\\MidtermGroupProject\\MidtermGroupProject\\Books.txt";

Library library = new();
FileIO fileio = new(filePath);

List<Media> mediaList = fileio.FileRead();

Console.WriteLine();

//remove a book from the list
mediaList.Remove(mediaList.SingleOrDefault(x => x.Title == "The Dark Tower VII: The Dark Tower"));

Console.WriteLine();

//add a book to the list
DateOnly DateOnly1 = new DateOnly(2023, 03, 04);
DateOnly DateOnly2 = new DateOnly(2023, 03, 11);
mediaList.Add(new Book("Book", "Available", DateOnly1, DateOnly2, "The Dark Tower VII: The Dark Tower", "Stephen King"));

Console.WriteLine();