using UnityEngine;

public class obrot : MonoBehaviour
{
    [Header("Ustawienia obrotu")]
    public float rotationSpeed = 30f; 

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
