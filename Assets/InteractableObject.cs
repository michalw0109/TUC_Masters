using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public Outline outline;  // przypisz w Inspector
    public bool isLookedAt = false;

    void Update()
    {
        // w³¹czenie/wy³¹czenie outline
        outline.OutlineWidth = isLookedAt ? 5f : 0f;
    }

    public void Interact()
    {
        Debug.Log("Interakcja z: " + gameObject.name);
        GameManager.Instance.playerEnergy = 100f; // przyk³adowa interakcja: zwiêkszenie energii gracza
        // tu wstaw swoj¹ akcjê, np. otwarcie drzwi, podniesienie przedmiotu
    }
}
