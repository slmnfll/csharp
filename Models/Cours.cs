using System.ComponentModel.DataAnnotations;

namespace EvaluationDeC_.Models {

public class Cours
{
    [Key]
    public int Id { get; set; }

    [Required]
    public DateTime Date { get; set; }

    public TimeSpan HeureDebut { get; set; }
    public TimeSpan HeureFin { get; set; }

    public int NombreHeures { get; set; }
    public int Semestre { get; set; }

    // Relations
    public ICollection<Absence>? Absences { get; set; }
    public ICollection<Etudiant>? Etudiants { get; set; }
}
}