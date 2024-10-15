// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRunePrideBoardOpen
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
  [Token(Token = "0x200185E")]
  [FlowNode.NodeType("RunePride/Req/ReqRunePrideBoardOpen", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqRunePrideBoardOpen : FlowNode_Network
  {
    [Token(Token = "0x4005764")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005765")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4005766")]
    public const string KEY_UNIT_ID = "KEY_UNIT_ID";
    [Token(Token = "0x4005767")]
    public const string KEY_PANEL_ID = "KEY_PANEL_ID";
    [Token(Token = "0x4005768")]
    public const string KEY_TARGET_NUMBERS = "KEY_TARGET_NUMBERS";
    [Token(Token = "0x4005769")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour svb;
    [Token(Token = "0x400576A")]
    [FieldOffset(Offset = "0x24")]
    private int[] mTargetIds;

    [Token(Token = "0x6006250")]
    [Address(RVA = "0x309780", Offset = "0x308580", VA = "0x10309780")]
    private ReqRunePrideBoardOpen.RequestParam CreateReqRunePrideBoardOpen(
      SerializeValueList _valueList)
    {
      return (ReqRunePrideBoardOpen.RequestParam) null;
    }

    [Token(Token = "0x6006251")]
    [Address(RVA = "0x309900", Offset = "0x308700", VA = "0x10309900", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6006252")]
    [Address(RVA = "0x309DD0", Offset = "0x308BD0", VA = "0x10309DD0")]
    private void Success(SerializeValueList _value_list)
    {
    }

    [Token(Token = "0x6006253")]
    [Address(RVA = "0x309A00", Offset = "0x308800", VA = "0x10309A00", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006254")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRunePrideBoardOpen()
    {
    }

    [Token(Token = "0x200185F")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400576B")]
      [FieldOffset(Offset = "0x28")]
      public ReqRunePrideBoardOpen.Response body;

      [Token(Token = "0x6006255")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
