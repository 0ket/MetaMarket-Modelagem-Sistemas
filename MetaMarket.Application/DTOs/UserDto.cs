using System.ComponentModel.DataAnnotations;

namespace MetaMarket.Application.DTOs;

/// <summary>
/// Entidade que representa um usuário no Sistema MetaMarket, seja ele cliente ou funcionário
/// </summary>
public class UserDto
{
    /// <summary>
    /// Nome do usuario
    /// </summary>
    [Required(ErrorMessage = "Por favor, informe um nome!")]
    [MaxLength(100)]
    [MinLength(1)]
    public string Name { get; init; }

    /// <summary>
    /// CPF do usuário
    /// </summary>
    [Required(ErrorMessage = "Por favor, informe um cpf!")]
    [MaxLength(11)]
    [MinLength(11)]
    public string Cpf { get; init; }

    /// <summary>
    /// Número de telefone do usuário
    /// </summary>
    [Required(ErrorMessage = "Por favor, informe um telefone!")]
    [MaxLength(20)]
    [MinLength(8)]
    public string PhoneNumber { get; init; }    
}
