﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2020_01_30.ViewModels
{
	public class OdabirTakmicenja
	{
		public int skolaId { get; set; }

		public  List<SelectListItem> Skole { get; set; }

		public string Razred { get; set; }

		public List<SelectListItem> Razredi { get; set;}



	}
}
