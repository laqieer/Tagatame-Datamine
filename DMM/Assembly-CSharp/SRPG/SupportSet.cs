// Decompiled with JetBrains decompiler
// Type: SRPG.SupportSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B13")]
  [FlowNode.Pin(0, "Refresh", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(3, "Unit Select", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(1, "Unit Selected", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "EndRefresh", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(4, "Unit Select End", FlowNode.PinTypes.Output, 4)]
  [AddComponentMenu("UI/SupportSet")]
  public class SupportSet : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D23F")]
    [FieldOffset(Offset = "0xC")]
    public SupportList UnitList;
    [Token(Token = "0x400D240")]
    [FieldOffset(Offset = "0x10")]
    public GameObject Parent;
    [Token(Token = "0x400D241")]
    [FieldOffset(Offset = "0x14")]
    public RectTransform UnitListHilit;
    [Token(Token = "0x400D242")]
    [FieldOffset(Offset = "0x18")]
    private long SelectedUniqueId;

    [Token(Token = "0x17001A34")]
    private List<UnitData> mOwnUnits
    {
      [Token(Token = "0x600C52D"), Address(RVA = "0x8DCC50", Offset = "0x8DBA50", VA = "0x108DCC50")] get
      {
        return (List<UnitData>) null;
      }
    }

    [Token(Token = "0x600C52E")]
    [Address(RVA = "0x8DCB10", Offset = "0x8DB910", VA = "0x108DCB10")]
    private void Start()
    {
    }

    [Token(Token = "0x600C52F")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600C530")]
    [Address(RVA = "0x8DCB90", Offset = "0x8DB990", VA = "0x108DCB90")]
    public void UnitSelect(long uniqueID)
    {
    }

    [Token(Token = "0x600C531")]
    [Address(RVA = "0x8DCA60", Offset = "0x8DB860", VA = "0x108DCA60", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C532")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public SupportSet()
    {
    }
  }
}
