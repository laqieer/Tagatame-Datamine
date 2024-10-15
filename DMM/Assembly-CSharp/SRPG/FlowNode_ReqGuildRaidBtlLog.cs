// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRaidBtlLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016C6")]
  [FlowNode.NodeType("GuildRaid/Req/GuildRaidBtlLog", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGuildRaidBtlLog : FlowNode_Network
  {
    [Token(Token = "0x4005282")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005283")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005D20")]
    [Address(RVA = "0x131A090", Offset = "0x1318E90", VA = "0x1131A090", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D21")]
    [Address(RVA = "0x131A780", Offset = "0x1319580", VA = "0x1131A780")]
    private void Success()
    {
    }

    [Token(Token = "0x6005D22")]
    [Address(RVA = "0x131A2C0", Offset = "0x13190C0", VA = "0x1131A2C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005D23")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRaidBtlLog()
    {
    }

    [Token(Token = "0x20016C7")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005284")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildRaidBtlLog.Response body;

      [Token(Token = "0x6005D24")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
