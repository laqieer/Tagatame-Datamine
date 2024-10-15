// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqSupportUsed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200159E")]
  [FlowNode.NodeType("System/Player/SupportUsed", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqSupportUsed : FlowNode_Network
  {
    [Token(Token = "0x4004E93")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004E94")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005914")]
    [Address(RVA = "0x12DED40", Offset = "0x12DDB40", VA = "0x112DED40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005915")]
    [Address(RVA = "0x12DF180", Offset = "0x12DDF80", VA = "0x112DF180")]
    private void Success()
    {
    }

    [Token(Token = "0x6005916")]
    [Address(RVA = "0x12DEE10", Offset = "0x12DDC10", VA = "0x112DEE10", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005917")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqSupportUsed()
    {
    }

    [Token(Token = "0x200159F")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004E95")]
      [FieldOffset(Offset = "0x28")]
      public ReqSetSupportUsed.Response body;

      [Token(Token = "0x6005918")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
