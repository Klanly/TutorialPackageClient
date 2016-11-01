﻿//********************************************************************
// 文件名: GameChatHistory.cs
// 描述: 聊天历史结构
// 作者: WangZhe
// 修改记录：
//     2014-5-28 Lijia: 客户端效率优化，把OwnSkillData从class改为struct
//********************************************************************

using UnityEngine;
using System.Collections.Generic;
using System;
using Games.GlobeDefine;
using GCGame;
using GCGame.Table;
using Games.LogicObj;
using Module.Log;

namespace Games.ChatHistory
{
    // 聊天历史条目
    public struct ChatHistoryItem
    {
        public enum LINK_INTDATA_COUNT
        {
            ITEM = 6,
            EQUIP = 9,
            COPYTEAM = 0,
            MOVETO = 4,
            PLAYERINFO = 2,
            SWORDSMAN = 3,
            GUILDRECRUIT = 7,
            ROBHONGBAO = 2,
            PROPAGATE = 26,
            MISSION = 2,
        }

        public enum LINK_STRDATA_COUNT
        {
            ITEM = 0,
            EQUIP = 0,
            COPYTEAM = 0,
            MOVETO = 0,
            PLAYERINFO = 0,
            SWORDSMAN = 0,
            GUILDRECRUIT = 0,
            ROBHONGBAO = 0,
            PROPAGATE = 1,
            MISSION = 2,
        }

        public void CleanUp()
        {
            m_eChannel = GC_CHAT.CHATTYPE.CHAT_TYPE_INVALID;
            m_SenderGuid = GlobeVar.INVALID_GUID;
            m_SenderName = "";
            m_ReceiverGuid = GlobeVar.INVALID_GUID;
            m_ReceiverName = "";
            m_ChatInfo = "";
            if (null == m_eLinkType)
            {
                m_eLinkType = new List<GC_CHAT.LINKTYPE>();
            }
            if (null == m_IntData)
            {
                m_IntData = new List<int>();
            }
            if (null == m_StrData)
            {
                m_StrData = new List<string>();
            }
            m_SenderVIPLevel = GlobeVar.INVALID_ID;
            m_VoiceChatIndex = GlobeVar.INVALID_ID;
            m_level = 1;
            m_profession = 0;
        }

        public bool IsValid()
        {
            return m_SenderGuid != GlobeVar.INVALID_GUID;
        }

        public int GetLinkIntDataCountByIndex(int index)
        {
            switch (m_eLinkType[index])
            {
                case GC_CHAT.LINKTYPE.LINK_TYPE_ITEM:
                    return (int)LINK_INTDATA_COUNT.ITEM;
                case GC_CHAT.LINKTYPE.LINK_TYPE_EQUIP:
                    return (int)LINK_INTDATA_COUNT.EQUIP;
                case GC_CHAT.LINKTYPE.LINK_TYPE_COPYTEAM:
                    return (int)LINK_INTDATA_COUNT.COPYTEAM;
                case GC_CHAT.LINKTYPE.LINK_TYPE_MOVETO:
                    return (int)LINK_INTDATA_COUNT.MOVETO;
                case GC_CHAT.LINKTYPE.LINK_TYPE_PLAYERINFO:
                    return (int)LINK_INTDATA_COUNT.PLAYERINFO;
                case GC_CHAT.LINKTYPE.LINK_TYPE_SWORDSMAN:
                    return (int)LINK_INTDATA_COUNT.SWORDSMAN;
                case GC_CHAT.LINKTYPE.LINK_TYPE_GUILDCRUITE:
                    return (int)LINK_INTDATA_COUNT.GUILDRECRUIT;
                case GC_CHAT.LINKTYPE.LINK_TYPE_HONGBAO:
                    return (int)LINK_INTDATA_COUNT.ROBHONGBAO;
                case GC_CHAT.LINKTYPE.LINK_TYPE_PROPAGATE:
                    return (int)LINK_INTDATA_COUNT.PROPAGATE;
                case GC_CHAT.LINKTYPE.LINK_TYPE_MISSION:
                    return (int)LINK_INTDATA_COUNT.MISSION;

                default:
                    return 0;
            }
        }

