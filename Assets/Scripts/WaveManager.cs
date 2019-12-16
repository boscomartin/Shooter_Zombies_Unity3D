using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager Instance
    {
        get { return _instance; }
    }
    //Elegimos cuantas oleadas habrá
    public void SetWaveLevel(WaveLevel waveLevel)
    {
        _waveLevel = waveLevel;
    }
    //Se inician las oleadas
    public void StartWaveLevel()
    {
        _waveLevel.StarWaveLevel();
    }
    private void Awake()
    {
        if (_instance != null)
        {

        }
        _instance = this;
    }

    private void Update()
    {
        if (_waveLevel == null)
        {
            return;
        }
        _waveLevel.Execute();
    }

    private static WaveManager _instance;
    private WaveLevel _waveLevel;
}
