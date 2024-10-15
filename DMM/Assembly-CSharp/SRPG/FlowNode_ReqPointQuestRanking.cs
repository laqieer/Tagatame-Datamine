// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqPointQuestRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200180B")]
  [FlowNode.NodeType("PointQuest/Req/PointQuestRanking", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqPointQuestRanking : FlowNode_Network
  {
    [Token(Token = "0x4005687")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005688")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005689")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;

    [Token(Token = "0x600612E")]
    [Address(RVA = "0x135E5D0", Offset = "0x135D3D0", VA = "0x1135E5D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600612F")]
    [Address(RVA = "0x135EB80", Offset = "0x135D980", VA = "0x1135EB80")]
    private void Success()
    {
    }

    [Token(Token = "0x6006130")]
    [Address(RVA = "0x135E800", Offset = "0x135D600", VA = "0x1135E800", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006131")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqPointQuestRanking()
    {
    }

    [Token(Token = "0x200180C")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400568A")]
      [FieldOffset(Offset = "0x28")]
      public ReqPointQuestRanking.Response body;

      [Token(Token = "0x6006132")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
