using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addle : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;
    public int speed, tempspeed;
    private Rigidbody rig;
    public bool rata,aktifs;
    public Collider batas;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        aktifs = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (aktifs == true)
        { if (rata)
                MoveObject(GetInputx());
            else
                MoveObject(GetInputy());
        } 
        else
            rig.velocity = Vector3.zero;
    }


    private Vector3 GetInputy()
    {

        if (Input.GetKey(upKey))
        {
            Debug.Log("Gerak euy: " + speed);
            return Vector3.forward * speed;
        }
        else if (Input.GetKey(downKey))
        {
            Debug.Log("Gerak euy: " + speed);
            return Vector3.back * speed;

        }

        return Vector3.zero;
    }

    private Vector3 GetInputx()
    {

        if (Input.GetKey(rightKey))
        {
            Debug.Log("Gerak euy: " + speed);
            return Vector3.right * speed;
        }
        else if (Input.GetKey(leftKey))
        {
            Debug.Log("Gerak euy: " + speed);
            return Vector3.left * speed;

        }

        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {

        // Debug.Log("Gerak euy: " + movement);
        rig.velocity = movement;
    }

    public void aktif()
    {
        aktifs = false;
        batas.isTrigger = false;
    }

}
