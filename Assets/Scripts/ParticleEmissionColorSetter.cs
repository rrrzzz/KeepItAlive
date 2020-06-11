using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEmissionColorSetter : MonoBehaviour
{
    private static readonly int EmissionColor = Shader.PropertyToID("_EmissionColor");

    // Start is called before the first frame update
    void Start()
    {
     
        GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        GetComponent<Renderer>().material.SetColor(EmissionColor,Color.green);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
