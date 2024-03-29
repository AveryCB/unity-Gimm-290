using UnityEngine;

public class RandomColor : MonoBehaviour
{
    Color colorStart = Color.red;
    Color colorEnd = Color.green;
    float duration = 1.0f;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer> ();
    }

    void Update()
    {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
    }
}