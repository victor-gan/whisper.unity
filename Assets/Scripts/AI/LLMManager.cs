using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LLMUnity;

public class LLMManager : MonoBehaviour
{
    public LLMCharacter llmCharacter;
    public static LLMManager Instance;

    void Awake(){
        Instance = this;
    }

    void HandleReply(string reply){
    Debug.Log(reply);
    }

    public void PromptAI(string message){
    _ = llmCharacter.Chat(message, HandleReply);
    }
}
