using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BotChatMessageController
{
    private BotChatMessageView _botChatMessageView;

    public BotChatMessageController(VisualElement visualElement)
    {
        _botChatMessageView = new BotChatMessageView(visualElement, this);
    }
    
    public VisualElement VsElement
    {
        get { return _botChatMessageView.Root; }
    }
    
    public void ConvertUserChatToChatMessage(string userChatString)
    {
        _botChatMessageView.ConvertUserChatToChatMessage(userChatString);
    }
}
