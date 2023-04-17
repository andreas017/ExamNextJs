namespace ExamNextJsBackend.Models
{
    public class AddToCartModel
    {
        public string RestaurantId { get; set; } = "";
        public int Quantity { get; set; }
        public string FoodItemId { get; set; } = "";
        public string CartId { get; set; } = "";
    }
}
