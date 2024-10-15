// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildTrainingSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016B6")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Guild/Training/GuildTrainingSet", 32741)]
  [FlowNode.Pin(101, "通信成功", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqGuildTrainingSet : FlowNode_Network
  {
    [Token(Token = "0x4005266")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005267")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005CFB")]
    [Address(RVA = "0x130CFF0", Offset = "0x130BDF0", VA = "0x1130CFF0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CFC")]
    [Address(RVA = "0x130D860", Offset = "0x130C660", VA = "0x1130D860")]
    private void Success()
    {
    }

    [Token(Token = "0x6005CFD")]
    [Address(RVA = "0x130D2F0", Offset = "0x130C0F0", VA = "0x1130D2F0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005CFE")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildTrainingSet()
    {
    }

    [Token(Token = "0x20016B7")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005268")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildTrainingSet.Response body;

      [Token(Token = "0x6005D00")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
