namespace CRUD_API.Models
{
    public class Cart
    {
        public int id { get; set; }
        public User userId { get; set; }
        public string date { get; set; }
        public string[] products {get; set; }
    }
}
