﻿using System;

namespace Data.Excel
{
	public interface IExcelReader
	{
		Schema ReadSchema ();
		Row[] ReadData();

        string[] GetTitle(string sheetName);

	}
}