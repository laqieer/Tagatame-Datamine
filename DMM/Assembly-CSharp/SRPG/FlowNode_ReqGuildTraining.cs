// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildTraining
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016AD")]
  [FlowNode.NodeType("Guild/Training/GuildTrainingGet", 32741)]
  [FlowNode.Pin(101, "通信成功", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqGuildTraining : FlowNode_Network
  {
    [Token(Token = "0x4005257")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005258")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005CE3")]
    [Address(RVA = "0x130D8D0", Offset = "0x130C6D0", VA = "0x1130D8D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CE4")]
    [Address(RVA = "0x130DE40", Offset = "0x130CC40", VA = "0x1130DE40")]
    private void Success()
    {
    }

    [Token(Token = "0x6005CE5")]
    [Address(RVA = "0x130D9A0", Offset = "0x130C7A0", VA = "0x1130D9A0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005CE6")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildTraining()
    {
    }

    [Token(Token = "0x20016AE")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005259")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildTraining.Response body;

      [Token(Token = "0x6005CE7")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
