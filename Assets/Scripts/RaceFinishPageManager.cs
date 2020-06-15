using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceFinishPageManager : MonoBehaviour
{
    public GameObject BestTimeBox, ThisTimeBox;
    public AudioSource BGMAudio;
    public GameObject InGameBTBox, InGameThisTimeBox;
    public MonoBehaviour HUD;

    // Start is called before the first frame update
    void Start()
    {
        HUD.enabled = false;
        BGMAudio.Stop();
        BestTimeBox.GetComponent<Text>().text = InGameBTBox.GetComponent<Text>().text;
        ThisTimeBox.GetComponent<Text>().text = InGameThisTimeBox.GetComponent<Text>().text;
    }
}
