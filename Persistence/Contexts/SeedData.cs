namespace Supermarket.API.Persistence.Contexts
{
    public static class SeedData
    {
        public static async Task Seed(AppDbContext context)
        {
            // Check if categories already exist to avoid duplicating data
            if (!context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new() { Id = 1, Name = "Fruits and Vegetables" },
                    new() { Id = 2, Name = "Dairy" }
                };

                context.Categories.AddRange(categories);
                await context.SaveChangesAsync();
            }


        }
    }
}