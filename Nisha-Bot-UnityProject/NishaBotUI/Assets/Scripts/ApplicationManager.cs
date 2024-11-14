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
    private UIDocument _chatBotUIDocument;

    private ChatWindowController _chatWindowController;
    
    // Start is called before the first frame update
    void Start()
    {
        _chatWindowController = new ChatWindowController(_chatBotUIDocument.rootVisualElement);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
