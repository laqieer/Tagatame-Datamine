// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PrepareSceneChange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001464")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Cancel", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(100, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Scene/PrepareSceneChange")]
  [FlowNode.Pin(0, "Done", FlowNode.PinTypes.Output, 0)]
  public class FlowNode_PrepareSceneChange : FlowNodePersistent
  {
    [Token(Token = "0x4004B6D")]
    [FieldOffset(Offset = "0x18")]
    private bool mStart;

    [Token(Token = "0x6005540")]
    [Address(RVA = "0x12998E0", Offset = "0x12986E0", VA = "0x112998E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005541")]
    [Address(RVA = "0xAE7870", Offset = "0xAE6670", VA = "0x10AE7870")]
    private void Reset()
    {
    }

    [Token(Token = "0x6005542")]
    [Address(RVA = "0x12998C0", Offset = "0x12986C0", VA = "0x112998C0")]
    private void Done()
    {
    }

    [Token(Token = "0x6005543")]
    [Address(RVA = "0x12998A0", Offset = "0x12986A0", VA = "0x112998A0")]
    private void Cancel()
    {
    }

    [Token(Token = "0x6005544")]
    [Address(RVA = "0x1299950", Offset = "0x1298750", VA = "0x11299950")]
    private void Update()
    {
    }

    [Token(Token = "0x6005545")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_PrepareSceneChange()
    {
    }
  }
}
