using MyLeasing.Web.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Myleasing.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Documento")]
        public string Document { get; set; }

        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Nombres Propietrio")]

        public string FirstName { get; set; }

       
        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }


        
        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Telefono Fijo")]
        public string FixedPhone { get; set; }


        [Required]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Telefono Celular")]
        public string CellPhone { get; set; }


        [Required]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Direccion")]
        public string Address { get; set; }


        [Display(Name = "Nombres y Apellido")]
        public string FullName => $"{FirstName} {LastName}";

        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

        public ICollection<Property> Propeties { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
