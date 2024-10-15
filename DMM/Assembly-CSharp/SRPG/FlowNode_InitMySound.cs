// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_InitMySound
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001408")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Sound/InitMySound", 65535)]
  [FlowNode.Pin(0, "In", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Out", FlowNode.PinTypes.Output, 1)]
  public class FlowNode_InitMySound : FlowNode
  {
    [Token(Token = "0x4004A32")]
    [FieldOffset(Offset = "0x18")]
    public bool UseEmb;
    [Token(Token = "0x4004A33")]
    [FieldOffset(Offset = "0x19")]
    public bool ForceReInit;

    [Token(Token = "0x60053C2")]
    [Address(RVA = "0x1284FE0", Offset = "0x1283DE0", VA = "0x11284FE0")]
    private void Init()
    {
    }

    [Token(Token = "0x60053C3")]
    [Address(RVA = "0x1285080", Offset = "0x1283E80", VA = "0x11285080", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60053C4")]
    [Address(RVA = "0x12852C0", Offset = "0x12840C0", VA = "0x112852C0")]
    private IEnumerator Restart() => (IEnumerator) null;

    [Token(Token = "0x60053C5")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_InitMySound()
    {
    }
  }
}
