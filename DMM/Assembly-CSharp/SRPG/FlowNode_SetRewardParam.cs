// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001622")]
  [FlowNode.Pin(1, "Assign", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(9, "Assigned", FlowNode.PinTypes.Output, 9)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Reward/Set", 32741)]
  public class FlowNode_SetRewardParam : FlowNode
  {
    [Token(Token = "0x4005036")]
    [FieldOffset(Offset = "0x18")]
    public GameObject target;
    [Token(Token = "0x4005037")]
    [FieldOffset(Offset = "0x1C")]
    public FlowNode_SetRewardParam.Type type;

    [Token(Token = "0x6005B03")]
    [Address(RVA = "0x12FBB10", Offset = "0x12FA910", VA = "0x112FBB10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B04")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetRewardParam()
    {
    }

    [Token(Token = "0x2001623")]
    public enum Type
    {
      [Token(Token = "0x4005039")] Item,
      [Token(Token = "0x400503A")] Unit,
      [Token(Token = "0x400503B")] Artifact,
      [Token(Token = "0x400503C")] Award,
    }
  }
}
