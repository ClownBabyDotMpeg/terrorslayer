using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner1 : MonoBehaviour
{
    [SerializeField]
    private float _waitTime;
    [SerializeField]
    private GameObject _EnemyContainer;
    [SerializeField]
    private GameObject[] _enemyToSpawn;


    private IEnumerator StartSpawn;

    // Start is called before the first frame update
    void Start()
    {
        IEnumerator StartSpawn = SpawnRoutine1(_waitTime);
        StartCoroutine(StartSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnRoutine1(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            Instantiate(_enemyToSpawn[0], new Vector3(0,0,0 ), Quaternion.identity);
        }

    }

    private void Spawn1()
    {

    }
}
