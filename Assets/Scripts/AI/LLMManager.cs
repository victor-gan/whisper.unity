using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LLMUnity;
using UnityEngine.UI;

public class LLMManager : MonoBehaviour
{
    public LLMCharacter llmCharacter;
    public static LLMManager Instance;
    public Text outputText;

    void Awake(){
        Instance = this;
    }

    void HandleReply(string reply){
        outputText.text = reply;
    }

    public void PromptAI(string message){
        _ = llmCharacter.Chat(message, HandleReply);
    }
}
