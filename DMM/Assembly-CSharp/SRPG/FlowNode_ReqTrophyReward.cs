// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqTrophyReward
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
  [Token(Token = "0x200187E")]
  [FlowNode.NodeType("Trophy/ReqTrophyReward", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqTrophyReward : FlowNode_Network
  {
    [Token(Token = "0x40057DC")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40057DD")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40057DE")]
    [FieldOffset(Offset = "0x20")]
    private List<TrophyParam> mTrophyParam;
    [Token(Token = "0x40057DF")]
    [FieldOffset(Offset = "0x24")]
    public GameObject RewardWindow;
    [Token(Token = "0x40057E0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string ReviewURL_Android;
    [Token(Token = "0x40057E1")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private string ReviewURL_iOS;
    [Token(Token = "0x40057E2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string ReviewURL_Generic;
    [Token(Token = "0x40057E3")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private string ReviewURL_Twitter;
    [Token(Token = "0x40057E4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private bool IsAllReward;
    [Token(Token = "0x40057E5")]
    [FieldOffset(Offset = "0x3C")]
    private int mLevelOld;
    [Token(Token = "0x40057E6")]
    [FieldOffset(Offset = "0x40")]
    private int mUnitCountsOld;

    [Token(Token = "0x60062B2")]
    [Address(RVA = "0x30EEF0", Offset = "0x30DCF0", VA = "0x1030EEF0")]
    public ReqTrophyReward.RequestParam CreateReqGetTrophyReward()
    {
      return (ReqTrophyReward.RequestParam) null;
    }

    [Token(Token = "0x60062B3")]
    [Address(RVA = "0x30F420", Offset = "0x30E220", VA = "0x1030F420", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60062B4")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x60062B5")]
    [Address(RVA = "0x30F5C0", Offset = "0x30E3C0", VA = "0x1030F5C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60062B6")]
    [Address(RVA = "0x30FEC0", Offset = "0x30ECC0", VA = "0x1030FEC0")]
    private void TrophySurveillanceStart()
    {
    }

    [Token(Token = "0x60062B7")]
    [Address(RVA = "0x30FBA0", Offset = "0x30E9A0", VA = "0x1030FBA0")]
    private void TrophySurveillanceEnd()
    {
    }

    [Token(Token = "0x60062B8")]
    [Address(RVA = "0x30E8C0", Offset = "0x30D6C0", VA = "0x1030E8C0")]
    private void BindRewardWindow()
    {
    }

    [Token(Token = "0x60062B9")]
    [Address(RVA = "0x30ED60", Offset = "0x30DB60", VA = "0x1030ED60")]
    private bool ContainsTwitterMission() => new bool();

    [Token(Token = "0x60062BA")]
    [Address(RVA = "0x30FB70", Offset = "0x30E970", VA = "0x1030FB70")]
    private void OpenTwitterURL()
    {
    }

    [Token(Token = "0x60062BB")]
    [Address(RVA = "0x30F280", Offset = "0x30E080", VA = "0x1030F280")]
    private TrophyObjective GetExternalLinkAchievedMission() => (TrophyObjective) null;

    [Token(Token = "0x60062BC")]
    [Address(RVA = "0x30FAE0", Offset = "0x30E8E0", VA = "0x1030FAE0")]
    private void OpenExternalLinkAchievedURL(TrophyObjective _objective)
    {
    }

    [Token(Token = "0x60062BD")]
    [Address(RVA = "0x30FF90", Offset = "0x30ED90", VA = "0x1030FF90")]
    public FlowNode_ReqTrophyReward()
    {
    }

    [Token(Token = "0x200187F")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40057E7")]
      [FieldOffset(Offset = "0x28")]
      public ReqTrophyReward.Response body;

      [Token(Token = "0x60062BE")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
