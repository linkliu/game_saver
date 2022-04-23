using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Common;
using Data;
namespace Mod
{
	public class SaveWriter : Singleton<SaveWriter>
	{

		public SaveWriter()
		{
			Init();
		}
		~SaveWriter()
		{ 
			EventManager.Instance.RemoveEventListenter(CommonEvents.SEND_WRITE_DATA_EVENT, OnWriteDataEvent);
		}

		private void Init()
		{
			InitEvents();
		}

		private void InitEvents()
		{
			EventManager.Instance.AddEventListener(CommonEvents.SEND_WRITE_DATA_EVENT, OnWriteDataEvent);
		}

		private void OnWriteDataEvent(DataArgs arg)
		{
			//TODO 1.分解传过来的参数
			//TODO 2.执行文件操作，将存档写入文件 
		}

	}
}
