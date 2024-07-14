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

    // Inputs spoken text into the AI model. Called in MicrophoneDemo when player stops recording.
    public void PromptAI(string message){
        _ = llmCharacter.Chat(message, HandleReply);
    }

    // AI is supposed to return a reply and a code. If '|' is found in the reply, then send the first half back to the player and handle the code.
    private void HandleReply(string reply){
        string[] substrings = reply.Split('|');
        outputText.text = substrings[0];
        if(substrings.Length > 1 && substrings[1].Contains("~")){
            HandleCode(substrings[1]);
        }
    }

    private void HandleCode(string code){
        Debug.Log("Code: " + code);
    }
}
