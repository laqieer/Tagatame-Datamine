// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRaidTraining
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016EC")]
  [FlowNode.NodeType("GuildRaid/Req/GuildRaidTraining", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqGuildRaidTraining : FlowNode_Network
  {
    [Token(Token = "0x40052D4")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40052D5")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005D8E")]
    [Address(RVA = "0x1321150", Offset = "0x131FF50", VA = "0x11321150", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D8F")]
    [Address(RVA = "0x13217D0", Offset = "0x13205D0", VA = "0x113217D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005D90")]
    [Address(RVA = "0x1321330", Offset = "0x1320130", VA = "0x11321330", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005D91")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRaidTraining()
    {
    }

    [Token(Token = "0x20016ED")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40052D6")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildRaidTraining.Response body;

      [Token(Token = "0x6005D92")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
