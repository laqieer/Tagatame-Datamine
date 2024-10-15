// Decompiled with JetBrains decompiler
// Type: SRPG.GachaTicketSelectNumWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200245B")]
  [AddComponentMenu("UI/GachaTicketSelectNumWindow")]
  [FlowNode.Pin(107, "アイテムの所持数が0", FlowNode.PinTypes.Output, 107)]
  [FlowNode.Pin(106, "アイテムのinameが指定されていない", FlowNode.PinTypes.Output, 106)]
  [FlowNode.Pin(105, "ガチャ情報を取得できない", FlowNode.PinTypes.Output, 105)]
  [FlowNode.Pin(104, "所持数が0orアイテムデータが存在しない", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(103, "チケットのinameが指定されていない", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(102, "キャンセル", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "チケット枚数を決定", FlowNode.PinTypes.Output, 101)]
  public class GachaTicketSelectNumWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A543")]
    private const int PIN_OUTPUT_TICKET_DECISION = 101;
    [Token(Token = "0x400A544")]
    private const int PIN_OUTPUT_CANCEL = 102;
    [Token(Token = "0x400A545")]
    private const int PIN_OUTPUT_NO_TICKET_INAME = 103;
    [Token(Token = "0x400A546")]
    private const int PIN_OUTPUT_NO_TICKET_DATA = 104;
    [Token(Token = "0x400A547")]
    private const int PIN_OUTPUT_NO_GACHA_INFO = 105;
    [Token(Token = "0x400A548")]
    private const int PIN_OUTPUT_NO_ITEM_INAME = 106;
    [Token(Token = "0x400A549")]
    private const int PIN_OUTPUT_NO_ITEM_DATA = 107;
    [Token(Token = "0x400A54A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text WindowTitle;
    [Token(Token = "0x400A54B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private BitmapText UsedNum;
    [Token(Token = "0x400A54C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Slider TicketNumSlider;
    [Token(Token = "0x400A54D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject AmountTicket;
    [Token(Token = "0x400A54E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject AmountItem;
    [Token(Token = "0x400A54F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button BtnDecide;
    [Token(Token = "0x400A550")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Button BtnCancel;
    [Token(Token = "0x400A551")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button BtnPlus;
    [Token(Token = "0x400A552")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button BtnMinus;
    [Token(Token = "0x400A553")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button BtnMax;
    [Token(Token = "0x400A554")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text TopText;
    [Token(Token = "0x400A555")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text ItemNameText;
    [Token(Token = "0x400A556")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text UnitText;
    [Token(Token = "0x400A557")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button BgButton;
    [Token(Token = "0x400A558")]
    [FieldOffset(Offset = "0x44")]
    [Header("単発召喚チケットの最大消費可能枚数(基本変更しない)")]
    [SerializeField]
    private int MaxSelectNumSingleGacha;
    [Token(Token = "0x400A559")]
    [FieldOffset(Offset = "0x48")]
    [Header("N連召喚チケットの最大消費可能枚数(基本変更しない)")]
    [SerializeField]
    private int MaxSelectNumMultiGacha;
    [Token(Token = "0x400A55A")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    [Header("最大選択枚数表記テキスト")]
    private Text SelectNumWarningText;
    [Token(Token = "0x400A55B")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    [Header("アイテム単発召喚時の連続召喚回数の最大値")]
    private int MaxSelectNumItemGacha;
    [Token(Token = "0x400A55C")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    [Header("アイテム単発召喚時かつ複数連実行も設定されている場合の連続召喚回数の最大値")]
    private int MaxSelectNumItemGachaWithMulti;
    [Token(Token = "0x400A55D")]
    [FieldOffset(Offset = "0x58")]
    private int mMaxNum;
    [Token(Token = "0x400A55E")]
    [FieldOffset(Offset = "0x5C")]
    private int mFixMaxNum;
    [Token(Token = "0x400A55F")]
    private const int BUTTON_SINGLE_VALUE = 1;
    [Token(Token = "0x400A560")]
    [FieldOffset(Offset = "0x0")]
    public static int LastSelectNum;
    [Token(Token = "0x400A561")]
    [FieldOffset(Offset = "0x4")]
    public static string LastSelectGachaIname;
    [Token(Token = "0x400A562")]
    [FieldOffset(Offset = "0x60")]
    private int mInitSelectNum;
    [Token(Token = "0x400A563")]
    [FieldOffset(Offset = "0x64")]
    private GachaManager gacham;
    [Token(Token = "0x400A564")]
    [FieldOffset(Offset = "0x68")]
    private GachaRequestParam mCurrentParam;
    [Token(Token = "0x400A565")]
    [FieldOffset(Offset = "0x6C")]
    private string mTicketIname;
    [Token(Token = "0x400A566")]
    [FieldOffset(Offset = "0x70")]
    private string mItemIname;
    [Token(Token = "0x400A567")]
    [FieldOffset(Offset = "0x74")]
    private ItemData mItemData;

    [Token(Token = "0x6009EE5")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009EE6")]
    [Address(RVA = "0x6164B0", Offset = "0x6152B0", VA = "0x106164B0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009EE7")]
    [Address(RVA = "0x615C60", Offset = "0x614A60", VA = "0x10615C60")]
    private void SetUpTicketSelectNum()
    {
    }

    [Token(Token = "0x6009EE8")]
    [Address(RVA = "0x616840", Offset = "0x615640", VA = "0x10616840")]
    private bool TicketDataCheck() => new bool();

    [Token(Token = "0x6009EE9")]
    [Address(RVA = "0x615440", Offset = "0x614240", VA = "0x10615440")]
    private void SetUpItemSelectNum()
    {
    }

    [Token(Token = "0x6009EEA")]
    [Address(RVA = "0x614DC0", Offset = "0x613BC0", VA = "0x10614DC0")]
    private bool ItemDataCheck() => new bool();

    [Token(Token = "0x6009EEB")]
    [Address(RVA = "0x614F90", Offset = "0x613D90", VA = "0x10614F90")]
    private void OnAddNum(int value)
    {
    }

    [Token(Token = "0x6009EEC")]
    [Address(RVA = "0x614EA0", Offset = "0x613CA0", VA = "0x10614EA0")]
    private void OnAddNumSingle()
    {
    }

    [Token(Token = "0x6009EED")]
    [Address(RVA = "0x6151F0", Offset = "0x613FF0", VA = "0x106151F0")]
    private void OnSubNum(int value)
    {
    }

    [Token(Token = "0x6009EEE")]
    [Address(RVA = "0x615100", Offset = "0x613F00", VA = "0x10615100")]
    private void OnSubNumSingle()
    {
    }

    [Token(Token = "0x6009EEF")]
    [Address(RVA = "0x615390", Offset = "0x614190", VA = "0x10615390")]
    private void OnUseNumChanged(float value)
    {
    }

    [Token(Token = "0x6009EF0")]
    [Address(RVA = "0x6152E0", Offset = "0x6140E0", VA = "0x106152E0")]
    private void OnSummonNumChanged(float value)
    {
    }

    [Token(Token = "0x6009EF1")]
    [Address(RVA = "0x616920", Offset = "0x615720", VA = "0x10616920")]
    private void UpdateButtonInteractable()
    {
    }

    [Token(Token = "0x6009EF2")]
    [Address(RVA = "0x615080", Offset = "0x613E80", VA = "0x10615080")]
    private void OnMaxNum()
    {
    }

    [Token(Token = "0x6009EF3")]
    [Address(RVA = "0x616AC0", Offset = "0x6158C0", VA = "0x10616AC0")]
    public GachaTicketSelectNumWindow()
    {
    }

    [Token(Token = "0x6009EF4")]
    [Address(RVA = "0x616A60", Offset = "0x615860", VA = "0x10616A60")]
    static GachaTicketSelectNumWindow()
    {
    }
  }
}
