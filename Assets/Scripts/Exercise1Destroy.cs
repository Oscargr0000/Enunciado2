using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1Destroy : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
