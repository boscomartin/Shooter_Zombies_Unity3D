using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnyKey : MonoBehaviour
{

    //Reiniciar la partida pulsando cualquier tecla
    void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene("Juego3D");
        }
    }
}
