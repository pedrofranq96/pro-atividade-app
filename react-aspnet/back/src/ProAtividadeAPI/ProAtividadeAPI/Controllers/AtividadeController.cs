using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAtividadeAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AtividadeController : ControllerBase
	{
		[HttpGet]
		public string get()
		{
			return "teste";
		}
	}
}
