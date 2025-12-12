using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tb_comentarios")]
public partial class TbComentarios
{
    [Key]
    [Column("ID_Comentarios")]
    public int IdComentarios { get; set; }

    [Column("texto")]
    [StringLength(500)]
    public string Texto { get; set; } = null!;

    [Column("data_coment")]
    public DateOnly DataComent { get; set; }

    [Column("ID_Usuario")]
    public int IdUsuario { get; set; }

    [Column("ID_Publi")]
    public int IdPubli { get; set; }

    [ForeignKey("IdPubli")]
    [InverseProperty("TbComentarios")]
    public virtual TbPubli IdPubliNavigation { get; set; } = null!;

    [ForeignKey("IdUsuario")]
    [InverseProperty("TbComentarios")]
    public virtual TbUsuario IdUsuarioNavigation { get; set; } = null!;
}
