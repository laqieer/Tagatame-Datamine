// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqPointQuestReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200180D")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("PointQuest/Req/PointQuestReward", 32741)]
  public class FlowNode_ReqPointQuestReward : FlowNode_Network
  {
    [Token(Token = "0x400568B")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400568C")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6006133")]
    [Address(RVA = "0x135EBF0", Offset = "0x135D9F0", VA = "0x1135EBF0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006134")]
    [Address(RVA = "0x135F5C0", Offset = "0x135E3C0", VA = "0x1135F5C0")]
    private void Success()
    {
    }

    [Token(Token = "0x6006135")]
    [Address(RVA = "0x135EE50", Offset = "0x135DC50", VA = "0x1135EE50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006136")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqPointQuestReward()
    {
    }

    [Token(Token = "0x200180E")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400568D")]
      [FieldOffset(Offset = "0x28")]
      public ReqPointQuestReward.Response body;

      [Token(Token = "0x6006137")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
