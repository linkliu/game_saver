using System;
using System.Collections.Generic;
using Data;
using Common;
namespace Mod
{
    

	public class GameCategorier : Singleton<GameCategorier>
	{
        private void Init()
        {
        }

		public GameData GetCurrentGame()
		{ 
            return new GameData();
		}
        public CategoryEnum GetCategory()
        {
            return CategoryEnum.CateAdd;
        }

        public void SendCateData()
        {

        }

	}
}
