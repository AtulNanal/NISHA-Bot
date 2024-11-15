using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
[Serializable]
public class BotMessage
{
    [SerializeField]
    public string response;
}

public class ChatWindowController : ControllerBase
{
    private ChatWindowView _chatWindowView;

    public override IView View
    {
        get { return _chatWindowView; }
    }

    private ApiTest _apiHandler;
    
    public ChatWindowController(VisualElement visualElement, ApiTest apihandler) : base()
    {
        _chatWindowView = new ChatWindowView(visualElement, this);
        _apiHandler = apihandler;
        _apiHandler.BotResponseReceived += BotResponseMessageReceived;
        Debug.Log(_apiHandler);
    }
    
    public void ChatWindowPostButtonClicked(string userChatText)
    {
        Debug.Log("ChatWindowPostButtonClicked");
        // Instantiate the UserChatMessageContainer
        VisualTreeAsset userChatMessageAsset = Resources.Load("UXMLs/" + UITags.UITagsChatWindow.UserChatMessageContainerName) as VisualTreeAsset;
        VisualElement userChatMessageContainer = userChatMessageAsset.CloneTree();
        UserChatMessageController userChatMessageController = new UserChatMessageController(userChatMessageContainer);
        userChatMessageController.ConvertUserChatToChatMessage(userChatText);
        _chatWindowView.AdduserChatMessageToScrollView(userChatMessageController.View.Root);
        _apiHandler.SendPostMessage(userChatText);
    }

    public void BotResponseMessageReceived(bool status, string botReposeText)
    {
        BotMessage myDeserializedClass = JsonUtility.FromJson<BotMessage>(botReposeText);
        
        Debug.Log("BotResponseMessageReceived " + myDeserializedClass.response);
        VisualTreeAsset botChatMessageAsset =
            Resources.Load("UXMLs/" + UITags.UITagsChatWindow.BotChatMessageContainerName) as VisualTreeAsset;
        VisualElement botChatMessageContainer = botChatMessageAsset.CloneTree();
        BotChatMessageController botChatMessageController = new BotChatMessageController(botChatMessageContainer);
        botChatMessageController.ConvertUserChatToChatMessage(myDeserializedClass.response);
        _chatWindowView.AdduserChatMessageToScrollView(botChatMessageController.View.Root);
    }

}
