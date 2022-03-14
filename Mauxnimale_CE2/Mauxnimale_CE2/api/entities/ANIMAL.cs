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
    
    public partial class ANIMAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ANIMAL()
        {
            this.LIEN_MALADIE = new HashSet<LIEN_MALADIE>();
            this.ORDONNANCE = new HashSet<ORDONNANCE>();
            this.RENDEZ_VOUS = new HashSet<RENDEZ_VOUS>();
        }
    
        public int IDANIMAL { get; set; }
        public int IDRACE { get; set; }
        public int IDCLIENT { get; set; }
        public string NOM { get; set; }
        public string ANNEENAISSANCE { get; set; }
        public int TAILLE { get; set; }
        public int POIDS { get; set; }
        public bool ESTMALE { get; set; }
    
        public virtual CLIENT CLIENT { get; set; }
        public virtual RACE RACE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIEN_MALADIE> LIEN_MALADIE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDONNANCE> ORDONNANCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RENDEZ_VOUS> RENDEZ_VOUS { get; set; }

        public override string ToString()
        {
            return this.NOM.ToString();
        }
    }
}
