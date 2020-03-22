using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public bool isActive = false;
    public GameObject sunaarashi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sunaarashi.SetActive(isActive);
    }

    public void buttonOn()
    {
        isActive =!isActive;
        Debug.Log("Button Downed!");
        Debug.Log(isActive);
    }
}
