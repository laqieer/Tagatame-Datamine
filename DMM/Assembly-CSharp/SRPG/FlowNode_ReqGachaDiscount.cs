// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGachaDiscount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014F7")]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  [FlowNode.Pin(13, "アイテム召喚の時", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(12, "AlreadyDiscount", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(11, "CanNotDiscount", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/Gacha/Discount", 32741)]
  public class FlowNode_ReqGachaDiscount : FlowNode_Network
  {
    [Token(Token = "0x4004CC3")]
    private const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x4004CC4")]
    private const int PIN_OT_SUCCESS = 10;
    [Token(Token = "0x4004CC5")]
    private const int PIN_OT_CANNOT_DISCOUNT = 11;
    [Token(Token = "0x4004CC6")]
    private const int PIN_OT_ALREADY_DISCOUNT = 12;
    [Token(Token = "0x4004CC7")]
    private const int PIN_OT_ENOUGH_COST_ITEM = 13;

    [Token(Token = "0x6005728")]
    [Address(RVA = "0x12C7E60", Offset = "0x12C6C60", VA = "0x112C7E60", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005729")]
    [Address(RVA = "0x12C8020", Offset = "0x12C6E20", VA = "0x112C8020", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600572A")]
    [Address(RVA = "0x1292FD0", Offset = "0x1291DD0", VA = "0x11292FD0")]
    private void Success()
    {
    }

    [Token(Token = "0x600572B")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGachaDiscount()
    {
    }
  }
}
