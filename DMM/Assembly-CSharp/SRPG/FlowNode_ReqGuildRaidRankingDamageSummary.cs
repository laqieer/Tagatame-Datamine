﻿// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRaidRankingDamageSummary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016D8")]
  [FlowNode.NodeType("GuildRaid/Req/GuildRaidRankingDamageSummary", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGuildRaidRankingDamageSummary : FlowNode_Network
  {
    [Token(Token = "0x40052A8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool Overwrite;
    [Token(Token = "0x40052A9")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40052AA")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005D59")]
    [Address(RVA = "0x131C8E0", Offset = "0x131B6E0", VA = "0x1131C8E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D5A")]
    [Address(RVA = "0x131CFA0", Offset = "0x131BDA0", VA = "0x1131CFA0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005D5B")]
    [Address(RVA = "0x131CB00", Offset = "0x131B900", VA = "0x1131CB00", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005D5C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRaidRankingDamageSummary()
    {
    }

    [Token(Token = "0x20016D9")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40052AB")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildRaidRankingDamageSummary.Response body;

      [Token(Token = "0x6005D5D")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}