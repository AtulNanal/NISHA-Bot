using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BotChatMessageView : IView
{
    private VisualElement _root;

    private BotChatMessageController _controller;
    
    public VisualElement Root
    {
        get { return _root; }
    }

    public ControllerBase ControllerBase
    {
        get { return _controller; }
    }

    private Label _labelBotChat;
    private VisualElement _containerUserReactions;
    private Button _buttonUserLike;
    private Button _buttonUserDislike;
    private Button _buttonUserHeart;
    private Button _buttonUserEmoji;
    public BotChatMessageView(VisualElement visualElement, BotChatMessageController controller)
    {
        _root = visualElement;
        _controller = controller;
        QueryVisualElements();
        RegisterEvents();
    }
    
    private void QueryVisualElements()
    {
        _labelBotChat = _root.Q<Label>(UITags.UITagsChatWindow.LabelBotChatMessage);
        _containerUserReactions = _root.Q<VisualElement>(UITags.UITagsChatWindow.ContainerUserReactions);
        _buttonUserLike = _containerUserReactions.Q<Button>(UITags.UITagsChatWindow.ButtonUserLike);
        _buttonUserDislike = _containerUserReactions.Q<Button>(UITags.UITagsChatWindow.ButtonUserDislike);
        _buttonUserHeart = _containerUserReactions.Q<Button>(UITags.UITagsChatWindow.ButtonUserHeart);
        _buttonUserEmoji = _containerUserReactions.Q<Button>(UITags.UITagsChatWindow.ButtonUserEmoji);
    }

    private void RegisterEvents()
    {
        _buttonUserLike.clicked += LikeButtonClicked;
        _buttonUserDislike.clicked += UnlikeBUttonClicked;
        _buttonUserHeart.clicked += HeartButtonClicked;
        _buttonUserEmoji.clicked += EmojiButtonClicked;
    }
    
    private void UnRegisterEvents()
    {
        _buttonUserLike.clicked -= LikeButtonClicked;
        _buttonUserDislike.clicked -= UnlikeBUttonClicked;
        _buttonUserHeart.clicked -= HeartButtonClicked;
        _buttonUserEmoji.clicked -= EmojiButtonClicked;
    }

    public void ConvertUserChatToChatMessage(string userChatString)
    {
        _labelBotChat.text = userChatString;
    }

    private void LikeButtonClicked()
    {
        
    }

    private void UnlikeBUttonClicked()
    {
        
    }

    private void HeartButtonClicked()
    {
        
    }

    private void EmojiButtonClicked()
    {
        
    }


}
