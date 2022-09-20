using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System;
using System.Globalization;

public class P_SaveSliderNumber : MonoBehaviour
{

    public Slider Presence_slider;

    public float sliderPresenceValue;

    public void start()
    {
        Presence_slider.value = PlayerPrefs.GetFloat("save", sliderPresenceValue);
    }

    public void ChangeSlider(float value)
    {
        sliderPresenceValue = value;
        PlayerPrefs.SetFloat("save", sliderPresenceValue);

    }
    // TextWriter tw = new ;
    
//     public static void Main()
//    {
//       DateTime localDate = DateTime.Now;
//       DateTime utcDate = DateTime.UtcNow;
//       String[] cultureNames = { "en-GB" };
//    }

    
//     public int slot;
//     public float stress;
//     public float presence;

//     public void LoadSettings()
// {
//     stress = PlayerPrefs.GetFloat("stress" + slot);
//     presence = PlayerPrefs.GetFloat("presence" + slot);

// }
// public void SaveSettings()
// {
//     PlayerPrefs.SetFloat("stress" + slot, stress);
//     PlayerPrefs.SetFloat("presence" + slot, presence);
// }

private void OnDisable(){
    PlayerPrefs.Save();
}

// public void WriteCSV(){
//     string filename = "Labelling_Data" + DateTime.Now.ToString("dd-MM-yyyy_hh-mm-ss") + ".csv";
//     TextWriter tw = "";
//     tw.WriteLine(stress + "," + presence);
//     tw.Close();
// }
 
}

