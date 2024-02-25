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
    public AlienSO(int idAlie, int idAlim, int idPlanet, int idElem, string name, string desc)
    {

        alienId = idAlie;
        alienName = name;
        alienDescription = desc;
        alienIdAlimento = idAlim;
        alienIdPlaneta = idPlanet;
        alienIdElemento = idElem;

    }
}
