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
		protected abstract void CreateWord(WordInfo info);

		protected abstract void CreateParagraph(WordParagraph paragraph);

		protected abstract void SaveWord(WordInfo info);

	}
}
