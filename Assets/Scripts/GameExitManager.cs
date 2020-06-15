using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameExitManager : MonoBehaviour
{
    public GameObject QuitUI;
    public AudioSource BGMAudio;
    public void Dismiss(){
        QuitUI.gameObject.SetActive(false);
        BGMAudio.UnPause();
    }

    public void Exit(){
        SceneManager.LoadScene(0);
    }
}
