using System.Timers;
using Common;
using Data;
namespace Mod
{
	public class GameSaver : Singleton<GameSaver>
	{
		private Timer autoSaveTimr;
		public GameSaver()
		{ 
			Init();
		}

		private void Init()
		{ 
			autoSaveTimr = new Timer();
			InitEvents();
		}
		protected void InitEvents()
		{
			EventManager.Instance.AddEventListener(CommonEvents.SEND_CATE_EVENT, OnSendCateEvent);
		}
		private void OnSendCateEvent(DataArgs arg)
		{ 

		}

	}
}
