using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Player : MonoBehaviour
{
    //Player Variables

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) PlayerInteract();
        if (ConversationManager.Instance != null && ConversationManager.Instance.IsConversationActive)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                ConversationManager.Instance.SelectNextOption();
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                ConversationManager.Instance.SelectPreviousOption();
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                ConversationManager.Instance.PressSelectedOption();
            }
        }
    }

    public void PlayerInteract()
    {
        var layermask0 = 1 << 0;
        var layermask3 = 1 << 3;
        var finalmask = layermask0 | layermask3;

        RaycastHit hit;
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(.5f, .5f, 0));

        if (Physics.Raycast(ray, out hit, 15, finalmask))
        {
            Interact interactScript = hit.transform.GetComponent<Interact>();
            if (interactScript) interactScript.CallInteract(this);
        }
    }


    
}