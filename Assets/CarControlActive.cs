using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{
    public GameObject carControl;

    void Start()
    {
        carControl.GetComponent<CarController>().enabled = true;
    }
}
