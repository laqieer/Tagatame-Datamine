// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGvGDefenseRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001709")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("GvG/Req/GvGDefenseRanking", 32741)]
  public class FlowNode_ReqGvGDefenseRanking : FlowNode_Network
  {
    [Token(Token = "0x4005317")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005318")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005DE5")]
    [Address(RVA = "0x1324600", Offset = "0x1323400", VA = "0x11324600", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005DE6")]
    [Address(RVA = "0x1324D00", Offset = "0x1323B00", VA = "0x11324D00")]
    private void Success()
    {
    }

    [Token(Token = "0x6005DE7")]
    [Address(RVA = "0x1324850", Offset = "0x1323650", VA = "0x11324850", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005DE8")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGvGDefenseRanking()
    {
    }

    [Token(Token = "0x200170A")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005319")]
      [FieldOffset(Offset = "0x28")]
      public ReqGvGDefenseRanking.Response body;

      [Token(Token = "0x6005DE9")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
