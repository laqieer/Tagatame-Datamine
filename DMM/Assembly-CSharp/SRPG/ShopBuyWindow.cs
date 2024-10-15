// Decompiled with JetBrains decompiler
// Type: SRPG.ShopBuyWindow
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
  [Token(Token = "0x2002A95")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Refresh完了", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(100, "アイテム選択単品", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "アイテム選択セット", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "アイテム更新", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "武具選択単品", FlowNode.PinTypes.Output, 103)]
  [AddComponentMenu("UI/ShopBuyWindow")]
  public class ShopBuyWindow : MonoBehaviour, IFlowInterface, IWebHelp
  {
    [Token(Token = "0x400CF84")]
    [FieldOffset(Offset = "0xC")]
    public RectTransform ItemLayoutParent;
    [Token(Token = "0x400CF85")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400CF86")]
    [FieldOffset(Offset = "0x14")]
    public Button BtnUpdated;
    [Token(Token = "0x400CF87")]
    [FieldOffset(Offset = "0x18")]
    public Text TxtTitle;
    [Token(Token = "0x400CF88")]
    [FieldOffset(Offset = "0x1C")]
    public Text TxtUpdateTime;
    [Token(Token = "0x400CF89")]
    [FieldOffset(Offset = "0x20")]
    public Text TxtUpdated;
    [Token(Token = "0x400CF8A")]
    [FieldOffset(Offset = "0x24")]
    public GameObject Updated;
    [Token(Token = "0x400CF8B")]
    [FieldOffset(Offset = "0x28")]
    public GameObject Update;
    [Token(Token = "0x400CF8C")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject TitleObj;
    [Token(Token = "0x400CF8D")]
    [FieldOffset(Offset = "0x30")]
    public List<GameObject> mBuyItems;
    [Token(Token = "0x400CF8E")]
    [FieldOffset(Offset = "0x34")]
    public GameObject Lineup;
    [Token(Token = "0x400CF8F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject CrystalHelpButton;
    [Token(Token = "0x400CF90")]
    [FieldOffset(Offset = "0x3C")]
    public string FIXURL;
    [Token(Token = "0x400CF91")]
    [FieldOffset(Offset = "0x40")]
    private string crystalWebID;

    [Token(Token = "0x600C277")]
    [Address(RVA = "0x8AAFB0", Offset = "0x8A9DB0", VA = "0x108AAFB0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C278")]
    [Address(RVA = "0x8AAF90", Offset = "0x8A9D90", VA = "0x108AAF90", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C279")]
    [Address(RVA = "0x8AB510", Offset = "0x8AA310", VA = "0x108AB510")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C27A")]
    [Address(RVA = "0x8AB350", Offset = "0x8AA150", VA = "0x108AB350")]
    private void OnSelect(GameObject go)
    {
    }

    [Token(Token = "0x600C27B")]
    [Address(RVA = "0x517F80", Offset = "0x516D80", VA = "0x10517F80")]
    private void OnItemUpdated()
    {
    }

    [Token(Token = "0x600C27C")]
    [Address(RVA = "0x8ABD90", Offset = "0x8AAB90", VA = "0x108ABD90")]
    private bool SetCrystalWebHelp(List<ShopItem> _list) => new bool();

    [Token(Token = "0x600C27D")]
    [Address(RVA = "0x8AB2A0", Offset = "0x8AA0A0", VA = "0x108AB2A0", Slot = "5")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x600C27E")]
    [Address(RVA = "0x8AC0E0", Offset = "0x8AAEE0", VA = "0x108AC0E0")]
    public ShopBuyWindow()
    {
    }
  }
}
