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
    
    public partial class SALARIE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SALARIE()
        {
            this.JOURNEE_SALARIE = new HashSet<JOURNEE_SALARIE>();
        }
    
        public int IDCOMPTE { get; set; }
        public string LOGIN { get; set; }
        public string MDP { get; set; }
        public string EMAIL { get; set; }
        public string TEL { get; set; }
        public string ADRESSE { get; set; }
        public bool ASSISTANT { get; set; }
        public Nullable<System.DateTime> DATEDEBUTSTAGE { get; set; }
        public Nullable<System.DateTime> DATEFINSTAGE { get; set; }
        public string PRENOM { get; set; }
        public string NOM { get; set; }
        public bool PREMIERECONNEXION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JOURNEE_SALARIE> JOURNEE_SALARIE { get; set; }
    }
}
