﻿using MyLeasing.Web.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace Myleasing.Web.Data.Entities
{
    public class PropertyImage
    {
        
        
        public int Id { get; set; }

        [Display(Name = "Imagen")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string ImageUrl { get; set; }

        // TODO: Change the path when publish
        public string ImageFullPath => $"https://TBD.azurewebsites.net{ImageUrl.Substring(1)}";

        public Property Property { get; set; }

    }
 }