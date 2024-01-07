using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RedHorizonSite.Data;
using RedHorizonSite.Data.Database;

namespace RedHorizonSite.Pages;

public class IndexModel(RhContext context) : PageModel
{
    public IEnumerable<ShowDetails> ShowDetails { get => SeedData.GetShowDetailData(); }
}
