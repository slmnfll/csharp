using System.ComponentModel.DataAnnotations;

namespace EvaluationDeC_.Models {

public class Etudiant
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Matricule { get; set; }

    [Required]
    public string NomComplet { get; set; }

    public string Adresse { get; set; }

    // Relations
    public ICollection<Absence>? Absences { get; set; }
    public ICollection<Cours>? Cours { get; set; }
}
}