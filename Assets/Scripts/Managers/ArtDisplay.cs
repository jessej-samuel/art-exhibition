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
    public Image artwork;

    public static ArtDisplay main;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(art);
        title.text = art.title;
        artist.text = art.artist;
        link.text = art.link;
        description.text = art.description;
        artwork.sprite = art.image;
        art.Print();
    }
}
