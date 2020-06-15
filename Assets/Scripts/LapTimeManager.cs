using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{

    public static int MinCount, SecCount;
    public static float MillSecCount;
    public static string MillSecDisplay;


    public static int BMinCount, BSecCount;
    public static float BMillSecCount,BestTime;
    public GameObject DisplayBox,BestTimeBox;

    void getBest(){
        BMinCount = PlayerPrefs.GetInt("BMin");
        BSecCount = PlayerPrefs.GetInt("BSec");
        BMillSecCount = PlayerPrefs.GetFloat("BMill");
        BestTime = (BMinCount * 60) + (BSecCount) + (BMillSecCount*10);
        BestTimeBox.GetComponent<Text>().text = string.Format("{0}:{1}:{2}",
            BMinCount,BSecCount,BMillSecCount); 
    }

    void Start()
    {
        this.getBest();
    }

    // Update is called once per frame
    void Update()
    {
        MillSecCount += Time.deltaTime * 10;
        MillSecDisplay = MillSecCount.ToString("F0");

        if(MillSecCount >= 10)
        {
            MillSecCount = 0;
            SecCount += 1;
        }

        if(SecCount >= 60)
        {
            SecCount = 0;
            MinCount++;
        }
        DisplayBox.GetComponent<Text>().text = string.Format("{0}:{1}:{2}",MinCount,SecCount,MillSecDisplay); 
    }
}
