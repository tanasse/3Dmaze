using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ballmove : MonoBehaviour
{
    public Rigidbody rb;
    int a;
    // Start is called before the first frame update
    void Start()
    {
        a = Random.Range(-15, 15);
        rb.AddForce(a, 0, 15, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < -20)
        {
            SceneManager.LoadScene("GAMEOVER");
        }
    }
}
