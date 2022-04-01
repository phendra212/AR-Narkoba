using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup : MonoBehaviour
{

    public GameObject PopUp;
    public bool aktif;

    void Start()
    {
        
    }


   void OnMouseDown()
    {
        PopUp.SetActive(aktif);
    }

    void Update()
    {
        
    }
}
