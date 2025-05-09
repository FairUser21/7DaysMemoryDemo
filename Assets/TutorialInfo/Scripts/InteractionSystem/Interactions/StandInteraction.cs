using UnityEngine;

public class StandInteraction : MonoBehaviour, IInteractable
{
    private bool _hasInteracted = false;

private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    public bool CanInteract(){
        if(!_hasInteracted){
            return true;
        }
        return false;
    }

    public bool Interact(Interactor interactor){
        _animator.SetBool("Open", true);
        _hasInteracted = true;
        return true;
    }

   
}
