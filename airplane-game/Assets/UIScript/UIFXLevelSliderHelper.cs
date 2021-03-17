using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIFXLevelSliderHelper : MonoBehaviour
{
    private Slider slider;
    void Awake()
    {
        slider = GetComponent<Slider>();
    }
      void Update()
    {
       Settings.FXLevel =(int) slider.value;
       Debug.Log(Settings.FXLevel);
    }
}
