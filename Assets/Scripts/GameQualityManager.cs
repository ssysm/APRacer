using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameQualityManager : MonoBehaviour
{
    public GameObject QualityName;

    void Update()
    {
        QualityName.GetComponent<Text>().text =  QualitySettings.names[QualitySettings.GetQualityLevel()];
    }

    void OnGUI()
    {
        string[] names = QualitySettings.names;
        GUILayout.Label("Quality Settings:");
        GUILayout.BeginVertical();
        for (int i = 0; i < names.Length; i++)
        {
            if (GUILayout.Button(names[i]))
            {
                QualitySettings.SetQualityLevel(i, true);
            }
        }
        GUILayout.EndVertical();
    }
}
