// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGvGRankingGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200172A")]
  [FlowNode.NodeType("GvG/Req/GvGRankingGroup", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqGvGRankingGroup : FlowNode_Network
  {
    [Token(Token = "0x4005361")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005362")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005E4F")]
    [Address(RVA = "0x132A960", Offset = "0x1329760", VA = "0x1132A960", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E50")]
    [Address(RVA = "0x132B080", Offset = "0x1329E80", VA = "0x1132B080")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E51")]
    [Address(RVA = "0x132AB60", Offset = "0x1329960", VA = "0x1132AB60", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E52")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGvGRankingGroup()
    {
    }

    [Token(Token = "0x200172B")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005363")]
      [FieldOffset(Offset = "0x28")]
      public ReqGvGRankingGroup.Response body;

      [Token(Token = "0x6005E53")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
