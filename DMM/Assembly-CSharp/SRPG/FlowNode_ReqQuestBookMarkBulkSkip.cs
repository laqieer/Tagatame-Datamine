// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqQuestBookMarkBulkSkip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001305")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Bookmark/Req/QuestBookMarkBulkSkip", 32741)]
  public class FlowNode_ReqQuestBookMarkBulkSkip : FlowNode_Network
  {
    [Token(Token = "0x400469C")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400469D")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x600504D")]
    [Address(RVA = "0x1262710", Offset = "0x1261510", VA = "0x11262710", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600504E")]
    [Address(RVA = "0x1262FC0", Offset = "0x1261DC0", VA = "0x11262FC0")]
    private void Success()
    {
    }

    [Token(Token = "0x600504F")]
    [Address(RVA = "0x1262A30", Offset = "0x1261830", VA = "0x11262A30", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005050")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqQuestBookMarkBulkSkip()
    {
    }

    [Token(Token = "0x2001306")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400469E")]
      [FieldOffset(Offset = "0x28")]
      public ReqBookmarkBulkSkip.Response body;

      [Token(Token = "0x6005051")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
