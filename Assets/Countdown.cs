using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class Countdown : MonoBehaviour
{
    [SerializeField] private GameObject countdown;
    [SerializeField] private GameObject LapTimer;
    [SerializeField] private GameObject panelTimer;
    [SerializeField] private GameObject CarControls;
    [SerializeField] private GameObject carUserControl;

    [SerializeField] private AudioSource countdownSound;
    [SerializeField] private AudioSource finishSound;

    private void Start() 
    {
        StartCoroutine(CountStart());
        carUserControl.GetComponent<CarUserControl>().enabled = false;
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        countdown.GetComponent<TextMeshProUGUI>().text = "3";
        countdown.SetActive(true);
        countdownSound.Play();
        yield return new WaitForSeconds(1);
        countdown.SetActive(false);
        countdown.GetComponent<TextMeshProUGUI>().text = "2";
        countdown.SetActive(true);
        countdownSound.Play();
        yield return new WaitForSeconds(1);
        countdown.SetActive(false);
        countdown.GetComponent<TextMeshProUGUI>().text = "1";
        countdown.SetActive(true);
        countdownSound.Play();
        yield return new WaitForSeconds(1f);
        finishSound.Play();
        countdown.SetActive(false);
        panelTimer.SetActive(false);
        LapTimer.SetActive(true);
        CarControls.SetActive(true);
        carUserControl.GetComponent<CarUserControl>().enabled = true;
    }
}
