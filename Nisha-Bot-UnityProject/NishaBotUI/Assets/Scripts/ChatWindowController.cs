using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ChatWindowController
{
    private ChatWindowView _chatWindowView; 
    public ChatWindowController(VisualElement visualElement)
    {
        _chatWindowView = new ChatWindowView(visualElement, this);
    }
    
    public VisualElement VsElement
    {
        get { return _chatWindowView.Root; }
    }

    public void ChatWindowPostButtonClicked(string userChatText)
    {
        Debug.Log("ChatWindowPostButtonClicked");
        // Instantiate the UserChatMessageContainer
        VisualTreeAsset userChatMessageAsset = Resources.Load("UXMLs/" + UITags.UITagsChatWindow.UserChatMessageContainerName) as VisualTreeAsset;
        VisualElement userChatMessageContainer = userChatMessageAsset.CloneTree();
        UserChatMessageController userChatMessageController = new UserChatMessageController(userChatMessageContainer);
        userChatMessageController.ConvertUserChatToChatMessage(userChatText);
        _chatWindowView.AdduserChatMessageToScrollView(userChatMessageController.VsElement);
    }

    public void BotResponseMessageReceived(string botReposeText)
    {
        Debug.Log("BotResponseMessageReceived");
        VisualTreeAsset botChatMessageAsset = Resources.Load("UXMLs/" + UITags.UITagsChatWindow.BotChatMessageContainerName) as VisualTreeAsset;
        VisualElement botChatMessageContainer = botChatMessageAsset.CloneTree();
        BotChatMessageController botChatMessageController = new BotChatMessageController(botChatMessageContainer);
        botChatMessageController.ConvertUserChatToChatMessage(botReposeText);
        _chatWindowView.AdduserChatMessageToScrollView(botChatMessageController.VsElement);

    }
}
