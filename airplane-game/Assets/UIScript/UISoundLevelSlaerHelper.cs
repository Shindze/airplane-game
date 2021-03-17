   using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UISoundLevelSlaerHelper : MonoBehaviour
{
    private Slider slider;
    void Awake()
    {
        slider = GetComponent<Slider>();
    }
      void Update()
    {
       Settings.soundLevel =(int) slider.value;
       Debug.Log(Settings. soundLevel);
    }
}

