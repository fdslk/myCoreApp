using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace databaseConnector.model{
    public class Moive{
        private long id;
        private string name;
        private int vote;
        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Vote { get => vote; set => vote = value; }
    }
}