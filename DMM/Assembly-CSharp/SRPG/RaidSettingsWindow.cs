// Decompiled with JetBrains decompiler
// Type: SRPG.RaidSettingsWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002907")]
  [AddComponentMenu("UI/RaidSettingsWindow")]
  [FlowNode.Pin(1, "Close", FlowNode.PinTypes.Output, 1)]
  public class RaidSettingsWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C597")]
    [FieldOffset(Offset = "0xC")]
    public RaidSettingsWindow.RaidSettingsEvent OnAccept;
    [Token(Token = "0x400C598")]
    [FieldOffset(Offset = "0x10")]
    public string DebugQuestID;
    [Token(Token = "0x400C599")]
    [FieldOffset(Offset = "0x14")]
    public SRPG_Button AddButton;
    [Token(Token = "0x400C59A")]
    [FieldOffset(Offset = "0x18")]
    public SRPG_Button SubButton;
    [Token(Token = "0x400C59B")]
    [FieldOffset(Offset = "0x1C")]
    public Slider Slider;
    [Token(Token = "0x400C59C")]
    [FieldOffset(Offset = "0x20")]
    public Text CountText;
    [Token(Token = "0x400C59D")]
    [FieldOffset(Offset = "0x24")]
    public Text APText;
    [Token(Token = "0x400C59E")]
    [FieldOffset(Offset = "0x28")]
    public Text CostText;
    [Token(Token = "0x400C59F")]
    [FieldOffset(Offset = "0x2C")]
    public SRPG_Button OKButton;
    [Token(Token = "0x400C5A0")]
    [FieldOffset(Offset = "0x30")]
    public GameObject Ticket;
    [Token(Token = "0x400C5A1")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text TitleText;
    [Token(Token = "0x400C5A2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject GoCostAp;
    [Token(Token = "0x400C5A3")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject GoCostItem;
    [Token(Token = "0x400C5A4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text GoCostItemCost;
    [Token(Token = "0x400C5A5")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject StoryExChallengeCount;
    [Token(Token = "0x400C5A6")]
    [FieldOffset(Offset = "0x48")]
    private QuestParam mQuest;
    [Token(Token = "0x400C5A7")]
    [FieldOffset(Offset = "0x4C")]
    private int mCount;
    [Token(Token = "0x400C5A8")]
    [FieldOffset(Offset = "0x50")]
    private int mCountMax;
    [Token(Token = "0x400C5A9")]
    [FieldOffset(Offset = "0x54")]
    private int mLimit;
    [Token(Token = "0x400C5AA")]
    [FieldOffset(Offset = "0x58")]
    private bool mStarted;
    [Token(Token = "0x400C5AB")]
    [FieldOffset(Offset = "0x5C")]
    private int mLastTicketCount;
    [Token(Token = "0x400C5AC")]
    [FieldOffset(Offset = "0x60")]
    private bool mInsideRefresh;
    [Token(Token = "0x400C5AD")]
    [FieldOffset(Offset = "0x64")]
    private ItemParam GenAdvBossChItemParam;
    [Token(Token = "0x400C5AE")]
    [FieldOffset(Offset = "0x68")]
    private int GenAdvBossChItemNeedNum;

    [Token(Token = "0x600B9B5")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B9B6")]
    [Address(RVA = "0x80D5F0", Offset = "0x80C3F0", VA = "0x1080D5F0")]
    public void Setup(QuestParam quest, int count, int max)
    {
    }

    [Token(Token = "0x17001965")]
    public int Count
    {
      [Token(Token = "0x600B9B7"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600B9B8")]
    [Address(RVA = "0x80D900", Offset = "0x80C700", VA = "0x1080D900")]
    private void Start()
    {
    }

    [Token(Token = "0x600B9B9")]
    [Address(RVA = "0x80D030", Offset = "0x80BE30", VA = "0x1080D030")]
    private void OnOKClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600B9BA")]
    [Address(RVA = "0x80D050", Offset = "0x80BE50", VA = "0x1080D050")]
    private void OnPlayerStaminaChange()
    {
    }

    [Token(Token = "0x600B9BB")]
    [Address(RVA = "0x80CF10", Offset = "0x80BD10", VA = "0x1080CF10")]
    private int GetTicketNum() => new int();

    [Token(Token = "0x600B9BC")]
    [Address(RVA = "0x80DCD0", Offset = "0x80CAD0", VA = "0x1080DCD0")]
    private void Update()
    {
    }

    [Token(Token = "0x600B9BD")]
    [Address(RVA = "0x80CFA0", Offset = "0x80BDA0", VA = "0x1080CFA0")]
    private void OnAddClick()
    {
    }

    [Token(Token = "0x600B9BE")]
    [Address(RVA = "0x80D220", Offset = "0x80C020", VA = "0x1080D220")]
    private void OnSubClick()
    {
    }

    [Token(Token = "0x600B9BF")]
    [Address(RVA = "0x80D180", Offset = "0x80BF80", VA = "0x1080D180")]
    private void OnSliderChange(float value)
    {
    }

    [Token(Token = "0x600B9C0")]
    [Address(RVA = "0x80CBD0", Offset = "0x80B9D0", VA = "0x1080CBD0")]
    private void CountChanged(bool is_stamina_change = false)
    {
    }

    [Token(Token = "0x600B9C1")]
    [Address(RVA = "0x80DC40", Offset = "0x80CA40", VA = "0x1080DC40")]
    private void UpdateCostItem()
    {
    }

    [Token(Token = "0x600B9C2")]
    [Address(RVA = "0x80D2B0", Offset = "0x80C0B0", VA = "0x1080D2B0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600B9C3")]
    [Address(RVA = "0x4FC150", Offset = "0x4FAF50", VA = "0x104FC150")]
    public void Close()
    {
    }

    [Token(Token = "0x600B9C4")]
    [Address(RVA = "0x767BA0", Offset = "0x7669A0", VA = "0x10767BA0")]
    public RaidSettingsWindow()
    {
    }

    [Token(Token = "0x2002908")]
    public delegate void RaidSettingsEvent(RaidSettingsWindow settings);
  }
}
