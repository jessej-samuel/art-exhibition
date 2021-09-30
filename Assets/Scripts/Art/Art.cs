using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Art", menuName = "Art")]
public class Art : ScriptableObject
{
    public Sprite image;
    public string title;
    public string artist;
    public string link;
    public string description;
 
    
}
