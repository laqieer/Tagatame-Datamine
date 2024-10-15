// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAdventureBook
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012D9")]
  [FlowNode.NodeType("Adventure/Req/AdventureBook", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqAdventureBook : FlowNode_Network
  {
    [Token(Token = "0x400463B")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400463C")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6004FCF")]
    [Address(RVA = "0x124A970", Offset = "0x1249770", VA = "0x1124A970", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6004FD0")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6004FD1")]
    [Address(RVA = "0x124AA30", Offset = "0x1249830", VA = "0x1124AA30", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6004FD2")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAdventureBook()
    {
    }

    [Token(Token = "0x20012DA")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400463D")]
      [FieldOffset(Offset = "0x28")]
      public ReqAdventureBook.Response body;

      [Token(Token = "0x6004FD3")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
