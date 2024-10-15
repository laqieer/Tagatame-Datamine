// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MultiCacheClear
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001772")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Input", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Multi/CacheClear", 32741)]
  [FlowNode.Pin(101, "Output", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_MultiCacheClear : FlowNode
  {
    [Token(Token = "0x400542F")]
    public const int PIN_IN = 1;
    [Token(Token = "0x4005430")]
    public const int PIN_OUT = 101;

    [Token(Token = "0x6005F19")]
    [Address(RVA = "0x1339F50", Offset = "0x1338D50", VA = "0x11339F50", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F1A")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MultiCacheClear()
    {
    }
  }
}
