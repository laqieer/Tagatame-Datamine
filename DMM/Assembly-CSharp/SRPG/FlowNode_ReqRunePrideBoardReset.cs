// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRunePrideBoardReset
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
  [Token(Token = "0x2001860")]
  [FlowNode.NodeType("RunePride/Req/ReqRunePrideBoardReset", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqRunePrideBoardReset : FlowNode_Network
  {
    [Token(Token = "0x400576C")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400576D")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x400576E")]
    public const string KEY_UNIT_ID = "KEY_UNIT_ID";
    [Token(Token = "0x400576F")]
    public const string KEY_USEDITEM_ID = "KEY_USEDITEM_ID";
    [Token(Token = "0x4005770")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour svb;

    [Token(Token = "0x6006256")]
    [Address(RVA = "0x309E50", Offset = "0x308C50", VA = "0x10309E50")]
    private ReqRunePrideBoardReset.RequestParam CreateReqRunePrideBoardReset(
      SerializeValueList _valueList)
    {
      return (ReqRunePrideBoardReset.RequestParam) null;
    }

    [Token(Token = "0x6006257")]
    [Address(RVA = "0x309EE0", Offset = "0x308CE0", VA = "0x10309EE0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6006258")]
    [Address(RVA = "0x30A440", Offset = "0x309240", VA = "0x1030A440")]
    private void Success(SerializeValueList _valueList = null)
    {
    }

    [Token(Token = "0x6006259")]
    [Address(RVA = "0x30A050", Offset = "0x308E50", VA = "0x1030A050", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600625A")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRunePrideBoardReset()
    {
    }

    [Token(Token = "0x2001861")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005771")]
      [FieldOffset(Offset = "0x28")]
      public ReqRunePrideBoardReset.Response body;

      [Token(Token = "0x600625B")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
