using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody rg;
    public Manbal keo;
    // Start is called before the first frame update
    void Start()
    {
        rg.AddForce(transform.forward * 100 * speed);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "skor")
        {
            keo.addskor(other.gameObject.name,1);
            keo.destrr(gameObject);
        }
    }

    public void cepat()
    { rg.AddForce(transform.forward * 100 * speed); }

}
