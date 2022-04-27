using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.BusinessLogicsContracts;
using FishFactoryContracts.StoragesContracts;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.ViewModels;
using FishFactoryBusinessLogic.OfficePackage;
using FishFactoryBusinessLogic.OfficePackage.HelperModels;

namespace FishFactoryBusinessLogic.BusinessLogics
{
    public class ReportLogic : IReportLogic
    {
        private readonly ICannedStorage _cannedStorage;

        private readonly IOrderStorage _orderStorage;

        private readonly IWareHouseStorage _wareHouseStorage;

        private readonly AbstractSaveToExcel _saveToExcel;

        private readonly AbstractSaveToWord _saveToWord;

        private readonly AbstractSaveToPdf _saveToPdf;

        public ReportLogic(ICannedStorage cannedStorage, IOrderStorage orderStorage, IWareHouseStorage wareHouseStorage, AbstractSaveToExcel saveToExcel, AbstractSaveToWord saveToWord, AbstractSaveToPdf saveToPdf)
        {
            _cannedStorage = cannedStorage;
            _orderStorage = orderStorage;
            _wareHouseStorage = wareHouseStorage;
            _saveToExcel = saveToExcel;
            _saveToWord = saveToWord;
            _saveToPdf = saveToPdf;
        }
        public List<ReportCannedComponentViewModel> GetCannedComponent()
        {

            var canneds = _cannedStorage.GetFullList();

            var list = new List<ReportCannedComponentViewModel>();

            foreach (var canned in canneds)
            {
                var record = new ReportCannedComponentViewModel
                {
                    CannedName = canned.CannedName,
                    Components = new List<Tuple<string, int>>(),
                    TotalCount = 0
                };
                foreach (var component in canned.CannedComponents)
                {
                    record.Components.Add(new Tuple<string, int>(component.Value.Item1, component.Value.Item2));
                    record.TotalCount += component.Value.Item2;
                }

                list.Add(record);
            }
            return list;
        }
        public List<ReportWareHouseComponentViewModel> GetWareHouseComponent()
        {
            var wareHouses = _wareHouseStorage.GetFullList();
            var list = new List<ReportWareHouseComponentViewModel>();
            foreach (var wareHouse in wareHouses)
            {
                var record = new ReportWareHouseComponentViewModel
                {
                    WareHouseName = wareHouse.WareHouseName,
                    Components = new List<Tuple<string, int>>(),
                    TotalCount = 0
                };
                foreach (var component in wareHouse.WareHouseComponents)
                {
                    record.Components.Add(new Tuple<string, int>(component.Value.Item1, component.Value.Item2));
                    record.TotalCount += component.Value.Item2;
                }
                list.Add(record);
            }
            return list;
        }
        public List<ReportOrdersViewModel> GetOrders(ReportBindingModel model)
        {
            return _orderStorage.GetFilteredList(new OrderBindingModel
            {
                DateFrom = model.DateFrom,
                DateTo = model.DateTo
            })
                .Select(x => new ReportOrdersViewModel
                {
                    DateCreate = x.DateCreate,
                    CannedName = x.CannedName,
                    Count = x.Count,
                    Sum = x.Sum,
                    Status = x.Status
                })
            .ToList();
        }
        public List<ReportOrdersByDateViewModel> GetOrdersByDate()
        {
            return _orderStorage.GetFullList()
                .GroupBy(order => order.DateCreate.ToShortDateString())
                .Select(rec => new ReportOrdersByDateViewModel
                {
                    Date = Convert.ToDateTime(rec.Key),
                    Count = rec.Count(),
                    Sum = rec.Sum(order => order.Sum)
                })
                .ToList();
        }
        public void SaveCannedsToWordFile(ReportBindingModel model)
        {
            _saveToWord.CreateDoc(new WordInfo
            {
                FileName = model.FileName,
                Title = "Список изделий",
                Canneds = _cannedStorage.GetFullList()
            });
        }
        public void SaveWareHousesToWordFile(ReportBindingModel model)
        {
            _saveToWord.CreateWareHousesDoc(new WordInfoWareHouses
            {
                FileName = model.FileName,
                Title = "Список складов",
                WareHouses = _wareHouseStorage.GetFullList()
            });
        }
        public void SaveCannedComponentToExcelFile(ReportBindingModel model)
        {
            _saveToExcel.CreateReport(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "Список изделий",
                CannedComponents = GetCannedComponent()
            });
        }
        public void SaveWareHouseComponentToExcelFile(ReportBindingModel model)
        {
            _saveToExcel.CreateReportWareHouses(new ExcelInfoWareHouses
            {
                FileName = model.FileName,
                Title = "Список складов",
                WareHouseComponents = GetWareHouseComponent()
            });
        }
        public void SaveOrdersToPdfFile(ReportBindingModel model)
        {
            _saveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Список заказов",
                DateFrom = model.DateFrom.Value,
                DateTo = model.DateTo.Value,
                Orders = GetOrders(model)
            });
        }
        public void SaveOrdersByDateToPdfFile(ReportBindingModel model)
        {
            _saveToPdf.CreateDocOrderReportByDate(new PdfInfoOrderReportByDate
            {
                FileName = model.FileName,
                Title = "Список заказов за весь период",
                Orders = GetOrdersByDate()
            });
        }
    }
}
