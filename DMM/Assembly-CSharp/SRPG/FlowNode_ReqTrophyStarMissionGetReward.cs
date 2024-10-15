// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqTrophyStarMissionGetReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001884")]
  [FlowNode.NodeType("Trophy/StarMission/Req/GetReward", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqTrophyStarMissionGetReward : FlowNode_Network
  {
    [Token(Token = "0x40057EF")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40057F0")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x60062C8")]
    [Address(RVA = "0x310000", Offset = "0x30EE00", VA = "0x10310000", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60062C9")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x60062CA")]
    [Address(RVA = "0x310250", Offset = "0x30F050", VA = "0x10310250", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60062CB")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqTrophyStarMissionGetReward()
    {
    }

    [Token(Token = "0x2001885")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40057F1")]
      [FieldOffset(Offset = "0x28")]
      public ReqTrophyStarMissionGetReward.Response body;

      [Token(Token = "0x60062CC")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
