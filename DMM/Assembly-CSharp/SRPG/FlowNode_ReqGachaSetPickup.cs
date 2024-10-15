// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGachaSetPickup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200167C")]
  [AddComponentMenu("")]
  [FlowNode.Pin(14, "CanNotChangePickups", FlowNode.PinTypes.Output, 14)]
  [FlowNode.Pin(13, "IncorrectPickups", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(12, "NotPickupSelect", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("System/Gacha/Pickup/Set", 32741)]
  [FlowNode.Pin(11, "NoGacha", FlowNode.PinTypes.Output, 11)]
  public class FlowNode_ReqGachaSetPickup : FlowNode_Network
  {
    [Token(Token = "0x40051CB")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40051CC")]
    private const int PIN_OUT_SUCCESS = 10;
    [Token(Token = "0x40051CD")]
    private const int PIN_OUT_NOGACHA = 11;
    [Token(Token = "0x40051CE")]
    private const int PIN_OUT_NOT_PICKUP_SELECT = 12;
    [Token(Token = "0x40051CF")]
    private const int PIN_OUT_INCORRECT_PICKUPS = 13;
    [Token(Token = "0x40051D0")]
    private const int PIN_OUT_CANNOT_CHANGE_PICKUPS = 14;

    [Token(Token = "0x6005C4D")]
    [Address(RVA = "0x130A340", Offset = "0x1309140", VA = "0x1130A340", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C4E")]
    [Address(RVA = "0x1309FC0", Offset = "0x1308DC0", VA = "0x11309FC0")]
    public ReqGachaSetPickup.RequestParam CreateRequest() => (ReqGachaSetPickup.RequestParam) null;

    [Token(Token = "0x6005C4F")]
    [Address(RVA = "0x1292FD0", Offset = "0x1291DD0", VA = "0x11292FD0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005C50")]
    [Address(RVA = "0x130A420", Offset = "0x1309220", VA = "0x1130A420", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005C51")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGachaSetPickup()
    {
    }
  }
}
