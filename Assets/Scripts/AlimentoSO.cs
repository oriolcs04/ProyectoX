using UnityEngine;

[CreateAssetMenu(fileName = "Alimento", menuName = "ScriptableObjects/Alimento")]
public class AlimentoSO : ScriptableObject
{
    public int alimentoId;
    public string alimentoName;
    public string alimentoDescription;
}
