using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryBusinessLogic.OfficePackage.HelperModels;
using FishFactoryBusinessLogic.OfficePackage.HelperEnums;

namespace FishFactoryBusinessLogic.OfficePackage
{
	public abstract class AbstractSaveToWord
	{
		public void CreateDoc(WordInfo info)
		{
			CreateWord(info);

			CreateParagraph(new WordParagraph
			{
				Texts = new List<(string, WordTextProperties)> { (info.Title, new WordTextProperties { Bold = true, Size = "24", }) },
				TextProperties = new WordTextProperties
				{
					Size = "24",
					JustificationType = WordJustificationType.Center
				}

			});

			foreach (var canned in info.Canneds)
			{
				CreateParagraph(new WordParagraph
				{
					Texts = new List<(string, WordTextProperties)>
					{
						(canned. CannedName + ": ", new WordTextProperties { Size = "24", Bold = true }),
						(canned.Price.ToString(), new WordTextProperties { Size = "24", Bold = false })
					},
					TextProperties = new WordTextProperties
					{
						Size = "24",
						JustificationType = WordJustificationType.Both
					}
				});
			}
			SaveWord(info);
		}
        public void CreateWareHousesDoc(WordInfoWareHouses info)
        {
            CreateWord(new WordInfo
            {
                FileName = info.FileName
            });

            CreateParagraph(new WordParagraph
            {
                Texts = new List<(string, WordTextProperties)>
                {(
                info.Title, new WordTextProperties
                {
                    Bold = true, Size = "24",
                }
                )},
                TextProperties = new WordTextProperties
                {
                    Size = "24",
                    JustificationType = WordJustificationType.Center
                }
            });

            CreateTable();
            CreateTableRow(new WordTableRow
            {
                Cells = new List<WordTableCell>
                {
                    new WordTableCell
                    {
                        Text = "Название",
                        Width = "2800"
                    },
                    new WordTableCell
                    {
                        Text = "ФИО ответственного",
                        Width = "4000"
                    },
                    new WordTableCell
                    {
                        Text = "Дата создания",
                        Width = "2000"
                    }
                },
                Bolded = true
            });

            foreach (var WareHouse in info.WareHouses)
            {
                CreateTableRow(new WordTableRow
                {
                    Cells = new List<WordTableCell>
                    {
                        new WordTableCell
                        {
                            Text = WareHouse.WareHouseName,
                            Width = "2800"
                        },
                        new WordTableCell
                        {
                            Text = WareHouse.ResponsibleFace,
                            Width = "4000"
                        },
                        new WordTableCell
                        {
                            Text = WareHouse.DateCreate.ToString(),
                            Width = "2000"
                        }
                    },
                    Bolded = false
                }); ;
            }

            SaveWord(new WordInfo
            {
                FileName = info.FileName
            });
        }

        protected abstract void CreateWord(WordInfo info);
		protected abstract void CreateParagraph(WordParagraph paragraph);
		protected abstract void SaveWord(WordInfo info);
        protected abstract void CreateTable();
        protected abstract void CreateTableRow(WordTableRow info);

    }
}
