using UnityEngine;

[CreateAssetMenu(fileName = "Elemento", menuName = "ScriptableObjects/Elemento")]
public class ElementoSO : ScriptableObject
{
    public int elementoId;
    public string elementoName;
    public string elementoDescription;

    public ElementoSO(int id, string name, string desc)
    {

        elementoId = id;
        elementoName = name;
        elementoDescription = desc;

    }
}
