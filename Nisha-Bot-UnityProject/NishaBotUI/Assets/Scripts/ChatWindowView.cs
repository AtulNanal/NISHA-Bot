using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ChatWindowView
{
    private VisualElement _root;

    private ScrollView _scrollViewRecentChats;

    private VisualElement _userInputBarContainer;

    private TextField _textFieldUserChat;

    private VisualElement _containerUserChatButtons;

    private Button _buttonPost;

    private Button _buttonAttach;

    public ChatWindowView(VisualElement root)
    {
        _root = root;
        QueryVisualElements();
    }

    private void QueryVisualElements()
    {
        _scrollViewRecentChats = _root.Q<ScrollView>(UITags.UITagsChatWindow.ScrollViewRecentChats);
        _userInputBarContainer = _root.Q<VisualElement>(UITags.UITagsChatWindow.ContainerUserInputBar);
        _textFieldUserChat = _userInputBarContainer.Q<TextField>(UITags.UITagsChatWindow.TextFieldUserChatField);
        _containerUserChatButtons =
            _userInputBarContainer.Q<VisualElement>(UITags.UITagsChatWindow.ContainerUserInputButtons);
        _buttonPost = _containerUserChatButtons.Q<Button>(UITags.UITagsChatWindow.ButtonPostChat);
        _buttonAttach = _containerUserChatButtons.Q<Button>(UITags.UITagsChatWindow.ButtonPostAttach);
        
        Debug.Log(_scrollViewRecentChats);
    }

    private void RegisterEvents()
    {
        
    }

}
