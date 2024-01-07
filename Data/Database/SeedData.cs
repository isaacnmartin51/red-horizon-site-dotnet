namespace RedHorizonSite.Data;

public static class SeedData
{
    public static IEnumerable<ShowDetails> GetShowDetailData()
    {
        var details = new List<ShowDetails>();

        for (int i = 0; i < 10; i++)
        {
            var detailToAdd = new ShowDetails()
            {
                Id = Guid.NewGuid(),
                Name = $"Name {i}",
                Time = DateTime.Now.AddDays(i),
                Details = $"Yo these are details {i}"
                
            };
            details.Add(detailToAdd);
        }

        return details;
    }

}