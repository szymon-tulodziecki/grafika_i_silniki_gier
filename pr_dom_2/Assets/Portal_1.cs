using UnityEngine;

public class Portal_1 : MonoBehaviour
{
    [Header("Ustawienia portalu")]
    [Tooltip("Lokalizacja docelowa (Empty Object z Transform)")]
    public Transform targetLocation;
    
    [Tooltip("Tag obiektu który może używać portalu (np. 'Player')")]
    public string playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        // Sprawdź czy obiekt wchodzący ma odpowiedni tag
        if (other.CompareTag(playerTag))
        {
            // Teleportuj gracza do lokalizacji docelowej
            if (targetLocation != null)
            {
                other.transform.position = targetLocation.position;
                other.transform.rotation = targetLocation.rotation;
                
                Debug.Log($"Teleportowano {other.name} do {targetLocation.name}");
            }
            else
            {
                Debug.LogWarning("Target Location nie jest przypisana w inspektorze!");
            }
        }
    }
}
