// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_LocalEventExtend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001425")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Event/LocalEventExtend", 58751)]
  [FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_LocalEventExtend : FlowNode
  {
    [Token(Token = "0x4004A90")]
    private const int PIN_TRIGGERED = 100;
    [Token(Token = "0x4004A91")]
    [FieldOffset(Offset = "0x18")]
    [FlowNode.ShowInInfo]
    [StringIsLocalEventID]
    public string EventName;

    [Token(Token = "0x600541E")]
    [Address(RVA = "0x128CBE0", Offset = "0x128B9E0", VA = "0x1128CBE0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600541F")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_LocalEventExtend()
    {
    }
  }
}
