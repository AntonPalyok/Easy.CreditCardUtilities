## Easy Credit Card Utilities

Provides method to determine credit card type, e.g Visa, MasterCard by its number.

#### Usage:

```c#
var cardType = CreditCardUtilities.GetCreditCardType("4111111111111111");
```

Possible card types to determine:

- Visa
- MasterCard
- AmericanExpress
- Discover
- DinersClub



#### Useful Links

- Table with rules to determine card type by number  
  https://en.wikipedia.org/wiki/Payment_card_number
- Card generator, validator and table with rules to determine card type by number  
  https://www.vccgenerator.org/
- Rules to determine card type by number from Braintree  
  https://github.com/braintree/credit-card-type/blob/main/src/lib/card-types.ts

