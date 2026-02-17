using UnityEngine;

public class CardData : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private string _description;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private Sprite _rarity;

    public string Name { get { return _name; } }
    public string Description { get { return _description; } }
    public Sprite Sprite { get { return _sprite; } }

    public Sprite rarity { get { return _rarity; } }
}
