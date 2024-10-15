// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GenesisCacheClear
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200168A")]
  [FlowNode.NodeType("Genesis/CacheClear", 32741)]
  [FlowNode.Pin(1, "Input", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Output", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_GenesisCacheClear : FlowNode
  {
    [Token(Token = "0x40051F0")]
    public const int PIN_IN = 1;
    [Token(Token = "0x40051F1")]
    public const int PIN_OUT = 101;
    [Token(Token = "0x40051F2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool GlobalVarsClear;

    [Token(Token = "0x6005C77")]
    [Address(RVA = "0x13070B0", Offset = "0x1305EB0", VA = "0x113070B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C78")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_GenesisCacheClear()
    {
    }
  }
}
