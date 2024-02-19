using System.Threading.Channels;
using UsingTime;

TimeOfDayService timeOfDayService = new TimeOfDayService(TimeProvider.System);

Console.WriteLine(timeOfDayService.GetTimeOfDay());