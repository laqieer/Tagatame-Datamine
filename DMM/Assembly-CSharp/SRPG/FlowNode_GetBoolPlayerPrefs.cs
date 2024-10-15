// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GetBoolPlayerPrefs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013F3")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/PlayerPrefs/GetBoolPlayerPrefs", 32741)]
  [FlowNode.Pin(2, "Check", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "True", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "False", FlowNode.PinTypes.Output, 0)]
  public class FlowNode_GetBoolPlayerPrefs : FlowNode
  {
    [Token(Token = "0x40049E9")]
    [FieldOffset(Offset = "0x18")]
    public string Name;
    [Token(Token = "0x40049EA")]
    private const int CHECK = 2;
    [Token(Token = "0x40049EB")]
    private const int GET_FALSE = 0;
    [Token(Token = "0x40049EC")]
    private const int GET_TRUE = 1;

    [Token(Token = "0x6005387")]
    [Address(RVA = "0x12814B0", Offset = "0x12802B0", VA = "0x112814B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005388")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_GetBoolPlayerPrefs()
    {
    }
  }
}
