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
        EnemyLeft = FindObjectsOfType<Exercise1Destroy>().Length; //Get the number of Spheres lefts in the scene

        if (EnemyLeft <= 0)  //When the Shpheres are all out spawn next round of sphere +1
        {
            EnemyLimit++;
            MultiplicateEnemy(EnemyLimit);
        }
    }

    private void MultiplicateEnemy(int cantidad) //Instantiate the spheres
    {

        for (int i = 1; i < cantidad; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-5, 5), Random.Range(-2, 2), Random.Range(-3, 3));

            Instantiate(Sphere, randomPosition, Sphere.transform.rotation);
        }
    }
}
