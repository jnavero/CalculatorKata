using NUnit.Framework;

namespace CalculatorTest
{

	[TestFixture]
	public class SumTest
	{

		[TestCase]
		public void A_new_Calc_start_in_cero() //This function will be moved
		{
			//Arrange
			var calc = new Calculator();

			//Act

			//Assert
			Assert.AreEqual (0, calc.Value);
		}

		[TestCase]
		public void Sum_2_and_3_Are_5()
		{
			//Arrange
			var calc = new Calculator ();

			//Act
			calc.Sum (2, 3);

			//Assert
			Assert.AreEqual (5, calc.Value);
		}

		[TestCase]
		public void Sum_4_and_3_Are_7()
		{
			//Arrange
			var calc = new Calculator ();

			//Act
			calc.Sum (4, 3);

			//Assert
			Assert.AreEqual (7, calc.Value);
		}


	}
}

