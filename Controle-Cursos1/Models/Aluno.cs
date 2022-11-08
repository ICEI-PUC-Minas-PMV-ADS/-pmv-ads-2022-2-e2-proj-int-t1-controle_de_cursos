using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.cursos.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tipo de Aluno")]
        [Required(ErrorMessage ="Obrigatório informar o tipo!")]
        public Tipo Tipo { get; set; }

        [Display(Name = "Curso")]
        [Required(ErrorMessage = "Obrigatório informar o curso!")]
        public int CursoId { get; set; }
        [ForeignKey("CursoId")]
        public Curso Curso { get; set; }
    }

    public enum Tipo
    {
        Comissionado,
        Efetivo
    }

}
