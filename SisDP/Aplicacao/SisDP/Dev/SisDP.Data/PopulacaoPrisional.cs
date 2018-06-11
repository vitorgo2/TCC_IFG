//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SisDP.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PopulacaoPrisional
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PopulacaoPrisional()
        {
            this.FatoEstabelecimento = new HashSet<FatoEstabelecimento>();
            this.FatoSistemaPenitenciario = new HashSet<FatoSistemaPenitenciario>();
        }
    
        public int SkPopulacaoPrisional { get; set; }
        public int NkUnidade { get; set; }
        public string InformacaoEstrangeiros { get; set; }
        public string InformacaoNumeroFilhos { get; set; }
        public string St_Visitantes { get; set; }
        public string InformacaoTempoPena { get; set; }
        public string TipoRegistroTempoPena { get; set; }
        public string InformacaoTempoPenaRemanescente { get; set; }
        public string InformacaoIncidenciaTipoPenal { get; set; }
        public string TipoRegistroIncidenciaTipoPenal { get; set; }
        public string InformacaoPessoasDeficientes { get; set; }
        public string InformacaoEstadoCivil { get; set; }
        public string InformacaoRacaEtnia { get; set; }
        public string InformacaoFaixaEtaria { get; set; }
        public string InformacaoAuxilioReclusao { get; set; }
        public Nullable<System.DateTime> DataInsercao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FatoEstabelecimento> FatoEstabelecimento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FatoSistemaPenitenciario> FatoSistemaPenitenciario { get; set; }
    }
}