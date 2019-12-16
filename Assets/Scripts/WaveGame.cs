using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveGame : Wave
{

    //La oleada se inicia
    public override void Setup()
    {
        _enemies = new List<GameObject>();
        for (int i = 0; i < _enemiesCount; i++)
        {
            //Le pasamos el prefab del enemigo y la zona donde aparecerán
            GameObject enemyObject = GameObject.Instantiate(_enemyPrefab, _zone.position, Quaternion.identity);
            _enemies.Add(enemyObject);
        }
    }
    public override bool Begin()
    {
        return true;
    }
    public override bool Run()
    {
        if (GetEnemyLeft() == 0)
        {
            return true;
        }
        return false;
    }
    public override void End()
    {
        Debug.Log("WaveGame: oleada finalizada. ");
    }
    //Método para ver cuantos enemigos quedan en la escena
    private int GetEnemyLeft()
    {
        int enemyLeft = 0;
        foreach (GameObject enemyObject in _enemies)
        {
            if (enemyObject != null)
            {
                enemyLeft++;
            }
        }
        return enemyLeft;
    }

    [SerializeField]
    private int _enemiesCount = 5;
    [SerializeField]
    private GameObject _enemyPrefab = null;
    [SerializeField]
    private Transform _zone = null;
    private List<GameObject> _enemies;


}
