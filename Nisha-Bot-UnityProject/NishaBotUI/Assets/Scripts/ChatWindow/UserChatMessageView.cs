using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UserChatMessageView : IView
{
    private VisualElement _root;
    
    private UserChatMessageController _controller;

    public VisualElement Root
    {
        get { return _root; }
    }

    public ControllerBase ControllerBase
    {
        get { return _controller; }
    }

    private Label _labelUserChat;
    
    public UserChatMessageView(VisualElement root, UserChatMessageController controller)
    {
        _root = root;
        _controller = controller;
        QueryVisualElements();
    }

    private void QueryVisualElements()
    {
        _labelUserChat = _root.Q<Label>(UITags.UITagsChatWindow.LabelUserChatMessage);
    }

    public void ConvertUserChatToChatMessage(string userChatString)
    {
        _labelUserChat.text = userChatString;
    }


}
