// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqDuelEnemy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200134E")]
  [FlowNode.NodeType("Duel/Req/DuelEnemy", 32741)]
  [FlowNode.Pin(10, "Request", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(110, "ホームに戻すべきエラー", FlowNode.PinTypes.Output, 110)]
  [AddComponentMenu("")]
  public class FlowNode_ReqDuelEnemy : FlowNode_Network
  {
    [Token(Token = "0x4004774")]
    private const int PIN_INPUT_REQUEST = 10;
    [Token(Token = "0x4004775")]
    private const int PIN_OUTPUT_SUCCESS = 100;
    [Token(Token = "0x4004776")]
    private const int PIN_OUTPUT_ERROR_GO_HOME = 110;

    [Token(Token = "0x6005124")]
    [Address(RVA = "0x125FBC0", Offset = "0x125E9C0", VA = "0x1125FBC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005125")]
    [Address(RVA = "0x125FC90", Offset = "0x125EA90", VA = "0x1125FC90", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005126")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqDuelEnemy()
    {
    }

    [Token(Token = "0x200134F")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004777")]
      [FieldOffset(Offset = "0x28")]
      public ReqDuelEnemy.Response body;

      [Token(Token = "0x6005128")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
