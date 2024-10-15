// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRankingMembers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001326")]
  [FlowNode.NodeType("CombatPower/Req/GuildRankingMembers", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqGuildRankingMembers : FlowNode_Network
  {
    [Token(Token = "0x4004705")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004706")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4004707")]
    [FieldOffset(Offset = "0x20")]
    private int m_TargetGid;

    [Token(Token = "0x60050B7")]
    [Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")]
    public void SetRequestParam(long targetGid)
    {
    }

    [Token(Token = "0x60050B8")]
    [Address(RVA = "0x1260C60", Offset = "0x125FA60", VA = "0x11260C60", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60050B9")]
    [Address(RVA = "0x12611E0", Offset = "0x125FFE0", VA = "0x112611E0")]
    private void Success()
    {
    }

    [Token(Token = "0x60050BA")]
    [Address(RVA = "0x1260D40", Offset = "0x125FB40", VA = "0x11260D40", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60050BB")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRankingMembers()
    {
    }

    [Token(Token = "0x2001327")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004708")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildRankingMembers.Response body;

      [Token(Token = "0x60050BC")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
