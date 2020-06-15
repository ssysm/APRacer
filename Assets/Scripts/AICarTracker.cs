using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarTracker : MonoBehaviour
{
    public GameObject Tracker;
    public MonoBehaviour AICarControl;
    public GameObject M1,M2,M3,M4,M5,M6,M7,M8,M9,M10,M11,M12,M13;
    public int MarkTracker;
    // Update is called once per frame
    void Update()
    {
        if (MarkTracker == 0) {
			Tracker.transform.position = M1.transform.position;
		}
		if (MarkTracker == 1) {
			Tracker.transform.position = M2.transform.position;
		}
		if (MarkTracker == 2) {
			Tracker.transform.position = M3.transform.position;
		}
		if (MarkTracker == 3) {
			Tracker.transform.position = M4.transform.position;
		}
		if (MarkTracker == 4) {
			Tracker.transform.position = M5.transform.position;
		}
		if (MarkTracker == 5) {
			Tracker.transform.position = M6.transform.position;
		}
        if (MarkTracker == 6) {
			Tracker.transform.position = M7.transform.position;
		}
		if (MarkTracker == 7) {
			Tracker.transform.position = M8.transform.position;
		}
        if (MarkTracker == 8) {
			Tracker.transform.position = M9.transform.position;
		}
        if (MarkTracker == 9) {
			Tracker.transform.position = M10.transform.position;
		}
        if (MarkTracker == 10) {
			Tracker.transform.position = M11.transform.position;
		}
        if (MarkTracker == 11) {
			Tracker.transform.position = M12.transform.position;
		}
        if (MarkTracker == 12) {
			Tracker.transform.position = M13.transform.position;
		}
    }

    IEnumerator OnTriggerEnter(Collider collision) {
		if (collision.gameObject.tag == "AICar") {
			this.GetComponent<BoxCollider> ().enabled = false;
			MarkTracker += 1;
			if (MarkTracker == 13) {
			    this.GetComponent<BoxCollider> ().enabled = false;
                AICarControl.GetComponent<MonoBehaviour>().enabled = false;
			}
			yield return new WaitForSeconds (1);
			this.GetComponent<BoxCollider> ().enabled = true;
		}
	}
}
