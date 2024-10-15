// Decompiled with JetBrains decompiler
// Type: OLong
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using MessagePack;

#nullable disable
[Token(Token = "0x200012A")]
[MessagePackObject(true)]
public struct OLong
{
  [Token(Token = "0x4000562")]
  [FieldOffset(Offset = "0x0")]
  private ObscuredLong value;

  [Token(Token = "0x6000764")]
  [Address(RVA = "0xD62150", Offset = "0xD60F50", VA = "0x10D62150")]
  public OLong(long value)
  {
  }

  [Token(Token = "0x6000765")]
  [Address(RVA = "0xD622B0", Offset = "0xD610B0", VA = "0x10D622B0")]
  public static implicit operator OLong(long value) => new OLong();

  [Token(Token = "0x6000766")]
  [Address(RVA = "0xD62250", Offset = "0xD61050", VA = "0x10D62250")]
  public static implicit operator long(OLong value) => new long();

  [Token(Token = "0x6000767")]
  [Address(RVA = "0xD622E0", Offset = "0xD610E0", VA = "0x10D622E0")]
  public static OLong operator ++(OLong value) => new OLong();

  [Token(Token = "0x6000768")]
  [Address(RVA = "0xD621C0", Offset = "0xD60FC0", VA = "0x10D621C0")]
  public static OLong operator --(OLong value) => new OLong();

  [Token(Token = "0x6000769")]
  [Address(RVA = "0xD62100", Offset = "0xD60F00", VA = "0x10D62100", Slot = "3")]
  public override string ToString() => (string) null;
}
