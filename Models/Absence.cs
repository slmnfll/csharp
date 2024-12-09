using System.ComponentModel.DataAnnotations;

namespace EvaluationDeC_.Models {
    public class Absence
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        // Relation avec Étudiant
        [Required]
        public int EtudiantId { get; set; }
        public Etudiant Etudiant { get; set; }

        // Relation avec Cours
        [Required]
        public int CoursId { get; set; }
        public Cours Cours { get; set; }
    }
}