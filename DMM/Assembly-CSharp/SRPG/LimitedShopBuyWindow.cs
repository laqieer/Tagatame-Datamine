// Decompiled with JetBrains decompiler
// Type: SRPG.LimitedShopBuyWindow
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
  [Token(Token = "0x20026C9")]
  [FlowNode.Pin(102, "アイテム更新", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "武具選択単品", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(104, "商品の期限切れ警告表示", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(100, "アイテム選択単品", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "アイテム選択セット", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(2, "ClearItem", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/LimitedShopBuyWindow")]
  public class LimitedShopBuyWindow : MonoBehaviour, IFlowInterface, IWebHelp
  {
    [Token(Token = "0x400B64C")]
    private const int PIN_IN_REFRESH = 1;
    [Token(Token = "0x400B64D")]
    private const int PIN_IN_CLEAR_ITEM = 2;
    [Token(Token = "0x400B64E")]
    [FieldOffset(Offset = "0xC")]
    public RectTransform ItemLayoutParent;
    [Token(Token = "0x400B64F")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400B650")]
    [FieldOffset(Offset = "0x14")]
    public Button BtnUpdated;
    [Token(Token = "0x400B651")]
    [FieldOffset(Offset = "0x18")]
    public Text TxtTitle;
    [Token(Token = "0x400B652")]
    [FieldOffset(Offset = "0x1C")]
    public Text TxtUpdateTime;
    [Token(Token = "0x400B653")]
    [FieldOffset(Offset = "0x20")]
    public Text TxtUpdated;
    [Token(Token = "0x400B654")]
    [FieldOffset(Offset = "0x24")]
    public GameObject Updated;
    [Token(Token = "0x400B655")]
    [FieldOffset(Offset = "0x28")]
    public GameObject Update;
    [Token(Token = "0x400B656")]
    [FieldOffset(Offset = "0x2C")]
    public Text ShopName;
    [Token(Token = "0x400B657")]
    [FieldOffset(Offset = "0x30")]
    public List<GameObject> mBuyItems;
    [Token(Token = "0x400B658")]
    [FieldOffset(Offset = "0x34")]
    public GameObject Lineup;
    [Token(Token = "0x400B659")]
    [FieldOffset(Offset = "0x38")]
    [Space(5f)]
    [SerializeField]
    private GameObject GoPaidCoinParent;
    [Token(Token = "0x400B65A")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject GoPaidCoinIcon;
    [Token(Token = "0x400B65B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject GoPaidCoinNum;
    [Token(Token = "0x400B65C")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject GoNoSellMask;
    [Token(Token = "0x400B65D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject CrystalHelpButton;
    [Token(Token = "0x400B65E")]
    [FieldOffset(Offset = "0x4C")]
    public string FIXURL;
    [Token(Token = "0x400B65F")]
    [FieldOffset(Offset = "0x50")]
    private string crystalWebID;

    [Token(Token = "0x600ADAB")]
    [Address(RVA = "0x718620", Offset = "0x717420", VA = "0x10718620")]
    private void Awake()
    {
    }

    [Token(Token = "0x600ADAC")]
    [Address(RVA = "0x7184F0", Offset = "0x7172F0", VA = "0x107184F0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600ADAD")]
    [Address(RVA = "0x718A70", Offset = "0x717870", VA = "0x10718A70")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600ADAE")]
    [Address(RVA = "0x7188B0", Offset = "0x7176B0", VA = "0x107188B0")]
    private void ClearItem()
    {
    }

    [Token(Token = "0x600ADAF")]
    [Address(RVA = "0x719140", Offset = "0x717F40", VA = "0x10719140")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600ADB0")]
    [Address(RVA = "0x71A3A0", Offset = "0x7191A0", VA = "0x1071A3A0")]
    private void ShowAndSaveTimeOutItem(string warned_key, List<LimitedShopItem> nearbyTimeout)
    {
    }

    [Token(Token = "0x600ADB1")]
    [Address(RVA = "0x718BF0", Offset = "0x7179F0", VA = "0x10718BF0")]
    private void OnSelect(GameObject go)
    {
    }

    [Token(Token = "0x600ADB2")]
    [Address(RVA = "0x718AD0", Offset = "0x7178D0", VA = "0x10718AD0")]
    private void OnItemUpdated()
    {
    }

    [Token(Token = "0x600ADB3")]
    [Address(RVA = "0x719000", Offset = "0x717E00", VA = "0x10719000")]
    private bool PopupUnlockInfo(JSON_ShopListArray.Shops shop) => new bool();

    [Token(Token = "0x600ADB4")]
    [Address(RVA = "0x71A0B0", Offset = "0x718EB0", VA = "0x1071A0B0")]
    private bool SetCrystalWebHelp(List<LimitedShopItem> _list) => new bool();

    [Token(Token = "0x600ADB5")]
    [Address(RVA = "0x7189C0", Offset = "0x7177C0", VA = "0x107189C0", Slot = "5")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x600ADB6")]
    [Address(RVA = "0x71AC30", Offset = "0x719A30", VA = "0x1071AC30")]
    public LimitedShopBuyWindow()
    {
    }
  }
}
