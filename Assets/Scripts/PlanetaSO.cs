using UnityEngine;

[CreateAssetMenu(fileName = "Planeta", menuName = "ScriptableObjects/Planeta")]
public class PlanetaSO : ScriptableObject
{
    public int planetaId;
    public string planetaName;
    public string planetaDescription;

    public PlanetaSO(int id, string name, string desc)
    {

        planetaId = id;
        planetaName = name;
        planetaDescription = desc;

    }
}
