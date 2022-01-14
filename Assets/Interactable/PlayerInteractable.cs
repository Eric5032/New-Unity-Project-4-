using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInteractable : MonoBehaviour
{
    public GameObject interactableText;
    public KeyCode interactionKey = KeyCode.E;
    [SerializeField] List<InteractableItemBase> interactables = new List<InteractableItemBase>();
    private InteractableItemBase currentInterable = null;

    private void Update() 
    {
        if(Input.GetKeyDown(interactionKey))
        {
            currentInterable?.OnInteract();
        }
    }

    public void AddItem(InteractableItemBase item)
    {
        interactables.Add(item);
        interactableText.SetActive(true);
        currentInterable = item;
        UpdateUI();
    }

    public void RemoveItem(InteractableItemBase item)
    {
        if(interactables.Contains(item))
        {
            interactables.Remove(item);
        }
        if(interactables.Count == 0)
        {
            currentInterable = null;
            interactableText.SetActive(false);
        }
        else
        {
            if(currentInterable == item) currentInterable = interactables[0];
            UpdateUI();
        }
    }

    public void UpdateUI()
    {
        interactableText.SetActive(true);
        interactableText.GetComponentInChildren<TextMeshProUGUI>().text = currentInterable?.GetInteractionText(interactionKey.ToString()) ?? "";
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.GetComponentInChildren<InteractableItemBase>() is InteractableItemBase item)
        {
            AddItem(item);
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.GetComponentInChildren<InteractableItemBase>() is InteractableItemBase item)
        {
            RemoveItem(item);
        }
    }
}
