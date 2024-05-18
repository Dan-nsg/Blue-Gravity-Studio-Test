using UnityEngine;

public class Shopkeeper : MonoBehaviour
{
    public GameObject shopUI;
    public GameObject playerInventoryUI;
    public GameObject interactionIcon;
    private bool playerInRange;

    void Start()
    {
        interactionIcon.SetActive(false);
        shopUI.SetActive(false);
        playerInventoryUI.SetActive(false);
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            shopUI.SetActive(!shopUI.activeSelf);
            playerInventoryUI.SetActive(!playerInventoryUI.activeSelf);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            interactionIcon.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            interactionIcon.SetActive(false);
            shopUI.SetActive(false);
            playerInventoryUI.SetActive(false);
        }
    }
}
