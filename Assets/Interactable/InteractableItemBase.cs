using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItemBase : MonoBehaviour
{
    [SerializeField] protected string Name = "Interactable";
    [SerializeField] protected string interactionAction = "interact";

    public virtual string GetInteractionText(string interactionKey)
    {
        return $"Press {interactionKey} to {interactionAction}";
    }

    public virtual void OnInteract()
    {

    }
    

}
