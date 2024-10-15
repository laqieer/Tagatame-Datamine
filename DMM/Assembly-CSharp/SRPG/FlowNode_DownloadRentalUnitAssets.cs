// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_DownloadRentalUnitAssets
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018A3")]
  [FlowNode.NodeType("UnitRental/Download", 32741)]
  [FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(111, "End", FlowNode.PinTypes.Output, 111)]
  public class FlowNode_DownloadRentalUnitAssets : FlowNode
  {
    [Token(Token = "0x4005871")]
    private const int PIN_IN_START = 1;
    [Token(Token = "0x4005872")]
    private const int PIN_OUT_END = 111;

    [Token(Token = "0x6006321")]
    [Address(RVA = "0x306C40", Offset = "0x305A40", VA = "0x10306C40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006322")]
    [Address(RVA = "0x306BD0", Offset = "0x3059D0", VA = "0x10306BD0")]
    private IEnumerator Download() => (IEnumerator) null;

    [Token(Token = "0x6006323")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_DownloadRentalUnitAssets()
    {
    }
  }
}
