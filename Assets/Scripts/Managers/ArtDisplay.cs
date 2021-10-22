using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArtDisplay : MonoBehaviour
{

    public Art art;

    public TMP_Text title;
    public TMP_Text artist;
    public TMP_Text link;
    public TMP_Text description;
    public TMP_Text current;
    public Image artwork;

    public static ArtDisplay main;

    private void Awake()
    {
        main = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(art);
        SetNewArt(art);
        link.text = "None";
    }

    public void SetNewArt(Art newArt)
    {
        art = newArt;
        title.text = newArt.title;
        current.text = "Currently viewing: "+ newArt.title;
        artist.text = newArt.artist;
        link.text = "Click here to visit artist page";
        description.text = newArt.description;
        artwork.sprite = newArt.image;
    }

    
}
