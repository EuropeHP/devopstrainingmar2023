﻿using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CatalogAPI.Models
{
    //user2 modiying the code
    //add sub catelog name

    [Table("Catalog")]
    public class Catalog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
	//user3 updated on 8.46am
        [Column("Catalog_Id")]
        public long CatalogId { get; set; }
        [Column("Catalog_Name")]
        [Required]
        [StringLength(50)]
        public string? CatalogName { get; set; }
	//user3 change

        //[JsonIgnore]       
       // public Collection<Product> ProductList { get; set; }


    }
}
