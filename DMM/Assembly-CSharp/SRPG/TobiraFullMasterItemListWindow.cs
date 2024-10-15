// Decompiled with JetBrains decompiler
// Type: SRPG.TobiraFullMasterItemListWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B2D")]
  [FlowNode.Pin(103, "選択したが期限切れだった", FlowNode.PinTypes.Output, 103)]
  [AddComponentMenu("UI/TobiraFullMasterItemListWindow")]
  [FlowNode.Pin(1, "初期化完了", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(11, "選択された", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(101, "アイテムアイコン選択", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "お知らせ選択", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(0, "初期化", FlowNode.PinTypes.Input, 0)]
  public class TobiraFullMasterItemListWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D2CA")]
    private const int PIN_INPUT_INIT = 0;
    [Token(Token = "0x400D2CB")]
    private const int PIN_OUTPUT_INIT = 1;
    [Token(Token = "0x400D2CC")]
    private const int PIN_OUTPUT_SELECT = 11;
    [Token(Token = "0x400D2CD")]
    private const int PIN_OUTPUT_ITEM_SELECT = 101;
    [Token(Token = "0x400D2CE")]
    private const int PIN_OUTPUT_INFO_SELECT = 102;
    [Token(Token = "0x400D2CF")]
    private const int PIN_OUTPUT_ITEM_EXPIRE = 103;
    [Token(Token = "0x400D2D0")]
    private const string SVB_ITEM_NAME = "item_name";
    [Token(Token = "0x400D2D1")]
    private const string SVB_ITEM_DESC = "item_desc";
    [Token(Token = "0x400D2D2")]
    private const string SVB_ITEM_AMMOUNT = "item_amount";
    [Token(Token = "0x400D2D3")]
    private const string SVB_ICON_BUTTON = "icon_button";
    [Token(Token = "0x400D2D4")]
    private const string SVB_ITEM_SELECT_BUTTON = "item_select_button";
    [Token(Token = "0x400D2D5")]
    private const string SVB_ITEM_USE_PERIOD = "item_use_period";
    [Token(Token = "0x400D2D6")]
    private const string SVB_ITEM_INFORMATION = "item_information";
    [Token(Token = "0x400D2D7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mRootObject;
    [Token(Token = "0x400D2D8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SerializeValueBehaviour mTemplateObject;
    [Token(Token = "0x400D2D9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mEmptyObject;
    [Token(Token = "0x400D2DA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string TOBIRA_MAX_ENHANCE_ITEM_URL_EMPTY;

    [Token(Token = "0x600C59A")]
    [Address(RVA = "0x8E1C90", Offset = "0x8E0A90", VA = "0x108E1C90", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C59B")]
    [Address(RVA = "0x8E27E0", Offset = "0x8E15E0", VA = "0x108E27E0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C59C")]
    [Address(RVA = "0x8E2620", Offset = "0x8E1420", VA = "0x108E2620")]
    private bool Init() => new bool();

    [Token(Token = "0x600C59D")]
    [Address(RVA = "0x8E1D90", Offset = "0x8E0B90", VA = "0x108E1D90")]
    private void CreateItemList(ItemData[] items)
    {
    }

    [Token(Token = "0x600C59E")]
    [Address(RVA = "0x8E1CF0", Offset = "0x8E0AF0", VA = "0x108E1CF0")]
    private static int CompareEndAt(ItemData item1, ItemData item2) => new int();

    [Token(Token = "0x600C59F")]
    [Address(RVA = "0x8E2840", Offset = "0x8E1640", VA = "0x108E2840")]
    public void UseButtonSelect(GameObject go)
    {
    }

    [Token(Token = "0x600C5A0")]
    [Address(RVA = "0x8E2490", Offset = "0x8E1290", VA = "0x108E2490")]
    public void IconSelect(GameObject go)
    {
    }

    [Token(Token = "0x600C5A1")]
    [Address(RVA = "0x8E2530", Offset = "0x8E1330", VA = "0x108E2530")]
    public void InformationSelect(GameObject go)
    {
    }

    [Token(Token = "0x600C5A2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TobiraFullMasterItemListWindow()
    {
    }
  }
}
