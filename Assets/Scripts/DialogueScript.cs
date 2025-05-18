using DialogueEditor;
using UnityEngine;
using DialogueEditor;   

public class DialogueScript : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;


    public Interact openFromInteraction;

    private void OnEnable()
    {
            openFromInteraction.GetInteractEvent.HasInteracted += onUse;
    }
    
    public void onUse(){
        Debug.Log("Dialogue");
        ConversationManager.Instance.StartConversation(myConversation);
    }
}
