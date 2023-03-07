
using MidtermGroupProject;
using static System.Reflection.Metadata.BlobBuilder;


string filePath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"../../../", "Media.txt");
Library library = new();
FileIO fileio = new(filePath);

List<Media> mediaList = fileio.FileRead();


//remove a media item from the list
//mediaList.Remove(mediaList.SingleOrDefault(x => x.Title == "The Dark Tower VII: The Dark Tower"));


//add a book to the list
DateOnly DateOnly1 = new DateOnly(2023, 03, 04);
DateOnly DateOnly2 = new DateOnly(2023, 03, 11);
mediaList.Add(new Book("Book", "Available", DateOnly1, DateOnly2, "The Dark Tower VIII: Susannah's Revenge", "Stephen King"));


//Update status of an item from the list, throws error if title is not unique
mediaList.Single(x => x.Title == "The Dark Tower VII: The Dark Tower").Status = "Checked Out";


fileio.FileUpdate(mediaList);