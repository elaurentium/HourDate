using System;
using System.Threading;

namespace HourDate
{
    //main class

    public class MainClass {
        public static void Main() {
            string version = "1.0";
            string WeekDay;
            string Month;

            console.WriteLine("===============");
            console.WriteLine("Hour & Data - Version {0}", version);
            console.WriteLine("===============");
            console.WriteLine("Hint: Press CTRL + C to exit!\n");
        
            //Count update timestamp each 1 seconds
            while(true) {
                switch ((int)DateTime.Now.DayOfWeek)
                {
                    case 0:
                        WeekDay = "Sunday"
                        break;
                    case 1:
                        WeekDay = "Monday"
                        break:
                    case 2:
                        WeekDay = "Tuesday"
                        break:
                    case 3:
                        WeekDay = "Wednesday"
                        break:
                    case 4:
                        WeekDay = "Thursdat"
                        break:
                    case 5:
                        WeekDay = "Friday"
                        break:
                    case 6:
                        WeekDay = "Saturday"
                        break:
                    default:
                        WeekDay = "N/D";
                        break;
                }
                //Determinated for each month names
                switch ((int)DataTime.Now.Month)
                {
                     case 1:
						Month = "January";
						break;
					case 2:
						Month = "February";
						break;
					case 3:
						Month = "March";
						break;
					case 4:
						Month = "April";
						break;
					case 5:
						Month = "May";
						break;
					case 6:
						Month = "June";
						break;
					case 7:
						Month = "July";
						break;
					case 8:
						Month = "August";
						break;
					case 9:
						Month = "September";
						break;
					case 10:
						Month = "October";
						break;
					case 11:
						Month = "November";
						break;
					case 12:
						Month = "December";
						break;
                    default:
                        Month = "N/D";
                        break;
                }
                //Date and hour are update at same line
                Console.WriteLine("\r{0} - {1} / {2} / {3} - {4}",
                    WeekDay, DateTime.Now.ToString("dd"),
                    Month, DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("HH:mm:ss"));
                    
                //Main thread wait 1 second before keep loop
                Thread.Sleep(1000);
            }
        }
    }
}