// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqResonanceReset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001835")]
  [FlowNode.NodeType("FlowNode_ReqResonanceReset", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqResonanceReset : FlowNode_Network
  {
    [Token(Token = "0x40056D3")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40056D4")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x40056D5")]
    public const string KEY_PARENT_UNIT_ID = "KEY_PARENT_UNIT_ID";
    [Token(Token = "0x40056D6")]
    public const string KEY_CHILD_UNIT_ID = "KEY_CHILD_UNIT_ID";
    [Token(Token = "0x40056D7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour svb;

    [Token(Token = "0x60061AE")]
    [Address(RVA = "0x1363E50", Offset = "0x1362C50", VA = "0x11363E50", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60061AF")]
    [Address(RVA = "0x1364380", Offset = "0x1363180", VA = "0x11364380")]
    private void Success()
    {
    }

    [Token(Token = "0x60061B0")]
    [Address(RVA = "0x1363FD0", Offset = "0x1362DD0", VA = "0x11363FD0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60061B1")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqResonanceReset()
    {
    }
  }
}
