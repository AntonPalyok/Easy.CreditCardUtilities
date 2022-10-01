namespace Easy.CreditCardUtilities.Tests;

public class CreditCardTypeTests
{
	[Theory]
	[InlineData("4016808667652259")]
	[InlineData("4111111111111111")]
	[InlineData("4485996379516524")]
	public void CreditCardType_ShouldBe_Visa(string cardNumber)
	{
		var cardType = CreditCardUtilities.GetCreditCardType(cardNumber);

		Assert.Equal(CreditCardType.Visa, cardType);
	}

	[Theory]
	[InlineData("5100060000000002")]
	[InlineData("5201285565672311")]
	[InlineData("5354405286162021")]
	[InlineData("5454547699084950")]
	[InlineData("5555341244441115")]
	[InlineData("2221003512041156")]
	[InlineData("2222400050000009")]
	[InlineData("2720991613758965")]
	public void CreditCardType_ShouldBe_MasterCard(string cardNumber)
	{
		var cardType = CreditCardUtilities.GetCreditCardType(cardNumber);

		Assert.Equal(CreditCardType.MasterCard, cardType);
	}

	[Theory]
	[InlineData("370000000100018")]
	[InlineData("344999312225361")]
	public void CreditCardType_ShouldBe_AmericanExpress(string cardNumber)
	{
		var cardType = CreditCardUtilities.GetCreditCardType(cardNumber);

		Assert.Equal(CreditCardType.AmericanExpress, cardType);
	}

	[Theory]
	[InlineData("6011601160116611")]
	[InlineData("6445644564456445")]
	[InlineData("657998262379")]
	public void CreditCardType_ShouldBe_Discover(string cardNumber)
	{
		var cardType = CreditCardUtilities.GetCreditCardType(cardNumber);

		Assert.Equal(CreditCardType.Discover, cardType);
	}

	[Theory]
	[InlineData("30091722010033")]
	[InlineData("30177612126524")]
	[InlineData("30293660108841")]
	[InlineData("30321398910137")]
	[InlineData("30410189222065")]
	[InlineData("30585881873495")]
	[InlineData("36070500001020")]
	[InlineData("3818358686143379")]
	public void CreditCardType_ShouldBe_DinersClub(string cardNumber)
	{
		var cardType = CreditCardUtilities.GetCreditCardType(cardNumber);

		Assert.Equal(CreditCardType.DinersClub, cardType);
	}
}
