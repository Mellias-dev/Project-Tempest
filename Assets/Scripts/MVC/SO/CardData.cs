using UnityEngine;

[CreateAssetMenu(fileName = "New base Card", menuName = "Cards/Base card")]
public class CardData : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private string _description;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private Sprite _rarity;

    public string Name => _name;
    public string Description => _description;
    public Sprite Sprite => _sprite;
    public Sprite Rarity => _rarity;
}
