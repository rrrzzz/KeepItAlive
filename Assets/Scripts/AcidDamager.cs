using TMPro;
using UnityEngine;

public class AcidDamager : MonoBehaviour
{
    public int health = 100;

    public TMP_Text text;
    public TMP_Text text2;

    private bool _isCollisionEnabled = true;
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateHealth();
    }

    private void Update()
    {
    
        if (_isCollisionEnabled) return;
        var col = text2.color;
        col.a = Mathf.PingPong(Time.realtimeSinceStartup, 1);
        text2.color = col;
    }


    private void OnParticleCollision(GameObject other)
    {
        health -= 1;
        if (health < 0)
        {
            _isCollisionEnabled = false;
            GetComponent<Collider>().enabled = false;
            text2.enabled = true;
            GetComponent<FPSController>().enabled = false;
            return;
        }
        
        UpdateHealth();
    }

    void UpdateHealth() => text.text = $"Health: {health}";
}
