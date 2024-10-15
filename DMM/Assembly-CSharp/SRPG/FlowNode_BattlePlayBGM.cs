// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_BattlePlayBGM
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023CE")]
  [FlowNode.Pin(0, "再生", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "停止", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Battle/PlayBGM", 32741)]
  public class FlowNode_BattlePlayBGM : FlowNode
  {
    [Token(Token = "0x6009B26")]
    [Address(RVA = "0x5ED1E0", Offset = "0x5EBFE0", VA = "0x105ED1E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6009B27")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_BattlePlayBGM()
    {
    }
  }
}
