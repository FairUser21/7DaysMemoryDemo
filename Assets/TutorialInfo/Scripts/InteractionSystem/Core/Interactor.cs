using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interactor : MonoBehaviour
{
   [SerializeField]
   private float _castDistance = 5f;
    [SerializeField]
    private void Update()
    {
        if(Keyboard.current.eKey.wasPressedThisFrame){
            if(DoInteractionTest(out IInteractable interactable)){
                if(interactable.CanInteract()){
                    interactable.Interact(this);
                }
            }
        }
    }
    private Vector3 _raycastOffset = new Vector3(0, 1f, 0);
   private bool DoInteractionTest(out IInteractable interactable){
    interactable = null;
    Ray ray = new Ray(transform.position + _raycastOffset, transform.forward);
    if(Physics.Raycast(ray, out RaycastHit hitInfo, _castDistance)){
        interactable = hitInfo.collider.GetComponent<IInteractable>();

        if(interactable != null){
            return true;
        }

        return false;
    }
    return false;
   }
}
