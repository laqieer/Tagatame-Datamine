// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqDuelTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001354")]
  [AddComponentMenu("")]
  [FlowNode.Pin(110, "ホームに戻すべきエラー", FlowNode.PinTypes.Output, 110)]
  [FlowNode.NodeType("Duel/Req/DuelTop", 32741)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(10, "Request", FlowNode.PinTypes.Input, 10)]
  public class FlowNode_ReqDuelTop : FlowNode_Network
  {
    [Token(Token = "0x4004780")]
    private const int PIN_INPUT_REQUEST = 10;
    [Token(Token = "0x4004781")]
    private const int PIN_OUTPUT_SUCCESS = 100;
    [Token(Token = "0x4004782")]
    private const int PIN_OUTPUT_ERROR_GO_HOME = 110;

    [Token(Token = "0x6005133")]
    [Address(RVA = "0x12764F0", Offset = "0x12752F0", VA = "0x112764F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005134")]
    [Address(RVA = "0x12765C0", Offset = "0x12753C0", VA = "0x112765C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005135")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqDuelTop()
    {
    }

    [Token(Token = "0x2001355")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004783")]
      [FieldOffset(Offset = "0x28")]
      public ReqDuelTop.Response body;

      [Token(Token = "0x6005137")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
