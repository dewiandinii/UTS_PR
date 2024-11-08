using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_PR.App.Model
{
    internal class M_tugas
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string judul { get; set; }
        [Required]
        public string deskripsi { get; set; }
        [Required]
        public string deadline { get; set; }
    }
}
