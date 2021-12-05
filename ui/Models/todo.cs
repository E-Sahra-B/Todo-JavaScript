using System;
using System.ComponentModel.DataAnnotations;

namespace ui.Models
{
    public class todo
    {
        [Key]
        public int ID { get; set; }
        public string konu { get; set; }
        public DateTime tarih { get; set; }
    }
}
