// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_BattlePause
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023CD")]
  [FlowNode.NodeType("Battle/Pause", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "再開", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "一時停止", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_BattlePause : FlowNode
  {
    [Token(Token = "0x17001596")]
    private bool IsPauseAllowed
    {
      [Token(Token = "0x6009B23"), Address(RVA = "0x5ED190", Offset = "0x5EBF90", VA = "0x105ED190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009B24")]
    [Address(RVA = "0x5ED020", Offset = "0x5EBE20", VA = "0x105ED020", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6009B25")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_BattlePause()
    {
    }
  }
}
