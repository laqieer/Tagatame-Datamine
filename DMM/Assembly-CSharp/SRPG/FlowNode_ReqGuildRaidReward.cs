// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRaidReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016E9")]
  [AddComponentMenu("")]
  [FlowNode.Pin(20, "Cancel", FlowNode.PinTypes.Output, 20)]
  [FlowNode.NodeType("GuildRaid/ReqGuildRaidReward", 32741)]
  [FlowNode.Pin(0, "Req", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Ok", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_ReqGuildRaidReward : FlowNode_Network
  {
    [Token(Token = "0x40052C9")]
    private const int PIN_IN_REQ = 0;
    [Token(Token = "0x40052CA")]
    private const int PIN_OUT_OK = 10;
    [Token(Token = "0x40052CB")]
    private const int PIN_OUT_CANCEL = 20;
    [Token(Token = "0x40052CC")]
    [FieldOffset(Offset = "0x20")]
    private bool isChecked;

    [Token(Token = "0x6005D88")]
    [Address(RVA = "0x131FC90", Offset = "0x131EA90", VA = "0x1131FC90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D89")]
    [Address(RVA = "0x1320390", Offset = "0x131F190", VA = "0x11320390")]
    private void Success()
    {
    }

    [Token(Token = "0x6005D8A")]
    [Address(RVA = "0x131FF80", Offset = "0x131ED80", VA = "0x1131FF80", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005D8B")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRaidReward()
    {
    }

    [Token(Token = "0x20016EA")]
    private enum GuildRaidRewardRankingStatus
    {
      [Token(Token = "0x40052CE")] RankingOutSide,
      [Token(Token = "0x40052CF")] GetReward,
      [Token(Token = "0x40052D0")] RewardNoneReceive,
      [Token(Token = "0x40052D1")] RewardTimeOut,
      [Token(Token = "0x40052D2")] RewardReceiveed,
    }

    [Token(Token = "0x20016EB")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40052D3")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildRaidRankingReward.Response body;

      [Token(Token = "0x6005D8D")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
