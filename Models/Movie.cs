//These model classes are used with Entity Framework Core (EF Core) to work with a database.
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; } //he Movie class contains an Id field, which is required by the database for the primary key.
        public string? Title { get; set; } //The question mark after string indicates that the property is nullable. 
        
        [Display(Name = "Release Date")] //The Display attribute specifies what to display for the name of a field (in this case "Release Date" instead of "ReleaseDate").
        [DataType(DataType.Date)] //The DataType attribute specifies the type of the data (Date), so the time information stored in the field isn't displayed.
        public DateTime ReleaseDate { get; set; } //The DataType attribute on ReleaseDate specifies the type of the data (Date). Only the date is displayed, not time information.The user isn't required to enter time information in the date field.

        public string? Genre { get; set; }



        [Column(TypeName = "decimal(18, 2)")] //The [Column(TypeName = "decimal(18, 2)")] data annotation is required so Entity Framework Core can correctly map Price to currency in the database.

        public decimal Price { get; set; }


    }


}
