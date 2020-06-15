using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject ExitUI;
    public AudioSource BGMAudio;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            BGMAudio.Pause();
            ExitUI.gameObject.SetActive(true);
        }
    }
}
