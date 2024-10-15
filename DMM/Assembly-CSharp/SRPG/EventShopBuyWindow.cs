// Decompiled with JetBrains decompiler
// Type: SRPG.EventShopBuyWindow
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
  [Token(Token = "0x2002384")]
  [FlowNode.Pin(101, "アイテム選択セット", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "アイテム選択単品", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(102, "アイテム更新", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "武具選択単品", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(104, "商品の期限切れ警告表示", FlowNode.PinTypes.Output, 104)]
  [AddComponentMenu("UI/EventShopBuyWindow")]
  public class EventShopBuyWindow : MonoBehaviour, IFlowInterface, IWebHelp
  {
    [Token(Token = "0x400A025")]
    [FieldOffset(Offset = "0xC")]
    public RectTransform ItemLayoutParent;
    [Token(Token = "0x400A026")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400A027")]
    [FieldOffset(Offset = "0x14")]
    public Button BtnUpdated;
    [Token(Token = "0x400A028")]
    [FieldOffset(Offset = "0x18")]
    public GameObject ObjUpdateBtn;
    [Token(Token = "0x400A029")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject ObjUpdateTime;
    [Token(Token = "0x400A02A")]
    [FieldOffset(Offset = "0x20")]
    public GameObject ObjLineup;
    [Token(Token = "0x400A02B")]
    [FieldOffset(Offset = "0x24")]
    public GameObject ObjItemNumLimit;
    [Token(Token = "0x400A02C")]
    [FieldOffset(Offset = "0x28")]
    public Text TxtPossessionCoinNum;
    [Token(Token = "0x400A02D")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject ImgEventCoinType;
    [Token(Token = "0x400A02E")]
    [FieldOffset(Offset = "0x30")]
    public Text ShopName;
    [Token(Token = "0x400A02F")]
    [FieldOffset(Offset = "0x34")]
    public GameObject CoinPeriodBanner;
    [Token(Token = "0x400A030")]
    [FieldOffset(Offset = "0x38")]
    public Text CoinPeriodText;
    [Token(Token = "0x400A031")]
    [FieldOffset(Offset = "0x3C")]
    public List<GameObject> mBuyItems;
    [Token(Token = "0x400A032")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject CrystalHelpButton;
    [Token(Token = "0x400A033")]
    [FieldOffset(Offset = "0x44")]
    public string FIXURL;
    [Token(Token = "0x400A034")]
    [FieldOffset(Offset = "0x48")]
    private string crystalWebID;

    [Token(Token = "0x600998A")]
    [Address(RVA = "0x5DB910", Offset = "0x5DA710", VA = "0x105DB910")]
    private void Awake()
    {
    }

    [Token(Token = "0x600998B")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600998C")]
    [Address(RVA = "0x5DBFB0", Offset = "0x5DADB0", VA = "0x105DBFB0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600998D")]
    [Address(RVA = "0x5DB8F0", Offset = "0x5DA6F0", VA = "0x105DB8F0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600998E")]
    [Address(RVA = "0x5DC1D0", Offset = "0x5DAFD0", VA = "0x105DC1D0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600998F")]
    [Address(RVA = "0x5DCFA0", Offset = "0x5DBDA0", VA = "0x105DCFA0")]
    private void ShowAndSaveTimeOutItem(List<EventShopItem> nearbyTimeout)
    {
    }

    [Token(Token = "0x6009990")]
    [Address(RVA = "0x5DC010", Offset = "0x5DAE10", VA = "0x105DC010")]
    private void OnSelect(GameObject go)
    {
    }

    [Token(Token = "0x6009991")]
    [Address(RVA = "0x517F80", Offset = "0x516D80", VA = "0x10517F80")]
    private void OnItemUpdated()
    {
    }

    [Token(Token = "0x6009992")]
    [Address(RVA = "0x5DCD80", Offset = "0x5DBB80", VA = "0x105DCD80")]
    private void SetPossessionCoinParam()
    {
    }

    [Token(Token = "0x6009993")]
    [Address(RVA = "0x5DCA90", Offset = "0x5DB890", VA = "0x105DCA90")]
    private bool SetCrystalWebHelp(List<EventShopItem> _list) => new bool();

    [Token(Token = "0x6009994")]
    [Address(RVA = "0x5DBF00", Offset = "0x5DAD00", VA = "0x105DBF00", Slot = "5")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x6009995")]
    [Address(RVA = "0x5DD860", Offset = "0x5DC660", VA = "0x105DD860")]
    public EventShopBuyWindow()
    {
    }
  }
}
