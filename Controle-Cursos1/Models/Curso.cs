using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.cursos.Models
{
    [Table("Cursos")]
    public class Curso
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Nome do Curso")]
        [Required(ErrorMessage = "Obrigatório informar o nome do curso!")]
        public string Nome { get; set; }

        [Display(Name = "Nome do Professor(a)")]
        [Required(ErrorMessage = "Obrigatório informar o nome do professor!")]
        public string Professor { get; set; }

        [Display(Name = "Nome do Fornecedor do Curso")]
        [Required(ErrorMessage = "Obrigatório informar o nome do fornecedor!")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a modalidade!")]
        public string Modalidade { get; set; }

        [Display(Name = "Data Início do Curso")]
        [Required(ErrorMessage = "Obrigatório informar o horário!")]
        public DateTime Horario { get; set; }

        public ICollection<Aluno> Alunos { get; set; }
    }
}
