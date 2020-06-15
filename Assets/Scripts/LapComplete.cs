using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject BestTimeBox;
    public GameObject FinishRaceUI;
    public GameObject CarControl, AICarControl;
    public MonoBehaviour LapTimer;

    void OnTriggerEnter(Collider collision) {
        if(collision.gameObject.tag == "AICar"){
            return;
        }

        float thisTime = (LapTimeManager.MinCount * 60) + (LapTimeManager.SecCount) + (LapTimeManager.MillSecCount*10);
        if(LapTimeManager.BestTime == 0){
            saveBest();
        }
        else if(thisTime < LapTimeManager.BestTime){
            saveBest();
        }

        BestTimeBox.GetComponent<Text>().text = string.Format("{0}:{1}:{2}",
            LapTimeManager.BMinCount,LapTimeManager.BSecCount,LapTimeManager.BMillSecCount); 

        CarControl.gameObject.SetActive(false);
        AICarControl.gameObject.SetActive(false);
        FinishRaceUI.SetActive(true);
        LapTimer.enabled = false;

        LapTimeManager.MinCount = 0;
        LapTimeManager.SecCount = 0;
        LapTimeManager.MillSecCount = 0;
        LapTimeManager.MillSecDisplay = "0";
    }

    void saveBest(){
        PlayerPrefs.SetInt("BMin", LapTimeManager.MinCount);
        PlayerPrefs.SetInt("BSec", LapTimeManager.SecCount);
        PlayerPrefs.SetFloat("BMill", LapTimeManager.MillSecCount);
        LapTimeManager.BMinCount = LapTimeManager.MinCount;
        LapTimeManager.BSecCount = LapTimeManager.SecCount;
        LapTimeManager.BMillSecCount = LapTimeManager.MillSecCount;
    }
}
