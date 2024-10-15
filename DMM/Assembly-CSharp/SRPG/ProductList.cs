// Decompiled with JetBrains decompiler
// Type: SRPG.ProductList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002851")]
  [FlowNode.Pin(200, "販売終了", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(0, "表示", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "選択された", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("Payment/ProductList")]
  public class ProductList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C074")]
    [FieldOffset(Offset = "0xC")]
    [Description("リストアイテムとして使用するゲームオブジェクト")]
    public PurchaseListItem ItemTemplate;
    [Token(Token = "0x400C075")]
    [FieldOffset(Offset = "0x10")]
    [Description("リスト限定アイテムとして使用するゲームオブジェクト")]
    public PurchaseListItem ItemLimitedTemplate;
    [Token(Token = "0x400C076")]
    [FieldOffset(Offset = "0x14")]
    [Description("詳細画面として使用するゲームオブジェクト")]
    public GameObject DetailTemplate;
    [Token(Token = "0x400C077")]
    [FieldOffset(Offset = "0x18")]
    [Description("リストアイテム(VIP)として使用するゲームオブジェクト")]
    public PurchaseListItem ItemVipTemplate;
    [Token(Token = "0x400C078")]
    [FieldOffset(Offset = "0x1C")]
    [Description("リストアイテム(PREMIUM)として使用するゲームオブジェクト")]
    public PurchaseListItem ItemPremiumTemplate;
    [Token(Token = "0x400C079")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Description("リストアイテム(機能売り)として使用するゲームオブジェクト")]
    private PurchaseListItem ItemExpansionTemplate;
    [Token(Token = "0x400C07A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    [Description("ステップアップとして使用するゲームオブジェクト")]
    public GameObject ItemStepUpTemplate;
    [Token(Token = "0x400C07B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ScrollRect ScrollRect;
    [Token(Token = "0x400C07C")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private ProductList.TemplateItem[] mTemplateItems;
    [Token(Token = "0x400C07D")]
    [FieldOffset(Offset = "0x30")]
    private GameObject mDetailInfo;
    [Token(Token = "0x400C07E")]
    [FieldOffset(Offset = "0x34")]
    private List<PurchaseListItem> mParchaseListItem;
    [Token(Token = "0x400C07F")]
    [FieldOffset(Offset = "0x38")]
    private List<int> coinNumList;

    [Token(Token = "0x600B5FE")]
    [Address(RVA = "0x7C64B0", Offset = "0x7C52B0", VA = "0x107C64B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B5FF")]
    [Address(RVA = "0x7C7D50", Offset = "0x7C6B50", VA = "0x107C7D50")]
    private void Start()
    {
    }

    [Token(Token = "0x600B600")]
    [Address(RVA = "0x7C75C0", Offset = "0x7C63C0", VA = "0x107C75C0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600B601")]
    [Address(RVA = "0x7C6A30", Offset = "0x7C5830", VA = "0x107C6A30")]
    private void RefreshItems(bool is_start)
    {
    }

    [Token(Token = "0x600B602")]
    [Address(RVA = "0x7C76F0", Offset = "0x7C64F0", VA = "0x107C76F0")]
    private void SortProductItems(
      PurchaseListItem vipItem,
      List<PurchaseListItem> premiumItems,
      List<PurchaseListItem> coinItems)
    {
    }

    [Token(Token = "0x600B603")]
    [Address(RVA = "0x7C6800", Offset = "0x7C5600", VA = "0x107C6800")]
    private void OnSelectItem(GameObject go)
    {
    }

    [Token(Token = "0x600B604")]
    [Address(RVA = "0x7C6660", Offset = "0x7C5460", VA = "0x107C6660")]
    private void OnCloseItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600B605")]
    [Address(RVA = "0x7C6700", Offset = "0x7C5500", VA = "0x107C6700")]
    private void OnOpenItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600B606")]
    [Address(RVA = "0x7C65E0", Offset = "0x7C53E0", VA = "0x107C65E0")]
    private PurchaseListItem FindTemplateItem(string name) => (PurchaseListItem) null;

    [Token(Token = "0x600B607")]
    [Address(RVA = "0x7C7E60", Offset = "0x7C6C60", VA = "0x107C7E60")]
    public ProductList()
    {
    }

    [Token(Token = "0x2002852")]
    [Serializable]
    public struct TemplateItem
    {
      [Token(Token = "0x400C080")]
      [FieldOffset(Offset = "0x0")]
      public string name;
      [Token(Token = "0x400C081")]
      [FieldOffset(Offset = "0x4")]
      public PurchaseListItem obj;
    }
  }
}
