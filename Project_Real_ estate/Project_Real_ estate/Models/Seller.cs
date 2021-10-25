//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_Real__estate.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Seller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seller()
        {
            this.Advertisements = new HashSet<Advertisement>();
            this.Reports = new HashSet<Report>();
        }
    
        public int SellerId { get; set; }
        [Required, StringLength(maximumLength: 50, MinimumLength =3)]
        public string Name { get; set; }
        public bool Gender { get; set; }

        [Required, StringLength(50)]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
            ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
            ApplyFormatInEditMode = true)]
        [DOBDateValidation]
        public DateTime Birthdate { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [Required, StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }
        public bool isActivate { get; set; }
        [Required, StringLength(50)]
        [DataType(DataType.Password)]
        [RegularExpression(@"(?=.*\d)(?=.*[A-Za-z]).{8,}",
            ErrorMessage = "Password minimum 8 characters at least 1 letter and 1 number")]
        public string Password { get; set; }
        [NotMapped]
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "ConFirm Password Required")]
        [DataType(DataType.Password)]
        //[Compare("Login_Password", ErrorMessage = "Password Do Not Matched")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Password Do Not Matched")]
        public string ConfirmPassword { get; set; }
        public Nullable<int> UserId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Advertisement> Advertisements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Report> Reports { get; set; }
        public virtual User User { get; set; }
    }
    public enum Gender
    {
        Male = 0,
        Female = 1
    }
    public enum isActivate
    {
        NotActive = 0,
        Active = 1
    }
}
