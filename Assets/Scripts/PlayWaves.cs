using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayWaves : MonoBehaviour
{

    public Text contador;

    //
    void Start()
    {
        WaveManager.Instance.SetWaveLevel(_waveLevel);
        contador.text = " " + tiempo;
        contador.enabled = true;
    }

    //Se inician las oleadas en un periodo de 5 segundos
    void Update()
    {
        tiempo -= Time.deltaTime;
        contador.text = tiempo.ToString("f0");

        if (tiempo <= 0)
        {
            StartWave();
            contador.enabled = false;
        }
    }

    private void StartWave()
    {
        WaveManager.Instance.StartWaveLevel();
    }

    [SerializeField]
    private WaveLevel _waveLevel;

    [SerializeField]

    private float tiempo = 5f;
}
