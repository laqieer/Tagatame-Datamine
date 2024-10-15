// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RemoveSuspendData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200147D")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Out", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "Remove", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/RemoveSuspendData", 16729156)]
  public class FlowNode_RemoveSuspendData : FlowNode
  {
    [Token(Token = "0x6005598")]
    [Address(RVA = "0x12B4540", Offset = "0x12B3340", VA = "0x112B4540", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005599")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_RemoveSuspendData()
    {
    }
  }
}
