namespace all_recipes1.Data.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCooked { get; set; }
        public string Category { get; set; }
        public string Ingredients { get; set; }
        public int CookingTime { get; set; }
        public System.DateTime? DateCooked { get; set; }
        public int? Rate { get; set; }
        public string CoverUrl { get; set; }
        public System.DateTime DateAdded { get; set; }
    }
}
