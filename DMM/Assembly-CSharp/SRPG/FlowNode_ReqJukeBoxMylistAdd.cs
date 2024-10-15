// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqJukeBoxMylistAdd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001680")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Add Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("JukeBox/Req/PlayListAdd", 32741)]
  public class FlowNode_ReqJukeBoxMylistAdd : FlowNode_Network
  {
    [Token(Token = "0x40051D7")]
    protected const int PIN_IN_ADD_REQUEST = 1;
    [Token(Token = "0x40051D8")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005C59")]
    [Address(RVA = "0x130DEB0", Offset = "0x130CCB0", VA = "0x1130DEB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C5A")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005C5B")]
    [Address(RVA = "0x130E000", Offset = "0x130CE00", VA = "0x1130E000", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005C5C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqJukeBoxMylistAdd()
    {
    }

    [Token(Token = "0x2001681")]
    [MessagePackObject(true)]
    public class MP_Add_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40051D9")]
      [FieldOffset(Offset = "0x28")]
      public ReqJukeBoxPlaylistAdd.Response body;

      [Token(Token = "0x6005C5D")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Add_Response()
      {
      }
    }
  }
}
