using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoV1 : MonoBehaviour
{
    public bool defeated = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        defeated = true;    
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
    }
}
