using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadLapTime : MonoBehaviour
{
    public int MinCount;
    public int SecCount;
    public float MilliCount;

    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;

    private void Start()
    {
        MinCount = PlayerPrefs.GetInt("MinSave");
        SecCount = PlayerPrefs.GetInt("SecSave");
        MilliCount = PlayerPrefs.GetFloat("MilliSave");

        MinDisplay.GetComponent<TextMeshProUGUI>().text = "" + MinCount + ".";
        SecDisplay.GetComponent<TextMeshProUGUI>().text = "" + SecCount + ".";
        MilliDisplay.GetComponent<TextMeshProUGUI>().text = "" + MilliCount;
    }
}
