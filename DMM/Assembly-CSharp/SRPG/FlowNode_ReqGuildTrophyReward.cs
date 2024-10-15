// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildTrophyReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200187B")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(150, "ポート未所属", FlowNode.PinTypes.Output, 150)]
  [FlowNode.Pin(151, "未達成のミッション", FlowNode.PinTypes.Output, 151)]
  [FlowNode.Pin(152, "前日より前の報酬は受け取れない", FlowNode.PinTypes.Output, 152)]
  [FlowNode.Pin(153, "受け取り済", FlowNode.PinTypes.Output, 153)]
  [FlowNode.NodeType("GuildTrophy/Req/ReqGuildTrophyReward", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGuildTrophyReward : FlowNode_Network
  {
    [Token(Token = "0x40057CE")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40057CF")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40057D0")]
    protected const int PIN_OUT_NOT_JOINED = 150;
    [Token(Token = "0x40057D1")]
    protected const int PIN_OUT_NOT_ACHIEVE_TROPHY = 151;
    [Token(Token = "0x40057D2")]
    protected const int PIN_OUT_PAST_TROPHY = 152;
    [Token(Token = "0x40057D3")]
    protected const int PIN_OUT_RECEIVED_TROPHY_REWARD = 153;
    [Token(Token = "0x40057D4")]
    [FieldOffset(Offset = "0x20")]
    private List<TrophyParam> mTrophyParam;
    [Token(Token = "0x40057D5")]
    [FieldOffset(Offset = "0x24")]
    public GameObject RewardWindow;
    [Token(Token = "0x40057D6")]
    [FieldOffset(Offset = "0x28")]
    private int mLevelOld;
    [Token(Token = "0x40057D7")]
    [FieldOffset(Offset = "0x2C")]
    private int mUnitCountsOld;

    [Token(Token = "0x60062A3")]
    [Address(RVA = "0x307DB0", Offset = "0x306BB0", VA = "0x10307DB0")]
    public ReqGuildTrophyReward.RequestParam CreateReqGetGuildTrophyReward()
    {
      return (ReqGuildTrophyReward.RequestParam) null;
    }

    [Token(Token = "0x60062A4")]
    [Address(RVA = "0x308270", Offset = "0x307070", VA = "0x10308270", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60062A5")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x60062A6")]
    [Address(RVA = "0x308410", Offset = "0x307210", VA = "0x10308410", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60062A7")]
    [Address(RVA = "0x308D30", Offset = "0x307B30", VA = "0x10308D30")]
    private void TrophySurveillanceStart()
    {
    }

    [Token(Token = "0x60062A8")]
    [Address(RVA = "0x3089F0", Offset = "0x3077F0", VA = "0x103089F0")]
    private void TrophySurveillanceEnd()
    {
    }

    [Token(Token = "0x60062A9")]
    [Address(RVA = "0x307910", Offset = "0x306710", VA = "0x10307910")]
    private void BindRewardWindow()
    {
    }

    [Token(Token = "0x60062AA")]
    [Address(RVA = "0x308E80", Offset = "0x307C80", VA = "0x10308E80")]
    public FlowNode_ReqGuildTrophyReward()
    {
    }

    [Token(Token = "0x200187C")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40057D8")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildTrophyReward.Response body;

      [Token(Token = "0x60062AF")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
