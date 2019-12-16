using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiadorEscena : MonoBehaviour
{
    //ESTE CAMBIADOR DE ESCENA LO UTILIZAMOS PARA EL BOTÓN DE EXIT DEL JUEGO. 

    public void CambiarEscena(string SampleScene)
    {
        print("Cambiando a la escena" + SampleScene);
        SceneManager.LoadScene(SampleScene);
    }
    //ESTE MÉTODO A TRAVÉS DEL COMANDO APPLICATION.QUIT HACE QUE AL PULSAR EL ELEMENTO QUE CONTENGA ESTE SCRIPT SE SALGA DEL JUEGO Y SE CIERRE COMPLETAMENTE.
    public void Salir()
    {
        Debug.Log("QUIT!");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
