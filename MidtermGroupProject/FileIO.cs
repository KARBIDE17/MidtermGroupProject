using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MidtermGroupProject
{
    public class FileIO
    {
        public string FilePath { get; set; } //file path for Media.txt file

        public FileIO(string filePath)
        {
            FilePath = filePath;
        }
        public List<Media> FileRead()
        {
            List <Media> mediaList = new List<Media>();

            using (StreamReader sr = File.OpenText(FilePath)) //Read from text file
            {
                string s;
                while ((s = sr.ReadLine()) != null) //iterates thru each line of text
                {
                    string[] values = s.Split(";"); //delimiter

                    DateOnly? checkOutDateFromFile = DateOnly.TryParse(values[2], out DateOnly CheckOutDate) ? CheckOutDate : null; //instantiate DateOnly object
                    DateOnly? dueDateFromFile = DateOnly.TryParse(values[3], out DateOnly DueDate) ? DueDate : null; //instantiate DateOnly object

                    if (true) //check object type and instantiate correct object
                    {
                        Media media = new Book(values[0], values[1], checkOutDateFromFile, dueDateFromFile, values[4], values[5]); //create new Media object for each line of text
                        mediaList.Add(media);
                    }
                }
                return mediaList;
            }
        }
        public void FileUpdate(List<Media> mediaList)
        {
            using (StreamWriter sw = File.CreateText(FilePath)) //Overwrites current contents of Media.txt file with updates from runtime
            {
                foreach (var item in mediaList)
                {
                    sw.WriteLine($"{item.Type};{item.Status};{item.CheckOutDate};{item.DueDate};{item.Title};{item.Author}");
                }
            }
        }
    }
}
