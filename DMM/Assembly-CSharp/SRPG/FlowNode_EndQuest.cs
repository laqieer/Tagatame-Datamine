// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_EndQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023D3")]
  [FlowNode.Pin(0, "End", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(101, "ForceEnded", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "ForceEnd", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("System/クエスト終了", 32741)]
  public class FlowNode_EndQuest : FlowNode
  {
    [Token(Token = "0x400A218")]
    [FieldOffset(Offset = "0x18")]
    public bool Restart;

    [Token(Token = "0x6009BC8")]
    [Address(RVA = "0x5EF230", Offset = "0x5EE030", VA = "0x105EF230", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6009BC9")]
    [Address(RVA = "0x5EF440", Offset = "0x5EE240", VA = "0x105EF440")]
    private void Update()
    {
    }

    [Token(Token = "0x6009BCA")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_EndQuest()
    {
    }
  }
}
