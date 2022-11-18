using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1Destroy : MonoBehaviour
{

    //Destroy de shperes every time is clicked
    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
