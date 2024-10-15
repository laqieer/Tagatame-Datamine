// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqJukeBoxMylistDel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001682")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Del Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("JukeBox/Req/PlayListDel", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqJukeBoxMylistDel : FlowNode_Network
  {
    [Token(Token = "0x40051DA")]
    protected const int PIN_IN_DEL_REQUEST = 1;
    [Token(Token = "0x40051DB")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005C5E")]
    [Address(RVA = "0x130E390", Offset = "0x130D190", VA = "0x1130E390", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C5F")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005C60")]
    [Address(RVA = "0x130E4E0", Offset = "0x130D2E0", VA = "0x1130E4E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005C61")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqJukeBoxMylistDel()
    {
    }

    [Token(Token = "0x2001683")]
    [MessagePackObject(true)]
    public class MP_Del_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40051DC")]
      [FieldOffset(Offset = "0x28")]
      public ReqJukeBoxPlaylistDel.Response body;

      [Token(Token = "0x6005C62")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Del_Response()
      {
      }
    }
  }
}
