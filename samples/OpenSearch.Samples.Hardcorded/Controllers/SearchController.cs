namespace OpenSearch.Samples.Hardcoded.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using Microsoft.AspNet.Mvc;

	[Route("[controller]")]
	public class SearchController : Controller
	{
		// GET
		[HttpGet]
		public IEnumerable<string> Get(
			[FromQuery(Name = "q")] string query,
			[FromQuery] string format,
			[FromQuery(Name = "pw")] int? startPage)
		{
			return new string[] { "value1", "value2" };
		}
	}
}
