// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqPointQuestGuildPersonRanking
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
  [Token(Token = "0x2001805")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("PointQuest/Req/PointQuestGuildPersonRanking", 32741)]
  public class FlowNode_ReqPointQuestGuildPersonRanking : FlowNode_Network
  {
    [Token(Token = "0x400567C")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400567D")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400567E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;

    [Token(Token = "0x600611F")]
    [Address(RVA = "0x135C970", Offset = "0x135B770", VA = "0x1135C970", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006120")]
    [Address(RVA = "0x135CEA0", Offset = "0x135BCA0", VA = "0x1135CEA0")]
    private void Success()
    {
    }

    [Token(Token = "0x6006121")]
    [Address(RVA = "0x135CB20", Offset = "0x135B920", VA = "0x1135CB20", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006122")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqPointQuestGuildPersonRanking()
    {
    }

    [Token(Token = "0x2001806")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400567F")]
      [FieldOffset(Offset = "0x28")]
      public ReqPointQuestGuildPersonRanking.Response body;

      [Token(Token = "0x6006123")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
