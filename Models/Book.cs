﻿namespace OnlineBookstoreAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; } // Foreign key to Author
        public int GenreId { get; set; }  // Foreign key to Genre
        public decimal Price { get; set; }
        public int QuantityAvailable { get; set; }
        public Author? Author { get; set; } // Navigation property to Author
        public Genre? Genre { get; set; }   // Navigation property to Genre
    }
}
