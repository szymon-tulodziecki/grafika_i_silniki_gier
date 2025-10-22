using UnityEngine;

public class n2 : MonoBehaviour
{
    [Header("Ustawienia wahadła")]
    public float speed = 3.5f;
    public float limit = 45f;
    public bool randomStart = false;
    public float phaseOffset = 3.14159f; 

    private float startPhase = 0f;

    void Awake()
    {
        if (randomStart)
        {
            startPhase = Random.Range(0f, 2f * Mathf.PI);
        }
        else
        {
            startPhase = phaseOffset;
        }
    }

    void Update()
    {
        float angle = Mathf.Sin(Time.time * speed + startPhase) * limit;
        transform.localRotation = Quaternion.Euler(angle, 0f, 0f);
    }
}
