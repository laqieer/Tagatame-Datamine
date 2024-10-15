// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_JudgeActionReleaseStartPart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001414")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("SRPG/ストーリーパート解放演出を見せるか判断", 32741)]
  [FlowNode.Pin(0, "イン", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "解放演出を見せる", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "解放演出を見ない", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_JudgeActionReleaseStartPart : FlowNode
  {
    [Token(Token = "0x60053E7")]
    [Address(RVA = "0x12866B0", Offset = "0x12854B0", VA = "0x112866B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60053E8")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_JudgeActionReleaseStartPart()
    {
    }
  }
}
