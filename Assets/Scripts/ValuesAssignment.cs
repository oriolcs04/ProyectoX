using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Asigne : MonoBehaviour
{
    public BBDD bbddValues;

    public TextMeshPro idValue;
    public TextMeshPro nameValue;
    public TextMeshPro descriptionValue;


    // Start is called before the first frame update
    void Start()
    {
        idValue.text = "ERROR";
        descriptionValue.text = "" + bbddValues.aliens.Count;
        descriptionValue.text = bbddValues.aliens[0].alienDescription;

        switch (this.name)
        {
            case "EscenaMecha":
                Debug.Log("EscenaMecha");
                idValue.text = "Nº." + bbddValues.aliens[0].alienId.ToString();
                nameValue.text = bbddValues.aliens[0].alienName;
                descriptionValue.text = bbddValues.aliens[0].alienDescription;
                break;
            case "EscenaRobot":
                Debug.Log("EscenaRobot");
                idValue.text = "Nº." + bbddValues.aliens[3].alienId.ToString();
                nameValue.text = bbddValues.aliens[3].alienName;
                descriptionValue.text = bbddValues.aliens[3].alienDescription;
                break;
            case "EscenaJawa":
                Debug.Log("EscenaJawa");
                idValue.text = "Nº." + bbddValues.aliens[2].alienId.ToString();
                nameValue.text = bbddValues.aliens[2].alienName;
                descriptionValue.text = bbddValues.aliens[2].alienDescription;
                break;
            case "EscenaCaballito":
                Debug.Log("EscenaCaballito");
                idValue.text = "Nº." + bbddValues.aliens[1].alienId.ToString();
                nameValue.text = bbddValues.aliens[1].alienName;
                descriptionValue.text = bbddValues.aliens[1].alienDescription;
                break;
            default:
                idValue.text = "ERROR";
                break;
        }
    }

}
