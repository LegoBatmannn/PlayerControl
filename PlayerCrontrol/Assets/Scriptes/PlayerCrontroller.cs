using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //we mobe BATMOBILE FOWARD
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
