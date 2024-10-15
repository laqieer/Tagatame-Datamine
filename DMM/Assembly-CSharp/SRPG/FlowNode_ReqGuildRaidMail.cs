// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRaidMail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016CD")]
  [FlowNode.NodeType("GuildRaid/Req/GuildRaidMail", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGuildRaidMail : FlowNode_Network
  {
    [Token(Token = "0x400528F")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005290")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005D37")]
    [Address(RVA = "0x131BAD0", Offset = "0x131A8D0", VA = "0x1131BAD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D38")]
    [Address(RVA = "0x131C130", Offset = "0x131AF30", VA = "0x1131C130")]
    private void Success()
    {
    }

    [Token(Token = "0x6005D39")]
    [Address(RVA = "0x131BCD0", Offset = "0x131AAD0", VA = "0x1131BCD0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005D3A")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRaidMail()
    {
    }

    [Token(Token = "0x20016CE")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005291")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildRaidMail.Response body;

      [Token(Token = "0x6005D3B")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
