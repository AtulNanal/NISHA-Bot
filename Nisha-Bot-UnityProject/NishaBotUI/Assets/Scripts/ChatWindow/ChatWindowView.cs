using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ChatWindowView : IView
{
    private VisualElement _root;
    
    private ChatWindowController _controller;
    
    public VisualElement Root
    {
        get { return _root; }
    }

    public ControllerBase ControllerBase
    {
        get { return _controller; }
    }

    private VisualElement _containerChatWindow;
    
    private ScrollView _scrollViewRecentChats;

    private VisualElement _userInputBarContainer;

    public TextField _textFieldUserChat;

    private VisualElement _containerUserChatButtons;

    private Button _buttonPost;

    private Button _buttonAttach;

    private VisualElement _containerTopBar;

    private Button _buttonBackToMainMenu;

    private Button _buttonUserMinimize;

    private Button _buttonChatIcon;

    public ChatWindowView(VisualElement root, ChatWindowController controller)
    {
        Debug.Log(root.name);
        _root = root;
        _controller = controller;
        QueryVisualElements();
        RegisterEvents();
        SetDefaultVisibility();
    }

    public void QueryVisualElements()
    {
        _containerChatWindow = _root.Q<VisualElement>(UITags.UITagsChatWindow.ContainerChatWindow);
        _scrollViewRecentChats = _root.Q<ScrollView>(UITags.UITagsChatWindow.ScrollViewRecentChats);
        _userInputBarContainer = _root.Q<VisualElement>(UITags.UITagsChatWindow.ContainerUserInputBar);
        _textFieldUserChat = _userInputBarContainer.Q<TextField>(UITags.UITagsChatWindow.TextFieldUserChatField);
        _containerUserChatButtons =
            _userInputBarContainer.Q<VisualElement>(UITags.UITagsChatWindow.ContainerUserInputButtons);
        _buttonPost = _containerUserChatButtons.Q<Button>(UITags.UITagsChatWindow.ButtonPostChat);
        _buttonAttach = _containerUserChatButtons.Q<Button>(UITags.UITagsChatWindow.ButtonPostAttach);
        _containerTopBar = _root.Q<VisualElement>(UITags.UITagsChatWindow.ContainerTopBar);
        _buttonBackToMainMenu = _containerTopBar.Q<Button>(UITags.UITagsChatWindow.ButtonBack);
        _buttonUserMinimize = _containerTopBar.Q<Button>(UITags.UITagsChatWindow.ButtonMinimize);
        _buttonChatIcon = _root.Q<Button>(UITags.UITagsChatWindow.ButtonChatIcon);
        
        Debug.Log(_scrollViewRecentChats);
    }

    private void SetDefaultVisibility()
    {
        _containerChatWindow.visible = false;
        _buttonChatIcon.visible = true;
    }

    public void RegisterEvents()
    {
        _buttonPost.clicked += PostButtonClicked;
        _buttonBackToMainMenu.clicked += BackButtonClicked;
        _buttonUserMinimize.clicked += MinimizeButtonClicked;
        _buttonChatIcon.clicked += ChatIconClicked;
    }

    public void UnRegisterEvents()
    {
        _buttonPost.clicked -= PostButtonClicked;
        _buttonBackToMainMenu.clicked -= BackButtonClicked;
        _buttonUserMinimize.clicked -= MinimizeButtonClicked;
        _buttonChatIcon.clicked -= ChatIconClicked;
    }

    private void PostButtonClicked()
    {
        _controller.ChatWindowPostButtonClicked(_textFieldUserChat.value);
    }

    private void BackButtonClicked()
    {
        Debug.Log("Back To Main Menu");
    }

    private void MinimizeButtonClicked()
    {
        Debug.Log("Minimize Button Clicked");
        _buttonChatIcon.visible = true;
        _containerChatWindow.visible = false;
    }

    private void ChatIconClicked()
    {
        Debug.Log("Chat Button Clicked");
        _buttonChatIcon.visible = false;
        _containerChatWindow.visible = true;
    }

    public void AdduserChatMessageToScrollView(VisualElement visualElement)
    {
        _scrollViewRecentChats.Add(visualElement);
    }


}
