// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildTrainingAdd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016B0")]
  [FlowNode.NodeType("Guild/Training/GuildTrainingAdd", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "通信成功", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqGuildTrainingAdd : FlowNode_Network
  {
    [Token(Token = "0x400525C")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400525D")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005CEB")]
    [Address(RVA = "0x130C380", Offset = "0x130B180", VA = "0x1130C380", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CEC")]
    [Address(RVA = "0x130C9A0", Offset = "0x130B7A0", VA = "0x1130C9A0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005CED")]
    [Address(RVA = "0x130C4E0", Offset = "0x130B2E0", VA = "0x1130C4E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005CEE")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildTrainingAdd()
    {
    }

    [Token(Token = "0x20016B1")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400525E")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildTrainingEnergyAdd.Response body;

      [Token(Token = "0x6005CEF")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
