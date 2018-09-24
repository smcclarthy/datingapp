using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.API.Models{
    public class Value{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{get;set;}
        public string Name { get; set; }
    }
    
}