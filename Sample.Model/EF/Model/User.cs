using System.ComponentModel.DataAnnotations;

namespace Sample.Model.EF.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }
    }
}