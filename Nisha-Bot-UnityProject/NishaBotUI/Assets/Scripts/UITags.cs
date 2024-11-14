using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;

public static class UITags
{
    public static class UITagsChatWindow
    {
        public const string ScrollViewRecentChats = "ScrollViewChat";
        public const string ContainerUserInputBar = "ContainerUserInputBar";
        public const string TextFieldUserChatField = "TextFieldUserChatField";
        public const string ContainerUserInputButtons = "ContainerUserButtons";
        public const string ButtonPostChat = "ButtonPost";
        public const string ButtonPostAttach = "ButtonAttach";

        public const string DefaultUserText = "Please Enter Your Query Here";

        public const string UserChatMessageContainerName = "UserChatMessageContainer";
        public const string BotChatMessageContainerName = "BotChatMessageContainer";

        public const string LabelUserChatMessage = "LabelUserChatMessage";
    }
}
