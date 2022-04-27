using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryBusinessLogic.OfficePackage.HelperModels;
using FishFactoryBusinessLogic.OfficePackage.HelperEnums;

namespace FishFactoryBusinessLogic.OfficePackage
{
	public abstract class AbstractSaveToExcel
	{
		public void CreateReport(ExcelInfo info)
		{
			CreateExcel(info);

			InsertCellInWorksheet(new ExcelCellParameters
			{
				ColumnName = "A",
				RowIndex = 1,
				Text = info.Title,
				StyleInfo = ExcelStyleInfoType.Title
			});

			MergeCells(new ExcelMergeParameters
			{
				CellFromName = "A1",
				CellToName = "C1"
			});

			uint rowIndex = 2;
			foreach (var pc in info.CannedComponents)
			{
				InsertCellInWorksheet(new ExcelCellParameters
				{
					ColumnName = "A",
					RowIndex = rowIndex,
					Text = pc.CannedName,
					StyleInfo = ExcelStyleInfoType.Text
				});
				rowIndex++;

				foreach (var component in pc.Components)
				{
					InsertCellInWorksheet(new ExcelCellParameters
					{
						ColumnName = "B",
						RowIndex = rowIndex,
						Text = component.Item1,
						StyleInfo = ExcelStyleInfoType.TextWithBroder
					});

					InsertCellInWorksheet(new ExcelCellParameters
					{
						ColumnName = "C",
						RowIndex = rowIndex,
						Text = component.Item2.ToString(),
						StyleInfo = ExcelStyleInfoType.TextWithBroder
					});

					rowIndex++;
				}

				InsertCellInWorksheet(new ExcelCellParameters
				{
					ColumnName = "C",
					RowIndex = rowIndex,
					Text = pc.TotalCount.ToString(),
					StyleInfo = ExcelStyleInfoType.Text
				});
				rowIndex++;
			}
			SaveExcel(info);
		}
		public void CreateReportWareHouses(ExcelInfoWareHouses info)
		{
			CreateExcel(new ExcelInfo
			{
				FileName = info.FileName
			});

			InsertCellInWorksheet(new ExcelCellParameters
			{
				ColumnName = "A",
				RowIndex = 1,
				Text = info.Title,
				StyleInfo = ExcelStyleInfoType.Title
			});
			MergeCells(new ExcelMergeParameters
			{
				CellFromName = "A1",
				CellToName = "C1"
			});

			uint rowIndex = 2;
			foreach (var sc in info.WareHouseComponents)
			{
				InsertCellInWorksheet(new ExcelCellParameters
				{
					ColumnName = "A",
					RowIndex = rowIndex,
					Text = sc.WareHouseName,
					StyleInfo = ExcelStyleInfoType.Text
				});

				rowIndex++;
				foreach (var component in sc.Components)
				{
					InsertCellInWorksheet(new ExcelCellParameters
					{
						ColumnName = "B",
						RowIndex = rowIndex,
						Text = component.Item1,
						StyleInfo = ExcelStyleInfoType.TextWithBroder
					});
					InsertCellInWorksheet(new ExcelCellParameters
					{
						ColumnName = "C",
						RowIndex = rowIndex,
						Text = component.Item2.ToString(),
						StyleInfo = ExcelStyleInfoType.TextWithBroder
					});

					rowIndex++;
				}

				InsertCellInWorksheet(new ExcelCellParameters
				{
					ColumnName = "C",
					RowIndex = rowIndex,
					Text = sc.TotalCount.ToString(),
					StyleInfo = ExcelStyleInfoType.Text
				});

				rowIndex++;
			}

			SaveExcel(new ExcelInfo
			{
				FileName = info.FileName
			});
		}
		protected abstract void CreateExcel(ExcelInfo info);
		protected abstract void InsertCellInWorksheet(ExcelCellParameters excelParams);
		protected abstract void MergeCells(ExcelMergeParameters excelParams);
		protected abstract void SaveExcel(ExcelInfo info);
	}
}
