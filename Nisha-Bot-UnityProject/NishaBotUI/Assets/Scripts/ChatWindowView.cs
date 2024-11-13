using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ChatWindowView
{
    private VisualElement _root;
    
    public VisualElement Root
    {
        get { return _root; }
    }

    private ScrollView _scrollViewRecentChats;

    private VisualElement _userInputBarContainer;

    private TextField _textFieldUserChat;

    private VisualElement _containerUserChatButtons;

    private Button _buttonPost;

    private Button _buttonAttach;

    private ChatWindowController _controller;

    public ChatWindowView(VisualElement root, ChatWindowController controller)
    {
        _root = root;
        _controller = controller;
        QueryVisualElements();
        RegisterEvents();
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
        _buttonPost.clicked += PostButtonClicked;
    }

    private void UnRegisterEvents()
    {
        _buttonPost.clicked -= PostButtonClicked;
    }

    private void PostButtonClicked()
    {
        _controller.ChatWindowPostButtonClicked(_textFieldUserChat.value);
        _textFieldUserChat.value = UITags.UITagsChatWindow.DefaultUserText;
    }

    public void AdduserChatMessageToScrollView(VisualElement visualElement)
    {
        _scrollViewRecentChats.Add(visualElement);
    }

}