        public int GetLinkStrDataCountByIndex(int index)
        {
            switch (m_eLinkType[index])
            {
                case GC_CHAT.LINKTYPE.LINK_TYPE_ITEM:
                    return (int)LINK_STRDATA_COUNT.ITEM;
                case GC_CHAT.LINKTYPE.LINK_TYPE_EQUIP:
                    return (int)LINK_STRDATA_COUNT.EQUIP;
                case GC_CHAT.LINKTYPE.LINK_TYPE_COPYTEAM:
                    return (int)LINK_STRDATA_COUNT.COPYTEAM;
                case GC_CHAT.LINKTYPE.LINK_TYPE_MOVETO:
                    return (int)LINK_STRDATA_COUNT.MOVETO;
                case GC_CHAT.LINKTYPE.LINK_TYPE_PLAYERINFO:
                    return (int)LINK_STRDATA_COUNT.PLAYERINFO;
                case GC_CHAT.LINKTYPE.LINK_TYPE_SWORDSMAN:
                    return (int)LINK_STRDATA_COUNT.SWORDSMAN;
                case GC_CHAT.LINKTYPE.LINK_TYPE_GUILDCRUITE:
                    return (int)LINK_STRDATA_COUNT.GUILDRECRUIT;
                case GC_CHAT.LINKTYPE.LINK_TYPE_HONGBAO:
                    return (int)LINK_STRDATA_COUNT.ROBHONGBAO;
                case GC_CHAT.LINKTYPE.LINK_TYPE_PROPAGATE:
                    return (int)LINK_STRDATA_COUNT.PROPAGATE;
                case GC_CHAT.LINKTYPE.LINK_TYPE_MISSION:
                    return (int)LINK_STRDATA_COUNT.MISSION;
                default:
                    return 0;
            }
        }

        GC_CHAT.CHATTYPE m_eChannel;
        public GC_CHAT.CHATTYPE EChannel
        {
            get { return m_eChannel; }
            set { m_eChannel = value; }
        }

        UInt64 m_SenderGuid;
        public UInt64 SenderGuid
        {
            get { return m_SenderGuid; }
            set { m_SenderGuid = value; }
        }

        string m_SenderName;
        public string SenderName
        {
            get { return m_SenderName; }
            set { m_SenderName = value; }
        }

        UInt64 m_ReceiverGuid;
        public UInt64 ReceiverGuid
        {
            get { return m_ReceiverGuid; }
            set { m_ReceiverGuid = value; }
        }

        string m_ReceiverName;
        public string ReceiverName
        {
            get { return m_ReceiverName; }
            set { m_ReceiverName = value; }
        }

        string m_ChatInfo;
        public string ChatInfo
        {
            get { return m_ChatInfo; }
            set { m_ChatInfo = value; }
        }

        List<GC_CHAT.LINKTYPE> m_eLinkType;
        public List<GC_CHAT.LINKTYPE> ELinkType
        {
            get { return m_eLinkType; }
            set { m_eLinkType = value; }
        }

        List<int> m_IntData;
        public List<int> IntData
        {
            get { return m_IntData; }
            set { m_IntData = value; }
        }

        List<string> m_StrData;
        public List<string> StrData
        {
            get { return m_StrData; }
            set { m_StrData = value; }
        }

        int m_SenderVIPLevel;
        public int SenderVIPLevel
        {
            get { return m_SenderVIPLevel; }
            set { m_SenderVIPLevel = value; }
        }

        int m_VoiceChatIndex;
        public int VoiceChatIndex
        {
            get { return m_VoiceChatIndex; }
            set { m_VoiceChatIndex = value; }
        }

