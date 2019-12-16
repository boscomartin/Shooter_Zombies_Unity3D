using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    //AÑADE UNA FUERZA A UNA DIRECCIÓN ESPECÍFICA
    public void AddForce(Vector3 force)
    {
        _rigidBody.AddForce(force, ForceMode.Impulse);
    }

    //PRODUCE UNA COLISIÓN ENTRE LO QUE DISPARAMOS Y HACIA DONDE LO DISPARAMOS

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter: " + collision.gameObject.name);



        Destroy(_rigidBody);

        Destroy(this.gameObject, 5f);

        this.transform.SetParent(collision.transform);

        //AÑADE VIDA AL GAMEOBJECT AL CUAL DISPARAMOS Y SI EL ELEMENTO QUE DISPARAMOS CHICA LE QUITA CIERTO DAÑO
        LifeController lifeController = collision.gameObject.GetComponent<LifeController>();
        if (lifeController != null)
        {
            lifeController.DoDamage(_damage);
        }
    }

    [SerializeField]
    private Rigidbody _rigidBody;
    [SerializeField]
    private float _damage = 15;
}
