using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Globalization;
using System.IO;

public class SliderChange : MonoBehaviour
{

    public Slider slider;
    public TextMeshProUGUI sliderText;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sliderText.text = slider.value.ToString("0.0");

        
    }


    void Save()
    {
        string filename = "Labelling_Data" + System.DateTime.Now.ToString("HH-mm-ss") + ".csv";
        string path = Path.Combine(Application.persistentDataPath, filename);
        File.AppendText(filename);
    }
}

