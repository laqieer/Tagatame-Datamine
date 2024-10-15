// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqWorldRaidReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018B5")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("WorldRaid/Req/WorldRaidReward", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqWorldRaidReward : FlowNode_Network
  {
    [Token(Token = "0x400589B")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400589C")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6006357")]
    [Address(RVA = "0x314D10", Offset = "0x313B10", VA = "0x10314D10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006358")]
    [Address(RVA = "0x314FB0", Offset = "0x313DB0", VA = "0x10314FB0")]
    private void Success()
    {
    }

    [Token(Token = "0x6006359")]
    [Address(RVA = "0x314DD0", Offset = "0x313BD0", VA = "0x10314DD0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600635A")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqWorldRaidReward()
    {
    }

    [Token(Token = "0x20018B6")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400589D")]
      [FieldOffset(Offset = "0x28")]
      public ReqWorldRaidReward.Response body;

      [Token(Token = "0x600635B")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
