using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class CardView : MonoBehaviour
{
    [SerializeField] private Image _rarity;
    [SerializeField] private Image _sprite;
    [SerializeField] private TMP_Text _name;
    [SerializeField] private TMP_Text _description;


    public void SetCard(CardModel cardModel)
    {
        if (cardModel != null)
        {
            Debug.LogError("Card model is empty");
            return;
        }

        CardData data = cardModel.CardD;

        _name.text = data.Name;
        _description.text = data.Description;
        _sprite.sprite = data.Sprite;
        _rarity.sprite = data.Rarity;
    }

}
