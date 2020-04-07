
using Myleasing.Web.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Myleasing.Web.Data.Entities

{
    public class Property
    {
        public int Id { get; set; }

        [Display(Name = "Barrio")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Neighborhood { get; set; }

        [Display(Name = "Direccion")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Address { get; set; }

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Metros Cuadrados")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int SquareMeters { get; set; }

        [Display(Name = "Habitaciones")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int Rooms { get; set; }

        [Display(Name = "Estrato")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int Stratum { get; set; }

        [Display(Name = "Tiene Parqueadero?")]
        public bool HasParkingLot { get; set; }

        [Display(Name = "Esta Disponible?")]
        public bool IsAvailable { get; set; }

        public string Remarks { get; set; }

        public PropertyType PropertyType { get; set; }

        public Owner Owner { get; set; }

        public ICollection<PropertyImage> PropertyImages { get; set; }



    }


}
