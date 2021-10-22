using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtObject : MonoBehaviour
{
    [SerializeField] private Art art;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
        
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Entered");
            ArtDisplay.main.SetNewArt(art);
        }
    }
}
