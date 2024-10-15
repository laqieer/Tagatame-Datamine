// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqQRCodeAccess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001568")]
  [FlowNode.Pin(100, "CheckQRCodeAccessHome", FlowNode.PinTypes.Input, 100)]
  [AddComponentMenu("")]
  [FlowNode.Pin(14, "OverUse", FlowNode.PinTypes.Output, 14)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(12, "OutOfTerm", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(11, "NotFoundSerial", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(10, "NotFoundCampaign", FlowNode.PinTypes.Output, 10)]
  [FlowNode.NodeType("Request/QRCodeAccess", 32741)]
  [FlowNode.Pin(0, "CheckQRCodeAccess", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(2, "Failed", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(13, "AlreadyInputed", FlowNode.PinTypes.Output, 13)]
  public class FlowNode_ReqQRCodeAccess : FlowNode_Network
  {
    [Token(Token = "0x4004DFB")]
    private const int PIN_INPUT_CHECK_QRCODE_ACCESS_HOME = 100;
    [Token(Token = "0x4004DFC")]
    private const int PIN_OUTPUT_SUCCESS = 1;
    [Token(Token = "0x4004DFD")]
    [FieldOffset(Offset = "0x20")]
    private bool end_callback;

    [Token(Token = "0x6005872")]
    [Address(RVA = "0x12D7190", Offset = "0x12D5F90", VA = "0x112D7190", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005873")]
    [Address(RVA = "0x12D6ED0", Offset = "0x12D5CD0", VA = "0x112D6ED0")]
    private void CheckQRCode()
    {
    }

    [Token(Token = "0x6005874")]
    [Address(RVA = "0x12D7080", Offset = "0x12D5E80", VA = "0x112D7080")]
    private void Finished(string msg = null)
    {
    }

    [Token(Token = "0x6005875")]
    [Address(RVA = "0x12D7050", Offset = "0x12D5E50", VA = "0x112D7050")]
    private void EndCallback(GameObject go)
    {
    }

    [Token(Token = "0x6005876")]
    [Address(RVA = "0x12D72D0", Offset = "0x12D60D0", VA = "0x112D72D0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005877")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqQRCodeAccess()
    {
    }

    [Token(Token = "0x2001569")]
    private class JSON_QRCodeAccess
    {
      [Token(Token = "0x4004DFE")]
      [FieldOffset(Offset = "0x8")]
      public Json_Item[] items;
      [Token(Token = "0x4004DFF")]
      [FieldOffset(Offset = "0xC")]
      public string message;

      [Token(Token = "0x6005878")]
      [Address(RVA = "0x12DBD00", Offset = "0x12DAB00", VA = "0x112DBD00")]
      public JSON_QRCodeAccess()
      {
      }
    }
  }
}
