using UnityEngine;

public class FPSInteraction : MonoBehaviour
{
    public float maxDistance = 2f;
    private InteractableObject currentInteractable;

    void Update()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;

        // reset poprzedniego outline
        if (currentInteractable != null)
        {
            currentInteractable.isLookedAt = false;
            currentInteractable = null;
        }

        if (Physics.Raycast(ray, out hit, maxDistance))
        {
            InteractableObject interactable = hit.collider.GetComponent<InteractableObject>();
            if (interactable != null)
            {
                currentInteractable = interactable;
                currentInteractable.isLookedAt = true;

                // klikniêcie LPM
                if (Input.GetMouseButtonDown(0))
                {
                    currentInteractable.Interact();
                }
            }
        }
    }
}
