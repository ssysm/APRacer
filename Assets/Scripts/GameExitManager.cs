using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameExitManager : MonoBehaviour
{
    public GameObject QuitUI,LapTimeManager,CarControl,AICar;
    public AudioSource BGMAudio;
    public void Dismiss(){
        QuitUI.gameObject.SetActive(false);
        LapTimeManager.gameObject.SetActive(true);
        BGMAudio.UnPause();
        CarControl.gameObject.SetActive(true);
        AICar.gameObject.SetActive(true);
    }

    public void Exit(){
        SceneManager.LoadScene(0);
    }
}
