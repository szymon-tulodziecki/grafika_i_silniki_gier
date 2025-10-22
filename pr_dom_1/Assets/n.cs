using UnityEngine;

public class n : MonoBehaviour
{
    [Header("Ustawienia wahadła")]
    public float speed = 3.5f;        
    public float limit = 75f;         
    public bool randomStart = false; 

    private float phaseOffset = 0f;   

    void Awake()
    {
        if (randomStart)
        {
            phaseOffset = Random.Range(0f, 2f * Mathf.PI);
        }
    }

    void Update()
    {
        float angle = Mathf.Sin(Time.time * speed + phaseOffset) * limit;
        transform.localRotation = Quaternion.Euler(0f, 0f, angle);
    }
}
