﻿namespace GripFoodBackEnd.Entities
{
    public class CartDetail
    {
        public string Id { get; set; } = "";
        public string CartId { get; set; } = "";
        public string FoodItemId { get; set; } = "";
        public int Quantity { get; set; }
        public Cart Cart { get; set; } = null!;
        public FoodItem FoodItem { get; set; } = null!;
        public DateTimeOffset CreatedAt { get; set; }
    }
}