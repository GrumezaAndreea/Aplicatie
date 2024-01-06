using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie.Models
{
    public class Elev
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }
        public string? Nume { get; set; }
        public string? Prenume { get; set; }
        public int Varsta { get; set; }
        public string? Clasa { get; set; }
        public string? Scoala { get; set; }
        public string? NumarTelefon { get; set; }
        public string? Email { get; set; }
    }
}
