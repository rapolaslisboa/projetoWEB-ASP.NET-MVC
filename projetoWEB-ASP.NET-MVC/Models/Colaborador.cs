//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoWEB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Colaborador
    {
        public int idColaborador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public string Oficio { get; set; }
        public Nullable<System.DateTime> DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public Nullable<bool> Disponibilidade { get; set; }
    }
}
