using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecuperarDatoDePlayerPrefs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlayerPrefs.GetString("nombreAlmacenado"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
