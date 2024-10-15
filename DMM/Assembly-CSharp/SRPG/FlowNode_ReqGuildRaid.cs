// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRaid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016C2")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("GuildRaid/Req/GuildRaid", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqGuildRaid : FlowNode_Network
  {
    [Token(Token = "0x400527C")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400527D")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005D16")]
    [Address(RVA = "0x1321840", Offset = "0x1320640", VA = "0x11321840", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D17")]
    [Address(RVA = "0x1322040", Offset = "0x1320E40", VA = "0x11322040")]
    private void Success()
    {
    }

    [Token(Token = "0x6005D18")]
    [Address(RVA = "0x13219A0", Offset = "0x13207A0", VA = "0x113219A0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005D19")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRaid()
    {
    }

    [Token(Token = "0x20016C3")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400527E")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildRaid.Response body;

      [Token(Token = "0x6005D1A")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
