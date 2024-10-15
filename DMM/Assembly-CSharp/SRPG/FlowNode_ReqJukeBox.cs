// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqJukeBox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200167E")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("JukeBox/Req", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqJukeBox : FlowNode_Network
  {
    [Token(Token = "0x40051D4")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40051D5")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005C54")]
    [Address(RVA = "0x130E870", Offset = "0x130D670", VA = "0x1130E870", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C55")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005C56")]
    [Address(RVA = "0x130E910", Offset = "0x130D710", VA = "0x1130E910", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005C57")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqJukeBox()
    {
    }

    [Token(Token = "0x200167F")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40051D6")]
      [FieldOffset(Offset = "0x28")]
      public ReqJukeBox.Response body;

      [Token(Token = "0x6005C58")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
