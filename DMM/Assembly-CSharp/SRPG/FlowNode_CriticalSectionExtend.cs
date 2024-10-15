// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CriticalSectionExtend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EDB")]
  [FlowNode.Pin(2, "Wait", FlowNode.PinTypes.Input, 2)]
  [FlowNode.NodeType("System/クリティカルセクションExtend", 16711680)]
  [FlowNode.Pin(0, "Enter", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Leave", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(10, "Out", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Finished", FlowNode.PinTypes.Output, 11)]
  public class FlowNode_CriticalSectionExtend : FlowNode
  {
    [Token(Token = "0x4002DB2")]
    private const int PINID_ENTER = 0;
    [Token(Token = "0x4002DB3")]
    private const int PINID_LEAVE = 1;
    [Token(Token = "0x4002DB4")]
    private const int PINID_WAIT = 2;
    [Token(Token = "0x4002DB5")]
    private const int PINID_OUT = 10;
    [Token(Token = "0x4002DB6")]
    private const int PINID_FINISHED = 11;
    [Token(Token = "0x4002DB7")]
    [FieldOffset(Offset = "0x18")]
    [BitMask]
    public CriticalSections Mask;

    [Token(Token = "0x6003DBA")]
    [Address(RVA = "0x10FF290", Offset = "0x10FE090", VA = "0x110FF290", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6003DBB")]
    [Address(RVA = "0x10FF350", Offset = "0x10FE150", VA = "0x110FF350")]
    private void Update()
    {
    }

    [Token(Token = "0x6003DBC")]
    [Address(RVA = "0x10FF3E0", Offset = "0x10FE1E0", VA = "0x110FF3E0")]
    public FlowNode_CriticalSectionExtend()
    {
    }
  }
}
