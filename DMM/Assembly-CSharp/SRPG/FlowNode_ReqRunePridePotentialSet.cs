// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRunePridePotentialSet
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
  [Token(Token = "0x2001864")]
  [FlowNode.NodeType("RunePride/Req/ReqRunePridePotentialSet", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqRunePridePotentialSet : FlowNode_Network
  {
    [Token(Token = "0x4005777")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005778")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4005779")]
    public const string KEY_UNIT_ID = "KEY_UNIT_ID";
    [Token(Token = "0x400577A")]
    public const string KEY_BONUS_ID = "KEY_BONUS_ID";
    [Token(Token = "0x400577B")]
    public const string KEY_SLOT_NUM = "KEY_SLOT_NUM";
    [Token(Token = "0x400577C")]
    public const string KEY_MATERIALS = "KEY_MATERIALS";
    [Token(Token = "0x400577D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour svb;

    [Token(Token = "0x6006262")]
    [Address(RVA = "0x30AA70", Offset = "0x309870", VA = "0x1030AA70")]
    private ReqRunePridePotentialSet.RequestParam CreateReqRunePridePotentialSet(
      SerializeValueList _valueList)
    {
      return (ReqRunePridePotentialSet.RequestParam) null;
    }

    [Token(Token = "0x6006263")]
    [Address(RVA = "0x30ABC0", Offset = "0x3099C0", VA = "0x1030ABC0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6006264")]
    [Address(RVA = "0x30B120", Offset = "0x309F20", VA = "0x1030B120")]
    private void Success()
    {
    }

    [Token(Token = "0x6006265")]
    [Address(RVA = "0x30ADE0", Offset = "0x309BE0", VA = "0x1030ADE0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006266")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRunePridePotentialSet()
    {
    }

    [Token(Token = "0x2001865")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400577E")]
      [FieldOffset(Offset = "0x28")]
      public ReqRunePridePotentialSet.Response body;

      [Token(Token = "0x6006267")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
