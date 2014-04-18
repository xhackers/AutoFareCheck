using System;

namespace Autofare.PCL
{
	public class Fare
	{
		public static string CalculateFare(double distance)
		{
			double fare = (distance < 1.9) ? 25 : (distance - 1.9) * 13 + 25;
			return "It would cost Rs." + string.Format("{0:0.00}", fare) + " and post 11pm till 6am, it is Rs." + string.Format("{0:0.00}", fare * 1.5) + "\nWaiting charges could add Rs.20/hour. First 5 mins free. Rs.5/15 mins.\nLuggage charges might be Rs.2 for more than 20kgs";

		}
	}
}