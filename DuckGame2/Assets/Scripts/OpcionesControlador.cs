using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.UI;

public class OpcionesControlador : MonoBehaviour
{
    [Header("Sliders")]
    [SerializeField] private Slider brightnessSlider;
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private Slider soundSlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BrightnessSlider()
    {
        UnityEngine.Device.Screen.brightness = brightnessSlider.value;
    }
}
