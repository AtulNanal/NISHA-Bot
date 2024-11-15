using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// Application Manager --> Dependency Handler for the application
/// </summary>
public class ApplicationManager : MonoBehaviour
{
    [SerializeField]
    private UIDocument _chatBotUiDocument;

    private ChatWindowController _chatWindowController;
    
    // Start is called before the first frame update
    void Start()
    {
        _chatWindowController = new ChatWindowController(_chatBotUiDocument.rootVisualElement);
    }

    // Update is called once per frame
    void Update()
    {
        //This is temporary code 
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _chatWindowController.BotResponseMessageReceived("Hi there this is NISHA --- Your personal assistant for your onboarding journey in this company. How can I help you ?");
        }
    }
}
