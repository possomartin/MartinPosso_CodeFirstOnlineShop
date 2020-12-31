using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MartinPosso_CodeFirstOnlineShop.Models
{
    public class Posso
    {
        public int PossoID { get; set; }
        [Required(ErrorMessage = "El nombre es requrido")]
        public string mPossoName { get; set; }

        [Required(ErrorMessage ="Si no esta completo este campo no puede ingresar")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Su contraseña debe ser de al menos 5 caracteres hasta 20")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string mpPassword { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string mpBirthdate { get; set; }
        public int ProductID { get; set; }
        public virtual Product product { get; set; }
    }
}