// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqQuestBookMarkFavorite
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
  [Token(Token = "0x2001307")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Bookmark/Req/QuestBookMarkFavorite", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqQuestBookMarkFavorite : FlowNode_Network
  {
    [Token(Token = "0x400469F")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40046A0")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005052")]
    [Address(RVA = "0x1263030", Offset = "0x1261E30", VA = "0x11263030", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005053")]
    [Address(RVA = "0x1263490", Offset = "0x1262290", VA = "0x11263490")]
    private void Success()
    {
    }

    [Token(Token = "0x6005054")]
    [Address(RVA = "0x1263100", Offset = "0x1261F00", VA = "0x11263100", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005055")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqQuestBookMarkFavorite()
    {
    }

    [Token(Token = "0x2001308")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40046A1")]
      [FieldOffset(Offset = "0x28")]
      public ReqBookmarkBulkFavorite.Response body;

      [Token(Token = "0x6005056")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
