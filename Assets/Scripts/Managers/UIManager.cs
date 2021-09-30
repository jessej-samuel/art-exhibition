using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]GameObject uiStd;
    [SerializeField] GameObject uiArt;


    public static UIManager main;

    private void Awake()
    {
        main = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        ToggleUIArt(false);
        ToggleUIStd(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleUIStd(bool state)
    {
        uiStd.SetActive(state);
    }
    public void ToggleUIArt(bool state)
    {
        uiArt.SetActive(state);
    }
}
