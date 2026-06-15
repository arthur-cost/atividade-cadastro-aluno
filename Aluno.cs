using System.ComponentModel.DataAnnotations;

namespace projeto.Models;

public class Aluno
{
  [Required(ErrorMessage = "O nome e obrigatorio")]
  [StringLength(100, ErrorMessage = "O nome deve ter no maximo 100 caracteres")]
  public string Nome { get; set; } = string.Empty;

  [Required(ErrorMessage = "O e-mail e obrigatorio")]
  [EmailAddress(ErrorMessage = "Informe um e-mail valido")]
  [StringLength(150, ErrorMessage = "O e-mail deve ter no maximo 150 caracteres")]
  public string Email { get; set; } = string.Empty;

  [Required(ErrorMessage = "O RA e obrigatorio")]
  [StringLength(20, ErrorMessage = "O RA deve ter no maximo 20 caracteres")]
  public string RA { get; set; } = string.Empty;

  [Required(ErrorMessage = "O curso e obrigatorio")]
  [StringLength(80, ErrorMessage = "O curso deve ter no maximo 80 caracteres")]
  public string Curso { get; set; } = string.Empty;

  [Required(ErrorMessage = "A data de nascimento e obrigatoria")]
  public DateTime? DataNascimento { get; set; }
}