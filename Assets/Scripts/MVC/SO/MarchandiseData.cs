using UnityEngine;

[CreateAssetMenu(fileName = "New Marchandise", menuName = "Cards/Marchandise card")]
public class MarchandiseData : CardData
{
    [SerializeField] private int _weight;
    [SerializeField] private int _value;

    public int Weight => _weight;
    public int Value => _value;
}
