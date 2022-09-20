using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System;
using System.Globalization;

public class SavedSliderNumbers : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI sliderText;
    

    //     void Update()
    // {
    //     sliderText.text = slider.value.ToString("0.0");
    //     string filename = "Labelling_Data" + System.DateTime.Now.ToString("HH-mm-ss") + ".csv";
    //     string path = Path.Combine(Application.persistentDataPath, filename);
    //     File.AppendText(filename);


    // }

    
    // TextWriter tw = new ;
    
//     public static void Main()
//    {
//       DateTime localDate = DateTime.Now;
//       DateTime utcDate = DateTime.UtcNow;
//       String[] cultureNames = { "en-GB" };
//    }

    
    public int slot;
    public float stress;
    public float presence;

    public void LoadSettings()
{
    stress = PlayerPrefs.GetFloat("stress" + slot);
    presence = PlayerPrefs.GetFloat("presence" + slot);

}
public void SaveSettings()
{
    PlayerPrefs.SetFloat("stress" + slot, stress);
    PlayerPrefs.SetFloat("presence" + slot, presence);
}

private void OnDisable(){
    PlayerPrefs.Save();
}


// public void WriteCSV(){
//     string filename = "Labelling_Data" + DateTime.Now.ToString("dd-MM-yyyy_hh-mm-ss") + ".csv";
//     TextWriter tw = "";
//     tw.WriteLine(stress + "," + presence);
//     tw.Close();
 }


