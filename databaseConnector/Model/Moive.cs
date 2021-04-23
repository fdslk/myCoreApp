using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace databaseConnector.model{
    [Table("tb_movie")]
    public class Moive : IEntity{
        [Key]
        private long id;
        private string name;
        private int vote;
        [Required(ErrorMessage = "Id is required")]
        public long Id { get => id; set => id = value; }
        [Required(ErrorMessage = "name is required")]
        public string Name { get => name; set => name = value; }
        [Required(ErrorMessage = "vote is required")]
        public int Vote { get => vote; set => vote = value; }
    }

    public interface IEntity
    {
    }
}