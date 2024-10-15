// Decompiled with JetBrains decompiler
// Type: SRPG.SupportUnitUsed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B16")]
  public class SupportUnitUsed
  {
    [Token(Token = "0x400D24D")]
    [FieldOffset(Offset = "0x8")]
    public UnitData unit;
    [Token(Token = "0x400D24E")]
    [FieldOffset(Offset = "0x10")]
    public DateTime from;
    [Token(Token = "0x400D24F")]
    [FieldOffset(Offset = "0x18")]
    public int times;
    [Token(Token = "0x400D250")]
    [FieldOffset(Offset = "0x20")]
    public DateTime last;
    [Token(Token = "0x400D251")]
    [FieldOffset(Offset = "0x28")]
    public int gold;
    [Token(Token = "0x400D252")]
    [FieldOffset(Offset = "0x2C")]
    public EElement element;

    [Token(Token = "0x600C53E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SupportUnitUsed()
    {
    }
  }
}
