using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UserChatMessageController : ControllerBase
{
    private UserChatMessageView _userChatMessageView;

    public override IView View
    {
        get { return _userChatMessageView; }
    }
    
    public UserChatMessageController(VisualElement visualElement)
    {
        _userChatMessageView = new UserChatMessageView(visualElement, this);
    }
    
    public void ConvertUserChatToChatMessage(string userChatString)
    {
        _userChatMessageView.ConvertUserChatToChatMessage(userChatString);
    }
}
