// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckHomeWorldRaid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018AC")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "演出発生", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("WorldRaid/CheckHomeWorldRaid", 32741)]
  [FlowNode.Pin(102, "発生しない", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(1, "演出発生確認", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_CheckHomeWorldRaid : FlowNode
  {
    [Token(Token = "0x4005883")]
    private const int CHECK_START = 1;
    [Token(Token = "0x4005884")]
    private const int CHECK_TRUE = 101;
    [Token(Token = "0x4005885")]
    private const int CHECK_FALSE = 102;
    [Token(Token = "0x4005886")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool IsSaveFlag;

    [Token(Token = "0x600633B")]
    [Address(RVA = "0x305FA0", Offset = "0x304DA0", VA = "0x10305FA0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600633C")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckHomeWorldRaid()
    {
    }
  }
}
