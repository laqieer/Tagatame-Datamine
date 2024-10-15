// Decompiled with JetBrains decompiler
// Type: SRPG.EventShopList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002393")]
  [FlowNode.Pin(103, "アリーナショップが選択された", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(104, "マルチショップが選択された", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(101, "更新あり：イベントショップが選択された", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "更新なし：イベントショップが選択された", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(0, "指定イベントショップの商品を開く", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(105, "ユニット欠片ショップが選択された", FlowNode.PinTypes.Output, 105)]
  [FlowNode.Pin(1, "所持コイン更新", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/EventShopList")]
  public class EventShopList : BaseShopList
  {
    [Token(Token = "0x400A05E")]
    private const int PIN_INPUT_OPEN_EVENT_SHOP = 0;
    [Token(Token = "0x400A05F")]
    private const int PIN_INPUT_UPDATE_COIN = 1;
    [Token(Token = "0x400A060")]
    private const int PIN_OUTPUT_SELECTED_EVENT_SHOP_WITH_UPDATE = 101;
    [Token(Token = "0x400A061")]
    private const int PIN_OUTPUT_SELECTED_EVENT_SHOP = 102;
    [Token(Token = "0x400A062")]
    private const int PIN_OUTPUT_SELECTED_ARENA_SHOP = 103;
    [Token(Token = "0x400A063")]
    private const int PIN_OUTPUT_SELECTED_MULTI_SHOP = 104;
    [Token(Token = "0x400A064")]
    private const int PIN_OUTPUT_SELECTED_UNIT_PIECE_SHOP = 105;
    [Token(Token = "0x400A065")]
    private const string UNIT_PIECE_SHOP_GNAME = "unitpiece";
    [Token(Token = "0x400A066")]
    [FieldOffset(Offset = "0x38")]
    [Header("MultiShopItemに設定していたマルチコインのスプライトを設定")]
    public Sprite MultiCoinIconSprite;
    [Token(Token = "0x400A067")]
    [FieldOffset(Offset = "0x3C")]
    [Header("マルチコイン交換所のバナーのスプライトを設定")]
    public Sprite MultiShopBannerSprite;
    [Token(Token = "0x400A068")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string[] HIDE_TIME_LIMIT_SHOP_NAMES;

    [Token(Token = "0x60099C6")]
    [Address(RVA = "0x5E1A70", Offset = "0x5E0870", VA = "0x105E1A70", Slot = "10")]
    protected override void DerivedActivated(int pinID)
    {
    }

    [Token(Token = "0x60099C7")]
    [Address(RVA = "0x5E1C20", Offset = "0x5E0A20", VA = "0x105E1C20")]
    public void DestroyItems()
    {
    }

    [Token(Token = "0x60099C8")]
    [Address(RVA = "0x5E2130", Offset = "0x5E0F30", VA = "0x105E2130")]
    private void ResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x60099C9")]
    [Address(RVA = "0x5E2000", Offset = "0x5E0E00", VA = "0x105E2000")]
    public static Json_ShopMsgResponse ParseMsg(JSON_ShopListArray.Shops shops)
    {
      return (Json_ShopMsgResponse) null;
    }

    [Token(Token = "0x60099CA")]
    [Address(RVA = "0x5E1980", Offset = "0x5E0780", VA = "0x105E1980")]
    public void AddMultiShopList()
    {
    }

    [Token(Token = "0x60099CB")]
    [Address(RVA = "0x5E1980", Offset = "0x5E0780", VA = "0x105E1980")]
    public void CreateMultiShopModel()
    {
    }

    [Token(Token = "0x60099CC")]
    [Address(RVA = "0x5E1CA0", Offset = "0x5E0AA0", VA = "0x105E1CA0", Slot = "13")]
    protected override long GetEndTime(JSON_ShopListArray.Shops shops) => new long();

    [Token(Token = "0x60099CD")]
    [Address(RVA = "0x5E1E60", Offset = "0x5E0C60", VA = "0x105E1E60", Slot = "16")]
    protected override void OnSelectItem(ShopListItemModel model)
    {
    }

    [Token(Token = "0x60099CE")]
    [Address(RVA = "0x5E1D40", Offset = "0x5E0B40", VA = "0x105E1D40")]
    private void OnSelectEventItem(ShopListItemModel model)
    {
    }

    [Token(Token = "0x60099CF")]
    [Address(RVA = "0x5E23C0", Offset = "0x5E11C0", VA = "0x105E23C0")]
    public EventShopList()
    {
    }

    [Token(Token = "0x2002394")]
    private class JSON_CoinNum
    {
      [Token(Token = "0x400A069")]
      [FieldOffset(Offset = "0x8")]
      public Json_Item[] item;
      [Token(Token = "0x400A06A")]
      [FieldOffset(Offset = "0xC")]
      public EventShopList.JSON_NewCoin newcoin;

      [Token(Token = "0x60099D0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_CoinNum()
      {
      }
    }

    [Token(Token = "0x2002395")]
    private class JSON_NewCoin
    {
      [Token(Token = "0x400A06B")]
      [FieldOffset(Offset = "0x8")]
      public long period;

      [Token(Token = "0x60099D1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_NewCoin()
      {
      }
    }
  }
}
