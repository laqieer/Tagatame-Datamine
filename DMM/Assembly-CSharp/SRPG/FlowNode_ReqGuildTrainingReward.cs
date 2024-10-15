// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildTrainingReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016B3")]
  [FlowNode.NodeType("Guild/Training/GuildTrainingReward", 32741)]
  [FlowNode.Pin(101, "通信成功", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqGuildTrainingReward : FlowNode_Network
  {
    [Token(Token = "0x4005261")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005262")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005CF3")]
    [Address(RVA = "0x130CA10", Offset = "0x130B810", VA = "0x1130CA10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CF4")]
    [Address(RVA = "0x130CF80", Offset = "0x130BD80", VA = "0x1130CF80")]
    private void Success()
    {
    }

    [Token(Token = "0x6005CF5")]
    [Address(RVA = "0x130CAE0", Offset = "0x130B8E0", VA = "0x1130CAE0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005CF6")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildTrainingReward()
    {
    }

    [Token(Token = "0x20016B4")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005263")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildTrainingReward.Response body;

      [Token(Token = "0x6005CF7")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
