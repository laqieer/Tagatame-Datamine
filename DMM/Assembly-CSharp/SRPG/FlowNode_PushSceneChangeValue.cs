// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PushSceneChangeValue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001731")]
  [FlowNode.Pin(2, "In(with SerializeValueList)", FlowNode.PinTypes.Input, 2)]
  [FlowNode.NodeType("Home/Scene/PushChangeValue", 32741)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_PushSceneChangeValue : FlowNode
  {
    [Token(Token = "0x4005376")]
    private const int PIN_IN = 1;
    [Token(Token = "0x4005377")]
    private const int PIN_IN_SVL = 2;
    [Token(Token = "0x4005378")]
    private const int PIN_OUT = 100;
    [Token(Token = "0x4005379")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SerializeValueList _valueList;

    [Token(Token = "0x6005E5E")]
    [Address(RVA = "0x1319B90", Offset = "0x1318990", VA = "0x11319B90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E5F")]
    [Address(RVA = "0x1319C60", Offset = "0x1318A60", VA = "0x11319C60", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6005E60")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_PushSceneChangeValue()
    {
    }
  }
}
