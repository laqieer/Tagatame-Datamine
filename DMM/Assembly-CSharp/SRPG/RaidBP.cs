// Decompiled with JetBrains decompiler
// Type: SRPG.RaidBP
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010E1")]
  public class RaidBP
  {
    [Token(Token = "0x4003CF9")]
    [FieldOffset(Offset = "0x8")]
    private int mCurrent;
    [Token(Token = "0x4003CFA")]
    [FieldOffset(Offset = "0xC")]
    private int mMax;
    [Token(Token = "0x4003CFB")]
    [FieldOffset(Offset = "0x10")]
    private DateTime mAt;
    [Token(Token = "0x4003CFC")]
    [FieldOffset(Offset = "0x18")]
    private int mAddBPMinutes;

    [Token(Token = "0x1700072D")]
    public int Current
    {
      [Token(Token = "0x6004758"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700072E")]
    public int Max
    {
      [Token(Token = "0x6004759"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700072F")]
    public DateTime At
    {
      [Token(Token = "0x600475A"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x600475B")]
    [Address(RVA = "0x11E7EE0", Offset = "0x11E6CE0", VA = "0x111E7EE0")]
    public RaidBP(int addBPMinutes)
    {
    }

    [Token(Token = "0x600475C")]
    [Address(RVA = "0x11E7E20", Offset = "0x11E6C20", VA = "0x111E7E20")]
    public bool Deserialize(Json_RaidBP json) => new bool();

    [Token(Token = "0x600475D")]
    [Address(RVA = "0x319740", Offset = "0x318540", VA = "0x10319740")]
    public void AddPoint()
    {
    }

    [Token(Token = "0x600475E")]
    [Address(RVA = "0x11E7DB0", Offset = "0x11E6BB0", VA = "0x111E7DB0")]
    public void AddMinutes()
    {
    }
  }
}
