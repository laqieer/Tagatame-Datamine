// Decompiled with JetBrains decompiler
// Type: SRPG.UnitListTotalCombatPower
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C78")]
  public class UnitListTotalCombatPower : FlowWindowBase
  {
    [Token(Token = "0x400DC28")]
    [FieldOffset(Offset = "0x30")]
    private UnitListWindow m_Root;
    [Token(Token = "0x400DC29")]
    [FieldOffset(Offset = "0x34")]
    private GameObject m_TotalCombatPowerRoot;
    [Token(Token = "0x400DC2A")]
    [FieldOffset(Offset = "0x38")]
    private Text m_TotalCombatPowerTitle;
    [Token(Token = "0x400DC2B")]
    [FieldOffset(Offset = "0x3C")]
    private Text m_TotalCombatPowerText;
    [Token(Token = "0x400DC2C")]
    [FieldOffset(Offset = "0x40")]
    private Text m_TotalCombatPowerTitle2;
    [Token(Token = "0x400DC2D")]
    [FieldOffset(Offset = "0x44")]
    private Text m_TotalCombatPowerText2;

    [Token(Token = "0x17001B29")]
    public override string name
    {
      [Token(Token = "0x600CE1D"), Address(RVA = "0x9A0480", Offset = "0x99F280", VA = "0x109A0480", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600CE1E")]
    [Address(RVA = "0x99FD40", Offset = "0x99EB40", VA = "0x1099FD40", Slot = "5")]
    public override void Initialize(FlowWindowBase.SerializeParamBase param)
    {
    }

    [Token(Token = "0x600CE1F")]
    [Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")]
    public void SetRoot(UnitListWindow root)
    {
    }

    [Token(Token = "0x600CE20")]
    [Address(RVA = "0x9A0140", Offset = "0x99EF40", VA = "0x109A0140")]
    private void SetTotalCombatPowerTitle(UnitListRootWindow.Tab tabType)
    {
    }

    [Token(Token = "0x600CE21")]
    [Address(RVA = "0x9A03D0", Offset = "0x99F1D0", VA = "0x109A03D0")]
    private void SetTotalCombatPower(long totalCombatPower)
    {
    }

    [Token(Token = "0x600CE22")]
    [Address(RVA = "0x99FE00", Offset = "0x99EC00", VA = "0x1099FE00", Slot = "9")]
    public override int OnActivate(int pinId) => new int();

    [Token(Token = "0x600CE23")]
    [Address(RVA = "0x99FC00", Offset = "0x99EA00", VA = "0x1099FC00")]
    private long CalcCurrentUnitTotalCombatPower() => new long();

    [Token(Token = "0x600CE24")]
    [Address(RVA = "0x4A5B50", Offset = "0x4A4950", VA = "0x104A5B50")]
    public UnitListTotalCombatPower()
    {
    }

    [Token(Token = "0x2002C79")]
    [Serializable]
    public class SerializeParam : FlowWindowBase.SerializeParamBase
    {
      [Token(Token = "0x400DC2E")]
      [FieldOffset(Offset = "0xC")]
      public GameObject totalCombatPowerRoot;
      [Token(Token = "0x400DC2F")]
      [FieldOffset(Offset = "0x10")]
      public Text totalCombatPowerTitle;
      [Token(Token = "0x400DC30")]
      [FieldOffset(Offset = "0x14")]
      public Text totalCombatPowerText;
      [Token(Token = "0x400DC31")]
      [FieldOffset(Offset = "0x18")]
      public Text totalCombatPowerTitle2;
      [Token(Token = "0x400DC32")]
      [FieldOffset(Offset = "0x1C")]
      public Text totalCombatPowerText2;

      [Token(Token = "0x17001B2A")]
      public override System.Type type
      {
        [Token(Token = "0x600CE25"), Address(RVA = "0x991300", Offset = "0x990100", VA = "0x10991300", Slot = "4")] get
        {
          return (System.Type) null;
        }
      }

      [Token(Token = "0x600CE26")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public SerializeParam()
      {
      }
    }
  }
}