        /// <summary>
        /// 等级
        /// </summary>
        private int m_level;
        public int SenderLevel
        {
            get { return m_level; }
            set { m_level = value; }
        }

        /// <summary>
        /// 玩家职业
        /// </summary>
        private int m_profession;
        public int SenderPro
        {
            get { return m_profession; }
            set { m_profession = value; }
        }
    }

    // 整个聊天历史 保存在playerdata中
    public class GameChatHistory
    {
        List<ChatHistoryItem> m_ChatHistoryList = new List<ChatHistoryItem>();
        public List<ChatHistoryItem> ChatHistoryList
        {
            get { return m_ChatHistoryList; }
            set { m_ChatHistoryList = value; }
        }

        List<ChatHistoryItem> m_ReplyHistoryList = new List<ChatHistoryItem>();
        public List<ChatHistoryItem> ReplyHistoryList
        {
            get { return m_ReplyHistoryList; }
            set { m_ReplyHistoryList = value; }
        }

        public const int ReplyHistoryNum = 6;

        List<ChatHistoryItem>[] m_ChannelHistory = new List<ChatHistoryItem>[(int)GC_CHAT.CHATTYPE.CHAT_TYPE_VARIOUS];
        int[] Channel_HistoryCount = { 20, 20, 20, 40, 40, 20, 20, 20, 20, 20, 20 };    // 各频道聊天记录上限 顺序和m_ChannelHistory一致

        List<UInt64> m_FriendSendList = new List<UInt64>();
        public List<UInt64> FriendSendList
        {
            get { return m_FriendSendList; }
            set { m_FriendSendList = value; }
        }

        private bool m_HasNewTellChat = false;
        public bool HasNewTellChat
        {
            get { return m_HasNewTellChat; }
            set { m_HasNewTellChat = value; }
        }

        private bool m_HasTeamInfoChat = false;
        public bool HasTeamInfoChat
        {
            get { return m_HasTeamInfoChat; }
            set { m_HasTeamInfoChat = value; }
        }
        private bool m_HasNewFriendChat = false;
        public bool HasNewFriendChat
        {
            get { return m_HasNewFriendChat; }
            set { m_HasNewFriendChat = value; }
        }

        public GameChatHistory()
        {
            ClearData();
        }

