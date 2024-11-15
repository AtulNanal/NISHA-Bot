using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build.Player;
using UnityEngine;

public static class UITags
{
    public static class UITagsChatWindow
    {
        //Tags for Chat Window UI
        public const string ScrollViewRecentChats = "ScrollViewChat";
        public const string ContainerUserInputBar = "ContainerUserInputBar";
        public const string TextFieldUserChatField = "TextFieldUserChatField";
        public const string ContainerUserInputButtons = "ContainerUserButtons";
        public const string ButtonPostChat = "ButtonPost";
        public const string ButtonPostAttach = "ButtonAttach";
        public const string ContainerTopBar = "ContainerTopBar";
        public const string ButtonBack = "ButtonBack";
        public const string ButtonMinimize = "ButtonMinimize";

        public const string DefaultUserText = "Please Enter Your Query Here ...";

        public const string UserChatMessageContainerName = "UserChatMessageContainer";
        public const string BotChatMessageContainerName = "BotChatMessageContainer";

        //Tags for User Chat Message UI
        public const string LabelUserChatMessage = "LabelUserChatMessage";
        
        //Tags for Bot Chat Message UI
        public const string LabelBotChatMessage = "LabelBotChatMessage";
        public const string ContainerUserReactions = "ContainerUserReactions";
        public const string ButtonUserLike = "ButtonLike";
        public const string ButtonUserDislike = "ButtonDislike";
        public const string ButtonUserHeart = "ButtonHeart";
        public const string ButtonUserEmoji = "ButtonEmoji";
    }
}
