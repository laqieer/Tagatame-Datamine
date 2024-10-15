// Decompiled with JetBrains decompiler
// Type: SRPG.ShopListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A8A")]
  public class ShopListView : MonoBehaviour
  {
    [Token(Token = "0x400CEF9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ContentExhibit contentExhibit;
    [Token(Token = "0x400CEFA")]
    [FieldOffset(Offset = "0x10")]
    private List<ShopListItemModel> modelList;
    [Token(Token = "0x400CEFB")]
    [FieldOffset(Offset = "0x14")]
    private Action<ShopListItemModel> onSelectCallback;
    [Token(Token = "0x400CEFC")]
    [FieldOffset(Offset = "0x18")]
    private Action switchChildrenListCallback;
    [Token(Token = "0x400CEFD")]
    [FieldOffset(Offset = "0x1C")]
    private ShopListView.ViewState currentViewState;
    [Token(Token = "0x400CEFE")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<string, List<ShopListItemModel>> childrenBanners;
    [Token(Token = "0x400CEFF")]
    [FieldOffset(Offset = "0x24")]
    private List<ShopListItemModel> banners;
    [Token(Token = "0x400CF00")]
    [FieldOffset(Offset = "0x28")]
    private List<ShopListItemModel> currentList;
    [Token(Token = "0x400CF01")]
    [FieldOffset(Offset = "0x2C")]
    private Vector2 parentAnchoredPos;

    [Token(Token = "0x600C23D")]
    [Address(RVA = "0x8B0910", Offset = "0x8AF710", VA = "0x108B0910")]
    public void SetList(
      List<ShopListItemModel> modelList,
      Action<ShopListItemModel> onSelectCallback,
      Action switchChildrenListCallback)
    {
    }

    [Token(Token = "0x600C23E")]
    [Address(RVA = "0x8B0280", Offset = "0x8AF080", VA = "0x108B0280")]
    private void DistinctBanners()
    {
    }

    [Token(Token = "0x600C23F")]
    [Address(RVA = "0x8B0890", Offset = "0x8AF690", VA = "0x108B0890")]
    private void OnSelectItem(ShopListItemModel model)
    {
    }

    [Token(Token = "0x600C240")]
    [Address(RVA = "0x8B0970", Offset = "0x8AF770", VA = "0x108B0970")]
    public void SwitchBannerList(string parentBannerId = "")
    {
    }

    [Token(Token = "0x600C241")]
    [Address(RVA = "0x8B0900", Offset = "0x8AF700", VA = "0x108B0900")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C242")]
    [Address(RVA = "0x8B01F0", Offset = "0x8AEFF0", VA = "0x108B01F0")]
    private void CreateNodes()
    {
    }

    [Token(Token = "0x600C243")]
    [Address(RVA = "0x8B07A0", Offset = "0x8AF5A0", VA = "0x108B07A0")]
    private void OnAttach(ContentNode node, ShopListItemModel model)
    {
    }

    [Token(Token = "0x600C244")]
    [Address(RVA = "0x8B0B20", Offset = "0x8AF920", VA = "0x108B0B20")]
    public ShopListView()
    {
    }

    [Token(Token = "0x2002A8B")]
    public enum ViewState
    {
      [Token(Token = "0x400CF03")] ParentList,
      [Token(Token = "0x400CF04")] ChildrenList,
    }
  }
}
