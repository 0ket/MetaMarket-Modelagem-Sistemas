using System.ComponentModel.DataAnnotations;

namespace MetaMarket.Application.DTOs;

/// <summary>
/// 
/// </summary>
public class BaseEntityDto
{
    /// <summary>
    /// Id da entidade em questao (primary key)
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Nome da entidade em questao
    /// </summary>
    [Required(ErrorMessage = "Por favor, informe um nome!")]
    [MaxLength(100)]
    [MinLength(3)]
    public string Name { get; init; }
}
