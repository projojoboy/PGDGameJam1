using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Pollution _pollutionController;

    private void Start()
    {
        SetPollutionLevel(0);
    }

    public void SetPollutionLevel(int p_level)
    {
        _pollutionController._currentPollution = p_level;
    }
}
