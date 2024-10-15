// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRaidInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016C9")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("GuildRaid/Req/GuildRaidInfo", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqGuildRaidInfo : FlowNode_Network
  {
    [Token(Token = "0x4005287")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005288")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005D28")]
    [Address(RVA = "0x131A860", Offset = "0x1319660", VA = "0x1131A860", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D29")]
    [Address(RVA = "0x131AF40", Offset = "0x1319D40", VA = "0x1131AF40")]
    private void Success()
    {
    }

    [Token(Token = "0x6005D2A")]
    [Address(RVA = "0x131AA70", Offset = "0x1319870", VA = "0x1131AA70", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005D2B")]
    [Address(RVA = "0x131A7F0", Offset = "0x13195F0", VA = "0x1131A7F0")]
    private IEnumerator DownloadUnitImage() => (IEnumerator) null;

    [Token(Token = "0x6005D2C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRaidInfo()
    {
    }

    [Token(Token = "0x20016CA")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005289")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildRaidInfo.Response body;

      [Token(Token = "0x6005D2D")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
