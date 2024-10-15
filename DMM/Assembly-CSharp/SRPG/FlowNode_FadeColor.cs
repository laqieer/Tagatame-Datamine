// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_FadeColor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013E9")]
  [FlowNode.NodeType("UI/Fade (Color)", 32741)]
  [FlowNode.Pin(100, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Finished", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_FadeColor : FlowNode
  {
    [Token(Token = "0x40049CC")]
    [FieldOffset(Offset = "0x18")]
    public Color Color;
    [Token(Token = "0x40049CD")]
    [FieldOffset(Offset = "0x28")]
    public float Time;
    [Token(Token = "0x40049CE")]
    [FieldOffset(Offset = "0x2C")]
    public bool ForceReset;

    [Token(Token = "0x6005362")]
    [Address(RVA = "0x127FEA0", Offset = "0x127ECA0", VA = "0x1127FEA0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005363")]
    [Address(RVA = "0x127FF80", Offset = "0x127ED80", VA = "0x1127FF80")]
    private void Update()
    {
    }

    [Token(Token = "0x6005364")]
    [Address(RVA = "0x127FFD0", Offset = "0x127EDD0", VA = "0x1127FFD0")]
    public FlowNode_FadeColor()
    {
    }
  }
}
