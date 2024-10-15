// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRaidMailRead
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016D0")]
  [AddComponentMenu("")]
  [FlowNode.Pin(401, "Mail ID Dupulicate", FlowNode.PinTypes.Output, 401)]
  [FlowNode.Pin(332, "Mail Not Received", FlowNode.PinTypes.Output, 332)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(301, "Out of Period", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(300, "Not Joined", FlowNode.PinTypes.Output, 300)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("GuildRaid/Req/GuildRaidMailRead", 32741)]
  [FlowNode.Pin(331, "Already Mail Received", FlowNode.PinTypes.Output, 331)]
  public class FlowNode_ReqGuildRaidMailRead : FlowNode_Network
  {
    [Token(Token = "0x4005294")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005295")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005296")]
    protected const int PIN_OUT_NOT_JOINED = 300;
    [Token(Token = "0x4005297")]
    protected const int PIN_OUT_OUT_OF_PERIOD = 301;
    [Token(Token = "0x4005298")]
    protected const int PIN_OUT_ALREADY_MAIL_RECEIVED = 331;
    [Token(Token = "0x4005299")]
    protected const int PIN_OUT_MAIL_NOT_RECEIVED = 332;
    [Token(Token = "0x400529A")]
    protected const int PIN_OUT_MAIL_ID_DUPULICATE = 401;

    [Token(Token = "0x6005D3F")]
    [Address(RVA = "0x131AFB0", Offset = "0x1319DB0", VA = "0x1131AFB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D40")]
    [Address(RVA = "0x131B9C0", Offset = "0x131A7C0", VA = "0x1131B9C0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005D41")]
    [Address(RVA = "0x131B230", Offset = "0x131A030", VA = "0x1131B230", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005D42")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRaidMailRead()
    {
    }

    [Token(Token = "0x20016D1")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400529B")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildRaidMailRead.Response body;

      [Token(Token = "0x6005D48")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
