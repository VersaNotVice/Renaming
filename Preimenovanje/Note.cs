using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_Zad_2_Refaktoriranje
{
    public class Note
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime TimeStamp { get; private set; }

        public Note(string title, string text)
        {
            Title = title;
            Text = text;
            TimeStamp = DateTime.Now;
        }
    }

    public class NotesCollection
    {
        public string Author { get; private set; }
        public List<Note> Notes;

        public NotesCollection(string author)
        {
            Author = author;
            Notes = new List<Note>();
        }

        public void Add(Note note)
        {
            Notes.Add(note);
        }
    }
}
