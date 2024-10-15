// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGvGReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200172D")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("GvG/Req/GvGReward", 32741)]
  [FlowNode.Pin(102, "Not Accept", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGvGReward : FlowNode_Network
  {
    [Token(Token = "0x4005366")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005367")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005368")]
    protected const int PIN_OUT_NOTACCEPT = 102;
    [Token(Token = "0x4005369")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool IsHomeGvGReward;
    [Token(Token = "0x400536A")]
    [FieldOffset(Offset = "0x21")]
    [SerializeField]
    private bool IsResultGvGReward;

    [Token(Token = "0x6005E57")]
    [Address(RVA = "0x132B0F0", Offset = "0x1329EF0", VA = "0x1132B0F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E58")]
    [Address(RVA = "0x132B660", Offset = "0x132A460", VA = "0x1132B660")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E59")]
    [Address(RVA = "0x132B2C0", Offset = "0x132A0C0", VA = "0x1132B2C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E5A")]
    [Address(RVA = "0x132B6D0", Offset = "0x132A4D0", VA = "0x1132B6D0")]
    public FlowNode_ReqGvGReward()
    {
    }

    [Token(Token = "0x200172E")]
    private enum GvGRewardStatus
    {
      [Token(Token = "0x400536C")] NoneReward,
      [Token(Token = "0x400536D")] HomeGift,
      [Token(Token = "0x400536E")] NotReward,
      [Token(Token = "0x400536F")] RewardTimeOut,
    }

    [Token(Token = "0x200172F")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005370")]
      [FieldOffset(Offset = "0x28")]
      public ReqGvGReward.Response body;

      [Token(Token = "0x6005E5B")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
