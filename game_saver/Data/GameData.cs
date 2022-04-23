using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public enum CategoryEnum : int
    {
        CateAdd = 0,    //添加
        CateDell,       //删除
        CateOverWrite,  //覆盖
        CateRestore,    //还原
    }

	public class GameData
	{
		private string gameName;
		private string sourcePath;
		private string writePath;
		private string aliasName;
		private DateTime dataTime;
	}
}
