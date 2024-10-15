// Decompiled with JetBrains decompiler
// Type: SRPG.GuildCommand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200254D")]
  [FlowNode.Pin(110, "ギルド加入申請Reqest", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(130, "ギルドメンバー役職変更", FlowNode.PinTypes.Output, 130)]
  [FlowNode.Pin(60, "おすすめギルド検索条件の設定", FlowNode.PinTypes.Input, 60)]
  [FlowNode.Pin(50, "おすすめギルド一覧更新", FlowNode.PinTypes.Input, 50)]
  [FlowNode.Pin(140, "勧誘メッセージ投稿完了", FlowNode.PinTypes.Output, 140)]
  [FlowNode.Pin(20, "前に戻る", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(150, "ギルド詳細ウィンドウを展開", FlowNode.PinTypes.Output, 150)]
  [FlowNode.Pin(160, "ギルド掲示板編集キャンセル", FlowNode.PinTypes.Output, 160)]
  [FlowNode.Pin(161, "ギルド掲示板編集決定", FlowNode.PinTypes.Output, 161)]
  [FlowNode.Pin(1001, "NGワードエラー", FlowNode.PinTypes.Output, 1001)]
  [AddComponentMenu("UI/GuildCommand")]
  [FlowNode.Pin(120, "ギルドメンバー詳細を展開", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(101, "ギルド編集Reqest", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(40, "チャンネル更新", FlowNode.PinTypes.Input, 40)]
  [FlowNode.Pin(10, "次に進む", FlowNode.PinTypes.Input, 10)]
  public class GuildCommand : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AB67")]
    private const int PIN_INPUT_NEXT = 10;
    [Token(Token = "0x400AB68")]
    private const int PIN_INPUT_BACK = 20;
    [Token(Token = "0x400AB69")]
    private const int PIN_INPUT_ENTRY_GUILD = 30;
    [Token(Token = "0x400AB6A")]
    private const int PIN_INPUT_REFRESH_CHANNEL = 40;
    [Token(Token = "0x400AB6B")]
    private const int PIN_INPUT_REFRESH_RECOMMEND_LIST = 50;
    [Token(Token = "0x400AB6C")]
    private const int PIN_INPUT_RECOMMEND_LIST_SEARCH = 60;
    [Token(Token = "0x400AB6D")]
    private const int PIN_OUTPUT_EDIT_GUILD = 101;
    [Token(Token = "0x400AB6E")]
    private const int PIN_OUTPUT_ENTRY_REQUEST = 110;
    [Token(Token = "0x400AB6F")]
    private const int PIN_OUTPUT_OPEN_MEMBER_INFO = 120;
    [Token(Token = "0x400AB70")]
    private const int PIN_OUTPUT_CHANGE_ROLE = 130;
    [Token(Token = "0x400AB71")]
    private const int PIN_OUTPUT_END_INVITE_MESSAGE = 140;
    [Token(Token = "0x400AB72")]
    private const int PIN_OUTPUT_OPEN_GUILD_INFO = 150;
    [Token(Token = "0x400AB73")]
    private const int PIN_OUTPUT_EDIT_BOARD_CANCEL = 160;
    [Token(Token = "0x400AB74")]
    private const int PIN_OUTPUT_EDIT_BOARD_DECISION = 161;
    [Token(Token = "0x400AB75")]
    private const int PIN_OUTPUT_NGWORD = 1001;
    [Token(Token = "0x400AB76")]
    private const int EDIT_BOARD_COUNT = 2;
    [Token(Token = "0x400AB77")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mGuildEditName;
    [Token(Token = "0x400AB78")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mGuildSelectEmblem;
    [Token(Token = "0x400AB79")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mGuildRecommendList;
    [Token(Token = "0x400AB7A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mGuildEditBoard;
    [Token(Token = "0x400AB7B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mGuildEditEntryConditions;
    [Token(Token = "0x400AB7C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mGuildEntryInvite;
    [Token(Token = "0x400AB7D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mGuildEditInviteMessage;
    [Token(Token = "0x400AB7E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mGuildChangeRole;
    [Token(Token = "0x400AB7F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mGuildRecommendListSearch;
    [Token(Token = "0x400AB80")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text mGuildRenameCostText;
    [Token(Token = "0x400AB81")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text mGuildEmblemCostText;
    [Token(Token = "0x400AB82")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private InputFieldCensorship mInputGuildName;
    [Token(Token = "0x400AB83")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private InputFieldCensorship mInputGuildBoard;
    [Token(Token = "0x400AB84")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private InputFieldCensorship mInputEntryInviteMessage;
    [Token(Token = "0x400AB85")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private InputFieldCensorship mInputInviteMessage;
    [Token(Token = "0x400AB86")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Button mSubmit_EditGuildNameButton;
    [Token(Token = "0x400AB87")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Button mSubmit_EditGuildEmblemButton;
    [Token(Token = "0x400AB88")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Button mSubmit_EditGuildBoardButton;
    [Token(Token = "0x400AB89")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Button mSubmit_EntryInviteButton;
    [Token(Token = "0x400AB8A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Button mSubmit_EditInviteMessageButton;
    [Token(Token = "0x400AB8B")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private GameObject mEmblemSelectParent;
    [Token(Token = "0x400AB8C")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject mEmblemSelectTemplate;
    [Token(Token = "0x400AB8D")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private GameObject mEmblemSelectButtonsNormal;
    [Token(Token = "0x400AB8E")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject mEmblemSelectButtonsNoRequest;
    [Token(Token = "0x400AB8F")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private GameObject mRecommendGuildParent;
    [Token(Token = "0x400AB90")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject mRecommendGuildTemplate;
    [Token(Token = "0x400AB91")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private ScrollablePulldown mPulldown_SearchConditionsPlayerLv;
    [Token(Token = "0x400AB92")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private ScrollablePulldown mPulldown_SearchConditionsGuildLv;
    [Token(Token = "0x400AB93")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private InputFieldCensorship mSearchConditions_GuildName;
    [Token(Token = "0x400AB94")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private SRPG_InputField mSearchConditions_GuildId;
    [Token(Token = "0x400AB95")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    private ScrollablePulldown mSearchConditions_AutoApproval;
    [Token(Token = "0x400AB96")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private int mSearchConditions_GuildLv;
    [Token(Token = "0x400AB97")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    private GameObject mSearchResultNoneMessage;
    [Token(Token = "0x400AB98")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ScrollablePulldown mPulldown_SearchConditionsMemberCount;
    [Token(Token = "0x400AB99")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    private ScrollablePulldown mPulldown_SearchConditionsPolicy;
    [Token(Token = "0x400AB9A")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private ScrollablePulldown mPulldown_SearchConditionsGuildShopLv;
    [Token(Token = "0x400AB9B")]
    [FieldOffset(Offset = "0x9C")]
    private List<int> mSearchConditionsPlayerLevelList;
    [Token(Token = "0x400AB9C")]
    [FieldOffset(Offset = "0xA0")]
    private List<int> mSearchConditionsGuildLevelList;
    [Token(Token = "0x400AB9D")]
    [FieldOffset(Offset = "0xA4")]
    [SerializeField]
    private GameObject mTargetChannelObject;
    [Token(Token = "0x400AB9E")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject mAutoApprovalOn;
    [Token(Token = "0x400AB9F")]
    [FieldOffset(Offset = "0xAC")]
    [SerializeField]
    private GameObject mAutoApprovalOff;
    [Token(Token = "0x400ABA0")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private ScrollablePulldown mEntryLevelPulldown;
    [Token(Token = "0x400ABA1")]
    [FieldOffset(Offset = "0xB4")]
    [SerializeField]
    private int mEntryLevelMin;
    [Token(Token = "0x400ABA2")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private int mEntryPlayerLevelDistance;
    [Token(Token = "0x400ABA3")]
    [FieldOffset(Offset = "0xBC")]
    [SerializeField]
    private int mEntryGuildLevelDistance;
    [Token(Token = "0x400ABA4")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private ScrollablePulldown mEntryPolicyPulldown;
    [Token(Token = "0x400ABA5")]
    [FieldOffset(Offset = "0xC4")]
    private List<int> mEntryLevelList;
    [Token(Token = "0x400ABA6")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Toggle mChangeRoleToggle_Mastar;
    [Token(Token = "0x400ABA7")]
    [FieldOffset(Offset = "0xCC")]
    [SerializeField]
    private Toggle mChangeRoleToggle_SubMastar;
    [Token(Token = "0x400ABA8")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Toggle mChangeRoleToggle_Member;
    [Token(Token = "0x400ABA9")]
    [FieldOffset(Offset = "0xD4")]
    private GameObject mConfirmBox;
    [Token(Token = "0x400ABAA")]
    [FieldOffset(Offset = "0x0")]
    private static GuildCommand mInstance;
    [Token(Token = "0x400ABAB")]
    [FieldOffset(Offset = "0xD8")]
    private List<GuildCommand.CommandProc> mCommands;
    [Token(Token = "0x400ABAC")]
    [FieldOffset(Offset = "0xDC")]
    private int mCommandProgress;
    [Token(Token = "0x400ABAD")]
    [FieldOffset(Offset = "0xE0")]
    private GuildCommand.CommandErrorCheckProc mCommandErrorCheck;
    [Token(Token = "0x400ABAE")]
    [FieldOffset(Offset = "0xE4")]
    private GuildData mTempGuild;
    [Token(Token = "0x400ABAF")]
    [FieldOffset(Offset = "0xE8")]
    private GuildMemberData mTargetMember;
    [Token(Token = "0x400ABB0")]
    [FieldOffset(Offset = "0xEC")]
    private GuildMemberData.eRole mTargetRole;
    [Token(Token = "0x400ABB1")]
    [FieldOffset(Offset = "0xF0")]
    private GuildCommand.RecommendSearchConditions mSearchConditions;
    [Token(Token = "0x400ABB2")]
    [FieldOffset(Offset = "0xF4")]
    private GuildCommand.eCommand mCurrentCommand;
    [Token(Token = "0x400ABB3")]
    [FieldOffset(Offset = "0xF8")]
    private GuildCommand.eMode mCurrentMode;
    [Token(Token = "0x400ABB4")]
    [FieldOffset(Offset = "0xFC")]
    private List<ChatUtility.ChatInspectionMaster> mChatInspectonMaster;
    [Token(Token = "0x400ABB5")]
    [FieldOffset(Offset = "0x100")]
    private bool mIsLoadedInspectionMaster;
    [Token(Token = "0x400ABB6")]
    [FieldOffset(Offset = "0x104")]
    private List<GameObject> mRecommendGuildItems;
    [Token(Token = "0x400ABB7")]
    [FieldOffset(Offset = "0x108")]
    private GuildEmblemParam mSelectedEmblem;
    [Token(Token = "0x400ABB8")]
    [FieldOffset(Offset = "0x10C")]
    private int mEmblemListPage;
    [Token(Token = "0x400ABB9")]
    [FieldOffset(Offset = "0x110")]
    private List<GameObject> mGuildEmblemItems;
    [Token(Token = "0x400ABBA")]
    [FieldOffset(Offset = "0x114")]
    private GuildEmblemParam[] mNoConditionsEmblemParams;
    [Token(Token = "0x400ABBB")]
    [FieldOffset(Offset = "0x118")]
    private GuildEmblemParam[] mHaveEmblemParams;
    [Token(Token = "0x400ABBC")]
    [FieldOffset(Offset = "0x11C")]
    private string mBeforeBoardText;
    [Token(Token = "0x400ABBD")]
    private const string SELECT_BADGE_KEY = "SelectBadge";

    [Token(Token = "0x170016FE")]
    public static GuildCommand Instance
    {
      [Token(Token = "0x600A4B9"), Address(RVA = "0x671830", Offset = "0x670630", VA = "0x10671830")] get
      {
        return (GuildCommand) null;
      }
    }

    [Token(Token = "0x170016FF")]
    public GuildData TempGuild
    {
      [Token(Token = "0x600A4BA"), Address(RVA = "0x664D40", Offset = "0x663B40", VA = "0x10664D40")] get
      {
        return (GuildData) null;
      }
    }

    [Token(Token = "0x17001700")]
    public GuildMemberData TargetMember
    {
      [Token(Token = "0x600A4BB"), Address(RVA = "0x45A220", Offset = "0x459020", VA = "0x1045A220")] get
      {
        return (GuildMemberData) null;
      }
    }

    [Token(Token = "0x17001701")]
    public GuildMemberData.eRole TargetRole
    {
      [Token(Token = "0x600A4BC"), Address(RVA = "0x6718F0", Offset = "0x6706F0", VA = "0x106718F0")] get
      {
        return new GuildMemberData.eRole();
      }
    }

    [Token(Token = "0x17001702")]
    public GuildCommand.RecommendSearchConditions SearchConditions
    {
      [Token(Token = "0x600A4BD"), Address(RVA = "0x6718D0", Offset = "0x6706D0", VA = "0x106718D0")] get
      {
        return (GuildCommand.RecommendSearchConditions) null;
      }
    }

    [Token(Token = "0x17001703")]
    private GuildEmblemParam[] NoConditionsEmblemParams
    {
      [Token(Token = "0x600A4BE"), Address(RVA = "0x671860", Offset = "0x670660", VA = "0x10671860")] get
      {
        return (GuildEmblemParam[]) null;
      }
    }

    [Token(Token = "0x17001704")]
    private GuildEmblemParam[] HaveEmblemParams
    {
      [Token(Token = "0x600A4BF"), Address(RVA = "0x671680", Offset = "0x670480", VA = "0x10671680")] get
      {
        return (GuildEmblemParam[]) null;
      }
    }

    [Token(Token = "0x17001705")]
    public GuildEmblemParam SelectedEmblem
    {
      [Token(Token = "0x600A4C0"), Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x106718E0")] get
      {
        return (GuildEmblemParam) null;
      }
    }

    [Token(Token = "0x600A4C1")]
    [Address(RVA = "0x66BF20", Offset = "0x66AD20", VA = "0x1066BF20", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A4C2")]
    [Address(RVA = "0x66BFB0", Offset = "0x66ADB0", VA = "0x1066BFB0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A4C3")]
    [Address(RVA = "0x670800", Offset = "0x66F600", VA = "0x10670800")]
    private void Start()
    {
    }

    [Token(Token = "0x600A4C4")]
    [Address(RVA = "0x671090", Offset = "0x66FE90", VA = "0x10671090")]
    private void Update()
    {
    }

    [Token(Token = "0x600A4C5")]
    [Address(RVA = "0x66F2D0", Offset = "0x66E0D0", VA = "0x1066F2D0")]
    public static void SetCommand(GameObject svb_obj, GuildCommand.eCommand command)
    {
    }

    [Token(Token = "0x600A4C6")]
    [Address(RVA = "0x66C550", Offset = "0x66B350", VA = "0x1066C550")]
    private GuildCommand.eCommand GetCommand() => new GuildCommand.eCommand();

    [Token(Token = "0x600A4C7")]
    [Address(RVA = "0x66C610", Offset = "0x66B410", VA = "0x1066C610")]
    private GuildData GetGuildData() => (GuildData) null;

    [Token(Token = "0x600A4C8")]
    [Address(RVA = "0x6704E0", Offset = "0x66F2E0", VA = "0x106704E0")]
    private void SetupUI(GuildData data)
    {
    }

    [Token(Token = "0x600A4C9")]
    [Address(RVA = "0x670340", Offset = "0x66F140", VA = "0x10670340")]
    private void SetupTempGuildByUI()
    {
    }

    [Token(Token = "0x600A4CA")]
    [Address(RVA = "0x66F0D0", Offset = "0x66DED0", VA = "0x1066F0D0")]
    public void ResetTempGuild()
    {
    }

    [Token(Token = "0x600A4CB")]
    [Address(RVA = "0x66D6A0", Offset = "0x66C4A0", VA = "0x1066D6A0")]
    private void HideAll()
    {
    }

    [Token(Token = "0x600A4CC")]
    [Address(RVA = "0x66F970", Offset = "0x66E770", VA = "0x1066F970")]
    private void SetupEntryGuild()
    {
    }

    [Token(Token = "0x600A4CD")]
    [Address(RVA = "0x66F860", Offset = "0x66E660", VA = "0x1066F860")]
    private void SetupEditGuildName()
    {
    }

    [Token(Token = "0x600A4CE")]
    [Address(RVA = "0x670260", Offset = "0x66F060", VA = "0x10670260")]
    private void SetupSelectEmblem()
    {
    }

    [Token(Token = "0x600A4CF")]
    [Address(RVA = "0x66F760", Offset = "0x66E560", VA = "0x1066F760")]
    private void SetupEditBoard()
    {
    }

    [Token(Token = "0x600A4D0")]
    [Address(RVA = "0x66F7E0", Offset = "0x66E5E0", VA = "0x1066F7E0")]
    private void SetupEditEntryConditions()
    {
    }

    [Token(Token = "0x600A4D1")]
    [Address(RVA = "0x66F9F0", Offset = "0x66E7F0", VA = "0x1066F9F0")]
    private void SetupEntryInvite()
    {
    }

    [Token(Token = "0x600A4D2")]
    [Address(RVA = "0x66F8F0", Offset = "0x66E6F0", VA = "0x1066F8F0")]
    private void SetupEditInviteMessage()
    {
    }

    [Token(Token = "0x600A4D3")]
    [Address(RVA = "0x66F3E0", Offset = "0x66E1E0", VA = "0x1066F3E0")]
    private void SetupChangeRole()
    {
    }

    [Token(Token = "0x600A4D4")]
    [Address(RVA = "0x66F460", Offset = "0x66E260", VA = "0x1066F460")]
    private void SetupDelegate(BitArray bits)
    {
    }

    [Token(Token = "0x600A4D5")]
    [Address(RVA = "0x66D960", Offset = "0x66C760", VA = "0x1066D960")]
    private void LoadChatInspectonMaster()
    {
    }

    [Token(Token = "0x600A4D6")]
    [Address(RVA = "0x66D8F0", Offset = "0x66C6F0", VA = "0x1066D8F0")]
    private bool IsExistNGWord(string text) => new bool();

    [Token(Token = "0x600A4D7")]
    [Address(RVA = "0x66E9C0", Offset = "0x66D7C0", VA = "0x1066E9C0")]
    private string ReplaceNGWord(string text) => (string) null;

    [Token(Token = "0x600A4D8")]
    [Address(RVA = "0x66FBE0", Offset = "0x66E9E0", VA = "0x1066FBE0")]
    private void SetupPulldown(
      ScrollablePulldown pulldown,
      List<int> level_list,
      int lower_lv,
      int min_lv,
      int distance)
    {
    }

    [Token(Token = "0x600A4D9")]
    [Address(RVA = "0x66FF70", Offset = "0x66ED70", VA = "0x1066FF70")]
    private void SetupPulldown(
      ScrollablePulldown pulldown,
      List<int> level_list,
      int level,
      int distance)
    {
    }

    [Token(Token = "0x600A4DA")]
    [Address(RVA = "0x66FA70", Offset = "0x66E870", VA = "0x1066FA70")]
    private void SetupPulldown(
      ScrollablePulldown pulldown,
      GuildCommand.RecommendSearchConditions.AutoApproval auto_approval)
    {
    }

    [Token(Token = "0x600A4DB")]
    [Address(RVA = "0x66FE30", Offset = "0x66EC30", VA = "0x1066FE30")]
    private void SetupPulldown(
      ScrollablePulldown pulldown,
      int svalue,
      eGuildSearchFilterTypes ftype)
    {
    }

    [Token(Token = "0x600A4DC")]
    [Address(RVA = "0x66D190", Offset = "0x66BF90", VA = "0x1066D190")]
    private void Guild_EditGuildName()
    {
    }

    [Token(Token = "0x600A4DD")]
    [Address(RVA = "0x66C780", Offset = "0x66B580", VA = "0x1066C780")]
    private void Guild_ConfirmUseCoin()
    {
    }

    [Token(Token = "0x600A4DE")]
    [Address(RVA = "0x66C470", Offset = "0x66B270", VA = "0x1066C470")]
    private void ConfrimNext(GameObject obj)
    {
    }

    [Token(Token = "0x600A4DF")]
    [Address(RVA = "0x66C430", Offset = "0x66B230", VA = "0x1066C430")]
    private void ConfrimBack(GameObject obj)
    {
    }

    [Token(Token = "0x600A4E0")]
    [Address(RVA = "0x66D470", Offset = "0x66C270", VA = "0x1066D470")]
    private void Guild_SelectEmblem()
    {
    }

    [Token(Token = "0x600A4E1")]
    [Address(RVA = "0x66F110", Offset = "0x66DF10", VA = "0x1066F110")]
    private void SelectEmblem(GameObject obj)
    {
    }

    [Token(Token = "0x600A4E2")]
    [Address(RVA = "0x670BA0", Offset = "0x66F9A0", VA = "0x10670BA0")]
    private void StopSelectEmblemAnimation()
    {
    }

    [Token(Token = "0x600A4E3")]
    [Address(RVA = "0x66E540", Offset = "0x66D340", VA = "0x1066E540")]
    private void RefreshSelectGuildEmblemList()
    {
    }

    [Token(Token = "0x600A4E4")]
    [Address(RVA = "0x66CD20", Offset = "0x66BB20", VA = "0x1066CD20")]
    private void Guild_EditBoard()
    {
    }

    [Token(Token = "0x600A4E5")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Guild_EditingBoard()
    {
    }

    [Token(Token = "0x600A4E6")]
    [Address(RVA = "0x66CBC0", Offset = "0x66B9C0", VA = "0x1066CBC0")]
    private void Guild_EditBoardCancel()
    {
    }

    [Token(Token = "0x600A4E7")]
    [Address(RVA = "0x66CC80", Offset = "0x66BA80", VA = "0x1066CC80")]
    private void Guild_EditBoardDecision()
    {
    }

    [Token(Token = "0x600A4E8")]
    [Address(RVA = "0x66D7D0", Offset = "0x66C5D0", VA = "0x1066D7D0")]
    private bool IsDecisionButtonInteractable() => new bool();

    [Token(Token = "0x600A4E9")]
    [Address(RVA = "0x66D090", Offset = "0x66BE90", VA = "0x1066D090")]
    private void Guild_EditEntryConditions()
    {
    }

    [Token(Token = "0x600A4EA")]
    [Address(RVA = "0x66D350", Offset = "0x66C150", VA = "0x1066D350")]
    private void Guild_EntryInvite()
    {
    }

    [Token(Token = "0x600A4EB")]
    [Address(RVA = "0x66E760", Offset = "0x66D560", VA = "0x1066E760")]
    private void RefreshSendTargetChannel()
    {
    }

    [Token(Token = "0x600A4EC")]
    [Address(RVA = "0x66D430", Offset = "0x66C230", VA = "0x1066D430")]
    private void Guild_RecommendList()
    {
    }

    [Token(Token = "0x600A4ED")]
    [Address(RVA = "0x66E390", Offset = "0x66D190", VA = "0x1066E390")]
    private void RefreshRecommendList(GuildCommand.RecommendSearchConditions conditions = null)
    {
    }

    [Token(Token = "0x600A4EE")]
    [Address(RVA = "0x66DDD0", Offset = "0x66CBD0", VA = "0x1066DDD0")]
    private void OpenRecommendListSearch()
    {
    }

    [Token(Token = "0x600A4EF")]
    [Address(RVA = "0x670C80", Offset = "0x66FA80", VA = "0x10670C80")]
    public void SubmitRecommendListSearch()
    {
    }

    [Token(Token = "0x600A4F0")]
    [Address(RVA = "0x66C040", Offset = "0x66AE40", VA = "0x1066C040")]
    public void CancelRecommendListSearch()
    {
    }

    [Token(Token = "0x600A4F1")]
    [Address(RVA = "0x66D270", Offset = "0x66C070", VA = "0x1066D270")]
    private void Guild_EditInviteMessage()
    {
    }

    [Token(Token = "0x600A4F2")]
    [Address(RVA = "0x66C6D0", Offset = "0x66B4D0", VA = "0x1066C6D0")]
    private void Guild_ChangeRole()
    {
    }

    [Token(Token = "0x600A4F3")]
    [Address(RVA = "0x66E200", Offset = "0x66D000", VA = "0x1066E200")]
    private void RefreshChangeRoleUI()
    {
    }

    [Token(Token = "0x600A4F4")]
    [Address(RVA = "0x66F250", Offset = "0x66E050", VA = "0x1066F250")]
    private void SetChangeRoleId()
    {
    }

    [Token(Token = "0x600A4F5")]
    [Address(RVA = "0x59F350", Offset = "0x59E150", VA = "0x1059F350")]
    private void RequestChangeRole(GameObject obj)
    {
    }

    [Token(Token = "0x600A4F6")]
    [Address(RVA = "0x66C520", Offset = "0x66B320", VA = "0x1066C520")]
    private bool ErrorCheck_GuildName() => new bool();

    [Token(Token = "0x600A4F7")]
    [Address(RVA = "0x66C490", Offset = "0x66B290", VA = "0x1066C490")]
    private bool ErrorCheck_EditBoard() => new bool();

    [Token(Token = "0x600A4F8")]
    [Address(RVA = "0x66C4F0", Offset = "0x66B2F0", VA = "0x1066C4F0")]
    private bool ErrorCheck_EntryInvite() => new bool();

    [Token(Token = "0x600A4F9")]
    [Address(RVA = "0x66C4C0", Offset = "0x66B2C0", VA = "0x1066C4C0")]
    private bool ErrorCheck_EditInviteMessage() => new bool();

    [Token(Token = "0x600A4FA")]
    [Address(RVA = "0x66D760", Offset = "0x66C560", VA = "0x1066D760")]
    public void Invoke()
    {
    }

    [Token(Token = "0x600A4FB")]
    [Address(RVA = "0x66D9F0", Offset = "0x66C7F0", VA = "0x1066D9F0")]
    public void Next()
    {
    }

    [Token(Token = "0x600A4FC")]
    [Address(RVA = "0x66C000", Offset = "0x66AE00", VA = "0x1066C000")]
    public void Back()
    {
    }

    [Token(Token = "0x600A4FD")]
    [Address(RVA = "0x66C0D0", Offset = "0x66AED0", VA = "0x1066C0D0")]
    private void CommandEnd()
    {
    }

    [Token(Token = "0x600A4FE")]
    [Address(RVA = "0x66C070", Offset = "0x66AE70", VA = "0x1066C070")]
    private void Close()
    {
    }

    [Token(Token = "0x600A4FF")]
    [Address(RVA = "0x66DB90", Offset = "0x66C990", VA = "0x1066DB90")]
    private void OnFinishSendInviteMessage()
    {
    }

    [Token(Token = "0x600A500")]
    [Address(RVA = "0x66DA90", Offset = "0x66C890", VA = "0x1066DA90")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A501")]
    [Address(RVA = "0x66DDC0", Offset = "0x66CBC0", VA = "0x1066DDC0")]
    public void OnSelectGuildEmblem(GameObject obj)
    {
    }

    [Token(Token = "0x600A502")]
    [Address(RVA = "0x66DC90", Offset = "0x66CA90", VA = "0x1066DC90")]
    public void OnRequestEntry(GameObject obj)
    {
    }

    [Token(Token = "0x600A503")]
    [Address(RVA = "0x66DBB0", Offset = "0x66C9B0", VA = "0x1066DBB0")]
    public void OnGuildDetail(GameObject obj)
    {
    }

    [Token(Token = "0x600A504")]
    [Address(RVA = "0x66EA20", Offset = "0x66D820", VA = "0x1066EA20")]
    private void RequestRecommendListCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600A505")]
    [Address(RVA = "0x6714C0", Offset = "0x6702C0", VA = "0x106714C0")]
    public GuildCommand()
    {
    }

    [Token(Token = "0x200254E")]
    public enum eCommand
    {
      [Token(Token = "0x400ABBF")] NONE,
      [Token(Token = "0x400ABC0")] EDIT_GUILD_NAME,
      [Token(Token = "0x400ABC1")] SELECT_EMBLEM,
      [Token(Token = "0x400ABC2")] EDIT_BOARD,
      [Token(Token = "0x400ABC3")] EDIT_ENTRY_CONDITIONS,
      [Token(Token = "0x400ABC4")] ENTRY_INVITE,
      [Token(Token = "0x400ABC5")] RECOMMEND_LIST,
      [Token(Token = "0x400ABC6")] EDIT_INVITE_MESSAGE,
      [Token(Token = "0x400ABC7")] SELECT_EMBLEM_NOREQUEST,
      [Token(Token = "0x400ABC8")] CHANGE_ROLE,
    }

    [Token(Token = "0x200254F")]
    private enum eMode
    {
      [Token(Token = "0x400ABCA")] NONE,
      [Token(Token = "0x400ABCB")] EDIT,
      [Token(Token = "0x400ABCC")] INVITE,
      [Token(Token = "0x400ABCD")] SET_PARAM,
      [Token(Token = "0x400ABCE")] CHANGE_ROLE,
    }

    [Token(Token = "0x2002550")]
    public enum eBitType
    {
      [Token(Token = "0x400ABD0")] NONE,
      [Token(Token = "0x400ABD1")] EDIT_GUILD_NAME,
      [Token(Token = "0x400ABD2")] SELECT_EMBLEM,
      [Token(Token = "0x400ABD3")] EDIT_BOARD,
      [Token(Token = "0x400ABD4")] EDIT_ENTRY_CONDITIONS,
      [Token(Token = "0x400ABD5")] ENTRY_INVITE,
      [Token(Token = "0x400ABD6")] EDIT_INVITE_MESSAGE,
      [Token(Token = "0x400ABD7")] CHANGE_ROLE,
      [Token(Token = "0x400ABD8")] RECOMMEND_LIST,
      [Token(Token = "0x400ABD9")] CONFRIM_USE_COIN,
      [Token(Token = "0x400ABDA")] MAX,
    }

    [Token(Token = "0x2002551")]
    private delegate void CommandProc();

    [Token(Token = "0x2002552")]
    private delegate bool CommandErrorCheckProc();

    [Token(Token = "0x2002553")]
    private enum EditBoardCommand
    {
      [Token(Token = "0x400ABDC")] CANCEL_CHECK,
      [Token(Token = "0x400ABDD")] EDIT_BOARD,
      [Token(Token = "0x400ABDE")] DECISION_CHECK,
      [Token(Token = "0x400ABDF")] MAX,
    }

    [Token(Token = "0x2002554")]
    public class RecommendSearchConditions
    {
      [Token(Token = "0x400ABE0")]
      [FieldOffset(Offset = "0x8")]
      public string guild_name;
      [Token(Token = "0x400ABE1")]
      [FieldOffset(Offset = "0x10")]
      public long guild_id;
      [Token(Token = "0x400ABE2")]
      [FieldOffset(Offset = "0x18")]
      public int guild_lv_from;
      [Token(Token = "0x400ABE3")]
      [FieldOffset(Offset = "0x1C")]
      public int guild_lv_to;
      [Token(Token = "0x400ABE4")]
      [FieldOffset(Offset = "0x20")]
      public int player_lv;
      [Token(Token = "0x400ABE5")]
      [FieldOffset(Offset = "0x24")]
      public GuildCommand.RecommendSearchConditions.AutoApproval auto_approval;
      [Token(Token = "0x400ABE6")]
      [FieldOffset(Offset = "0x28")]
      public int guild_policy;
      [Token(Token = "0x400ABE7")]
      [FieldOffset(Offset = "0x2C")]
      public int guild_member_num_from;
      [Token(Token = "0x400ABE8")]
      [FieldOffset(Offset = "0x30")]
      public int guild_member_num_to;
      [Token(Token = "0x400ABE9")]
      [FieldOffset(Offset = "0x34")]
      public int guild_shop_lv_from;
      [Token(Token = "0x400ABEA")]
      [FieldOffset(Offset = "0x38")]
      public int guild_shop_lv_to;

      [Token(Token = "0x600A50E")]
      [Address(RVA = "0x67F430", Offset = "0x67E230", VA = "0x1067F430")]
      public RecommendSearchConditions()
      {
      }

      [Token(Token = "0x2002555")]
      public enum AutoApproval
      {
        [Token(Token = "0x400ABEC")] None,
        [Token(Token = "0x400ABED")] On,
        [Token(Token = "0x400ABEE")] Off,
        [Token(Token = "0x400ABEF")] __MAX,
      }
    }

    [Token(Token = "0x2002556")]
    public class Json_ResRecommendGuild
    {
      [Token(Token = "0x400ABF0")]
      [FieldOffset(Offset = "0x8")]
      public JSON_Guild[] guild_recommend;

      [Token(Token = "0x600A50F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ResRecommendGuild()
      {
      }
    }
  }
}
