// Decompiled with JetBrains decompiler
// Type: OShort
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using MessagePack;

#nullable disable
[Token(Token = "0x2000127")]
[MessagePackObject(true)]
public struct OShort
{
  [Token(Token = "0x400055F")]
  [FieldOffset(Offset = "0x0")]
  private ObscuredShort value;

  [Token(Token = "0x6000749")]
  [Address(RVA = "0xD62670", Offset = "0xD61470", VA = "0x10D62670")]
  public OShort(short value)
  {
  }

  [Token(Token = "0x600074A")]
  [Address(RVA = "0xD62610", Offset = "0xD61410", VA = "0x10D62610")]
  public OShort(int value)
  {
  }

  [Token(Token = "0x600074B")]
  [Address(RVA = "0xD62810", Offset = "0xD61610", VA = "0x10D62810")]
  public static implicit operator OShort(short value) => new OShort();

  [Token(Token = "0x600074C")]
  [Address(RVA = "0xD62950", Offset = "0xD61750", VA = "0x10D62950")]
  public static implicit operator short(OShort value) => new short();

  [Token(Token = "0x600074D")]
  [Address(RVA = "0xD628F0", Offset = "0xD616F0", VA = "0x10D628F0")]
  public static implicit operator int(OShort value) => new int();

  [Token(Token = "0x600074E")]
  [Address(RVA = "0xD62750", Offset = "0xD61550", VA = "0x10D62750")]
  public static implicit operator OShort(OInt value) => new OShort();

  [Token(Token = "0x600074F")]
  [Address(RVA = "0xD62880", Offset = "0xD61680", VA = "0x10D62880")]
  public static implicit operator OShort(int value) => new OShort();

  [Token(Token = "0x6000750")]
  [Address(RVA = "0xD629B0", Offset = "0xD617B0", VA = "0x10D629B0")]
  public static OShort operator ++(OShort value) => new OShort();

  [Token(Token = "0x6000751")]
  [Address(RVA = "0xD626D0", Offset = "0xD614D0", VA = "0x10D626D0")]
  public static OShort operator --(OShort value) => new OShort();

  [Token(Token = "0x6000752")]
  [Address(RVA = "0xD625C0", Offset = "0xD613C0", VA = "0x10D625C0", Slot = "3")]
  public override string ToString() => (string) null;
}
