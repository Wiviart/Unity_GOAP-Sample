using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GUI_Gameplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    void Start()
    {
        Time.timeScale = 5;
    }
    void LateUpdate()
    {
        Dictionary<string, int> worldStates = GWorld.Instance.GetWorld().GetStates();

        text.text = "";

        foreach (KeyValuePair<string, int> s in worldStates)
        {
            text.text += s.Key + ": " + s.Value + "\n";
        }
    }
}
