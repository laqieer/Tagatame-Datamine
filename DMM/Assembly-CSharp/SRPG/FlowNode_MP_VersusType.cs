// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_VersusType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017F4")]
  [FlowNode.Pin(1, "Set Free", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(202, "Test NG", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(201, "Test OK", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(101, "Finish", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(11, "Test", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(4, "Set RankMatch", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(3, "Set CPU", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "Set Friend", FlowNode.PinTypes.Input, 2)]
  [FlowNode.NodeType("MultiPlay/Versus/Type", 32741)]
  public class FlowNode_MP_VersusType : FlowNode
  {
    [Token(Token = "0x400563F")]
    private const int PIN_IN_SET_FREE = 1;
    [Token(Token = "0x4005640")]
    private const int PIN_IN_SET_FRIEND = 2;
    [Token(Token = "0x4005641")]
    private const int PIN_IN_SET_CPU = 3;
    [Token(Token = "0x4005642")]
    private const int PIN_IN_SET_RANKMATCH = 4;
    [Token(Token = "0x4005643")]
    private const int PIN_IN_TEST = 11;
    [Token(Token = "0x4005644")]
    private const int PIN_OUT_FINISH = 101;
    [Token(Token = "0x4005645")]
    private const int PIN_OUT_TEST_OK = 201;
    [Token(Token = "0x4005646")]
    private const int PIN_OUT_TEST_NG = 202;
    [Token(Token = "0x4005647")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private VERSUS_TYPE type;

    [Token(Token = "0x60060E4")]
    [Address(RVA = "0x135AC70", Offset = "0x1359A70", VA = "0x1135AC70", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060E5")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_VersusType()
    {
    }
  }
}
