using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myProjectApi
{
	//IoC контейнеры
	public class SimpleConfigModule : NinjectModule
	{

		//public override void Load()
		//{
		//	Bind<IScheduleManager>().To<ScheduleManager>();
		//	// нижняя строка необязательна, это поведение стоит по умолчанию:
		//	// класс подставляет сам себя
		//	Bind<ScheduleViewer>().ToSelf();
		//}
		public override void Load()
		{
			throw new NotImplementedException();
		}
	}
}
