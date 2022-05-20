using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    public GameObject MinuteDisplay;

    public GameObject SecondDisplay;
    public GameObject MilliDisplay;
    public GameObject LapTimeBox;

    public GameObject LapCounter;
    public GameObject RaceFinish;
    public int LapsDone;

    public float RawTime;

    private void Update()
    {
        if (LapsDone == 3)
        {
            RaceFinish.SetActive(true);
        }
    }

    private void OnTriggerEnter() {
        LapsDone += 1;
        RawTime = PlayerPrefs.GetFloat("RawTime");

        if(LapTimeManager.RawTime <= RawTime)
        {
            if (LapTimeManager.SecondCount <= 9)
            {
                SecondDisplay.GetComponent<TextMeshProUGUI>().text = "0" + LapTimeManager.SecondCount + ".";
            }
            else
            {
                SecondDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.SecondCount + ".";
            }

            if (LapTimeManager.MinuteCount <= 9)
            {
                MinuteDisplay.GetComponent<TextMeshProUGUI>().text = "0" + LapTimeManager.MinuteCount + ".";
            }
            else
            {
                MinuteDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.MinuteCount + ".";
            }

            MilliDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.MilliCount;
        }

        PlayerPrefs.SetInt("MinSave", LapTimeManager.MinuteCount);
        PlayerPrefs.SetInt("SecSave", LapTimeManager.SecondCount);
        PlayerPrefs.SetFloat("MilliSave", LapTimeManager.MilliCount);
        PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);

        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;
        LapTimeManager.RawTime = 0;

        LapCounter.GetComponent<TextMeshProUGUI>().text = "" + LapsDone;

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);

        if (LapTimeManager.MilliCount > 9) {
            LapTimeManager.MilliCount = 0;
            MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;
        }
    }

}
