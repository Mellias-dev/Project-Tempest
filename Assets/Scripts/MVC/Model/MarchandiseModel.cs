using UnityEngine;

public class MarchandiseModel : CardModel
{
    private MarchandiseData marchandiseData;

    public MarchandiseData MD => marchandiseData;

    public void SetMarchandise(MarchandiseData MD)
    {
        marchandiseData = MD;
    }
}
