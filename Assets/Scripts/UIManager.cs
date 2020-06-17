using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject ExitUI,LapTimeManager, CarControl,AICar;
    public AudioSource BGMAudio;
    public AudioListener GAudioListener;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            BGMAudio.Pause();
            LapTimeManager.gameObject.SetActive(false);
            ExitUI.gameObject.SetActive(true);
            CarControl.gameObject.SetActive(false);
            AICar.gameObject.SetActive(false);
        }
    }
}
