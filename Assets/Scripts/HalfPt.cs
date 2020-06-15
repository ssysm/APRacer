using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPt : MonoBehaviour
{  
    public GameObject LapCompeteTrig, HalfLapTrig;

    void OnTriggerEnter() {
        LapCompeteTrig.SetActive(true);
        HalfLapTrig.SetActive(false);
    }
}
