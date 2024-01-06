using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie.Models
{
    public class Parinte
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }
        [MaxLength(250), Unique]
        public string? Nume { get; set; }
        public string? Prenume { get; set; }

        public string? NumarTelefon { get; set; }
    }
}
