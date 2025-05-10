using UnityEngine;
using UnityEngine.InputSystem;

public class OpenClose : MonoBehaviour
{
    private Animator mAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    

    private void onUse(InputAction.CallbackContext context){
        if(mAnimator != null){
            mAnimator.SetTrigger("Open");
        }
    }
}
