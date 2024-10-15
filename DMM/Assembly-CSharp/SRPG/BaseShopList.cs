// Decompiled with JetBrains decompiler
// Type: SRPG.BaseShopList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A84")]
  [FlowNode.Pin(20000, "子バナー一覧を表示する", FlowNode.PinTypes.Output, 20000)]
  [FlowNode.Pin(10000, "子バナー一覧から親バナー一覧に戻る", FlowNode.PinTypes.Input, 10000)]
  public class BaseShopList : SRPG_ListBase, IFlowInterface
  {
    [Token(Token = "0x400CEE7")]
    private const int PIN_INPUT_BACK_TO_PARENT_BANNER_LIST = 10000;
    [Token(Token = "0x400CEE8")]
    private const int PIN_OUTPUT_TO_CHILDREN_LIST = 20000;
    [Token(Token = "0x400CEE9")]
    [FieldOffset(Offset = "0x20")]
    [Header("ショップバナーが登録されているSpriteSheet名")]
    public string SpritePath;
    [Token(Token = "0x400CEEA")]
    [FieldOffset(Offset = "0x24")]
    [Header("ショップ種別")]
    public EShopType ShopType;
    [Token(Token = "0x400CEEB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    protected ShopListView shopListView;
    [Token(Token = "0x400CEEC")]
    [FieldOffset(Offset = "0x2C")]
    private Sprite[] sprites;
    [Token(Token = "0x400CEED")]
    [FieldOffset(Offset = "0x30")]
    protected List<ShopListItemModel> modelList;
    [Token(Token = "0x400CEEE")]
    [FieldOffset(Offset = "0x34")]
    private List<ShopListData> _shoplist;

    [Token(Token = "0x600C21F")]
    [Address(RVA = "0x8A5630", Offset = "0x8A4430", VA = "0x108A5630", Slot = "9")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C220")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "10")]
    protected virtual void DerivedActivated(int pinID)
    {
    }

    [Token(Token = "0x600C221")]
    [Address(RVA = "0x8A5C40", Offset = "0x8A4A40", VA = "0x108A5C40")]
    public void ResetModelList()
    {
    }

    [Token(Token = "0x600C222")]
    [Address(RVA = "0x8A6300", Offset = "0x8A5100", VA = "0x108A6300")]
    private void SwitchChildrenList()
    {
    }

    [Token(Token = "0x600C223")]
    [Address(RVA = "0x8A6240", Offset = "0x8A5040", VA = "0x108A6240", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600C224")]
    [Address(RVA = "0x8A5B80", Offset = "0x8A4980", VA = "0x108A5B80")]
    private void LoadTabSprites()
    {
    }

    [Token(Token = "0x600C225")]
    [Address(RVA = "0x8A6020", Offset = "0x8A4E20", VA = "0x108A6020", Slot = "11")]
    public virtual void SetShopList(JSON_ShopListArray.Shops[] shops, bool isCheckAlwaysView = false)
    {
    }

    [Token(Token = "0x600C226")]
    [Address(RVA = "0x8A6130", Offset = "0x8A4F30", VA = "0x108A6130", Slot = "12")]
    public virtual void SetShopList(JSON_ShopListArray.Banners[] banners, bool isCheckAlwaysView = false)
    {
    }

    [Token(Token = "0x600C227")]
    [Address(RVA = "0x8A5AA0", Offset = "0x8A48A0", VA = "0x108A5AA0", Slot = "13")]
    protected virtual long GetEndTime(JSON_ShopListArray.Shops shops) => new long();

    [Token(Token = "0x600C228")]
    [Address(RVA = "0x8A56A0", Offset = "0x8A44A0", VA = "0x108A56A0", Slot = "14")]
    protected virtual void CreateModels()
    {
    }

    [Token(Token = "0x600C229")]
    [Address(RVA = "0x8A5CA0", Offset = "0x8A4AA0", VA = "0x108A5CA0")]
    private void SetParentModel(ShopListItemModel.Param param, ShopListData shopListData)
    {
    }

    [Token(Token = "0x600C22A")]
    [Address(RVA = "0x8A57D0", Offset = "0x8A45D0", VA = "0x108A57D0", Slot = "15")]
    protected virtual ShopListItemModel CreateShopModel(
      ShopListItemModel.Param _param,
      JSON_ShopListArray.Shops _shopInfo,
      bool isChildren = false)
    {
      return (ShopListItemModel) null;
    }

    [Token(Token = "0x600C22B")]
    [Address(RVA = "0x8A5990", Offset = "0x8A4790", VA = "0x108A5990")]
    public void DrawList()
    {
    }

    [Token(Token = "0x600C22C")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "16")]
    protected virtual void OnSelectItem(ShopListItemModel model)
    {
    }

    [Token(Token = "0x600C22D")]
    [Address(RVA = "0x8A5AC0", Offset = "0x8A48C0", VA = "0x108A5AC0")]
    protected Sprite GetSprite(string spriteName) => (Sprite) null;

    [Token(Token = "0x600C22E")]
    [Address(RVA = "0x8A6320", Offset = "0x8A5120", VA = "0x108A6320")]
    public BaseShopList()
    {
    }
  }
}
