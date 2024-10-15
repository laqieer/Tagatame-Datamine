// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_BuyItemUpdate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001373")]
  [AddComponentMenu("")]
  [FlowNode.Pin(131, "ポートショップ：ギルド未所属", FlowNode.PinTypes.Output, 131)]
  [FlowNode.Pin(109, "イベントコイン不足", FlowNode.PinTypes.Output, 19)]
  [FlowNode.Pin(107, "欠片ポイント不足", FlowNode.PinTypes.Output, 17)]
  [FlowNode.Pin(106, "アリーナコイン不足", FlowNode.PinTypes.Output, 16)]
  [FlowNode.Pin(108, "マルチコイン不足", FlowNode.PinTypes.Output, 18)]
  [FlowNode.Pin(104, "課金コイン不足", FlowNode.PinTypes.Output, 14)]
  [FlowNode.Pin(103, "ゴールド不足", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(101, "ショップ情報が存在しない", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(105, "遠征コイン不足", FlowNode.PinTypes.Output, 15)]
  [FlowNode.NodeType("System/Buy/BuyItemUpdate", 32741)]
  public class FlowNode_BuyItemUpdate : FlowNode_Network
  {
    [Token(Token = "0x40047D3")]
    private const int PIN_OUT_PORTSHOP_GUILD_NOTJOINED = 131;
    [Token(Token = "0x40047D4")]
    [FieldOffset(Offset = "0x20")]
    private EShopType mShopType;

    [Token(Token = "0x600519D")]
    [Address(RVA = "0x1268480", Offset = "0x1267280", VA = "0x11268480", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600519E")]
    [Address(RVA = "0x1256AB0", Offset = "0x12558B0", VA = "0x11256AB0")]
    private void Success()
    {
    }

    [Token(Token = "0x600519F")]
    [Address(RVA = "0x1268A30", Offset = "0x1267830", VA = "0x11268A30", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60051A0")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_BuyItemUpdate()
    {
    }
  }
}
