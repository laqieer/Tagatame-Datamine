// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceEventSelectorItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F4D")]
  [FlowNode.Pin(1, "選択された", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/Advance/AdvanceEventSelectorItem")]
  [FlowNode.Pin(106, "アーカイブ用クエストリストに遷移", FlowNode.PinTypes.Output, 106)]
  [FlowNode.Pin(0, "表示更新", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(103, "鍵の有効期限が来た", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(102, "鍵解放ポップ", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(100, "期間外だった", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "未解放だった", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(105, "イベント一覧に遷移", FlowNode.PinTypes.Output, 105)]
  public class AdvanceEventSelectorItem : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40083CA")]
    private const int PIN_INPUT_REFRESH = 0;
    [Token(Token = "0x40083CB")]
    private const int PIN_INPUT_ONCLICK = 1;
    [Token(Token = "0x40083CC")]
    private const int PIN_OUT_OUT_OF_PERIOD = 100;
    [Token(Token = "0x40083CD")]
    private const int PIN_OUT_NO_LIBERATION = 101;
    [Token(Token = "0x40083CE")]
    private const int PIN_OUTPUT_ONCLICK_LOCKED_KEY = 102;
    [Token(Token = "0x40083CF")]
    private const int PIN_OUTPUT_LOCK_KEY = 103;
    [Token(Token = "0x40083D0")]
    private const int PIN_OUTPUT_OPEN_KEY = 104;
    [Token(Token = "0x40083D1")]
    private const int PIN_OUTPUT_TO_EVENTLIST = 105;
    [Token(Token = "0x40083D2")]
    private const int PIN_OUTPUT_TO_ARCHIVE_QUESTLIST = 106;
    [Token(Token = "0x40083D3")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text TextTitle;
    [Token(Token = "0x40083D4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform TrParentBanner;
    [Token(Token = "0x40083D5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject NotAvailable;
    [Token(Token = "0x40083D6")]
    [FieldOffset(Offset = "0x18")]
    [Space(5f)]
    [SerializeField]
    private SRPG_Button SelectBtn;
    [Token(Token = "0x40083D7")]
    [FieldOffset(Offset = "0x1C")]
    [Space(5f)]
    [SerializeField]
    private GameObject KeyLocked;
    [Token(Token = "0x40083D8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RawImage KeyIcon;
    [Token(Token = "0x40083D9")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Image KeyItemFrame;
    [Token(Token = "0x40083DA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text UseKeyNum;
    [Token(Token = "0x40083DB")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text KeyAmount;
    [Token(Token = "0x40083DC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string ChapterBannerPath;
    [Token(Token = "0x40083DD")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    [Space(5f)]
    private QuestTimeLimit QuestTimer;
    [Token(Token = "0x40083DE")]
    [FieldOffset(Offset = "0x38")]
    private AdvanceEventParam mEventParam;
    [Token(Token = "0x40083DF")]
    [FieldOffset(Offset = "0x3C")]
    private ChapterParam mChapterParam;
    [Token(Token = "0x40083E0")]
    [FieldOffset(Offset = "0x40")]
    private AdvanceEventSelector mSelector;
    [Token(Token = "0x40083E1")]
    [FieldOffset(Offset = "0x44")]
    private KeyItem mKeyItem;
    [Token(Token = "0x40083E2")]
    [FieldOffset(Offset = "0x48")]
    private bool mIsNoLiberation;

    [Token(Token = "0x17001262")]
    public AdvanceEventParam EventParam
    {
      [Token(Token = "0x6008051"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (AdvanceEventParam) null;
      }
    }

    [Token(Token = "0x17001263")]
    public ChapterParam ChapterParam
    {
      [Token(Token = "0x6008052"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (ChapterParam) null;
      }
    }

    [Token(Token = "0x6008053")]
    [Address(RVA = "0x408580", Offset = "0x407380", VA = "0x10408580", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008054")]
    [Address(RVA = "0x408F40", Offset = "0x407D40", VA = "0x10408F40")]
    public void SetItem()
    {
    }

    [Token(Token = "0x6008055")]
    [Address(RVA = "0x4087D0", Offset = "0x4075D0", VA = "0x104087D0")]
    public void OnClick()
    {
    }

    [Token(Token = "0x6008056")]
    [Address(RVA = "0x408D80", Offset = "0x407B80", VA = "0x10408D80")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6008057")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008058")]
    [Address(RVA = "0x408C60", Offset = "0x407A60", VA = "0x10408C60")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008059")]
    [Address(RVA = "0x409540", Offset = "0x408340", VA = "0x10409540")]
    private void UpdateKeyItemValue()
    {
    }

    [Token(Token = "0x600805A")]
    [Address(RVA = "0x4085B0", Offset = "0x4073B0", VA = "0x104085B0")]
    private bool IsKeyLocked() => new bool();

    [Token(Token = "0x600805B")]
    [Address(RVA = "0x4096C0", Offset = "0x4084C0", VA = "0x104096C0")]
    private void UpdateKeyStatus()
    {
    }

    [Token(Token = "0x600805C")]
    [Address(RVA = "0x408D60", Offset = "0x407B60", VA = "0x10408D60")]
    public void PlayStartLockKey()
    {
    }

    [Token(Token = "0x600805D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdvanceEventSelectorItem()
    {
    }
  }
}
