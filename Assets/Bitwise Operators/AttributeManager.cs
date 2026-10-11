using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttributeManager : MonoBehaviour
{
    static public int MAGIC = 16;
    static public int INTELLIGENSE = 8;
    static public int CHARISMA = 4;
    static public int FLY = 2;
    static public int INVISIBLE = 1;
    int attributes = 0;

    public Text attributeDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);
        attributeDisplay.transform.position = screenPoint + new Vector3(0,-50,0);
        attributeDisplay.text = Convert.ToString(attributes, 2).PadLeft(8, '0'); 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MAGIC"))
            attributes |= MAGIC;
        else if (other.CompareTag("INTELLIGENSE"))
            attributes |= INTELLIGENSE;
        else if (other.CompareTag("CHARISMA"))
            attributes |= CHARISMA;
        else if (other.CompareTag("FLY"))
            attributes |= FLY;
        else if (other.CompareTag("INVISIBLE"))
            attributes |= INVISIBLE;
    }
}
