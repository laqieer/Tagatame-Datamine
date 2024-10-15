// Decompiled with JetBrains decompiler
// Type: OIntVector2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
[Token(Token = "0x200012D")]
[MessagePackObject(true)]
public struct OIntVector2
{
  [Token(Token = "0x4000565")]
  [FieldOffset(Offset = "0x0")]
  public OInt x;
  [Token(Token = "0x4000566")]
  [FieldOffset(Offset = "0x14")]
  public OInt y;

  [Token(Token = "0x6000772")]
  [Address(RVA = "0xD619B0", Offset = "0xD607B0", VA = "0x10D619B0")]
  public OIntVector2(int a, int b)
  {
  }

  [Token(Token = "0x6000773")]
  [Address(RVA = "0xD61920", Offset = "0xD60720", VA = "0x10D61920", Slot = "3")]
  public override string ToString() => (string) null;

  [Token(Token = "0x6000774")]
  [Address(RVA = "0xD61A60", Offset = "0xD60860", VA = "0x10D61A60")]
  public static bool operator ==(OIntVector2 a, OIntVector2 b) => new bool();

  [Token(Token = "0x6000775")]
  [Address(RVA = "0xD61B50", Offset = "0xD60950", VA = "0x10D61B50")]
  public static bool operator !=(OIntVector2 a, OIntVector2 b) => new bool();

  [Token(Token = "0x6000776")]
  [Address(RVA = "0xD61710", Offset = "0xD60510", VA = "0x10D61710", Slot = "0")]
  public override bool Equals(object obj) => new bool();

  [Token(Token = "0x6000777")]
  [Address(RVA = "0xD618C0", Offset = "0xD606C0", VA = "0x10D618C0", Slot = "2")]
  public override int GetHashCode() => new int();
}
