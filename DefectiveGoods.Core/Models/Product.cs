using System;
using System.ComponentModel.DataAnnotations;

namespace DefectiveGoods.Core.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string ArrivalNumber { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public string PathToImage { get; set; }
        public string Category { get; set; }
        public string Comment { get; set; }
        public string Location { get; set; }
    }
}
