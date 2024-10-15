// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAdventureCancel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012DB")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(208, "AdventureEnd", FlowNode.PinTypes.Output, 208)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(209, "AdventureNotStart", FlowNode.PinTypes.Output, 209)]
  [FlowNode.NodeType("Adventure/Req/AdventureCancel", 32741)]
  public class FlowNode_ReqAdventureCancel : FlowNode_Network
  {
    [Token(Token = "0x400463E")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400463F")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4004640")]
    protected const int PIN_OUT_ADVENTURE_END = 208;
    [Token(Token = "0x4004641")]
    protected const int PIN_OUT_ADVENTURE_NOT_START = 209;

    [Token(Token = "0x6004FD4")]
    [Address(RVA = "0x124ADA0", Offset = "0x1249BA0", VA = "0x1124ADA0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6004FD5")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6004FD6")]
    [Address(RVA = "0x124AF00", Offset = "0x1249D00", VA = "0x1124AF00", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6004FD7")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAdventureCancel()
    {
    }

    [Token(Token = "0x20012DC")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004642")]
      [FieldOffset(Offset = "0x28")]
      public ReqAdventureCancel.Response body;

      [Token(Token = "0x6004FDA")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
