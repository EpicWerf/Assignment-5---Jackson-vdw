using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_5___Jackson_vdw.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorFirst { get; set; }
        //Not required because not every author has a middle name
        public string AuthorMiddle { get; set; }
        [Required]
        public string AuthorLast { get; set; }
        [Required]
        public string Publisher { get; set; }

        [Required][RegularExpression(@"(ISBN[-] * (1[03]) *[ ] * (: ){0, 1})* (([0 - 9Xx][- ]*){13}| ([0 - 9Xx][- ] *){ 10})",
         ErrorMessage = "ISBN must be in valid format: XXX-XXXXXXXXXX.")]
        public string ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
