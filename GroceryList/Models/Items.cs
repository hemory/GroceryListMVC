using System;
using System.ComponentModel.DataAnnotations;

namespace GroceryList.Models
{
    public class Items
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

    }
}
