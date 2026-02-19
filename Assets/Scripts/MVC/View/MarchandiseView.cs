using TMPro;
using UnityEngine;

public class MarchandiseView : CardView
{
    [SerializeField] private TMP_Text _weight;
    [SerializeField] private TMP_Text _value;

    public void SetCard(MarchandiseModel marchandiseModel)
    {
        base.SetCard(marchandiseModel);

        if (marchandiseModel == null)
        {
            Debug.LogError("Marchandise model is empty");
            return;
        }

        MarchandiseData MD = marchandiseModel.MD;

        _weight.text = $"{MD.Weight}";
        _value.text = $"{MD.Value}";
    }
}
