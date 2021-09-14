using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private Slider timeSlider;
    [SerializeField] private Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        timeSlider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeSlider.value += 5 * Time.deltaTime;

        if (timeSlider.value >= timeSlider.maxValue) 
        {
            timeText.text = "Finished";
        }
    }
}
