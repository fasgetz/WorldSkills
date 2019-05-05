//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorldSkills_Client.Model.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Runner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Runner()
        {
            this.Registration = new HashSet<Registration>();
        }
    
        public int RunnerId { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string CountryCode { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual Gender Gender1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration> Registration { get; set; }
        public virtual User User { get; set; }

        // Свойство, которое возвращает данные в необходимом формате
        public string GetFormat
        {
            get => $"{User.FirstName} {User.LastName} - {RunnerId} ({CountryCode})";
        }
    }
}