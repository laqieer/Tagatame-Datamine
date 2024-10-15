// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_EventBuyItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013D3")]
  [FlowNode.Pin(111, "カケラポイント不足", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(122, "ショップラインナップが更新された", FlowNode.PinTypes.Output, 27)]
  [FlowNode.Pin(121, "ショップ期間外", FlowNode.PinTypes.Output, 26)]
  [FlowNode.Pin(120, "購入期間外", FlowNode.PinTypes.Output, 25)]
  [FlowNode.Pin(114, "イベントコイン不足", FlowNode.PinTypes.Output, 24)]
  [FlowNode.Pin(113, "有償石不足", FlowNode.PinTypes.Output, 23)]
  [FlowNode.Pin(112, "マルチコイン不足", FlowNode.PinTypes.Output, 22)]
  [FlowNode.Pin(110, "アリーナコイン不足", FlowNode.PinTypes.Output, 20)]
  [AddComponentMenu("")]
  [FlowNode.Pin(108, "課金コイン不足", FlowNode.PinTypes.Output, 18)]
  [FlowNode.Pin(107, "ゴールド不足", FlowNode.PinTypes.Output, 17)]
  [FlowNode.Pin(106, "アイテム所持上限", FlowNode.PinTypes.Output, 16)]
  [FlowNode.Pin(105, "購入済み", FlowNode.PinTypes.Output, 15)]
  [FlowNode.Pin(104, "ショップ情報がない", FlowNode.PinTypes.Output, 14)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/Shop/EventBuyItem", 32741)]
  [FlowNode.Pin(109, "遠征コイン不足", FlowNode.PinTypes.Output, 19)]
  public class FlowNode_EventBuyItem : FlowNode_Network
  {
    [Token(Token = "0x400495F")]
    [FieldOffset(Offset = "0x20")]
    private EShopType mShopType;
    [Token(Token = "0x4004960")]
    private const int PIN_OUTPUT_REQ_SUCCESS = 100;
    [Token(Token = "0x4004961")]
    private const int PIN_OUTPUT_SHOP_INFO_NULL = 104;
    [Token(Token = "0x4004962")]
    private const int PIN_OUTPUT_PURCHASED = 105;
    [Token(Token = "0x4004963")]
    private const int PIN_OUTPUT_HAVE_MAX = 106;
    [Token(Token = "0x4004964")]
    private const int PIN_OUTPUT_SHORTAGE_GOLD = 107;
    [Token(Token = "0x4004965")]
    private const int PIN_OUTPUT_SHORTAGE_COIN = 108;
    [Token(Token = "0x4004966")]
    private const int PIN_OUTPUT_SHORTAGE_TOUR_COIN = 109;
    [Token(Token = "0x4004967")]
    private const int PIN_OUTPUT_SHORTAGE_ARENA_COIN = 110;
    [Token(Token = "0x4004968")]
    private const int PIN_OUTPUT_SHORTAGE_PIECE_POINT = 111;
    [Token(Token = "0x4004969")]
    private const int PIN_OUTPUT_SHORTAGE_MULTI_COIN = 112;
    [Token(Token = "0x400496A")]
    private const int PIN_OUTPUT_SHORTAGE_PAID_COIN = 113;
    [Token(Token = "0x400496B")]
    private const int PIN_OUTPUT_SHORTAGE_EVENT_COIN = 114;
    [Token(Token = "0x400496C")]
    private const int PIN_OT_SHOP_BUY_OUTOF_ITEM_PERIOD = 120;
    [Token(Token = "0x400496D")]
    private const int PIN_OT_SHOP_REFRESH_ITEM_LIST = 121;
    [Token(Token = "0x400496E")]
    private const int PIN_OT_SHOP_BUY_OUTOF_PERIOD = 122;

    [Token(Token = "0x60052F7")]
    [Address(RVA = "0x127AE20", Offset = "0x1279C20", VA = "0x1127AE20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60052F8")]
    [Address(RVA = "0x1256AB0", Offset = "0x12558B0", VA = "0x11256AB0")]
    private void Success()
    {
    }

    [Token(Token = "0x60052F9")]
    [Address(RVA = "0x127B5F0", Offset = "0x127A3F0", VA = "0x1127B5F0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60052FA")]
    [Address(RVA = "0x12690A0", Offset = "0x1267EA0", VA = "0x112690A0")]
    public bool CheckCanBuy(EventShopItem shopitem, int buy, int check, int pin) => new bool();

    [Token(Token = "0x60052FB")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_EventBuyItem()
    {
    }
  }
}
