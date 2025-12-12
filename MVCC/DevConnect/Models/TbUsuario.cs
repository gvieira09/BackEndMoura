using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tb_usuario")]
[Index("Email", Name = "UQ__tb_usuar__AB6E6164DEF5630C", IsUnique = true)]
[Index("NomeUsuario", Name = "UQ__tb_usuar__CCB80B0A8BAC254B", IsUnique = true)]
public partial class TbUsuario
{
    [Key]
    [Column("ID_Usuario")]
    public int IdUsuario { get; set; }

    [Column("nome_completo")]
    [StringLength(200)]
    public string NomeCompleto { get; set; } = null!;

    [Column("nome_usuario")]
    [StringLength(55)]
    public string NomeUsuario { get; set; } = null!;

    [Column("email")]
    [StringLength(200)]
    public string Email { get; set; } = null!;

    [Column("senha")]
    [StringLength(80)]
    public string Senha { get; set; } = null!;

    [Column("foto_perfl_url")]
    [StringLength(200)]
    public string? FotoPerflUrl { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbComentarios> TbComentarios { get; set; } = new List<TbComentarios>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbCurtidas> TbCurtidas { get; set; } = new List<TbCurtidas>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbPubli> TbPubli { get; set; } = new List<TbPubli>();

    [ForeignKey("IdUsuarioSeguidor")]
    [InverseProperty("IdUsuarioSeguidor")]
    public virtual ICollection<TbUsuario> IdUsuarioNavigation { get; set; } = new List<TbUsuario>();

    [ForeignKey("IdUsuario")]
    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbUsuario> IdUsuarioSeguidor { get; set; } = new List<TbUsuario>();
}
