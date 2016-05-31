using NUnit.Framework;


namespace TrueLove.Tests
{
	[TestFixture]
    public class WeddingTests
    {
		const bool TrueLove = true;

		[Test]
		public void IsTrueLove()
		{
			var luca = new Husband();
			var elisabetta = new Wife();

			var wedding = new Wedding();
			var actualResult = wedding.LivingTogether(luca, elisabetta);

			Assert.That(actualResult, Is.EqualTo(TrueLove));
		}
    }
}
