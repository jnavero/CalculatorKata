
namespace CalculatorTest
{
	public class Calculator
	{
		public int Value {
			get;
			set;
		}
		public Calculator ()
		{
			this.Value = 0;
		}

		public void Sum (int Operand1, int Operand2)
		{
			Value = Operand1 + Operand2;
		}

		public void Subtract (int Operand1, int Operand2)
		{
			Value = Operand1 - Operand2;
		}
	}
}

