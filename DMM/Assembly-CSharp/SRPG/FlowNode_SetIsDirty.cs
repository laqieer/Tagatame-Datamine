// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetIsDirty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200161B")]
  [FlowNode.NodeType("System/SetIsDirty", 32741)]
  [FlowNode.Pin(1, "真理念装再読み込み", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "真理念装スキン再読み込み", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "真理刻印再読み込み", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(4, "水晶再読み込み", FlowNode.PinTypes.Input, 4)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "武具再読み込み", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_SetIsDirty : FlowNode
  {
    [Token(Token = "0x4005024")]
    private const int PIN_IN_ARTIFACT = 0;
    [Token(Token = "0x4005025")]
    private const int PIN_IN_CONCEPTCARD = 1;
    [Token(Token = "0x4005026")]
    private const int PIN_IN_SKINCONCEPTCARD = 2;
    [Token(Token = "0x4005027")]
    private const int PIN_IN_RUNE = 3;
    [Token(Token = "0x4005028")]
    private const int PIN_IN_CRYSTAL = 4;

    [Token(Token = "0x6005AEB")]
    [Address(RVA = "0x12FA1D0", Offset = "0x12F8FD0", VA = "0x112FA1D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005AEC")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetIsDirty()
    {
    }
  }
}
