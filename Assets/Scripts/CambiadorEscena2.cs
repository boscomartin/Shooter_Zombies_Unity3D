using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiadorEscena2 : MonoBehaviour
{
    //ESTE MÉTODO NOS PERMITE CAMBIAR DE ESCENA A TRAVÉS DEL SCENEMANAGER Y CARGAR UNA NUEVA A TRAVÉS DEL .LOADSCENE
    public void CambiarEscena(string SampleScene)
    {
        print("Cambiando a la escena" + SampleScene);
        SceneManager.LoadScene(SampleScene);
    }
}
