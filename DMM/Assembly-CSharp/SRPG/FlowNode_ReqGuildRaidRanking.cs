// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRaidRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016D2")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("GuildRaid/Req/GuildRaidRanking", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqGuildRaidRanking : FlowNode_Network
  {
    [Token(Token = "0x400529C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool Overwrite;
    [Token(Token = "0x400529D")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400529E")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005D49")]
    [Address(RVA = "0x131E070", Offset = "0x131CE70", VA = "0x1131E070", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D4A")]
    [Address(RVA = "0x131E8C0", Offset = "0x131D6C0", VA = "0x1131E8C0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005D4B")]
    [Address(RVA = "0x131E2F0", Offset = "0x131D0F0", VA = "0x1131E2F0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005D4C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRaidRanking()
    {
    }

    [Token(Token = "0x20016D3")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400529F")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildRaidRanking.Response body;

      [Token(Token = "0x6005D4D")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
