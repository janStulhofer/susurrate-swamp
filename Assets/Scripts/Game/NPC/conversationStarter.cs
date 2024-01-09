using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class conversationStarter : MonoBehaviour
{
    public questKey questKeyScript;

    [SerializeField] private NPCConversation conversation;
    public bool inRange = false;
    void Update()
    {
        {
            if(Input.GetKeyDown(KeyCode.E) && inRange)
            {
                Debug.Log("Conversation started");
                ConversationManager.Instance.StartConversation(conversation);
                questKeyScript.showKey();

            }
        }
    }
        
private void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Player")
            {
                inRange = true;
                Debug.Log("Player in range");
            }
        }

private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            inRange = false;
            Debug.Log("Player out of range");
        }
    }

    
        
    
}