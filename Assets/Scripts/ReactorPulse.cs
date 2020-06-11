using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactorPulse : MonoBehaviour
{
    public bool isPulsing = true;
    public float pulsingSpeed = 2f;
    
    private Material _reactorMat;
    private static readonly int Emission = Shader.PropertyToID("_EmissionColor");

    // Start is called before the first frame update
    void Start()
    {
        _reactorMat = GetComponent<Renderer>().material;
        
        //_reactorMat.EnableKeyword("_EmissionColor");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPulsing) return;
        var redAmount = Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup * pulsingSpeed)) * 0.7f + 0.2f;
        var currentColor = new Color(redAmount, 0, 0);
        _reactorMat.SetColor(Emission, currentColor);
    }
}
