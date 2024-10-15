// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGallery
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001503")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1011, "ハイライト受け取り済み", FlowNode.PinTypes.Output, 1011)]
  [FlowNode.NodeType("System/ReqGallery", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "InProgress", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1000, "ハイライト期間外", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(1001, "ハイライトデータ作成中", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1002, "ハイライト表示可能", FlowNode.PinTypes.Output, 1002)]
  [FlowNode.Pin(1010, "ハイライト未受け取り", FlowNode.PinTypes.Output, 1010)]
  public class FlowNode_ReqGallery : FlowNode_Network
  {
    [Token(Token = "0x4004CF6")]
    public const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x4004CF7")]
    public const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4004CF8")]
    public const int PIN_OUT_INPROGRESS = 101;
    [Token(Token = "0x4004CF9")]
    public const int PIN_OUT_HIGHLIGHT_OUTOFPERIOD = 1000;
    [Token(Token = "0x4004CFA")]
    public const int PIN_OUT_HIGHLIGHT_INPROGRESS = 1001;
    [Token(Token = "0x4004CFB")]
    public const int PIN_OUT_HIGHLIGHT_COMPLETED = 1002;
    [Token(Token = "0x4004CFC")]
    public const int PIN_OUT_HIGHLIGHT_NOT_REWARDED = 1010;
    [Token(Token = "0x4004CFD")]
    public const int PIN_OUT_HIGHLIGHT_REWARDED = 1011;

    [Token(Token = "0x600575A")]
    [Address(RVA = "0x12CE960", Offset = "0x12CD760", VA = "0x112CE960", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600575B")]
    [Address(RVA = "0x1256AB0", Offset = "0x12558B0", VA = "0x11256AB0")]
    private void Success()
    {
    }

    [Token(Token = "0x600575C")]
    [Address(RVA = "0x12CEA50", Offset = "0x12CD850", VA = "0x112CEA50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600575D")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGallery()
    {
    }

    [Token(Token = "0x2001504")]
    [Serializable]
    private class Json_Response
    {
      [Token(Token = "0x4004CFE")]
      [FieldOffset(Offset = "0x8")]
      public string highlight_iname;
      [Token(Token = "0x4004CFF")]
      [FieldOffset(Offset = "0xC")]
      public int highlight_status;
      [Token(Token = "0x4004D00")]
      [FieldOffset(Offset = "0x10")]
      public int is_highlight_rewarded;

      [Token(Token = "0x600575E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_Response()
      {
      }
    }
  }
}
