// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRuneReplace
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001851")]
  [FlowNode.NodeType("Rune/Req/Replace", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqRuneReplace : FlowNode_Network
  {
    [Token(Token = "0x4005742")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005743")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6006227")]
    [Address(RVA = "0x1369EA0", Offset = "0x1368CA0", VA = "0x11369EA0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6006228")]
    [Address(RVA = "0x136A3A0", Offset = "0x13691A0", VA = "0x1136A3A0")]
    private void Success()
    {
    }

    [Token(Token = "0x6006229")]
    [Address(RVA = "0x1369FF0", Offset = "0x1368DF0", VA = "0x11369FF0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600622A")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRuneReplace()
    {
    }

    [Token(Token = "0x2001852")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005744")]
      [FieldOffset(Offset = "0x28")]
      public ReqRuneReplace.Response body;

      [Token(Token = "0x600622B")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
