using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstaWeapon : Weapon
{
    void Awake()
    {
        _standarAmmo = _municion;
    }



    //El método disparar lo utilizamos para que nuestro arma lance la bala 
    public override void Shoot()
    {
        if (_municion > 0)
        {
            if (Physics.Raycast(_shootPoint.transform.position, _shootPoint.transform.forward, out _raycastHit))
            {

                Debug.Log("Choca" + _raycastHit.transform);
                GameObject impactObject = Instantiate(_impactPrefab, _raycastHit.point, Quaternion.identity);
                //Si impacta destruye el objeto dependiendo del daño
                Destroy(impactObject, 1f);
                impactObject.transform.SetParent(_raycastHit.transform, true);

                LifeController lifevontroller = _raycastHit.transform.GetComponent<LifeController>();
                if (lifevontroller != null)
                {
                    //Cada hit es daño que le resta vida al objeto
                    lifevontroller.DoDamage(_damage);
                }


                //Disparar();
                if (Input.GetMouseButton(0))
                {
                    _municion--;
                    _ammo.text = _municion.ToString();
                }

            }
        }
    }

    //Con la tecla R recargaremos el arma cuando se nos quede sin balas
    public override void recargar()
    {
        if (_municion < _standarAmmo && _municionExtra >= 1)
        {
            //recargar();
            Debug.Log("Recargando");
            if (_municionExtra == 0)
            {
                Debug.Log("No queda munición");
            }
            else
            {
                //int cargadorRestante = _municion;
                //cargadorRestante = cargadorRestante - 30;
                if (_municionExtra >= _standarAmmo)
                {
                    _municionExtra -= (_standarAmmo - _municion);
                    _municion = _standarAmmo;
                    _ammo.text = _municion.ToString();
                }
                else
                {
                    _municion = _municionExtra;
                    _municionExtra = 0;
                    _ammo.text = _municion.ToString();
                }
                _extraAmmo.text = _standarAmmo.ToString();
            }
        }
    }

    private float _standarAmmo;
    [SerializeField]
    private float _municion;
    public float _municionExtra = 300f;


    [SerializeField]
    private GameObject _impactPrefab;
    [SerializeField]
    private Transform _shootPoint = null;
    [SerializeField]
    private float _damage = 20f;

    private RaycastHit _raycastHit;

    [SerializeField]
    private Text _ammo;

    [SerializeField]
    private Text _extraAmmo;


    public int contador;

    private Text contadorText;


}
