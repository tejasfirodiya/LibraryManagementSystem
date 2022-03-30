using LibraryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.MainEntity;

public class Author : IAuthor
{
    int authorId;
    string authorName;
    string authorNotes;

    private const string Heading = "Id, Title, Notes\n";
    private const string FilePath = @"D:\Tejas Firodiya (Training Folder)\LibraryManagementSystem\LibraryManagementSystem\exelFiles\BookData.csv";

    string s = new('-', 30);

    public Author(int AuthorId, string AuthorName, string AuthorNotes)
    {
        authorId = AuthorId;
        authorName = AuthorName;
        authorNotes = AuthorNotes;
    }

    public Author()
    {
        //int AuthorId;
        //string AuthorName;
        //string AuthorNotes;
    }

    public void CreateAuthor()
    {
        Console.WriteLine(s);
        Console.WriteLine("       Add Book Details      ");
        Console.WriteLine(s);

        Console.Write("Enter Author Id : ");
        authorId = int.Parse(Console.ReadLine());

        Console.Write("Enter Author Name : ");
        authorName = Console.ReadLine();

        Console.Write("Enter Author Notes : ");
        authorNotes = Console.ReadLine();
    }

    public void SaveData()
    {
        var data = $"{authorId},{authorName},{authorNotes}\n";

        if (!File.Exists(FilePath))
            File.WriteAllText(FilePath, Heading);

        try
        {
            File.AppendAllText(FilePath, data);
            Console.WriteLine($"File successfully saved at {FilePath}");
        }

        catch (Exception exception)
        {
            Console.WriteLine($"Error Saving File. {exception.Message}");
        }
    }

    public void ListAuthor()
    {
        throw new NotImplementedException();
    }

    public void UpdateAuthor()
    {
        throw new NotImplementedException();
    }

    public void DeleteAuthor()
    {
        throw new NotImplementedException();
    }
}
