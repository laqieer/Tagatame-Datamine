// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqConvertPiece
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014E6")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/Shop/ReqConvertPiece", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqConvertPiece : FlowNode_Network
  {
    [Token(Token = "0x4004C99")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004C9A")]
    private const int PIN_IN_SUCCESS = 100;

    [Token(Token = "0x60056EF")]
    [Address(RVA = "0x12C68D0", Offset = "0x12C56D0", VA = "0x112C68D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60056F0")]
    [Address(RVA = "0x12C6A20", Offset = "0x12C5820", VA = "0x112C6A20", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60056F1")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqConvertPiece()
    {
    }

    [Token(Token = "0x20014E7")]
    private class Json_Response
    {
      [Token(Token = "0x4004C9B")]
      [FieldOffset(Offset = "0x8")]
      public Json_Item[] items;

      [Token(Token = "0x60056F2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_Response()
      {
      }
    }
  }
}
