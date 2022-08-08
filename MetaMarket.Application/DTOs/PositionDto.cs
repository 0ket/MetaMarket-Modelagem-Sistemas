using MetaMarket.Domain.Validation.Entities;
using System.ComponentModel.DataAnnotations;

namespace MetaMarket.Application.DTOs;

/// <summary>
/// Entidade que representa o cargo de um funcionario do MetaMarket
/// </summary>
public class PositionDto
{
    /// <summary>
    /// Código que representa o cargo (primary key)
    /// </summary>
    public int Id { get; init; }
    /// <summary>
    /// Nome do cargo
    /// </summary>
    [Required(ErrorMessage = "Por favor, informe um nome!")]
    [MaxLength(100)]
    [MinLength(10)]
    public string Name { get; init; }

    /// <summary>
    /// Representa uma lista de vendedores
    /// </summary>
    public ICollection<SalespersonDto> Salespeople { get; init; }
}