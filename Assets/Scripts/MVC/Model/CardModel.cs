public class CardModel
{
    private CardData _cardData;
    public bool IsEmpty => _cardData == null;

    public CardData CardD => _cardData;

    public void SetCard(CardData card) => _cardData = card;
}