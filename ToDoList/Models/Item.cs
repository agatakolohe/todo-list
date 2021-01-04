using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class Item
    {
        public Item()
        {
            this.Categories = new HashSet<CategoryItem>();
        }

        public int ItemId { get; set; }
        public string Description { get; set; }
        public bool CompletedItem { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DueDate { get; set; }

        public ICollection<CategoryItem> Categories { get; }
    }


}