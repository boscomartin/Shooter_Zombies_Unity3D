using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class LifeController : MonoBehaviour
{

    //Si el enemigo acaba con 0 de daño, se destruye
    public void DoDamage(float damage)
    {
        _life -= damage;
        if (_life <= 0f)
        {
            Destroy(gameObject);
        }
    }
    //Si te matan se carga la escena gameover
    public void GetDamage(float damage)
    {

        _life -= damage;
        if (_life <= 0f)
        {

            SceneManager.LoadScene("GameOver");
        }
    }

    [SerializeField]
    private float _life = 100f;

    public CambiadorEscena2 _cambiadorEscena2;

}


