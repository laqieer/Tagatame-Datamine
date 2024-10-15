// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRunePrideOpen
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
  [Token(Token = "0x2001862")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("RunePride/Req/ReqRunePrideOpen", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqRunePrideOpen : FlowNode_Network
  {
    [Token(Token = "0x4005772")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005773")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4005774")]
    public const string KEY_UNIT_ID = "KEY_UNIT_ID";
    [Token(Token = "0x4005775")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour svb;

    [Token(Token = "0x600625C")]
    [Address(RVA = "0x30A4C0", Offset = "0x3092C0", VA = "0x1030A4C0")]
    private ReqRunePrideOpen.RequestParam CreateReqRunePrideOpen(SerializeValueList _valueList)
    {
      return (ReqRunePrideOpen.RequestParam) null;
    }

    [Token(Token = "0x600625D")]
    [Address(RVA = "0x30A550", Offset = "0x309350", VA = "0x1030A550", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600625E")]
    [Address(RVA = "0x30AA00", Offset = "0x309800", VA = "0x1030AA00")]
    private void Success()
    {
    }

    [Token(Token = "0x600625F")]
    [Address(RVA = "0x30A6C0", Offset = "0x3094C0", VA = "0x1030A6C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006260")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRunePrideOpen()
    {
    }

    [Token(Token = "0x2001863")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005776")]
      [FieldOffset(Offset = "0x28")]
      public ReqRunePrideOpen.Response body;

      [Token(Token = "0x6006261")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
