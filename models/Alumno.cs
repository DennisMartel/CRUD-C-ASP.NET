using System.ComponentModel.DataAnnotations;

namespace Crud.models
{
    public class Alumno
    {
        public int Id { get; set; }
        public string names { get; set; }
        public string lastnames { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public DateTime birthday { get; set; }
    }
}
