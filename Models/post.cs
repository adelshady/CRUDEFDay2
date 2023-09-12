using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEFDay2.Models
{
    public class post
    {
        [Key]
        public int ID{ get; set; }
        public string Title { get; set; }
        public string? Bref{ get; set; }
        [DisplayName("Description")]
        public string? Desc{ get; set; }
        public TimeSpan? Time{ get; set; }
        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public byte[]? image{ get; set; }

        [DisplayName("Author")]
        [ForeignKey("Author")]
        public int AutherId{ get; set; }
        public virtual Author Author { get; set; }
        [DisplayName("Category")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category{ get; set; }




    }
}
