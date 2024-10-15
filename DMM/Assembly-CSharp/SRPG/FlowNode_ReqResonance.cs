// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqResonance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001834")]
  [FlowNode.NodeType("Resonance/FlowNode_ReqResonance", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqResonance : FlowNode_Network
  {
    [Token(Token = "0x40056CE")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40056CF")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x40056D0")]
    public const string KEY_PARENT_UNIT_ID = "KEY_PARENT_UNIT_ID";
    [Token(Token = "0x40056D1")]
    public const string KEY_CHILD_UNIT_ID = "KEY_CHILD_UNIT_ID";
    [Token(Token = "0x40056D2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour svb;

    [Token(Token = "0x60061A9")]
    [Address(RVA = "0x13643F0", Offset = "0x13631F0", VA = "0x113643F0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60061AA")]
    [Address(RVA = "0x1364990", Offset = "0x1363790", VA = "0x11364990")]
    private void Success()
    {
    }

    [Token(Token = "0x60061AB")]
    [Address(RVA = "0x1364570", Offset = "0x1363370", VA = "0x11364570", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60061AC")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqResonance()
    {
    }
  }
}
