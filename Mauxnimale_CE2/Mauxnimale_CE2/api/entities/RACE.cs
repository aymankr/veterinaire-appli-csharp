//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mauxnimale_CE2.api.entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class RACE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RACE()
        {
            this.ANIMAL = new HashSet<ANIMAL>();
        }
    
        public int IDRACE { get; set; }
        public int IDESPECE { get; set; }
        public string NOMRACE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ANIMAL> ANIMAL { get; set; }
        public virtual ESPECE ESPECE { get; set; }
    }
}
