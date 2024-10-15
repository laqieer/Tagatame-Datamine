// Decompiled with JetBrains decompiler
// Type: SRPG.ChallengeCategoryParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A42")]
  public class ChallengeCategoryParam
  {
    [Token(Token = "0x40060B8")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40060B9")]
    [FieldOffset(Offset = "0xC")]
    public TimeParser begin_at;
    [Token(Token = "0x40060BA")]
    [FieldOffset(Offset = "0x10")]
    public TimeParser end_at;
    [Token(Token = "0x40060BB")]
    [FieldOffset(Offset = "0x14")]
    public int prio;
    [Token(Token = "0x40060BC")]
    [FieldOffset(Offset = "0x18")]
    public TimeParser beginner_period;

    [Token(Token = "0x17000BBF")]
    public int Priority
    {
      [Token(Token = "0x6006BFB"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006BFC")]
    [Address(RVA = "0x34FDD0", Offset = "0x34EBD0", VA = "0x1034FDD0")]
    public bool Deserialize(JSON_ChallengeCategoryParam json) => new bool();

    [Token(Token = "0x6006BFD")]
    [Address(RVA = "0x34FEC0", Offset = "0x34ECC0", VA = "0x1034FEC0")]
    public bool IsAvailablePeriod(DateTime now) => new bool();

    [Token(Token = "0x6006BFE")]
    [Address(RVA = "0x350000", Offset = "0x34EE00", VA = "0x10350000")]
    public ChallengeCategoryParam()
    {
    }
  }
}
