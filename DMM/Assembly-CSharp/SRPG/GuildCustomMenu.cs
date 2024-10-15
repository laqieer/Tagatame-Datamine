// Decompiled with JetBrains decompiler
// Type: SRPG.GuildCustomMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200255C")]
  [FlowNode.Pin(1001, "プレイヤー詳細", FlowNode.PinTypes.Output, 1001)]
  [AddComponentMenu("UI/GuildCustomMenu")]
  [FlowNode.Pin(1050, "掲示板確認", FlowNode.PinTypes.Output, 1050)]
  [FlowNode.Pin(1040, "ポートバトル変更", FlowNode.PinTypes.Output, 1040)]
  [FlowNode.Pin(1, "表示更新", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(1021, "加入申請の一括拒否", FlowNode.PinTypes.Output, 1021)]
  [FlowNode.Pin(1020, "メンバーの除名", FlowNode.PinTypes.Output, 1020)]
  [FlowNode.Pin(1010, "加入申請詳細", FlowNode.PinTypes.Output, 1010)]
  [FlowNode.Pin(1030, "メンバーの役職変更", FlowNode.PinTypes.Output, 1030)]
  public class GuildCustomMenu : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AC2C")]
    private const int PIN_INPUT_REFRESH = 1;
    [Token(Token = "0x400AC2D")]
    private const int PIN_OUTPUT_OPEN_PLAYER_INFO = 1001;
    [Token(Token = "0x400AC2E")]
    private const int PIN_OUTPUT_OPEN_ENTRY_REQUEST_INFO = 1010;
    [Token(Token = "0x400AC2F")]
    private const int PIN_OUTPUT_OPEN_MEMBER_KICK = 1020;
    [Token(Token = "0x400AC30")]
    private const int PIN_OUTPUT_CONFIRM_ENTRY_REQUEST_NG_ALL = 1021;
    [Token(Token = "0x400AC31")]
    private const int PIN_OUTPUT_OPEN_CHANGE_MEMBER = 1030;
    [Token(Token = "0x400AC32")]
    private const int PIN_OUTPUT_CHANGE_GVGJOIN = 1040;
    [Token(Token = "0x400AC33")]
    private const int PIN_OUTPUT_CHECK_BOARD = 1050;
    [Token(Token = "0x400AC34")]
    [FieldOffset(Offset = "0xC")]
    private readonly string[] SORT_KEYS;
    [Token(Token = "0x400AC35")]
    [FieldOffset(Offset = "0x10")]
    private GuildCustomMenu.eSortType mSortType;
    [Token(Token = "0x400AC36")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle[] mTabs;
    [Token(Token = "0x400AC37")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mMemberTemplate1;
    [Token(Token = "0x400AC38")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mMemberTemplate2;
    [Token(Token = "0x400AC39")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mEntryRequestTemplate;
    [Token(Token = "0x400AC3A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mPage_GuildInfo;
    [Token(Token = "0x400AC3B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mPage_MemebrList;
    [Token(Token = "0x400AC3C")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mPage_Board;
    [Token(Token = "0x400AC3D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mPage_GuildEdit;
    [Token(Token = "0x400AC3E")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mPage_MemberManagement;
    [Token(Token = "0x400AC3F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mPage_EntryRequest;
    [Token(Token = "0x400AC40")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mPage_GvG;
    [Token(Token = "0x400AC41")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject[] mTabLockObjects;
    [Token(Token = "0x400AC42")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject mNoEntryRequestsCaution;
    [Token(Token = "0x400AC43")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Pulldown mGuildMemberListSort;
    [Token(Token = "0x400AC44")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Pulldown mGuildMemberManagementSort;
    [Token(Token = "0x400AC45")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Button mEntryRequestRejectAllButton;
    [Token(Token = "0x400AC46")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject mExistInviteBadge;
    [Token(Token = "0x400AC47")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Toggle mGvGJoinTab;
    [Token(Token = "0x400AC48")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private Toggle mGvGCancelTab;
    [Token(Token = "0x400AC49")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private bool isGvGJoin;
    [Token(Token = "0x400AC4A")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private Text mBoardText;
    [Token(Token = "0x400AC4B")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject mBoardEditButton;
    [Token(Token = "0x400AC4C")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private GameObject mBoardBadge;
    [Token(Token = "0x400AC4D")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject mLeaveButtonObj;
    [Token(Token = "0x400AC4E")]
    [FieldOffset(Offset = "0x0")]
    private static GuildCustomMenu mInstance;
    [Token(Token = "0x400AC4F")]
    [FieldOffset(Offset = "0x74")]
    private GuildData mTargetGuild;
    [Token(Token = "0x400AC50")]
    [FieldOffset(Offset = "0x78")]
    private GuildMemberData.eRole mCurrentRole;
    [Token(Token = "0x400AC51")]
    [FieldOffset(Offset = "0x7C")]
    private GameObject[] mPages;
    [Token(Token = "0x400AC52")]
    [FieldOffset(Offset = "0x80")]
    private Toggle SelectTab;
    [Token(Token = "0x400AC53")]
    [FieldOffset(Offset = "0x84")]
    private List<GameObject> mCreatedItems_MemberList;
    [Token(Token = "0x400AC54")]
    [FieldOffset(Offset = "0x88")]
    private List<GameObject> mCreatedItems_MemberManagement;
    [Token(Token = "0x400AC55")]
    [FieldOffset(Offset = "0x8C")]
    private List<GameObject> mCreatedItems_EntryRequest;
    [Token(Token = "0x400AC56")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ScrollRect mScrollRect_GuildInfo;
    [Token(Token = "0x400AC57")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    private ScrollRect mScrollRect_MemberList;
    [Token(Token = "0x400AC58")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private ScrollRect mScrollRect_GuildEdit;
    [Token(Token = "0x400AC59")]
    [FieldOffset(Offset = "0x9C")]
    [SerializeField]
    private ScrollRect mScrollRect_MemberManagement;
    [Token(Token = "0x400AC5A")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private ScrollRect mScrollRect_EntryRequest;
    [Token(Token = "0x400AC5B")]
    [FieldOffset(Offset = "0xA4")]
    [SerializeField]
    private ScrollRect mScrollRect_GvG;
    [Token(Token = "0x400AC5C")]
    [FieldOffset(Offset = "0xA8")]
    private List<ChatUtility.ChatInspectionMaster> mChatInspectionMaster;
    [Token(Token = "0x400AC5D")]
    [FieldOffset(Offset = "0xAC")]
    private bool mIsLoadedInspectionMaster;

    [Token(Token = "0x1700170C")]
    public static GuildCustomMenu Instance
    {
      [Token(Token = "0x600A535"), Address(RVA = "0x676D80", Offset = "0x675B80", VA = "0x10676D80")] get
      {
        return (GuildCustomMenu) null;
      }
    }

    [Token(Token = "0x600A536")]
    [Address(RVA = "0x673900", Offset = "0x672700", VA = "0x10673900", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A537")]
    [Address(RVA = "0x673920", Offset = "0x672720", VA = "0x10673920")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A538")]
    [Address(RVA = "0x676B60", Offset = "0x675960", VA = "0x10676B60")]
    private void Start()
    {
    }

    [Token(Token = "0x600A539")]
    [Address(RVA = "0x673E20", Offset = "0x672C20", VA = "0x10673E20")]
    private void Init()
    {
    }

    [Token(Token = "0x600A53A")]
    [Address(RVA = "0x676280", Offset = "0x675080", VA = "0x10676280")]
    private void SetupTabs()
    {
    }

    [Token(Token = "0x600A53B")]
    [Address(RVA = "0x673DB0", Offset = "0x672BB0", VA = "0x10673DB0")]
    private void HidePageAll()
    {
    }

    [Token(Token = "0x600A53C")]
    [Address(RVA = "0x674E30", Offset = "0x673C30", VA = "0x10674E30")]
    private void RefreshAll()
    {
    }

    [Token(Token = "0x600A53D")]
    [Address(RVA = "0x676090", Offset = "0x674E90", VA = "0x10676090")]
    private void SetupGuildMemberSortPulldown(Pulldown pulldown)
    {
    }

    [Token(Token = "0x600A53E")]
    [Address(RVA = "0x673960", Offset = "0x672760", VA = "0x10673960")]
    public static List<GuildMemberData> GetSortedMemberList(
      GuildMemberData[] members,
      GuildCustomMenu.eSortType sort_type)
    {
      return (List<GuildMemberData>) null;
    }

    [Token(Token = "0x600A53F")]
    [Address(RVA = "0x675E10", Offset = "0x674C10", VA = "0x10675E10")]
    private void Refresh_MemberList(bool is_update_gameparameter = true)
    {
    }

    [Token(Token = "0x600A540")]
    [Address(RVA = "0x675020", Offset = "0x673E20", VA = "0x10675020")]
    private void RefreshMemberListItem()
    {
    }

    [Token(Token = "0x600A541")]
    [Address(RVA = "0x675690", Offset = "0x674490", VA = "0x10675690")]
    private void Refresh_Board()
    {
    }

    [Token(Token = "0x600A542")]
    [Address(RVA = "0x674170", Offset = "0x672F70", VA = "0x10674170")]
    private void LoadChatInspectionMaster()
    {
    }

    [Token(Token = "0x600A543")]
    [Address(RVA = "0x676030", Offset = "0x674E30", VA = "0x10676030")]
    private string ReplaceNGWord(string text) => (string) null;

    [Token(Token = "0x600A544")]
    [Address(RVA = "0x675F20", Offset = "0x674D20", VA = "0x10675F20")]
    private void Refresh_MemberManagement(bool is_update_gameparameter = true)
    {
    }

    [Token(Token = "0x600A545")]
    [Address(RVA = "0x675310", Offset = "0x674110", VA = "0x10675310")]
    private void RefreshMemberManagementItem()
    {
    }

    [Token(Token = "0x600A546")]
    [Address(RVA = "0x675860", Offset = "0x674660", VA = "0x10675860")]
    private void Refresh_EntryRequest(bool is_update_gameparameter = true)
    {
    }

    [Token(Token = "0x600A547")]
    [Address(RVA = "0x675DB0", Offset = "0x674BB0", VA = "0x10675DB0")]
    private void Refresh_GvG(bool is_update_gameparameter = true)
    {
    }

    [Token(Token = "0x600A548")]
    [Address(RVA = "0x674C40", Offset = "0x673A40", VA = "0x10674C40")]
    private void OnSelect_Info(bool isOn)
    {
    }

    [Token(Token = "0x600A549")]
    [Address(RVA = "0x674D00", Offset = "0x673B00", VA = "0x10674D00")]
    private void OnSelect_MemberList(bool isOn)
    {
    }

    [Token(Token = "0x600A54A")]
    [Address(RVA = "0x674950", Offset = "0x673750", VA = "0x10674950")]
    private void OnSelect_Board(bool isOn)
    {
    }

    [Token(Token = "0x600A54B")]
    [Address(RVA = "0x6749C0", Offset = "0x6737C0", VA = "0x106749C0")]
    private void OnSelect_Edit(bool isOn)
    {
    }

    [Token(Token = "0x600A54C")]
    [Address(RVA = "0x674D20", Offset = "0x673B20", VA = "0x10674D20")]
    private void OnSelect_MemberManagement(bool isOn)
    {
    }

    [Token(Token = "0x600A54D")]
    [Address(RVA = "0x674A80", Offset = "0x673880", VA = "0x10674A80")]
    private void OnSelect_EntryRequest(bool isOn)
    {
    }

    [Token(Token = "0x600A54E")]
    [Address(RVA = "0x674AA0", Offset = "0x6738A0", VA = "0x10674AA0")]
    private void OnSelect_GvG(bool isOn)
    {
    }

    [Token(Token = "0x600A54F")]
    [Address(RVA = "0x674880", Offset = "0x673680", VA = "0x10674880")]
    public void OnClickMemberUnitIcon(GameObject obj)
    {
    }

    [Token(Token = "0x600A550")]
    [Address(RVA = "0x6745E0", Offset = "0x6733E0", VA = "0x106745E0")]
    public void OnClickEntryRequestInfo(GameObject obj)
    {
    }

    [Token(Token = "0x600A551")]
    [Address(RVA = "0x6746E0", Offset = "0x6734E0", VA = "0x106746E0")]
    public void OnClickEntryRequestRejectAll()
    {
    }

    [Token(Token = "0x600A552")]
    [Address(RVA = "0x674780", Offset = "0x673580", VA = "0x10674780")]
    public void OnClickMemberKick(GameObject obj)
    {
    }

    [Token(Token = "0x600A553")]
    [Address(RVA = "0x6744E0", Offset = "0x6732E0", VA = "0x106744E0")]
    public void OnClickChangeRole(GameObject obj)
    {
    }

    [Token(Token = "0x600A554")]
    [Address(RVA = "0x674D40", Offset = "0x673B40", VA = "0x10674D40")]
    private void OnSortChange(int idx)
    {
    }

    [Token(Token = "0x600A555")]
    [Address(RVA = "0x674200", Offset = "0x673000", VA = "0x10674200")]
    public void OnClickChangeGvGJoin(Toggle obj)
    {
    }

    [Token(Token = "0x600A556")]
    [Address(RVA = "0x676890", Offset = "0x675690", VA = "0x10676890")]
    public static void Sort_JoinAt(List<GuildMemberData> lists)
    {
    }

    [Token(Token = "0x600A557")]
    [Address(RVA = "0x676980", Offset = "0x675780", VA = "0x10676980")]
    public static void Sort_LastLogin(List<GuildMemberData> lists)
    {
    }

    [Token(Token = "0x600A558")]
    [Address(RVA = "0x676A70", Offset = "0x675870", VA = "0x10676A70")]
    public static void Sort_PlayerLevel(List<GuildMemberData> lists)
    {
    }

    [Token(Token = "0x600A559")]
    [Address(RVA = "0x676B70", Offset = "0x675970", VA = "0x10676B70")]
    public GuildCustomMenu()
    {
    }

    [Token(Token = "0x200255D")]
    private enum eTab
    {
      [Token(Token = "0x400AC5F")] INFO,
      [Token(Token = "0x400AC60")] MEMBER_LIST,
      [Token(Token = "0x400AC61")] BOARD,
      [Token(Token = "0x400AC62")] EDIT,
      [Token(Token = "0x400AC63")] MEMBER_MANAGEMENT,
      [Token(Token = "0x400AC64")] ENTRY_REQUEST,
      [Token(Token = "0x400AC65")] GVG,
      [Token(Token = "0x400AC66")] MAX,
    }

    [Token(Token = "0x200255E")]
    public enum eSortType
    {
      [Token(Token = "0x400AC6D")] DEFAULT = 0,
      [Token(Token = "0x400AC69")] ENTRY_DATE = 0,
      [Token(Token = "0x400AC68")] MIN = 0,
      [Token(Token = "0x400AC6A")] LAST_LOGIN = 1,
      [Token(Token = "0x400AC6B")] PLAYER_LEVEL = 2,
      [Token(Token = "0x400AC6C")] MAX = 3,
    }
  }
}
