using UnityEngine;

[CreateAssetMenu(fileName = "Alimento", menuName = "ScriptableObjects/Alimento")]
public class AlimentoSO : ScriptableObject
{
    public int alimentoId;
    public string alimentoName;
    public string alimentoDescription;

    public AlimentoSO(int id, string name, string desc)
    {

        alimentoId = id;
        alimentoName = name;
        alimentoDescription = desc;

    }
}
