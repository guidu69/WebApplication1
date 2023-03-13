using Microsoft.JSInterop.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    [Table("Customers")]
    public class Jeu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public String Nom;

        public Double Prix;

        public Double PrixTTC;

        public DateTime DateAchat;

    }
}