        public bool OnReceiveChat(GC_CHAT pak)
        {
            if (pak == null)
            {
                return false;
            }

            if (pak.Chattype - 1 >= m_ChannelHistory.Length || pak.Chattype - 1 >= Channel_HistoryCount.Length || pak.Chattype - 1 < 0)
            {
                return false;
            }
            if (pak.HasSenderguid)
            {
                if (pak.Chattype != (int)GC_CHAT.CHATTYPE.CHAT_TYPE_SYSTEM)
                {
                    if (pak.Senderguid != Singleton<ObjManager>.Instance.MainPlayer.GUID)
                    {
                        if (Utils.IsStrFilter_Abuse(pak.Chatinfo))
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                if (Utils.IsStrFilter_Abuse(pak.Chatinfo))
                {
                    return false;
                }
            }
            if (m_ChannelHistory[pak.Chattype - 1].Count >= Channel_HistoryCount[pak.Chattype - 1])
            {
                ChatHistoryItem item = m_ChannelHistory[pak.Chattype - 1][0];
                m_ChannelHistory[pak.Chattype - 1].RemoveAt(0);
                m_ChatHistoryList.Remove(item);
                if (item.VoiceChatIndex != GlobeVar.INVALID_ID)
                {
                    GameManager.gameManager.PlayerDataPool.VoiceChatDownloadRecord.DelVoice(item.VoiceChatIndex);
                }
            }

            // 记录聊天历史
            ChatHistoryItem history = new ChatHistoryItem();
            history.CleanUp();
            //string ChatInfo = "";
            if (pak.HasSenderguid)
            {
                history.SenderGuid = pak.Senderguid;
            }
            if (pak.HasSendername)
            {
                history.SenderName = pak.Sendername;
                if (pak.HasAnoymousState)
                {
                    if (pak.AnoymousState == (int)GC_CHAT.ANOYMOUS_STATE.ANOYMOUS_SUCCESS)
                    {
                        history.SenderName = StrDictionary.GetClientDictionaryString("#{10566}");
                    }
                }
            }
            if (pak.HasReceiverguid)
            {
                history.ReceiverGuid = pak.Receiverguid;
            }
            if (pak.HasReceivername)
            {
                history.ReceiverName = pak.Receivername;
            }

            if (pak.HasSenderLevel)
            {
                history.SenderLevel = pak.SenderLevel;
            }

            if (pak.HasSenderProfession)
            {
              history.SenderPro = pak.SenderProfession;
            }
            if (pak.Chattype == (int)GC_CHAT.CHATTYPE.CHAT_TYPE_SYSTEM)
            {
                history.ChatInfo = pak.Chatinfo;
            }
            else
            {
                //history.ChatInfo = Utils.StrFilter_Chat(pak.Chatinfo);                      
            }

            history.ChatInfo = pak.Chatinfo;
            history.ChatInfo = history.ChatInfo.Replace(" ", "　");
            history.EChannel = (GC_CHAT.CHATTYPE)pak.Chattype;
            for (int i = 0; i < pak.linktypeCount; i++)
            {
                history.ELinkType.Add((GC_CHAT.LINKTYPE)pak.linktypeList[i]);
            }
            for (int i = 0; i < pak.intdataList.Count; ++i)
            {
                history.IntData.Add(pak.intdataList[i]);
            }
            for (int i = 0; i < pak.strdataList.Count; ++i)
            {
                history.StrData.Add(pak.strdataList[i]);
            }
            if (pak.HasSenderVIPLevel)
            {
                history.SenderVIPLevel = pak.SenderVIPLevel;
            }

            Obj_MainPlayer mainPlayer = Singleton<ObjManager>.Instance.MainPlayer;
            if (null == mainPlayer)
            {
                return false;
            }
            if (pak.HasVoiceChatIndex && pak.HasSenderguid)
            {
               // LogModule.DebugLog("ReeiveGCCHATVoice");
                history.VoiceChatIndex = pak.VoiceChatIndex;
                if (mainPlayer.GUID != pak.Senderguid && IsCanAutoDownloadVoiceChat(history))
                {
                    if (ChatInfoSetupLogic.IsChannelReceiveChat(GameManager.gameManager.PlayerDataPool.ChooseChannel, history.EChannel))
                    {
                        // 不是自己发送的 又通过语音设置的 又通过聊天频道接收设置的 才去自动下载
                        LogModule.DebugLog("AddGCCHATVoice");
                        GameManager.gameManager.PlayerDataPool.VoiceChatDownloadRecord.ReqDownload(history.VoiceChatIndex, history.SenderGuid);
                    }
                }
            }
            m_ChannelHistory[pak.Chattype - 1].Add(history);
            //LogModule.DebugLog ("add ----------- " + history.ChatInfo + " " + history.StrData[0] +"  " + history.IntData.Count);
            m_ChatHistoryList.Add(history);

            if (pak.HasSenderguid && (pak.Chattype == (int)GC_CHAT.CHATTYPE.CHAT_TYPE_NORMAL || pak.Chattype == (int)GC_CHAT.CHATTYPE.CHAT_TYPE_TEAM))
            {
                if (pak.Senderguid == mainPlayer.GUID)
                {
                    mainPlayer.ShowChatBubble(history);
                }
                else
                {
                    Obj_OtherPlayer player = Singleton<ObjManager>.GetInstance().FindOtherPlayerInScene(pak.Senderguid);
                    if (player != null)
                    {
                        player.ShowChatBubble(history);
                    }
                }
            }

            // 好友频道消息
            if (pak.Chattype == (int)GC_CHAT.CHATTYPE.CHAT_TYPE_FRIEND)
            {
                // 发送者不是玩家自己
                if (pak.HasSenderguid && pak.Senderguid != mainPlayer.GUID)
                {
                    // 如果当前是好友频道 且选中的不是该好友 才向list添加
                    if (ChatInfoLogic.Instance() != null &&
                        ChatInfoLogic.Instance().CurChannelType == ChatInfoLogic.CHANNEL_TYPE.CHAT_TYPE_FRIEND &&
                        ChatInfoLogic.Instance().FriendChatReceiverGuid == pak.Senderguid)
                    {
                    }
                    else
                    {
                        if (!m_FriendSendList.Contains(pak.Senderguid))
                        {
                            m_FriendSendList.Add(pak.Senderguid);
                        }
                    }

                    // 聊天界面关闭或者打开但不是好友频道时
                    if (ChatInfoLogic.Instance() == null ||
                        (ChatInfoLogic.Instance() != null && ChatInfoLogic.Instance().CurChannelType != ChatInfoLogic.CHANNEL_TYPE.CHAT_TYPE_FRIEND))
                    {
                        // 通知ChatFrame显示提示红点
                        if (ChatFrameLogic.Instance() != null)
                        {
                            ChatFrameLogic.Instance().m_InformSprite.SetActive(true);
                        }
                        m_HasNewFriendChat = true;
                    }
                }
            }

            if (pak.Chattype == (int)GC_CHAT.CHATTYPE.CHAT_TYPE_TELL)
            {
                if (pak.HasSenderguid && pak.Senderguid != mainPlayer.GUID)
                {
                    // 聊天界面关闭或者打开但不是密聊频道时
                    if (ChatInfoLogic.Instance() == null ||
                        (ChatInfoLogic.Instance() != null && ChatInfoLogic.Instance().CurChannelType != ChatInfoLogic.CHANNEL_TYPE.CHAT_TYPE_TELL))
                    {
                        // 通知ChatFrame显示提示红点
                        if (ChatFrameLogic.Instance() != null)
                        {
                            ChatFrameLogic.Instance().m_InformSprite.SetActive(true);
                            m_HasNewTellChat = true;
                        }

                        // 如果打开但不是密聊频道 通知聊天界面显示密聊频道标签上的红点
                        if (ChatInfoLogic.Instance() != null && ChatInfoLogic.Instance().CurChannelType != ChatInfoLogic.CHANNEL_TYPE.CHAT_TYPE_TELL)
                        {
                            ChatInfoLogic.Instance().m_TellInformSprite.SetActive(true);
                        }
                    }
                }
            }

            if (pak.Chattype == (int)GC_CHAT.CHATTYPE.CHAT_TYPE_TEAM)
            {
                if (pak.HasSenderguid && pak.Senderguid != mainPlayer.GUID)
                {
                    // 聊天界面关闭或者打开但不是密聊频道时
                    if (ChatInfoLogic.Instance() == null ||
                        (ChatInfoLogic.Instance() != null && ChatInfoLogic.Instance().CurChannelType != ChatInfoLogic.CHANNEL_TYPE.CHAT_TYPE_TEAM))
                    {
                        // 通知ChatFrame显示提示红点
                        if (ChatFrameLogic.Instance() != null)
                        {
                            ChatFrameLogic.Instance().m_InformSprite.SetActive(true);
                            m_HasTeamInfoChat = true;
                        }

                        // 如果打开但不是密聊频道 通知聊天界面显示密聊频道标签上的红点
                        if (ChatInfoLogic.Instance() != null && ChatInfoLogic.Instance().CurChannelType != ChatInfoLogic.CHANNEL_TYPE.CHAT_TYPE_TEAM)
                        {
                            ChatInfoLogic.Instance().m_TeamInfoSprite.SetActive(true);
                        }
                    }
                }
            }
            return true;
        }

        public void AddReplyHistory(CG_CHAT pak)
        {
            if (pak != null)
            {
                // 记录历史回复
                // 如果重复发言 把之前的记录提前 不新增
                foreach (ChatHistoryItem item in m_ReplyHistoryList)
                {
                    if (item.ChatInfo == pak.Chatinfo)
                    {
                        m_ReplyHistoryList.Remove(item);
                        break;
                    }
                }

                ChatHistoryItem history = new ChatHistoryItem();
                history.CleanUp();
                history.ChatInfo = pak.Chatinfo;
                history.ELinkType.Add((GC_CHAT.LINKTYPE)pak.Linktype);
                for (int i = 0; i < pak.intdataList.Count; ++i)
                {
                    history.IntData.Add(pak.intdataList[i]);
                }
                for (int i = 0; i < pak.strdataList.Count; ++i)
                {
                    history.StrData.Add(pak.strdataList[i]);
                }

                if (m_ReplyHistoryList.Count >= ReplyHistoryNum)
                {
                    m_ReplyHistoryList.RemoveAt(0);
                }
                m_ReplyHistoryList.Add(history);
            }
        }

        public void ClearData()
        {
            m_ChatHistoryList.Clear();
            m_ReplyHistoryList.Clear();
            for (int i = 0; i < m_ChannelHistory.Length; i++)
            {
                if (m_ChannelHistory[i] == null)
                {
                    m_ChannelHistory[i] = new List<ChatHistoryItem>();
                }
                m_ChannelHistory[i].Clear();
            }
        }

        public bool IsCanAutoDownloadVoiceChat(ChatHistoryItem history)
        {
            switch (history.EChannel)
            {
                case GC_CHAT.CHATTYPE.CHAT_TYPE_FRIEND: return PlayerPreferenceData.AutoDownloadVoiceChat_Friend;
                case GC_CHAT.CHATTYPE.CHAT_TYPE_TEAM: return PlayerPreferenceData.AutoDownloadVoiceChat_Team;
                case GC_CHAT.CHATTYPE.CHAT_TYPE_GUILD: return PlayerPreferenceData.AutoDownloadVoiceChat_Guild;
                case GC_CHAT.CHATTYPE.CHAT_TYPE_MASTER: return PlayerPreferenceData.AutoDownloadVoiceChat_Master;
                case GC_CHAT.CHATTYPE.CHAT_TYPE_TELL: return true;
                default: return false;
            }
        }
    }

    public struct LastSpeaker
    {
        public void CleanUp()
        {
            m_Guid = GlobeVar.INVALID_GUID;
            m_Name = "";
        }

        public bool IsValid()
        {
            return m_Guid != GlobeVar.INVALID_GUID;
        }

        UInt64 m_Guid;
        public UInt64 Guid
        {
            get { return m_Guid; }
            set { m_Guid = value; }
        }

        string m_Name;
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }
    }

    public class LastSpeakerRecord
    {
        List<LastSpeaker> m_LastSpeakerList = new List<LastSpeaker>();
        public List<LastSpeaker> LastSpeakerList
        {
            get { return m_LastSpeakerList; }
            set { m_LastSpeakerList = value; }
        }

        public void Add(UInt64 guid, string name)
        {
            if (m_LastSpeakerList.Count >= GlobeVar.MAX_LAST_SPEAKERS)
            {
                m_LastSpeakerList.RemoveAt(0);
            }

            LastSpeaker speaker = new LastSpeaker();
            speaker.CleanUp();
            speaker.Guid = guid;
            speaker.Name = name;
            m_LastSpeakerList.Add(speaker);
        }

        public bool IsExist(UInt64 guid)
        {
            for (int i = 0; i < m_LastSpeakerList.Count; i++)
            {
                if (m_LastSpeakerList[i].Guid == guid)
                {
                    return true;
                }
            }
            return false;
        }

        public void ClearData()
        {
            m_LastSpeakerList.Clear();
        }
    }
}