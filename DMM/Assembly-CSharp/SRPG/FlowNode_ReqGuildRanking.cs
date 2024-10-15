// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001323")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("CombatPower/Req/GuildRanking", 32741)]
  public class FlowNode_ReqGuildRanking : FlowNode_Network
  {
    [Token(Token = "0x40046FF")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004700")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4004701")]
    [FieldOffset(Offset = "0x20")]
    private int m_TargetGid;

    [Token(Token = "0x60050AE")]
    [Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")]
    public void SetRequestParam(long targetGid)
    {
    }

    [Token(Token = "0x60050AF")]
    [Address(RVA = "0x1261250", Offset = "0x1260050", VA = "0x11261250", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60050B0")]
    [Address(RVA = "0x12617D0", Offset = "0x12605D0", VA = "0x112617D0")]
    private void Success()
    {
    }

    [Token(Token = "0x60050B1")]
    [Address(RVA = "0x1261330", Offset = "0x1260130", VA = "0x11261330", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60050B2")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRanking()
    {
    }

    [Token(Token = "0x2001324")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004702")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildRanking.Response body;

      [Token(Token = "0x60050B3")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
