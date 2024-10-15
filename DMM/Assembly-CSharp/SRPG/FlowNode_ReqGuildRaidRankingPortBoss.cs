// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRaidRankingPortBoss
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016DE")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("GuildRaid/Req/GuildRaidRankingPortBoss", 32741)]
  public class FlowNode_ReqGuildRaidRankingPortBoss : FlowNode_Network
  {
    [Token(Token = "0x40052B4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool Overwrite;
    [Token(Token = "0x40052B5")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40052B6")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005D69")]
    [Address(RVA = "0x131D010", Offset = "0x131BE10", VA = "0x1131D010", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D6A")]
    [Address(RVA = "0x131D730", Offset = "0x131C530", VA = "0x1131D730")]
    private void Success()
    {
    }

    [Token(Token = "0x6005D6B")]
    [Address(RVA = "0x131D290", Offset = "0x131C090", VA = "0x1131D290", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005D6C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRaidRankingPortBoss()
    {
    }

    [Token(Token = "0x20016DF")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40052B7")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildRaidRankingPortBoss.Response body;

      [Token(Token = "0x6005D6D")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
