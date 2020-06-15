using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{

    public GameObject _car;
    public float carX, carY, carZ;

    // Update is called once per frame
    void Update()
    {
        carX = _car.transform.eulerAngles.x;
        carY = _car.transform.eulerAngles.y;
        carZ = _car.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(carX - carX, carY, carZ - carZ);
    }
}
