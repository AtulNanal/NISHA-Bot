using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BotChatMessageController : ControllerBase
{
    private BotChatMessageView _botChatMessageView;

    public override IView View
    {
        get { return _botChatMessageView; }
    }
    
    public BotChatMessageController(VisualElement visualElement)
    {
        _botChatMessageView = new BotChatMessageView(visualElement, this);
    }
    
    public void ConvertUserChatToChatMessage(string userChatString)
    {
        _botChatMessageView.ConvertUserChatToChatMessage(userChatString);
    }
}
