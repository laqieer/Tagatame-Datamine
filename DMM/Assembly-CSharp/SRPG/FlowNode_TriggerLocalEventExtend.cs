// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_TriggerLocalEventExtend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200165A")]
  [FlowNode.NodeType("Event/TriggerLocalEventExtend", 32741)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_TriggerLocalEventExtend : FlowNode
  {
    [Token(Token = "0x4005129")]
    private const int PIN_IN = 1;
    [Token(Token = "0x400512A")]
    private const int PIN_OUT = 100;
    [Token(Token = "0x400512B")]
    [FieldOffset(Offset = "0x18")]
    [StringIsLocalEventID]
    public string EventName;

    [Token(Token = "0x6005BC7")]
    [Address(RVA = "0x13112E0", Offset = "0x13100E0", VA = "0x113112E0", Slot = "6")]
    public override string[] GetInfoLines() => (string[]) null;

    [Token(Token = "0x6005BC8")]
    [Address(RVA = "0x13113A0", Offset = "0x13101A0", VA = "0x113113A0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6005BC9")]
    [Address(RVA = "0x13114B0", Offset = "0x13102B0", VA = "0x113114B0")]
    public static void TriggerLocalEvent(
      Component caller,
      string EventName,
      SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6005BCA")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_TriggerLocalEventExtend()
    {
    }
  }
}
