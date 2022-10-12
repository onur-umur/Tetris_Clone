using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputlar : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
       /* if (IspressLeft || IsPressRight)
        {
            var value = IspressLeft ? -1:1;
            MoveHorizontal(value);
        }*/
        if (Input.GetKeyDown (KeyCode.D))
            transform.position += transform.right;
        if (Input.GetKeyDown (KeyCode.A))
            transform.position -= transform.right;
        if (Input.GetKeyDown (KeyCode.S))
            transform.position -= transform.up;
    }


}
