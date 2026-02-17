using UnityEngine;

[System.Serializable]
public class CardModel
{
    // Card assigned to this slot (null when empty)
    public CardData CardSlot { get; set; }
    public bool IsEmpty => CardSlot == null;

    public void SetCard(CardData card)
        { CardSlot = card; }
}
