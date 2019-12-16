using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
/// <summary>
/// Controlador del player. Comprueba el movimiento en el plano XZ, la rotación de la cabeza en el eje X
/// y la rotación del cuerpo en el eje Y
/// </summary>
public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// Utilizamos el singleton para que el zombie reciba constantemente nuestra posición
    /// </summary>
    private void Awake()
    {
        _player = this.transform;
        _lifeController = this.gameObject.GetComponent<LifeController>();
    }

    /// <summary>
    /// Le pasamos el método de disparar y de recargar
    /// </summary>
    private void Update()
    {
        CheckShoot();
        RecargarArma();
    }

    //Con el botón izquierdo ejecutaremos el método de disparar del weapon
    private void CheckShoot()
    {
        if (Input.GetButton("Fire1"))
        {
            _weapon.Shoot();
        }
    }

    //Con la tecla R ejecutaremos el método de recargar del weapon
    private void RecargarArma()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _weapon.recargar();
        }
    }

    //Cuando el jugador muera, aparezca la escena de Game Over
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag.Equals("Dead"))
            _cambiadorEscena2.CambiarEscena("GameOver");
    }

    //Recibir daño del zombie

    private void OnTriggerStay(Collider collider)
    {
        if (_timeToReciveDmg > 0)
        {
            _timeToReciveDmg -= Time.deltaTime;
        }
        if (collider.tag.Equals("Zombie") && _timeToReciveDmg <= 0)
        {
            _timeToReciveDmg = 0.8f;
            _lifeController.GetDamage(25f);
        }
    }


    [SerializeField]
    private Weapon _weapon;
    private float _timeToReciveDmg = 0;


    public static Transform Player
    {
        get { return _player; }
    }

    private static Transform _player;

    private LifeController _lifeController;


    public CambiadorEscena2 _cambiadorEscena2 = null;

}

