using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UserChatMessageController
{
    private UserChatMessageView _userChatMessageView;

    public UserChatMessageController(VisualElement visualElement)
    {
        _userChatMessageView = new UserChatMessageView(visualElement, this);
    }
    
    public VisualElement VsElement
    {
        get { return _userChatMessageView.Root; }
    }

    public void ConvertUserChatToChatMessage(string userChatString)
    {
        _userChatMessageView.ConvertUserChatToChatMessage(userChatString);
    }
    
    
}
