// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqPointQuestGuildReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001809")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("PointQuest/Req/PointQuestGuildReward", 32741)]
  public class FlowNode_ReqPointQuestGuildReward : FlowNode_Network
  {
    [Token(Token = "0x4005684")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005685")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6006129")]
    [Address(RVA = "0x135D530", Offset = "0x135C330", VA = "0x1135D530", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600612A")]
    [Address(RVA = "0x135DF50", Offset = "0x135CD50", VA = "0x1135DF50")]
    private void Success()
    {
    }

    [Token(Token = "0x600612B")]
    [Address(RVA = "0x135D780", Offset = "0x135C580", VA = "0x1135D780", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600612C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqPointQuestGuildReward()
    {
    }

    [Token(Token = "0x200180A")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005686")]
      [FieldOffset(Offset = "0x28")]
      public ReqPointQuestGuildReward.Response body;

      [Token(Token = "0x600612D")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
