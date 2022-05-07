using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.BusinessLogicsContracts;
using FishFactoryContracts.ViewModels;

namespace FishFactoryRestApi.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class ClientController : ControllerBase
	{
		private readonly IClientLogic _clientlogic;

		private readonly IMessageInfoLogic _messageLogic;
		public ClientController(IClientLogic clientlogic, IMessageInfoLogic messageLogic)
		{
			_clientlogic = clientlogic;
			_messageLogic = messageLogic;
		}

		[HttpGet]
		public ClientViewModel Login(string login, string password)
		{
			var list = _clientlogic.Read(new ClientBindingModel
			{
				Email = login,
				Password = password
			});
			return (list != null && list.Count > 0) ? list[0] : null;
		}

		[HttpPost] 
		public void Register(ClientBindingModel model) => _clientlogic.CreateOrUpdate(model);

		[HttpPost] 
		public void UpdateData(ClientBindingModel model) => _clientlogic.CreateOrUpdate(model);

		[HttpGet]
		public List<MessageInfoViewModel> GetMessages(int clientId) => _messageLogic.Read(new MessageInfoBindingModel { ClientId = clientId });
	}
}
