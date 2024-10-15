// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqPointQuestGuildRanking
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
  [Token(Token = "0x2001807")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("PointQuest/Req/PointQuestGuildRanking", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqPointQuestGuildRanking : FlowNode_Network
  {
    [Token(Token = "0x4005680")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005681")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005682")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;

    [Token(Token = "0x6006124")]
    [Address(RVA = "0x135CF10", Offset = "0x135BD10", VA = "0x1135CF10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006125")]
    [Address(RVA = "0x135D4C0", Offset = "0x135C2C0", VA = "0x1135D4C0")]
    private void Success()
    {
    }

    [Token(Token = "0x6006126")]
    [Address(RVA = "0x135D140", Offset = "0x135BF40", VA = "0x1135D140", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006127")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqPointQuestGuildRanking()
    {
    }

    [Token(Token = "0x2001808")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005683")]
      [FieldOffset(Offset = "0x28")]
      public ReqPointQuestGuildRanking.Response body;

      [Token(Token = "0x6006128")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
