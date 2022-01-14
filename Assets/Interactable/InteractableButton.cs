using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class InteractableButton : InteractableItemBase
{

    public Color unpressedColor = Color.red;
    public Color pressedColor = Color.green;
    public UnityEvent OnButtonClicked = new UnityEvent();
    private void Start() 
    {
        this.GetComponent<MeshRenderer>().material.color = unpressedColor;
    }
    public override void OnInteract()
    {
        this.GetComponent<MeshRenderer>().material.color = pressedColor;
        OnButtonClicked?.Invoke();
    }
}
