// Decompiled with JetBrains decompiler
// Type: SRPG.RankMatchWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200292C")]
  [AddComponentMenu("UI/RankMatchWindow")]
  [FlowNode.Pin(211, "Auto Off", FlowNode.PinTypes.Output, 4)]
  [FlowNode.Pin(100, "Refresh Map", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(110, "Refresh Party", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(200, "Auto Toggle", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(210, "Auto On", FlowNode.PinTypes.Output, 3)]
  public class RankMatchWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C639")]
    public const int PINID_REFRESH_MAP = 100;
    [Token(Token = "0x400C63A")]
    public const int PINID_REFRESH_PARTY = 110;
    [Token(Token = "0x400C63B")]
    public const int PININ_TOGGLE_AUTO = 200;
    [Token(Token = "0x400C63C")]
    public const int PINOUT_AUTO_ON = 210;
    [Token(Token = "0x400C63D")]
    public const int PINOUT_AUTO_OFF = 211;
    [Token(Token = "0x400C63E")]
    private const float UPDATE_WAIT_TIME = 1f;
    [Token(Token = "0x400C63F")]
    [FieldOffset(Offset = "0xC")]
    private float mWaitTime;
    [Token(Token = "0x400C640")]
    [FieldOffset(Offset = "0x10")]
    private long mEndTime;
    [Token(Token = "0x400C641")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject PartyInfo;
    [Token(Token = "0x400C642")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject[] PartyUnitSlots;
    [Token(Token = "0x400C643")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject PartyUnitLeader;
    [Token(Token = "0x400C644")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text SeasonDateText;
    [Token(Token = "0x400C645")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text SeasonTimeText;
    [Token(Token = "0x400C646")]
    [FieldOffset(Offset = "0x2C")]
    [Space(10f)]
    [SerializeField]
    private GameObject GoMapInfo;
    [Token(Token = "0x400C647")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text TextMapInfoSchedule;
    [Token(Token = "0x400C648")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text NextOpenDate;
    [Token(Token = "0x400C649")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text NextOpenTime;
    [Token(Token = "0x400C64A")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text RemainTime;
    [Token(Token = "0x400C64B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text StreakWin;
    [Token(Token = "0x400C64C")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject AwardItem;
    [Token(Token = "0x400C64D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Toggle AutoSetting;
    [Token(Token = "0x400C64E")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private WebHelpButton mWebHelp;
    [Token(Token = "0x400C64F")]
    [FieldOffset(Offset = "0x50")]
    private bool mIsUpdateMapInfoEndAt;
    [Token(Token = "0x400C650")]
    [FieldOffset(Offset = "0x54")]
    private float mPassedTimeMapInfoEndAt;

    [Token(Token = "0x600BA3D")]
    [Address(RVA = "0x819FC0", Offset = "0x818DC0", VA = "0x10819FC0")]
    private void Start()
    {
    }

    [Token(Token = "0x600BA3E")]
    [Address(RVA = "0x81A1A0", Offset = "0x818FA0", VA = "0x1081A1A0")]
    private void Update()
    {
    }

    [Token(Token = "0x600BA3F")]
    [Address(RVA = "0x8187F0", Offset = "0x8175F0", VA = "0x108187F0")]
    private void CountDown()
    {
    }

    [Token(Token = "0x600BA40")]
    [Address(RVA = "0x818730", Offset = "0x817530", VA = "0x10818730", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BA41")]
    [Address(RVA = "0x8198C0", Offset = "0x8186C0", VA = "0x108198C0")]
    private void RefreshParty()
    {
    }

    [Token(Token = "0x600BA42")]
    [Address(RVA = "0x819620", Offset = "0x818420", VA = "0x10819620")]
    private void RefreshNextTime()
    {
    }

    [Token(Token = "0x600BA43")]
    [Address(RVA = "0x819190", Offset = "0x817F90", VA = "0x10819190")]
    private void RefreshMap()
    {
    }

    [Token(Token = "0x600BA44")]
    [Address(RVA = "0x81A0B0", Offset = "0x818EB0", VA = "0x1081A0B0")]
    private void ToggleAutoSetting()
    {
    }

    [Token(Token = "0x600BA45")]
    [Address(RVA = "0x818D50", Offset = "0x817B50", VA = "0x10818D50")]
    private bool RefreshMapInfoEndAt() => new bool();

    [Token(Token = "0x600BA46")]
    [Address(RVA = "0x81A140", Offset = "0x818F40", VA = "0x1081A140")]
    private void UpdateMapInfoEndAt()
    {
    }

    [Token(Token = "0x600BA47")]
    [Address(RVA = "0x818C00", Offset = "0x817A00", VA = "0x10818C00")]
    private void RankmatchFirstViewSeason()
    {
    }

    [Token(Token = "0x600BA48")]
    [Address(RVA = "0x81A230", Offset = "0x819030", VA = "0x1081A230")]
    public RankMatchWindow()
    {
    }
  }
}
