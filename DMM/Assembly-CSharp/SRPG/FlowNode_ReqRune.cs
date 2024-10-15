// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRune
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200183F")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("ConceptCard/Req/ReqRune", 32741)]
  public class FlowNode_ReqRune : FlowNode_Network
  {
    [Token(Token = "0x40056F2")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40056F3")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40056F4")]
    [FieldOffset(Offset = "0x20")]
    private bool mIsDataOverride;

    [Token(Token = "0x60061D1")]
    [Address(RVA = "0x136C000", Offset = "0x136AE00", VA = "0x1136C000")]
    public ReqGetRune.RequestParam CreateReqGetRune(out bool isDataOverride)
    {
      return (ReqGetRune.RequestParam) null;
    }

    [Token(Token = "0x60061D2")]
    [Address(RVA = "0x136C060", Offset = "0x136AE60", VA = "0x1136C060", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60061D3")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x60061D4")]
    [Address(RVA = "0x136C1C0", Offset = "0x136AFC0", VA = "0x1136C1C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60061D5")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRune()
    {
    }

    [Token(Token = "0x2001840")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40056F5")]
      [FieldOffset(Offset = "0x28")]
      public ReqGetRune.Response body;

      [Token(Token = "0x60061D6")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
