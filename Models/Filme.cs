using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "O Titulo do Filme é obrigatório")]
    public string Titulo { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "O Gênero do Filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "O Tamanho do Gênero não deve ultrapassar 50 caracteres.")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "A duração do filme deve ser entre 70 e 600 minutos.")]
    public int Duracao { get; set; }
}
