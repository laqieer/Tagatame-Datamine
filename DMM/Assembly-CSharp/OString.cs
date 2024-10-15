// Decompiled with JetBrains decompiler
// Type: OString
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using MessagePack;

#nullable disable
[Token(Token = "0x200012C")]
[MessagePackObject(true)]
public struct OString
{
  [Token(Token = "0x4000564")]
  [FieldOffset(Offset = "0x0")]
  private ObscuredString value;

  [Token(Token = "0x600076E")]
  [Address(RVA = "0xD62A60", Offset = "0xD61860", VA = "0x10D62A60")]
  public OString(string value)
  {
  }

  [Token(Token = "0x600076F")]
  [Address(RVA = "0xD62B00", Offset = "0xD61900", VA = "0x10D62B00")]
  public static implicit operator OString(string value) => new OString();

  [Token(Token = "0x6000770")]
  [Address(RVA = "0xD62AB0", Offset = "0xD618B0", VA = "0x10D62AB0")]
  public static implicit operator string(OString value) => (string) null;

  [Token(Token = "0x6000771")]
  [Address(RVA = "0xD62A30", Offset = "0xD61830", VA = "0x10D62A30", Slot = "3")]
  public override string ToString() => (string) null;
}
