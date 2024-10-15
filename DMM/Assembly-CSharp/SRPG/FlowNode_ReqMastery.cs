// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqMastery
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200176E")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("DoorMastery/Req/Mastery", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqMastery : FlowNode_Network
  {
    [Token(Token = "0x4005429")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400542A")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005F0F")]
    [Address(RVA = "0x1343D10", Offset = "0x1342B10", VA = "0x11343D10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F10")]
    [Address(RVA = "0x1344170", Offset = "0x1342F70", VA = "0x11344170")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F11")]
    [Address(RVA = "0x1343DE0", Offset = "0x1342BE0", VA = "0x11343DE0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F12")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqMastery()
    {
    }

    [Token(Token = "0x200176F")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400542B")]
      [FieldOffset(Offset = "0x28")]
      public ReqMastery.Response body;

      [Token(Token = "0x6005F13")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
