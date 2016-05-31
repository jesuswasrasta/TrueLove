namespace TrueLove
{
	public class Wedding
	{
		public bool LivingTogether(Husband husband, Wife wife)
		{
			var husbandLovesWife = husband.TakesCareOf(wife);
			var wifeLovesHusband = wife.TakesCareOf(husband);

			return husbandLovesWife && wifeLovesHusband;
		}
	}
}