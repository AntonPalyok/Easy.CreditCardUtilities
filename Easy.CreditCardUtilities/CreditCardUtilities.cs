namespace Easy.CreditCardUtilities;

public static class CreditCardUtilities
{
	public static CreditCardType GetCreditCardType(string cardNumber)
	{
		if (string.IsNullOrWhiteSpace(cardNumber)) return CreditCardType.Unknown;

		if (cardNumber.Length < 12) return CreditCardType.Unknown;

		if (!int.TryParse(cardNumber.Substring(0, 1), out int firstOneDigit)) return CreditCardType.Unknown;
		if (!int.TryParse(cardNumber.Substring(0, 2), out int firstTwoDigits)) return CreditCardType.Unknown;
		if (!int.TryParse(cardNumber.Substring(0, 3), out int firstThreeDigits)) return CreditCardType.Unknown;
		if (!int.TryParse(cardNumber.Substring(0, 4), out int firstFourDigits)) return CreditCardType.Unknown;
		if (!int.TryParse(cardNumber.Substring(0, 6), out int firstSixDigits)) return CreditCardType.Unknown;

		if (firstOneDigit == 4)
		{
			return CreditCardType.Visa;
		}

		if ((firstTwoDigits >= 51 && firstTwoDigits <= 55) ||
			(firstFourDigits >= 2221 && firstFourDigits <= 2720))
		{
			return CreditCardType.MasterCard;
		}

		if (firstTwoDigits == 34 || firstTwoDigits == 37)
		{
			return CreditCardType.AmericanExpress;
		}

		if ((firstTwoDigits == 65) ||
			(firstThreeDigits >= 644 && firstThreeDigits <= 649) ||
			(firstFourDigits == 6011) ||
			(firstSixDigits >= 622126 && firstSixDigits <= 622925))
		{
			return CreditCardType.Discover;
		}

		if ((firstTwoDigits == 36) ||
			(firstTwoDigits == 38) ||
			(firstTwoDigits == 39) ||
			(firstThreeDigits >= 300 && firstThreeDigits <= 305) ||
			(firstThreeDigits == 309))
		{
			return CreditCardType.DinersClub;
		}

		return CreditCardType.Unknown;
	}
}
