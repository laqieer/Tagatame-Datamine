// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRaidTrainingBtlLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016EF")]
  [FlowNode.NodeType("GuildRaid/Req/GuildRaidTrainingBtlLog", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGuildRaidTrainingBtlLog : FlowNode_Network
  {
    [Token(Token = "0x40052D9")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40052DA")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005D96")]
    [Address(RVA = "0x1320AE0", Offset = "0x131F8E0", VA = "0x11320AE0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D97")]
    [Address(RVA = "0x13210E0", Offset = "0x131FEE0", VA = "0x113210E0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005D98")]
    [Address(RVA = "0x1320C20", Offset = "0x131FA20", VA = "0x11320C20", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005D99")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRaidTrainingBtlLog()
    {
    }

    [Token(Token = "0x20016F0")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40052DB")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildRaidTrainingBtlLog.Response body;

      [Token(Token = "0x6005D9A")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
