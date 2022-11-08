using System.ComponentModel.DataAnnotations;

namespace CSC.WordPress.Models
{
    public class User
   {
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }

        public string Description { get; set; }
    }
}
