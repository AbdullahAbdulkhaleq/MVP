using System;

namespace MVP.View
{
    public interface IBook
    {
        string Title { get; set; }
        string Author { get; set; }
        DateTime Year { get; set; }
    }
}
