using UnityEngine;

[CreateAssetMenu(fileName = "Alien", menuName = "ScriptableObjects/Alien")]
public class AlienSO : ScriptableObject
{
    public int alienId;
    public string alienName;
    public string alienDescription;
    public int alienIdAlimento;
    public int alienIdPlaneta;
    public int alienIdElemento;
    public AlienSO(string name)
    {

        alienId = default;
        alienName = name;
        alienDescription = default;
        alienIdAlimento = default;
        alienIdPlaneta = default;
        alienIdElemento = default;

    }
}
