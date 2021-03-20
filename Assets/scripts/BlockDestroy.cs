using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroy : MonoBehaviour
{
  
    private void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<ScoreScript>().Addpoint(10);
        Destroy(this.gameObject);
    }
}
