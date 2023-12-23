using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class conversationStarter : MonoBehaviour
{
    [SerializeField] private NPCConversation conversation;

    void Update()
    {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Conversation started");
                ConversationManager.Instance.StartConversation(conversation);
            }
        }
       }
    
