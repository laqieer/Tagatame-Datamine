// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_LeagueMatchScheduleCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001358")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "output", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "input", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("BulkRelease", 32741)]
  public class FlowNode_LeagueMatchScheduleCheck : FlowNode
  {
    [Token(Token = "0x400478E")]
    private const int PIN_IN_INPUT = 1;
    [Token(Token = "0x400478F")]
    private const int PIN_OUT_OUTPUT = 101;
    [Token(Token = "0x4004790")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;

    [Token(Token = "0x600513D")]
    [Address(RVA = "0x1275770", Offset = "0x1274570", VA = "0x11275770", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600513E")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_LeagueMatchScheduleCheck()
    {
    }
  }
}
