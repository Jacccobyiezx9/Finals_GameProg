using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Anthony_Control playerControl = collision.GetComponent<Anthony_Control>();
            if (playerControl != null)
            {
                if (gameObject.CompareTag("Baguette"))
                {
                    playerControl.PickUpItem("Baguette");
                    Destroy(gameObject); // Destroy the item after pickup
                }
                else if (gameObject.CompareTag("List"))
                {
                    playerControl.PickUpItem("List");
                    Destroy(gameObject); // Destroy the item after pickup
                }
            }
        }
    }
}
