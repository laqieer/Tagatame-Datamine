// Decompiled with JetBrains decompiler
// Type: OUInt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using MessagePack;

#nullable disable
[Token(Token = "0x2000129")]
[MessagePackObject(true)]
public struct OUInt
{
  [Token(Token = "0x4000561")]
  [FieldOffset(Offset = "0x0")]
  private ObscuredUInt value;

  [Token(Token = "0x600075D")]
  [Address(RVA = "0xD62C00", Offset = "0xD61A00", VA = "0x10D62C00")]
  public OUInt(uint value)
  {
  }

  [Token(Token = "0x600075E")]
  [Address(RVA = "0xD62D30", Offset = "0xD61B30", VA = "0x10D62D30")]
  public static implicit operator OUInt(uint value) => new OUInt();

  [Token(Token = "0x600075F")]
  [Address(RVA = "0xD62CD0", Offset = "0xD61AD0", VA = "0x10D62CD0")]
  public static implicit operator uint(OUInt value) => new uint();

  [Token(Token = "0x6000760")]
  [Address(RVA = "0xD62DA0", Offset = "0xD61BA0", VA = "0x10D62DA0")]
  public static OUInt operator ++(OUInt value) => new OUInt();

  [Token(Token = "0x6000761")]
  [Address(RVA = "0xD62C60", Offset = "0xD61A60", VA = "0x10D62C60")]
  public static OUInt operator --(OUInt value) => new OUInt();

  [Token(Token = "0x6000762")]
  [Address(RVA = "0xD62BB0", Offset = "0xD619B0", VA = "0x10D62BB0", Slot = "3")]
  public override string ToString() => (string) null;

  [Token(Token = "0x6000763")]
  [Address(RVA = "0xD62B60", Offset = "0xD61960", VA = "0x10D62B60")]
  public string ToString(string format) => (string) null;
}
