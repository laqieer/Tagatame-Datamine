// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqDuelRankingReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001352")]
  [FlowNode.NodeType("Duel/Req/DuelRankingReward", 32741)]
  [FlowNode.Pin(10, "Request", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  public class FlowNode_ReqDuelRankingReward : FlowNode_Network
  {
    [Token(Token = "0x400477D")]
    private const int PIN_INPUT_REQUEST = 10;
    [Token(Token = "0x400477E")]
    private const int PIN_OUTPUT_SUCCESS = 100;

    [Token(Token = "0x600512F")]
    [Address(RVA = "0x1276060", Offset = "0x1274E60", VA = "0x11276060", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005130")]
    [Address(RVA = "0x1276130", Offset = "0x1274F30", VA = "0x11276130", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005131")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqDuelRankingReward()
    {
    }

    [Token(Token = "0x2001353")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400477F")]
      [FieldOffset(Offset = "0x28")]
      public ReqDuelRankingReward.Response body;

      [Token(Token = "0x6005132")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
