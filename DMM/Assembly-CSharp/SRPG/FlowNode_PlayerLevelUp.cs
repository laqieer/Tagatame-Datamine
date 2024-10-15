// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PlayerLevelUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001457")]
  [FlowNode.NodeType("Battle/プレイヤーレベルアップ", 32741)]
  [FlowNode.Pin(0, "実行", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "レベルアップした", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "レベルアップしなかった", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  public class FlowNode_PlayerLevelUp : FlowNode
  {
    [Token(Token = "0x6005524")]
    [Address(RVA = "0x1298E40", Offset = "0x1297C40", VA = "0x11298E40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005525")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_PlayerLevelUp()
    {
    }
  }
}
