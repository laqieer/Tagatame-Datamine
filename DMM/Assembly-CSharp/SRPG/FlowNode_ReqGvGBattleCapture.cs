// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGvGBattleCapture
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001700")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("GvG/Req/GvGBattleCapture", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqGvGBattleCapture : FlowNode_Network
  {
    [Token(Token = "0x4005304")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005305")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005DC9")]
    [Address(RVA = "0x13220B0", Offset = "0x1320EB0", VA = "0x113220B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005DCA")]
    [Address(RVA = "0x1322950", Offset = "0x1321750", VA = "0x11322950")]
    private void Success()
    {
    }

    [Token(Token = "0x6005DCB")]
    [Address(RVA = "0x13222C0", Offset = "0x13210C0", VA = "0x113222C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005DCC")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGvGBattleCapture()
    {
    }

    [Token(Token = "0x2001701")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005306")]
      [FieldOffset(Offset = "0x28")]
      public ReqGvGBattleCapture.Response body;

      [Token(Token = "0x6005DCD")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
