using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{
   
    [SerializeField] float saniye;
     
    //Vector3 hedefKonum = new Vector3 (3,0,0);
    //bool hareketEdiyor = false;
    // Start is called before the first frame update
    
    void Start()
    {
       StartCoroutine(MoveDown());
    }

    void Update()
    {
        



    }
    IEnumerator MoveDown(){
        while (true)
        {
            yield return new WaitForSeconds(saniye);
            var position = transform.position;
            position.y--;
            transform.position =  position;
        }
 
    }

}
