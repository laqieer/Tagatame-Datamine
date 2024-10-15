// Decompiled with JetBrains decompiler
// Type: SRPG.ChatWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002175")]
  [FlowNode.Pin(50, "チャットログリスト更新", FlowNode.PinTypes.Input, 50)]
  [FlowNode.Pin(47, "ギルドチャットログ取得Request", FlowNode.PinTypes.Output, 47)]
  [FlowNode.Pin(46, "ルームチャットログ取得Request", FlowNode.PinTypes.Output, 46)]
  [FlowNode.Pin(60, "ウィンドウ開いた", FlowNode.PinTypes.Input, 60)]
  [FlowNode.Pin(61, "ウィンドウ閉じた", FlowNode.PinTypes.Input, 61)]
  [FlowNode.Pin(20, "チャットウィンドウを開く", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(112, "ギルド加入申請最終確認", FlowNode.PinTypes.Input, 112)]
  [FlowNode.Pin(45, "前回の発言から10秒以内にメッセージ送信時", FlowNode.PinTypes.Input, 45)]
  [FlowNode.Pin(111, "ギルド勧誘から加入申請", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(110, "申請先のギルド情報を取得", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(101, "スタンプ送信", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/ChatWindow")]
  [FlowNode.Pin(43, "ワールドチャットログ取得", FlowNode.PinTypes.Input, 43)]
  [FlowNode.Pin(70, "チャットログ更新失敗", FlowNode.PinTypes.Input, 70)]
  [FlowNode.Pin(40, "ワールドチャットログ取得Request", FlowNode.PinTypes.Output, 40)]
  [FlowNode.Pin(30, "ユーザーのアイコンをタップ", FlowNode.PinTypes.Output, 30)]
  [FlowNode.Pin(22, "ウィンドウクローズ終了", FlowNode.PinTypes.Output, 22)]
  [FlowNode.Pin(21, "ウィンドウオープン終了", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(23, "チャットウィンドウを閉じる", FlowNode.PinTypes.Input, 23)]
  [FlowNode.Pin(10, "Chat Enter", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(11, "Chat Leave", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(100, "スタンプ送信セット", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(42, "ワールドチャットログリセット", FlowNode.PinTypes.Input, 42)]
  public class ChatWindow : MonoSingleton<ChatWindow>, IFlowInterface
  {
    [Token(Token = "0x40091EF")]
    private const int PINID_IN_CHAT_ENTER = 10;
    [Token(Token = "0x40091F0")]
    private const int PINID_IN_CHAT_LEAVE = 11;
    [Token(Token = "0x40091F1")]
    private const int PINID_IN_CAHTWINDOW_OPEN = 20;
    [Token(Token = "0x40091F2")]
    private const int PINID_OU_OPEN_OUTPUT = 21;
    [Token(Token = "0x40091F3")]
    private const int PINID_OU_CLOSE_OUTPUT = 22;
    [Token(Token = "0x40091F4")]
    private const int PINID_IN_CAHTWINDOW_CLOSE = 23;
    [Token(Token = "0x40091F5")]
    private const int PINID_OU_UNITICON_TAP = 30;
    [Token(Token = "0x40091F6")]
    private const int PINID_OU_REQUEST_CHATLOG_WORLD = 40;
    [Token(Token = "0x40091F7")]
    private const int PINID_IN_UPDATE_CHATLOG_RESET = 42;
    [Token(Token = "0x40091F8")]
    private const int PINID_IN_UPDATE_CHATLOG = 43;
    [Token(Token = "0x40091F9")]
    private const int PINID_IN_SEND_CHAT_INTERVAL = 45;
    [Token(Token = "0x40091FA")]
    private const int PINID_OU_REQUEST_CHATLOG_ROOM = 46;
    [Token(Token = "0x40091FB")]
    private const int PINID_OU_REQUEST_CHATLOG_GUILD = 47;
    [Token(Token = "0x40091FC")]
    private const int PINID_IN_REFRESH_CHATLOGLIST = 50;
    [Token(Token = "0x40091FD")]
    private const int PINID_IN_WINDOW_OPENED = 60;
    [Token(Token = "0x40091FE")]
    private const int PINID_IN_WINDOW_CLOSED = 61;
    [Token(Token = "0x40091FF")]
    private const int PINID_IN_UPDATE_CHATLOG_FAILURE = 70;
    [Token(Token = "0x4009200")]
    private const int PINID_IN_SEND_STAMP = 100;
    [Token(Token = "0x4009201")]
    private const int PINID_OU_REQUEST_SEND_STAMP = 101;
    [Token(Token = "0x4009202")]
    private const int PINID_OU_GET_GUILD_INFO = 110;
    [Token(Token = "0x4009203")]
    private const int PINID_OU_SEND_GUILD_ENTRY_REQUEST = 111;
    [Token(Token = "0x4009204")]
    private const int PINID_IN_OPEN_GUILD_ENTRY_REQUEST_CONFIRM = 112;
    [Token(Token = "0x4009205")]
    [FieldOffset(Offset = "0x0")]
    private static readonly float SPAN_UPDATE_WORLD_MESSAGE_UIOPEN;
    [Token(Token = "0x4009206")]
    [FieldOffset(Offset = "0x4")]
    private static readonly float SPAN_UPDATE_WORLD_MESSAGE_UICLOSE;
    [Token(Token = "0x4009207")]
    [FieldOffset(Offset = "0x8")]
    private static readonly float SPAN_UPDATE_ROOM_MESSAGE_UIOPEN;
    [Token(Token = "0x4009208")]
    [FieldOffset(Offset = "0xC")]
    private static readonly float SPAN_UPDATE_ROOM_MESSAGE_UICLOSE;
    [Token(Token = "0x4009209")]
    [FieldOffset(Offset = "0x10")]
    private static readonly float SPAN_UPDATE_GUILD_MESSAGE_UIOPEN;
    [Token(Token = "0x400920A")]
    [FieldOffset(Offset = "0x14")]
    private static readonly float SPAN_UPDATE_GUILD_MESSAGE_UICLOSE;
    [Token(Token = "0x400920B")]
    [FieldOffset(Offset = "0x18")]
    private static readonly float SPAN_UPDATE_ROOM_MEMBER;
    [Token(Token = "0x400920C")]
    [FieldOffset(Offset = "0xC")]
    private float elapsed_time_for_photon_room_member;
    [Token(Token = "0x400920D")]
    [FieldOffset(Offset = "0x10")]
    private StateMachine<ChatWindow> mState;
    [Token(Token = "0x400920E")]
    [FieldOffset(Offset = "0x14")]
    private bool mOpened;
    [Token(Token = "0x400920F")]
    [FieldOffset(Offset = "0x15")]
    private bool Maintenance;
    [Token(Token = "0x4009210")]
    [FieldOffset(Offset = "0x18")]
    private string MaintenanceMsg;
    [Token(Token = "0x4009211")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject MessageRoot;
    [Token(Token = "0x4009212")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject MessageTemplate;
    [Token(Token = "0x4009213")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Scrollbar ChatScrollBar;
    [Token(Token = "0x4009214")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private InputFieldCensorship InputFieldMessage;
    [Token(Token = "0x4009215")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private SRPG_Button SendMessageButton;
    [Token(Token = "0x4009216")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject ChannelPanel;
    [Token(Token = "0x4009217")]
    [FieldOffset(Offset = "0x34")]
    private Dictionary<ChatWindow.eChatType, SRPG_ToggleButton> mTabButtons;
    [Token(Token = "0x4009218")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private SRPG_ToggleButton Tab_Official;
    [Token(Token = "0x4009219")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private SRPG_ToggleButton Tab_World;
    [Token(Token = "0x400921A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private SRPG_ToggleButton Tab_Room;
    [Token(Token = "0x400921B")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private SRPG_ToggleButton Tab_Guild;
    [Token(Token = "0x400921C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject MaintenancePanel;
    [Token(Token = "0x400921D")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject MaintenanceText;
    [Token(Token = "0x400921E")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject NoUsedChatText;
    [Token(Token = "0x400921F")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject ClosedShowMessage;
    [Token(Token = "0x4009220")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject UpdateMessageBadge;
    [Token(Token = "0x4009221")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private GameObject WordlChatBadge;
    [Token(Token = "0x4009222")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject RoomChatBadge;
    [Token(Token = "0x4009223")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private GameObject GuildChatBadge;
    [Token(Token = "0x4009224")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject OfficialChatBadge;
    [Token(Token = "0x4009225")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private ScrollRect ScrollView;
    [Token(Token = "0x4009226")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text Caution;
    [Token(Token = "0x4009227")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private Animator CautionAnimator;
    [Token(Token = "0x4009228")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text MaintenanceMsgText;
    [Token(Token = "0x4009229")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private Button UsefulButton;
    [Token(Token = "0x400922A")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject UsefulRootObject;
    [Token(Token = "0x400922B")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    private Text InputPlaceholderText;
    [Token(Token = "0x400922C")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text ClosedShowMessageText;
    [Token(Token = "0x400922D")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    private SRPG_Button OpenCloseButton;
    [Token(Token = "0x400922E")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private VerticalLayoutGroup mContentVerticalLayoutGroup;
    [Token(Token = "0x400922F")]
    [FieldOffset(Offset = "0x1C")]
    public static readonly byte MAX_CHAT_LOG_ITEM;
    [Token(Token = "0x4009230")]
    [FieldOffset(Offset = "0x94")]
    public int CharacterLimit;
    [Token(Token = "0x4009231")]
    [FieldOffset(Offset = "0x98")]
    private GameManager gm;
    [Token(Token = "0x4009232")]
    [FieldOffset(Offset = "0x9C")]
    private float mRestTime_Opend_UpdateWorldChat;
    [Token(Token = "0x4009233")]
    [FieldOffset(Offset = "0xA0")]
    private float mRestTime_Opend_UpdateRoomChat;
    [Token(Token = "0x4009234")]
    [FieldOffset(Offset = "0xA4")]
    private float mRestTime_Opend_UpdateGuildChat;
    [Token(Token = "0x4009235")]
    [FieldOffset(Offset = "0xA8")]
    private float mRestTime_Closed_UpdateWorldChat;
    [Token(Token = "0x4009236")]
    [FieldOffset(Offset = "0xAC")]
    private float mRestTime_Closed_UpdateRoomChat;
    [Token(Token = "0x4009237")]
    [FieldOffset(Offset = "0xB0")]
    private float mRestTime_Closed_UpdateGuildChat;
    [Token(Token = "0x4009238")]
    [FieldOffset(Offset = "0xB4")]
    private int mLastChannelID;
    [Token(Token = "0x4009239")]
    [FieldOffset(Offset = "0x20")]
    private static long system_message_local_id;
    [Token(Token = "0x400923A")]
    [FieldOffset(Offset = "0xB8")]
    private Text mMaintenance;
    [Token(Token = "0x400923B")]
    [FieldOffset(Offset = "0xBC")]
    private Text mNoUsedChat;
    [Token(Token = "0x400923C")]
    [FieldOffset(Offset = "0xC0")]
    private bool mIsEnableOpenCloseButton;
    [Token(Token = "0x400923D")]
    [FieldOffset(Offset = "0xC1")]
    private bool is_need_reset_world;
    [Token(Token = "0x400923E")]
    [FieldOffset(Offset = "0xC2")]
    private bool is_need_reset_room;
    [Token(Token = "0x400923F")]
    [FieldOffset(Offset = "0xC3")]
    private bool is_need_reset_guild;
    [Token(Token = "0x4009240")]
    [FieldOffset(Offset = "0xC4")]
    private ChatLog mWorldChatLog;
    [Token(Token = "0x4009241")]
    [FieldOffset(Offset = "0xC8")]
    private ChatLog mRoomChatLog;
    [Token(Token = "0x4009242")]
    [FieldOffset(Offset = "0xCC")]
    private ChatLog mGuildChatLog;
    [Token(Token = "0x4009243")]
    [FieldOffset(Offset = "0xD0")]
    private ChatLog mOfficalChatLog;
    [Token(Token = "0x4009244")]
    [FieldOffset(Offset = "0xD4")]
    private ChatWindow.eChatType mCurrentChatType;
    [Token(Token = "0x4009245")]
    [FieldOffset(Offset = "0xD8")]
    private string mInputPlaceholderDefaultText_World;
    [Token(Token = "0x4009246")]
    [FieldOffset(Offset = "0xDC")]
    private string mInputPlaceholderDefaultText_Room;
    [Token(Token = "0x4009247")]
    [FieldOffset(Offset = "0xE0")]
    private string mInputPlaceholderDefaultText_Guild;
    [Token(Token = "0x4009248")]
    [FieldOffset(Offset = "0xE4")]
    private string mInputPlaceholderDefaultText_Official;
    [Token(Token = "0x4009249")]
    [FieldOffset(Offset = "0x28")]
    private static ChatLog CacheRoomChatLog;
    [Token(Token = "0x400924A")]
    [FieldOffset(Offset = "0x2C")]
    private static ChatUtility.RoomInfo room_info;
    [Token(Token = "0x400924B")]
    [FieldOffset(Offset = "0x30")]
    public static ChatUtility.RoomMemberManager room_member_manager;
    [Token(Token = "0x400924C")]
    [FieldOffset(Offset = "0xE8")]
    private List<ChatLogItem> mItems;
    [Token(Token = "0x400924D")]
    [FieldOffset(Offset = "0xEC")]
    private bool mRequesting;
    [Token(Token = "0x400924E")]
    [FieldOffset(Offset = "0xED")]
    private bool mInitialized;
    [Token(Token = "0x400924F")]
    [FieldOffset(Offset = "0xF0")]
    private long mCurrentGuildId;
    [Token(Token = "0x4009250")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private GameObject RootWindow;
    [Token(Token = "0x4009251")]
    [FieldOffset(Offset = "0xFC")]
    private bool mChatPermit;
    [Token(Token = "0x4009252")]
    [FieldOffset(Offset = "0x100")]
    private List<ChatUtility.ChatInspectionMaster> mChatInspectionMaster;
    [Token(Token = "0x4009253")]
    [FieldOffset(Offset = "0x104")]
    private FlowNode_SendChatMessage mFNode_Sendmessage;
    [Token(Token = "0x4009254")]
    [FieldOffset(Offset = "0x108")]
    private bool IsActiveMaintenancePanel;
    [Token(Token = "0x4009255")]
    [FieldOffset(Offset = "0x109")]
    private bool IsActiveNoUsedChatText;
    [Token(Token = "0x4009256")]
    [FieldOffset(Offset = "0x10A")]
    private bool IsActiveMaintenanceText;

    [Token(Token = "0x170013DA")]
    public bool IsClose
    {
      [Token(Token = "0x6008CA6"), Address(RVA = "0x509D90", Offset = "0x508B90", VA = "0x10509D90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170013DB")]
    public bool IsOpened
    {
      [Token(Token = "0x6008CA7"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170013DC")]
    public bool IsMaintenance
    {
      [Token(Token = "0x6008CA8"), Address(RVA = "0x39C2B0", Offset = "0x39B0B0", VA = "0x1039C2B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170013DD")]
    public bool IsRequesting
    {
      [Token(Token = "0x6008CA9"), Address(RVA = "0x509E20", Offset = "0x508C20", VA = "0x10509E20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170013DE")]
    public bool IsInitialized
    {
      [Token(Token = "0x6008CAA"), Address(RVA = "0x509E00", Offset = "0x508C00", VA = "0x10509E00")] get
      {
        return new bool();
      }
      [Token(Token = "0x6008CAB"), Address(RVA = "0x509EC0", Offset = "0x508CC0", VA = "0x10509EC0")] set
      {
      }
    }

    [Token(Token = "0x170013DF")]
    public bool IsPermit
    {
      [Token(Token = "0x6008CAC"), Address(RVA = "0x509E10", Offset = "0x508C10", VA = "0x10509E10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170013E0")]
    private FlowNode_SendChatMessage FlowNodeSendChatMessage
    {
      [Token(Token = "0x6008CAD"), Address(RVA = "0x509CF0", Offset = "0x508AF0", VA = "0x10509CF0")] get
      {
        return (FlowNode_SendChatMessage) null;
      }
    }

    [Token(Token = "0x6008CAE")]
    [Address(RVA = "0x505320", Offset = "0x504120", VA = "0x10505320")]
    public ChatLog GetChatLogInstance(ChatWindow.eChatType _chat_type) => (ChatLog) null;

    [Token(Token = "0x6008CAF")]
    [Address(RVA = "0x507C70", Offset = "0x506A70", VA = "0x10507C70")]
    public void SetChatLog(ChatLog _chat_log, ChatWindow.eChatType _chat_type)
    {
    }

    [Token(Token = "0x6008CB0")]
    [Address(RVA = "0x507640", Offset = "0x506440", VA = "0x10507640")]
    public void SetChatLogAndSystemMessageMerge(ChatLog _server_chat_log, long _exclude_id)
    {
    }

    [Token(Token = "0x6008CB1")]
    [Address(RVA = "0x5094D0", Offset = "0x5082D0", VA = "0x105094D0")]
    private void UpdateRootWindowState(bool state)
    {
    }

    [Token(Token = "0x6008CB2")]
    [Address(RVA = "0x502F40", Offset = "0x501D40", VA = "0x10502F40", Slot = "6")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008CB3")]
    [Address(RVA = "0x504D60", Offset = "0x503B60", VA = "0x10504D60")]
    private void CreateChatMessageObjects()
    {
    }

    [Token(Token = "0x6008CB4")]
    [Address(RVA = "0x504F00", Offset = "0x503D00", VA = "0x10504F00")]
    public void DeleteChatMessageObjects()
    {
    }

    [Token(Token = "0x6008CB5")]
    [Address(RVA = "0x505EC0", Offset = "0x504CC0", VA = "0x10505EC0")]
    public void Open()
    {
    }

    [Token(Token = "0x6008CB6")]
    [Address(RVA = "0x504C80", Offset = "0x503A80", VA = "0x10504C80")]
    public void Close()
    {
    }

    [Token(Token = "0x6008CB7")]
    [Address(RVA = "0x507530", Offset = "0x506330", VA = "0x10507530")]
    public void SetActiveOpenCloseButton(bool is_active)
    {
    }

    [Token(Token = "0x6008CB8")]
    [Address(RVA = "0x507160", Offset = "0x505F60", VA = "0x10507160")]
    private void ResetChatLog(ChatWindow.eChatType _chat_type)
    {
    }

    [Token(Token = "0x6008CB9")]
    [Address(RVA = "0x506090", Offset = "0x504E90", VA = "0x10506090")]
    private void RefreshCaution()
    {
    }

    [Token(Token = "0x6008CBA")]
    [Address(RVA = "0x509780", Offset = "0x508580", VA = "0x10509780")]
    private void UpdateWindowState(int inputPinID)
    {
    }

    [Token(Token = "0x6008CBB")]
    [Address(RVA = "0x505880", Offset = "0x504680", VA = "0x10505880")]
    private bool IsDispRoomChatTab() => new bool();

    [Token(Token = "0x6008CBC")]
    [Address(RVA = "0x5035F0", Offset = "0x5023F0", VA = "0x105035F0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008CBD")]
    [Address(RVA = "0x505B90", Offset = "0x504990", VA = "0x10505B90")]
    private void OnTabChange(SRPG_Button button)
    {
    }

    [Token(Token = "0x6008CBE")]
    [Address(RVA = "0x508340", Offset = "0x507140", VA = "0x10508340")]
    private bool TabChange(SRPG_Button button) => new bool();

    [Token(Token = "0x6008CBF")]
    [Address(RVA = "0x503DD0", Offset = "0x502BD0", VA = "0x10503DD0")]
    public void ChangeChatTypeTab(ChatWindow.eChatType _chat_type)
    {
    }

    [Token(Token = "0x6008CC0")]
    [Address(RVA = "0x505CE0", Offset = "0x504AE0", VA = "0x10505CE0")]
    private void OnUsefulButton()
    {
    }

    [Token(Token = "0x6008CC1")]
    [Address(RVA = "0x5075C0", Offset = "0x5063C0", VA = "0x105075C0")]
    public void SetActiveUsefulWindowObject(bool _active)
    {
    }

    [Token(Token = "0x6008CC2")]
    [Address(RVA = "0x505A00", Offset = "0x504800", VA = "0x10505A00")]
    public void LoadTemplateMessage()
    {
    }

    [Token(Token = "0x6008CC3")]
    [Address(RVA = "0x508080", Offset = "0x506E80", VA = "0x10508080")]
    private void Start()
    {
    }

    [Token(Token = "0x6008CC4")]
    [Address(RVA = "0x507CE0", Offset = "0x506AE0", VA = "0x10507CE0")]
    public void SetMessageDataToFlowNode(
      string input_text,
      bool is_force_send = false,
      bool is_guild_invite = false,
      ChatWindow.FinishSendCallback callback = null)
    {
    }

    [Token(Token = "0x6008CC5")]
    [Address(RVA = "0x505B50", Offset = "0x504950", VA = "0x10505B50")]
    private void OnSetSendMessage()
    {
    }

    [Token(Token = "0x6008CC6")]
    [Address(RVA = "0x507ED0", Offset = "0x506CD0", VA = "0x10507ED0")]
    private void SetSendStamp()
    {
    }

    [Token(Token = "0x6008CC7")]
    [Address(RVA = "0x509580", Offset = "0x508380", VA = "0x10509580")]
    private void UpdateSendMessageButtonInteractable()
    {
    }

    [Token(Token = "0x6008CC8")]
    [Address(RVA = "0x508BF0", Offset = "0x5079F0", VA = "0x10508BF0")]
    private void UpdateInputPlaceholderText()
    {
    }

    [Token(Token = "0x6008CC9")]
    [Address(RVA = "0x509A20", Offset = "0x508820", VA = "0x10509A20")]
    private void Update()
    {
    }

    [Token(Token = "0x6008CCA")]
    [Address(RVA = "0x504B10", Offset = "0x503910", VA = "0x10504B10")]
    private void ClearAllItems()
    {
    }

    [Token(Token = "0x6008CCB")]
    [Address(RVA = "0x508530", Offset = "0x507330", VA = "0x10508530")]
    private void UpdateChannelPanel()
    {
    }

    [Token(Token = "0x6008CCC")]
    [Address(RVA = "0x506920", Offset = "0x505720", VA = "0x10506920")]
    private void RequestChatLog(ChatWindow.eChatType select, bool force_request = false)
    {
    }

    [Token(Token = "0x6008CCD")]
    [Address(RVA = "0x507000", Offset = "0x505E00", VA = "0x10507000")]
    private void RequestWorldChatLog()
    {
    }

    [Token(Token = "0x6008CCE")]
    [Address(RVA = "0x506E10", Offset = "0x505C10", VA = "0x10506E10")]
    private void RequestRoomChatLog(long exclude_id, bool force_request = false)
    {
    }

    [Token(Token = "0x6008CCF")]
    [Address(RVA = "0x506AF0", Offset = "0x5058F0", VA = "0x10506AF0")]
    public void RequestGuildChatLog()
    {
    }

    [Token(Token = "0x6008CD0")]
    [Address(RVA = "0x505270", Offset = "0x504070", VA = "0x10505270")]
    public void ForceUpdateChatLog(ChatWindow.eChatType chat_type)
    {
    }

    [Token(Token = "0x6008CD1")]
    [Address(RVA = "0x5061C0", Offset = "0x504FC0", VA = "0x105061C0")]
    private void RefreshChatLogView(bool _force_refresh = false)
    {
    }

    [Token(Token = "0x6008CD2")]
    [Address(RVA = "0x506270", Offset = "0x505070", VA = "0x10506270")]
    public void RefreshChatLogView(ChatLog target_chat_log)
    {
    }

    [Token(Token = "0x6008CD3")]
    [Address(RVA = "0x5063D0", Offset = "0x5051D0", VA = "0x105063D0")]
    private IEnumerator RefreshChatMessage(ChatLog _chat_log) => (IEnumerator) null;

    [Token(Token = "0x6008CD4")]
    [Address(RVA = "0x509E30", Offset = "0x508C30", VA = "0x10509E30")]
    private void setPosX(RectTransform rt, float px)
    {
    }

    [Token(Token = "0x6008CD5")]
    [Address(RVA = "0x505BA0", Offset = "0x5049A0", VA = "0x10505BA0")]
    private void OnTapUnitIcon(SRPG_Button button)
    {
    }

    [Token(Token = "0x6008CD6")]
    [Address(RVA = "0x507470", Offset = "0x506270", VA = "0x10507470")]
    private void SetActiveMaintenancePanel(bool active)
    {
    }

    [Token(Token = "0x6008CD7")]
    [Address(RVA = "0x5074F0", Offset = "0x5062F0", VA = "0x105074F0")]
    private void SetActiveNoUsedChatText(bool active)
    {
    }

    [Token(Token = "0x6008CD8")]
    [Address(RVA = "0x5074B0", Offset = "0x5062B0", VA = "0x105074B0")]
    private void SetActiveMaintenanceText(bool active)
    {
    }

    [Token(Token = "0x6008CD9")]
    [Address(RVA = "0x508DE0", Offset = "0x507BE0", VA = "0x10508DE0")]
    private bool UpdateMaintenancePanel() => new bool();

    [Token(Token = "0x6008CDA")]
    [Address(RVA = "0x508780", Offset = "0x507580", VA = "0x10508780")]
    private void UpdateClosingMessage(
      bool _is_world_dirty = false,
      bool _is_room_dirty = false,
      bool _is_guild_dirty = false,
      bool _is_official_dirty = false)
    {
    }

    [Token(Token = "0x6008CDB")]
    [Address(RVA = "0x505440", Offset = "0x504240", VA = "0x10505440")]
    private string GetOneLineMessageText(ChatLogParam _param) => (string) null;

    [Token(Token = "0x6008CDC")]
    [Address(RVA = "0x5072D0", Offset = "0x5060D0", VA = "0x105072D0")]
    private void ResetChatOff()
    {
    }

    [Token(Token = "0x6008CDD")]
    [Address(RVA = "0x509000", Offset = "0x507E00", VA = "0x10509000")]
    private void UpdateMessageBadgeState()
    {
    }

    [Token(Token = "0x6008CDE")]
    [Address(RVA = "0x506540", Offset = "0x505340", VA = "0x10506540")]
    private void RefreshMainBadge(
      bool is_show_world_badge,
      bool is_show_room_badge,
      bool is_show_guild_badge,
      bool is_show_official_badge)
    {
    }

    [Token(Token = "0x6008CDF")]
    [Address(RVA = "0x506820", Offset = "0x505620", VA = "0x10506820")]
    private bool RefreshWorldChatBadge() => new bool();

    [Token(Token = "0x6008CE0")]
    [Address(RVA = "0x506720", Offset = "0x505520", VA = "0x10506720")]
    private bool RefreshRoomChatBadge() => new bool();

    [Token(Token = "0x6008CE1")]
    [Address(RVA = "0x506440", Offset = "0x505240", VA = "0x10506440")]
    private bool RefreshGuildChatBadge() => new bool();

    [Token(Token = "0x6008CE2")]
    [Address(RVA = "0x5065D0", Offset = "0x5053D0", VA = "0x105065D0")]
    private bool RefreshOfficialChatBadge() => new bool();

    [Token(Token = "0x6008CE3")]
    [Address(RVA = "0x507370", Offset = "0x506170", VA = "0x10507370")]
    private void ResetCloseShowMessage()
    {
    }

    [Token(Token = "0x6008CE4")]
    [Address(RVA = "0x504100", Offset = "0x502F00", VA = "0x10504100")]
    private void CheckChannelUpdate()
    {
    }

    [Token(Token = "0x6008CE5")]
    [Address(RVA = "0x504240", Offset = "0x503040", VA = "0x10504240")]
    private void CheckRoomMember()
    {
    }

    [Token(Token = "0x6008CE6")]
    [Address(RVA = "0x505000", Offset = "0x503E00", VA = "0x10505000")]
    public void ExitRoomSelf()
    {
    }

    [Token(Token = "0x6008CE7")]
    [Address(RVA = "0x5052D0", Offset = "0x5040D0", VA = "0x105052D0")]
    private long GenerateSystemMessageId() => new long();

    [Token(Token = "0x6008CE8")]
    [Address(RVA = "0x507400", Offset = "0x506200", VA = "0x10507400")]
    private void SaveRoomChatLogCache()
    {
    }

    [Token(Token = "0x6008CE9")]
    [Address(RVA = "0x504CB0", Offset = "0x503AB0", VA = "0x10504CB0")]
    private void CopyChatLog(ChatLog _base, ref ChatLog _target)
    {
    }

    [Token(Token = "0x6008CEA")]
    [Address(RVA = "0x505A80", Offset = "0x504880", VA = "0x10505A80")]
    public void OnGuildEntryRequest(GameObject obj)
    {
    }

    [Token(Token = "0x6008CEB")]
    [Address(RVA = "0x505D60", Offset = "0x504B60", VA = "0x10505D60")]
    private void OpenSendEntryRequestConfirmWindow()
    {
    }

    [Token(Token = "0x6008CEC")]
    [Address(RVA = "0x509C30", Offset = "0x508A30", VA = "0x10509C30")]
    public ChatWindow()
    {
    }

    [Token(Token = "0x6008CED")]
    [Address(RVA = "0x509B80", Offset = "0x508980", VA = "0x10509B80")]
    static ChatWindow()
    {
    }

    [Token(Token = "0x2002176")]
    public enum eChatType : byte
    {
      [Token(Token = "0x4009258")] None,
      [Token(Token = "0x4009259")] World,
      [Token(Token = "0x400925A")] Room,
      [Token(Token = "0x400925B")] Guild,
      [Token(Token = "0x400925C")] Official,
    }

    [Token(Token = "0x2002177")]
    public enum MessageTemplateType : byte
    {
      [Token(Token = "0x400925E")] None,
      [Token(Token = "0x400925F")] OtherUser,
      [Token(Token = "0x4009260")] User,
      [Token(Token = "0x4009261")] System,
      [Token(Token = "0x4009262")] Official,
    }

    [Token(Token = "0x2002178")]
    public delegate void FinishSendCallback();

    [Token(Token = "0x2002179")]
    private class State_NoUsed : State<ChatWindow>
    {
      [Token(Token = "0x6008CF3")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
      public override void Begin(ChatWindow self)
      {
      }

      [Token(Token = "0x6008CF4")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
      public override void Update(ChatWindow self)
      {
      }

      [Token(Token = "0x6008CF5")]
      [Address(RVA = "0x51E680", Offset = "0x51D480", VA = "0x1051E680")]
      public State_NoUsed()
      {
      }
    }

    [Token(Token = "0x200217A")]
    private class State_Init : State<ChatWindow>
    {
      [Token(Token = "0x6008CF6")]
      [Address(RVA = "0x51E5A0", Offset = "0x51D3A0", VA = "0x1051E5A0", Slot = "5")]
      public override void Update(ChatWindow self)
      {
      }

      [Token(Token = "0x6008CF7")]
      [Address(RVA = "0x51E640", Offset = "0x51D440", VA = "0x1051E640")]
      public State_Init()
      {
      }
    }

    [Token(Token = "0x200217B")]
    private class State_WaitOpened : State<ChatWindow>
    {
      [Token(Token = "0x6008CF8")]
      [Address(RVA = "0x51E940", Offset = "0x51D740", VA = "0x1051E940", Slot = "4")]
      public override void Begin(ChatWindow self)
      {
      }

      [Token(Token = "0x6008CF9")]
      [Address(RVA = "0x51E980", Offset = "0x51D780", VA = "0x1051E980", Slot = "5")]
      public override void Update(ChatWindow self)
      {
      }

      [Token(Token = "0x6008CFA")]
      [Address(RVA = "0x51EB40", Offset = "0x51D940", VA = "0x1051EB40")]
      public State_WaitOpened()
      {
      }
    }

    [Token(Token = "0x200217C")]
    private class State_WaitClosed : State<ChatWindow>
    {
      [Token(Token = "0x6008CFB")]
      [Address(RVA = "0x51E6C0", Offset = "0x51D4C0", VA = "0x1051E6C0", Slot = "4")]
      public override void Begin(ChatWindow self)
      {
      }

      [Token(Token = "0x6008CFC")]
      [Address(RVA = "0x51E740", Offset = "0x51D540", VA = "0x1051E740", Slot = "5")]
      public override void Update(ChatWindow self)
      {
      }

      [Token(Token = "0x6008CFD")]
      [Address(RVA = "0x51E900", Offset = "0x51D700", VA = "0x1051E900")]
      public State_WaitClosed()
      {
      }
    }
  }
}
