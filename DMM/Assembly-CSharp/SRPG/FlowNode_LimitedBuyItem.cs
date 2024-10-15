// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_LimitedBuyItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001418")]
  [FlowNode.Pin(110, "アリーナコイン不足", FlowNode.PinTypes.Output, 20)]
  [FlowNode.NodeType("System/Shop/LimitedBuyItem", 32741)]
  [FlowNode.Pin(111, "カケラポイント不足", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(112, "マルチコイン不足", FlowNode.PinTypes.Output, 22)]
  [FlowNode.Pin(113, "有償石不足", FlowNode.PinTypes.Output, 23)]
  [FlowNode.Pin(114, "イベントコイン不足", FlowNode.PinTypes.Output, 24)]
  [FlowNode.Pin(120, "購入期間外", FlowNode.PinTypes.Output, 25)]
  [FlowNode.Pin(121, "ショップ期間外", FlowNode.PinTypes.Output, 26)]
  [FlowNode.Pin(109, "遠征コイン不足", FlowNode.PinTypes.Output, 19)]
  [FlowNode.Pin(122, "ショップラインナップが更新された", FlowNode.PinTypes.Output, 27)]
  [AddComponentMenu("")]
  [FlowNode.Pin(108, "課金コイン不足", FlowNode.PinTypes.Output, 18)]
  [FlowNode.Pin(107, "ゴールド不足", FlowNode.PinTypes.Output, 17)]
  [FlowNode.Pin(106, "アイテム所持上限", FlowNode.PinTypes.Output, 16)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(131, "ポートショップ：ギルド未所属", FlowNode.PinTypes.Output, 131)]
  [FlowNode.Pin(105, "購入済み", FlowNode.PinTypes.Output, 15)]
  [FlowNode.Pin(104, "ショップ情報がない", FlowNode.PinTypes.Output, 14)]
  public class FlowNode_LimitedBuyItem : FlowNode_Network
  {
    [Token(Token = "0x4004A57")]
    [FieldOffset(Offset = "0x20")]
    private EShopType mShopType;
    [Token(Token = "0x4004A58")]
    private const int PIN_INPUT_REQUEST = 1;
    [Token(Token = "0x4004A59")]
    private const int PIN_OUTPUT_REQ_SUCCESS = 100;
    [Token(Token = "0x4004A5A")]
    private const int PIN_OUTPUT_SHOP_INFO_NULL = 104;
    [Token(Token = "0x4004A5B")]
    private const int PIN_OUTPUT_PURCHASED = 105;
    [Token(Token = "0x4004A5C")]
    private const int PIN_OUTPUT_HAVE_MAX = 106;
    [Token(Token = "0x4004A5D")]
    private const int PIN_OUTPUT_SHORTAGE_GOLD = 107;
    [Token(Token = "0x4004A5E")]
    private const int PIN_OUTPUT_SHORTAGE_COIN = 108;
    [Token(Token = "0x4004A5F")]
    private const int PIN_OUTPUT_SHORTAGE_TOUR_COIN = 109;
    [Token(Token = "0x4004A60")]
    private const int PIN_OUTPUT_SHORTAGE_ARENA_COIN = 110;
    [Token(Token = "0x4004A61")]
    private const int PIN_OUTPUT_SHORTAGE_PIECE_POINT = 111;
    [Token(Token = "0x4004A62")]
    private const int PIN_OUTPUT_SHORTAGE_MULTI_COIN = 112;
    [Token(Token = "0x4004A63")]
    private const int PIN_OUTPUT_SHORTAGE_PAID_COIN = 113;
    [Token(Token = "0x4004A64")]
    private const int PIN_OUTPUT_SHORTAGE_EVENT_COIN = 114;
    [Token(Token = "0x4004A65")]
    private const int PIN_OT_SHOP_BUY_OUTOF_ITEM_PERIOD = 120;
    [Token(Token = "0x4004A66")]
    private const int PIN_OT_SHOP_REFRESH_ITEM_LIST = 121;
    [Token(Token = "0x4004A67")]
    private const int PIN_OT_SHOP_BUY_OUTOF_PERIOD = 122;
    [Token(Token = "0x4004A68")]
    private const int PIN_OUT_PORTSHOP_GUILD_NOTJOINED = 131;

    [Token(Token = "0x60053F0")]
    [Address(RVA = "0x1286A90", Offset = "0x1285890", VA = "0x11286A90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60053F1")]
    [Address(RVA = "0x1256AB0", Offset = "0x12558B0", VA = "0x11256AB0")]
    private void Success()
    {
    }

    [Token(Token = "0x60053F2")]
    [Address(RVA = "0x12871D0", Offset = "0x1285FD0", VA = "0x112871D0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60053F3")]
    [Address(RVA = "0x12690A0", Offset = "0x1267EA0", VA = "0x112690A0")]
    public bool CheckCanBuy(LimitedShopItem shopitem, int buy, int check, int pin) => new bool();

    [Token(Token = "0x60053F4")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_LimitedBuyItem()
    {
    }
  }
}
