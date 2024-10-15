// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CriticalSection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000ED8")]
  [FlowNode.NodeType("System/クリティカルセクション", 16711680)]
  [FlowNode.Pin(0, "Enter", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Out", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "Leave", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Wait", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("")]
  [FlowNode.Pin(11, "Finished", FlowNode.PinTypes.Output, 11)]
  public class FlowNode_CriticalSection : FlowNode
  {
    [Token(Token = "0x4002DA8")]
    private const int PINID_ENTER = 0;
    [Token(Token = "0x4002DA9")]
    private const int PINID_LEAVE = 1;
    [Token(Token = "0x4002DAA")]
    private const int PINID_WAIT = 2;
    [Token(Token = "0x4002DAB")]
    private const int PINID_OUT = 10;
    [Token(Token = "0x4002DAC")]
    private const int PINID_FINISHED = 11;
    [Token(Token = "0x4002DAD")]
    [FieldOffset(Offset = "0x18")]
    [BitMask]
    public CriticalSections Mask;

    [Token(Token = "0x6003DAA")]
    [Address(RVA = "0x10FF400", Offset = "0x10FE200", VA = "0x110FF400", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6003DAB")]
    [Address(RVA = "0x10FF4B0", Offset = "0x10FE2B0", VA = "0x110FF4B0")]
    private void Update()
    {
    }

    [Token(Token = "0x6003DAC")]
    [Address(RVA = "0x10FF3E0", Offset = "0x10FE1E0", VA = "0x110FF3E0")]
    public FlowNode_CriticalSection()
    {
    }
  }
}
