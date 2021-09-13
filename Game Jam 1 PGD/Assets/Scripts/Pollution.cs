using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pollution : MonoBehaviour
{
    [SerializeField] private GameObject _pollutedWater;

    [Range(0, 100)]
    public int _currentPollution = 0;
    [SerializeField] private int _maxPollution = 100;

    [SerializeField] private float _pollutedWaterStartY;
    [SerializeField] private float _pollutedWaterStopY;

    private void Start()
    {

    }

    private void Update()
    {
        float tempWaterLevel = (_pollutedWaterStopY - _pollutedWaterStartY);
        tempWaterLevel = tempWaterLevel / _maxPollution * _currentPollution;
        
        _pollutedWater.transform.position = new Vector2(
            _pollutedWater.transform.position.x,
            _pollutedWaterStartY + tempWaterLevel);
    }
}
