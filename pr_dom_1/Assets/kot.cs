using UnityEngine;

public class kot : MonoBehaviour
{
    [Header("Ustawienia machania")]
    public float speed = 2f;          // szybkość machania
    public float angleLimit = 25f;    // maksymalny kąt wychylenia w stopniach

    private float initialAngle;

    void Start()
    {
        // Zapamiętaj początkowy kąt obiektu wokół osi X
        initialAngle = transform.localEulerAngles.x;
    }

    void Update()
    {
        // Oblicz sinusoidalny kąt machania
        float angle = Mathf.Sin(Time.time * speed) * angleLimit;

        // Ustaw rotację lokalną wokół osi X
        transform.localRotation = Quaternion.Euler(initialAngle + angle, 0f, 0f);
    }
}
