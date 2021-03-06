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
    
    public partial class Unidade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Unidade()
        {
            this.FatoEstabelecimento = new HashSet<FatoEstabelecimento>();
            this.FatoSistemaPenitenciario = new HashSet<FatoSistemaPenitenciario>();
        }
    
        public int SkUnidade { get; set; }
        public int NkUnidade { get; set; }
        public string NomeUnidade { get; set; }
        public string UF { get; set; }
        public string NomeRegistro { get; set; }
        public string NomeResponsavelPreenchimento { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }
        public string DestinadaAoSexo { get; set; }
        public string TipoEstabelecimento { get; set; }
        public string TipoRegime { get; set; }
        public string TipoGestao { get; set; }
        public string St_RegimeInterno { get; set; }
        public string RegimeInternoEstado { get; set; }
        public string AdaptadoParaPrisao { get; set; }
        public string St_Bercario { get; set; }
        public string St_Creche { get; set; }
        public string St_LocalEspVisitaInt { get; set; }
        public string St_LocalEspVisitacao { get; set; }
        public string St_LocalEspServicoSoc { get; set; }
        public string St_SalaAtendimentoPsic { get; set; }
        public string St_AtendJuridicoGrat { get; set; }
        public string St_CelaSeguro { get; set; }
        public string St_CelaAlaLGBT { get; set; }
        public string St_CelaAlaIdoso { get; set; }
        public string St_CelaAlaIndio { get; set; }
        public string St_CelaAlaEstrangeiro { get; set; }
        public string AcessibilidadePD { get; set; }
        public string EspacoDisponivelConst { get; set; }
        public string VisitaInspecaoSemestral { get; set; }
        public Nullable<System.DateTime> DataInsercao { get; set; }
        public Nullable<int> SkCidade { get; set; }
    
        public virtual Cidade Cidade1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FatoEstabelecimento> FatoEstabelecimento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FatoSistemaPenitenciario> FatoSistemaPenitenciario { get; set; }
    }
}
