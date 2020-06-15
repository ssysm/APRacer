using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject MainCam, FPVCam;
    public int cam = 0;

    void Update()
    {
        if(Input.GetButtonDown("Viewmode"))
        {
            if(cam == 1){
                cam = 0;
            }else{
                cam++;
            }
            StartCoroutine(ModeChange());
        }
        
    }
    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if(cam == 0){
            MainCam.SetActive(true);
            FPVCam.SetActive(false);
        }if(cam == 1){
            MainCam.SetActive(false);
            FPVCam.SetActive(true);   
        }
    }

}
