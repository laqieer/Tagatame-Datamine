// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCrystalGet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001332")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("Crystal/Req/CrystalGet", 32741)]
  public class FlowNode_ReqCrystalGet : FlowNode_Network
  {
    [Token(Token = "0x4004728")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004729")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x60050DB")]
    [Address(RVA = "0x125C100", Offset = "0x125AF00", VA = "0x1125C100", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60050DC")]
    [Address(RVA = "0x125C770", Offset = "0x125B570", VA = "0x1125C770")]
    private void Success()
    {
    }

    [Token(Token = "0x60050DD")]
    [Address(RVA = "0x125C3A0", Offset = "0x125B1A0", VA = "0x1125C3A0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60050DE")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqCrystalGet()
    {
    }

    [Token(Token = "0x2001333")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400472A")]
      [FieldOffset(Offset = "0x28")]
      public ReqCrystalGet.Response body;

      [Token(Token = "0x60050DF")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
