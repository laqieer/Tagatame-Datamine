// Decompiled with JetBrains decompiler
// Type: OInt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using MessagePack;

#nullable disable
[Token(Token = "0x2000128")]
[MessagePackObject(true)]
public struct OInt
{
  [Token(Token = "0x4000560")]
  [FieldOffset(Offset = "0x0")]
  private ObscuredInt value;

  [Token(Token = "0x6000753")]
  [Address(RVA = "0xD61C90", Offset = "0xD60A90", VA = "0x10D61C90")]
  public OInt(int value)
  {
  }

  [Token(Token = "0x6000754")]
  [Address(RVA = "0xD61E20", Offset = "0xD60C20", VA = "0x10D61E20")]
  public static implicit operator OInt(int value) => new OInt();

  [Token(Token = "0x6000755")]
  [Address(RVA = "0xD61F70", Offset = "0xD60D70", VA = "0x10D61F70")]
  public static implicit operator int(OInt value) => new int();

  [Token(Token = "0x6000756")]
  [Address(RVA = "0xD61F00", Offset = "0xD60D00", VA = "0x10D61F00")]
  public static implicit operator OInt(short value) => new OInt();

  [Token(Token = "0x6000757")]
  [Address(RVA = "0xD61FD0", Offset = "0xD60DD0", VA = "0x10D61FD0")]
  public static implicit operator OInt(OShort value) => new OInt();

  [Token(Token = "0x6000758")]
  [Address(RVA = "0xD61E90", Offset = "0xD60C90", VA = "0x10D61E90")]
  public static implicit operator OInt(sbyte value) => new OInt();

  [Token(Token = "0x6000759")]
  [Address(RVA = "0xD61D60", Offset = "0xD60B60", VA = "0x10D61D60")]
  public static implicit operator OInt(OSbyte value) => new OInt();

  [Token(Token = "0x600075A")]
  [Address(RVA = "0xD62090", Offset = "0xD60E90", VA = "0x10D62090")]
  public static OInt operator ++(OInt value) => new OInt();

  [Token(Token = "0x600075B")]
  [Address(RVA = "0xD61CF0", Offset = "0xD60AF0", VA = "0x10D61CF0")]
  public static OInt operator --(OInt value) => new OInt();

  [Token(Token = "0x600075C")]
  [Address(RVA = "0xD61C40", Offset = "0xD60A40", VA = "0x10D61C40", Slot = "3")]
  public override string ToString() => (string) null;
}
