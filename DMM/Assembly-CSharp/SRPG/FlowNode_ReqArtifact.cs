// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqArtifact
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001486")]
  [FlowNode.NodeType("System/ReqArtifact/ReqArtifact", 32741)]
  [FlowNode.Pin(0, "一覧取得", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "一覧取得した", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  public class FlowNode_ReqArtifact : FlowNode_Network
  {
    [Token(Token = "0x4004BC6")]
    private const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x4004BC7")]
    private const int PIN_OUT_DONE = 100;
    [Token(Token = "0x4004BC8")]
    [FieldOffset(Offset = "0x20")]
    private bool mIsDifferenceUpdate;

    [Token(Token = "0x60055BD")]
    [Address(RVA = "0x12B9F10", Offset = "0x12B8D10", VA = "0x112B9F10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60055BE")]
    [Address(RVA = "0x12BA020", Offset = "0x12B8E20", VA = "0x112BA020", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60055BF")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqArtifact()
    {
    }
  }
}
