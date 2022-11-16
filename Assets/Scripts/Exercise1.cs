using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    private int EnemyLeft;
    private int EnemyLimit = 2;
    public GameObject Sphere;


    private void Start()
    {
        MultiplicateEnemy(EnemyLimit);
    }

    private void Update()
    {
        EnemyLeft = FindObjectsOfType<Exercise1Destroy>().Length;

        if (EnemyLeft <= 0)
        {
            EnemyLimit++;
            MultiplicateEnemy(EnemyLimit);
        }
    }

    private void MultiplicateEnemy(int cantidad)
    {

        for (int i = 1; i < cantidad; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-5, 5), Random.Range(-2, 2), Random.Range(-3, 3));

            Instantiate(Sphere, randomPosition, Sphere.transform.rotation);
        }
    }
}
