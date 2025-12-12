using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tb_publi")]
public partial class TbPubli
{
    [Key]
    [Column("ID_Publi")]
    public int IdPubli { get; set; }

    [Column("descricao")]
    [StringLength(200)]
    public string Descricao { get; set; } = null!;

    [Column("imagem_url")]
    [StringLength(200)]
    public string? ImagemUrl { get; set; }

    [Column("data_publi")]
    public DateOnly DataPubli { get; set; }

    [Column("ID_Usuario")]
    public int? IdUsuario { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("TbPubli")]
    public virtual TbUsuario? IdUsuarioNavigation { get; set; }

    [InverseProperty("IdPubliNavigation")]
    public virtual ICollection<TbComentarios> TbComentarios { get; set; } = new List<TbComentarios>();

    [InverseProperty("IdPubliNavigation")]
    public virtual ICollection<TbCurtidas> TbCurtidas { get; set; } = new List<TbCurtidas>();
}
