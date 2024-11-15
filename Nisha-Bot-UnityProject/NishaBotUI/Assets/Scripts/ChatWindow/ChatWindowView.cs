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
    
    private ScrollView _scrollViewRecentChats;

    private VisualElement _userInputBarContainer;

    private TextField _textFieldUserChat;

    private VisualElement _containerUserChatButtons;

    private Button _buttonPost;

    private Button _buttonAttach;



    private VisualElement _containerTopBar;

    private Button _buttonBackToMainMenu;

    private Button _buttonUserProfile;

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
        _containerTopBar = _root.Q<VisualElement>(UITags.UITagsChatWindow.ContainerTopBar);
        _buttonBackToMainMenu = _containerTopBar.Q<Button>(UITags.UITagsChatWindow.ButtonBack);
        _buttonUserProfile = _containerTopBar.Q<Button>(UITags.UITagsChatWindow.ButtonProfile);
        
        Debug.Log(_scrollViewRecentChats);
    }

    private void RegisterEvents()
    {
        _buttonPost.clicked += PostButtonClicked;
        _buttonBackToMainMenu.clicked += BackButtonClicked;
        _buttonUserProfile.clicked += ProfileButtonClicked;
    }

    private void UnRegisterEvents()
    {
        _buttonPost.clicked -= PostButtonClicked;
        _buttonBackToMainMenu.clicked -= BackButtonClicked;
        _buttonUserProfile.clicked -= ProfileButtonClicked;
    }

    private void PostButtonClicked()
    {
        _controller.ChatWindowPostButtonClicked(_textFieldUserChat.value);
        _textFieldUserChat.value = UITags.UITagsChatWindow.DefaultUserText;
    }

    private void BackButtonClicked()
    {
        Debug.Log("Back To Main Menu");
    }

    private void ProfileButtonClicked()
    {
        Debug.Log("Profile Button Clicked");
    }

    public void AdduserChatMessageToScrollView(VisualElement visualElement)
    {
        _scrollViewRecentChats.Add(visualElement);
    }


}
