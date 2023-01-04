using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
        [Required]

        public string ISBN { get; set; }
        [Required]

        public string Author { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "List Price")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]

        public double ListPrice { get; set; }
        [Required]
        [Range(1, 10000)]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]

        [Display(Name = "Price for 1-50")]
        public double Price { get; set; }

        [Required]
        [Range(1, 10000)]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]

        [Display(Name = "Price for 51-100")]
        public double Price50 { get; set; }

        [Required]
        [Display(Name = "Price for 100+")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]

        [Range(1, 10000)]
        public double Price100 { get; set; }
        [ValidateNever]
         public string ImageUrl { get; set; }
        [Required]
        [Display(Name = "Category")]
        public int CategoryId  { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        [Required]
        [Display(Name = "CoverType")]
        public int CoverTypeId { get; set; }
        [ValidateNever]
        public CoverType CoverType { get; set; }

    }
}
