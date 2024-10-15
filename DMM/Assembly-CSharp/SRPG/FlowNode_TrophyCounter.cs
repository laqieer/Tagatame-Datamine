// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_TrophyCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200165B")]
  [FlowNode.Pin(0, "RequestReviewURL", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "output", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Trophy/TrophyCounter", 32741)]
  public class FlowNode_TrophyCounter : FlowNode
  {
    [Token(Token = "0x400512C")]
    [FieldOffset(Offset = "0x18")]
    public string ReviewURL_Android;
    [Token(Token = "0x400512D")]
    [FieldOffset(Offset = "0x1C")]
    public string ReviewURL_iOS;
    [Token(Token = "0x400512E")]
    [FieldOffset(Offset = "0x20")]
    public string ReviewURL_Generic;
    [Token(Token = "0x400512F")]
    [FieldOffset(Offset = "0x24")]
    public string ReviewURL_Twitter;

    [Token(Token = "0x6005BCB")]
    [Address(RVA = "0x1311590", Offset = "0x1310390", VA = "0x11311590", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005BCC")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_TrophyCounter()
    {
    }
  }
}
