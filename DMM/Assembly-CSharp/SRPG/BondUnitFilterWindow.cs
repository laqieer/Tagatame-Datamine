// Decompiled with JetBrains decompiler
// Type: SRPG.BondUnitFilterWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020D7")]
  [AddComponentMenu("UI/Bond/BondUnitFilterWindow")]
  public class BondUnitFilterWindow : PlayerUnitSelectWindow
  {
    [Token(Token = "0x4008DCB")]
    [FieldOffset(Offset = "0x58")]
    private List<string> mAllGroupUnitInames;

    [Token(Token = "0x60088EC")]
    [Address(RVA = "0x4A25D0", Offset = "0x4A13D0", VA = "0x104A25D0")]
    private void Awake()
    {
    }

    [Token(Token = "0x60088ED")]
    [Address(RVA = "0x4A2620", Offset = "0x4A1420", VA = "0x104A2620", Slot = "7")]
    public override void Initialized()
    {
    }

    [Token(Token = "0x60088EE")]
    [Address(RVA = "0x4A3100", Offset = "0x4A1F00", VA = "0x104A3100", Slot = "8")]
    public override void Refresh()
    {
    }

    [Token(Token = "0x60088EF")]
    [Address(RVA = "0x4A3030", Offset = "0x4A1E30", VA = "0x104A3030", Slot = "9")]
    public override bool OnFinishSave() => new bool();

    [Token(Token = "0x60088F0")]
    [Address(RVA = "0x4A37F0", Offset = "0x4A25F0", VA = "0x104A37F0")]
    public BondUnitFilterWindow()
    {
    }
  }
}
