using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ChatWindowController
{
    private ChatWindowView _chatWindowView; 
    public ChatWindowController(UIDocument uiDocument)
    {
        _chatWindowView = new ChatWindowView(uiDocument.rootVisualElement);
    }
}
