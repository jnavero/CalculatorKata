using System;
using NUnit.Framework;

namespace CalculatorTest
{
	[TestFixture]
	public class SubtratTest
	{
		// I want not use [Setup]

		[TestCase]
		public void Subtract_2_minus_1_are_1()
		{
			//Arrange
			var calc = new Calculator ();

			//Act
			calc.Subtract (2, 1);

			//Assert
			Assert.AreEqual (1,calc.Value);
		}

		[TestCase]
		public void Subtract_5_minus_3_are_2()
		{
			//Arrange
			var calc = new Calculator ();

			//Act
			calc.Subtract (5, 3);

			//Assert
			Assert.AreEqual (2, calc.Value);
		}

	}
}

