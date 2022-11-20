using Microsoft.AspNetCore.Mvc.Rendering;

namespace OnlineStore.Models
{
    public class StoreCategoryViewModel
    {
        public List<Store>? Stores { get; set; }

        public SelectList? Categories { get; set; }

        public string? StoreCategory { get; set; }

        public string? SearchString { get; set; } 
    }
}
