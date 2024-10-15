// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqUnitEquipRuneBulkRelease
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
  [Token(Token = "0x2001859")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("Rune/Req/UnitEquipRuneBulkRelease", 32741)]
  public class FlowNode_ReqUnitEquipRuneBulkRelease : FlowNode_Network
  {
    [Token(Token = "0x400575B")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400575C")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400575D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;

    [Token(Token = "0x6006244")]
    [Address(RVA = "0x311B00", Offset = "0x310900", VA = "0x10311B00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006245")]
    [Address(RVA = "0x3120F0", Offset = "0x310EF0", VA = "0x103120F0")]
    private void Success()
    {
    }

    [Token(Token = "0x6006246")]
    [Address(RVA = "0x311D30", Offset = "0x310B30", VA = "0x10311D30", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006247")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqUnitEquipRuneBulkRelease()
    {
    }

    [Token(Token = "0x200185A")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400575E")]
      [FieldOffset(Offset = "0x28")]
      public ReqRuneBulkRelease.Response body;

      [Token(Token = "0x6006248")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
