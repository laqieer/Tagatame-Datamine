// Decompiled with JetBrains decompiler
// Type: SRPG.GuildCreateMenu
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
  [Token(Token = "0x200255B")]
  [FlowNode.Pin(10, "ギルド設立", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(30, "表示更新", FlowNode.PinTypes.Input, 30)]
  [FlowNode.Pin(110, "ギルド設立Reqest", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(1001, "NGワード：ギルド名", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1002, "NGワード：ギルド掲示板", FlowNode.PinTypes.Output, 1002)]
  [AddComponentMenu("UI/GuildCreateMenu")]
  public class GuildCreateMenu : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AC17")]
    private const int PIN_INPUT_CREATE_GUILD = 10;
    [Token(Token = "0x400AC18")]
    private const int PIN_INPUT_REFRESH = 30;
    [Token(Token = "0x400AC19")]
    private const int PIN_OUTPUT_CREATE_GUILD = 110;
    [Token(Token = "0x400AC1A")]
    private const int PIN_OUTPUT_NGWORD_GUILD_NAME = 1001;
    [Token(Token = "0x400AC1B")]
    private const int PIN_OUTPUT_NGWORD_GUILD_BOARD = 1002;
    [Token(Token = "0x400AC1C")]
    [FieldOffset(Offset = "0x0")]
    private static GuildCreateMenu mInstance;
    [Token(Token = "0x400AC1D")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private InputFieldCensorship mGuildNameInput;
    [Token(Token = "0x400AC1E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private InputFieldCensorship mGuildCommentInput;
    [Token(Token = "0x400AC1F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle mAutoApprovalToggle;
    [Token(Token = "0x400AC20")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button mSubmitButton;
    [Token(Token = "0x400AC21")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mCreateGuildCostText;
    [Token(Token = "0x400AC22")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ScrollablePulldown mEntryLevelPulldown;
    [Token(Token = "0x400AC23")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int mEntryLevelMin;
    [Token(Token = "0x400AC24")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int mEntryLevelDistance;
    [Token(Token = "0x400AC25")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private ScrollablePulldown mPolicyPulldown;
    [Token(Token = "0x400AC26")]
    [FieldOffset(Offset = "0x30")]
    private List<ChatUtility.ChatInspectionMaster> mChatInspectonMaster;
    [Token(Token = "0x400AC27")]
    [FieldOffset(Offset = "0x34")]
    private bool mIsLoadedInspectionMaster;
    [Token(Token = "0x400AC28")]
    [FieldOffset(Offset = "0x38")]
    private GuildData mTempGuildData;
    [Token(Token = "0x400AC29")]
    [FieldOffset(Offset = "0x3C")]
    private SerializeValueBehaviour mSerializeValueBehaviour;
    [Token(Token = "0x400AC2A")]
    [FieldOffset(Offset = "0x40")]
    private List<int> mEntryLevelList;
    [Token(Token = "0x400AC2B")]
    [FieldOffset(Offset = "0x44")]
    private GameObject mConfirmBox;

    [Token(Token = "0x1700170A")]
    public static GuildCreateMenu Instance
    {
      [Token(Token = "0x600A526"), Address(RVA = "0x6738D0", Offset = "0x6726D0", VA = "0x106738D0")] get
      {
        return (GuildCreateMenu) null;
      }
    }

    [Token(Token = "0x1700170B")]
    public GuildData TempGuildData
    {
      [Token(Token = "0x600A527"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (GuildData) null;
      }
    }

    [Token(Token = "0x600A528")]
    [Address(RVA = "0x6729F0", Offset = "0x6717F0", VA = "0x106729F0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A529")]
    [Address(RVA = "0x672BB0", Offset = "0x6719B0", VA = "0x10672BB0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A52A")]
    [Address(RVA = "0x673730", Offset = "0x672530", VA = "0x10673730")]
    private void Start()
    {
    }

    [Token(Token = "0x600A52B")]
    [Address(RVA = "0x673740", Offset = "0x672540", VA = "0x10673740")]
    private void Update()
    {
    }

    [Token(Token = "0x600A52C")]
    [Address(RVA = "0x672E50", Offset = "0x671C50", VA = "0x10672E50")]
    private void Init()
    {
    }

    [Token(Token = "0x600A52D")]
    [Address(RVA = "0x6732E0", Offset = "0x6720E0", VA = "0x106732E0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600A52E")]
    [Address(RVA = "0x672CB0", Offset = "0x671AB0", VA = "0x10672CB0")]
    private void CreateGuild(GameObject obj)
    {
    }

    [Token(Token = "0x600A52F")]
    [Address(RVA = "0x673180", Offset = "0x671F80", VA = "0x10673180")]
    public void OnCreate()
    {
    }

    [Token(Token = "0x600A530")]
    [Address(RVA = "0x673100", Offset = "0x671F00", VA = "0x10673100")]
    private void LoadChatInspectonMaster()
    {
    }

    [Token(Token = "0x600A531")]
    [Address(RVA = "0x673090", Offset = "0x671E90", VA = "0x10673090")]
    private bool IsExistNGWord(string text) => new bool();

    [Token(Token = "0x600A532")]
    [Address(RVA = "0x673340", Offset = "0x672140", VA = "0x10673340")]
    private void SetupEntryLevelPulldown(GuildData guild)
    {
    }

    [Token(Token = "0x600A533")]
    [Address(RVA = "0x6735D0", Offset = "0x6723D0", VA = "0x106735D0")]
    private void SetupPulldown(GuildData guild)
    {
    }

    [Token(Token = "0x600A534")]
    [Address(RVA = "0x673850", Offset = "0x672650", VA = "0x10673850")]
    public GuildCreateMenu()
    {
    }
  }
}
