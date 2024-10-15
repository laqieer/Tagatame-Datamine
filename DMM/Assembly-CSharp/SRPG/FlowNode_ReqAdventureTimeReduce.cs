// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAdventureTimeReduce
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012E5")]
  [FlowNode.NodeType("Adventure/Req/AdventureTimeReduce", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(208, "AdventureEnd", FlowNode.PinTypes.Output, 208)]
  [AddComponentMenu("")]
  public class FlowNode_ReqAdventureTimeReduce : FlowNode_Network
  {
    [Token(Token = "0x4004658")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004659")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400465A")]
    protected const int PIN_OUT_ADVENTURE_END = 208;

    [Token(Token = "0x6004FF5")]
    [Address(RVA = "0x1251440", Offset = "0x1250240", VA = "0x11251440", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6004FF6")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6004FF7")]
    [Address(RVA = "0x12517A0", Offset = "0x12505A0", VA = "0x112517A0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6004FF8")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAdventureTimeReduce()
    {
    }

    [Token(Token = "0x20012E6")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400465B")]
      [FieldOffset(Offset = "0x28")]
      public ReqAdventureTimeReduce.Response body;

      [Token(Token = "0x6004FFA")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
