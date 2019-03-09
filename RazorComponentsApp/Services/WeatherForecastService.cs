using System;
using System.Linq;
using System.Threading.Tasks;

namespace RazorComponentsApp.Services
{
	public class WeatherForecastService
	{
		private static string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching",
			"Sinjul","MSBH","Jack","Slater"
		};

		public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
		{
			var rng = new Random();
			return Task.FromResult(Enumerable.Range(1, Summaries.Length).Select(index => new WeatherForecast
			{
				Date = startDate.AddDays(index),
				TemperatureC = rng.Next(-20, 55),
				Summary = Summaries[rng.Next(Summaries.Length)]
			}).ToArray());
		}
	}
}
