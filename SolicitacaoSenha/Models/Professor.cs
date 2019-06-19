using AcademySystem.Enum;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AcademySystem.Models
{
    [Table("tbl_Professor")]
    public class Professor
    {
        [Key]
        public int CodigoProfessor { get; set; }
        [Column("_nome",TypeName = "varchar(500)")]
        public string Nome { get; set; }
        [Column("_idade",TypeName = "varchar(2)")]
        public string Idade { get; set; }
        [Column("_rg",TypeName = "varchar(9)")]
        public string Rg { get; set; }
        [Column("_sexo",TypeName = "int")]
        public EnumSexo sexo { get; set; }
        [Column("_formacao", TypeName = "varchar(50)")]
        public string DescricaoFormacao { get; set; }
        [Column("_materiaLecionada", TypeName = "varchar(150)")]
        public string MateriaSelecionada {get;set;}
        [Column("_contratacao",TypeName = "Date")]
        public DateTime DiaContratacao { get; set; }
        [Column("_ativo", TypeName = "bit")]     
        public bool Status { get; set; }
        [Column("_foto", TypeName = "varchar(150)")]
        public string CaminhoFoto { get; set; }
        [NotMapped]
        public IFormFile foto { get; set; }
    }
}
