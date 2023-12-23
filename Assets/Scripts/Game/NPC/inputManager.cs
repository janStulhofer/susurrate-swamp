using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class inputManager : MonoBehaviour
{
void Update()
{
    if(ConversationManager.Instance != null && ConversationManager.Instance.IsConversationActive)
    {
        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            ConversationManager.Instance.DisplayNextSentence();
        }*/
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            ConversationManager.Instance.SelectNextOption();
        }
        if( Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ConversationManager.Instance.SelectPreviousOption();
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            ConversationManager.Instance.PressSelectedOption();
        }   
    }
    if(Input.GetKeyDown(KeyCode.Escape))
    {
        ConversationManager.Instance.EndConversation();
    }
}
}
