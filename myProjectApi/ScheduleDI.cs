using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myProjectApi
{
	// DI 
    public class ScheduleDI
	{

		ScheduleViewer scheduleViewer = new ScheduleViewer(new ScheduleManager()); //воспользоваться нашим классом для отображения расписания мы пишем

		interface IScheduleManager
		{
			ScheduleDI GetSchedule();
		}

		class ScheduleManager : IScheduleManager
		{
			public ScheduleDI GetSchedule()
			{
				// Do Something by init schedule...     
				return GetSchedule();
			}
		}

		class ScheduleViewer
		{
			private IScheduleManager _scheduleManager;
			public ScheduleViewer(IScheduleManager scheduleManager)
			{
				_scheduleManager = scheduleManager;
			}
			public void RenderSchedule()
			{
				_scheduleManager.GetSchedule();
				// Do Something by render schedule... 
			}
		}
	}
}
