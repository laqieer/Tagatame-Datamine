// Decompiled with JetBrains decompiler
// Type: OBool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using MessagePack;

#nullable disable
[Token(Token = "0x200012B")]
[MessagePackObject(true)]
public struct OBool
{
  [Token(Token = "0x4000563")]
  [FieldOffset(Offset = "0x0")]
  private ObscuredBool value;

  [Token(Token = "0x600076A")]
  [Address(RVA = "0xD61390", Offset = "0xD60190", VA = "0x10D61390")]
  public OBool(bool value)
  {
  }

  [Token(Token = "0x600076B")]
  [Address(RVA = "0xD61450", Offset = "0xD60250", VA = "0x10D61450")]
  public static implicit operator OBool(bool value) => new OBool();

  [Token(Token = "0x600076C")]
  [Address(RVA = "0xD613F0", Offset = "0xD601F0", VA = "0x10D613F0")]
  public static implicit operator bool(OBool value) => new bool();

  [Token(Token = "0x600076D")]
  [Address(RVA = "0xD61340", Offset = "0xD60140", VA = "0x10D61340", Slot = "3")]
  public override string ToString() => (string) null;
}
