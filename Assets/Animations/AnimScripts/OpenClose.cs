using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenClose : MonoBehaviour
{
    private Animator mAnimator;
        public bool IsOpen = false;

    public Interact openFromInteraction;

    private void OnEnable()
    {
        if(openFromInteraction && IsOpen == false){
            openFromInteraction.GetInteractEvent.HasInteracted += onUse;
        }
    }

    private void OnDisable()
    {
        if(openFromInteraction && IsOpen == true){
            openFromInteraction.GetInteractEvent.HasInteracted -= onUse;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    

    public void onUse(){
        
        if(mAnimator != null){
            if(IsOpen == false){
                mAnimator.SetTrigger("TrOpen");
                IsOpen = true;
            }
            else{
                mAnimator.SetTrigger("TrClose");
                IsOpen = false;
            }
        }
            Debug.Log(IsOpen);

    }


}
