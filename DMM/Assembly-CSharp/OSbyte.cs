// Decompiled with JetBrains decompiler
// Type: OSbyte
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using MessagePack;

#nullable disable
[Token(Token = "0x2000126")]
[MessagePackObject(true)]
public struct OSbyte
{
  [Token(Token = "0x400055E")]
  [FieldOffset(Offset = "0x0")]
  private ObscuredSByte value;

  [Token(Token = "0x6000743")]
  [Address(RVA = "0xD623C0", Offset = "0xD611C0", VA = "0x10D623C0")]
  public OSbyte(sbyte value)
  {
  }

  [Token(Token = "0x6000744")]
  [Address(RVA = "0xD624E0", Offset = "0xD612E0", VA = "0x10D624E0")]
  public static implicit operator OSbyte(sbyte value) => new OSbyte();

  [Token(Token = "0x6000745")]
  [Address(RVA = "0xD62490", Offset = "0xD61290", VA = "0x10D62490")]
  public static implicit operator sbyte(OSbyte value) => new sbyte();

  [Token(Token = "0x6000746")]
  [Address(RVA = "0xD62550", Offset = "0xD61350", VA = "0x10D62550")]
  public static OSbyte operator ++(OSbyte value) => new OSbyte();

  [Token(Token = "0x6000747")]
  [Address(RVA = "0xD62420", Offset = "0xD61220", VA = "0x10D62420")]
  public static OSbyte operator --(OSbyte value) => new OSbyte();

  [Token(Token = "0x6000748")]
  [Address(RVA = "0xD62370", Offset = "0xD61170", VA = "0x10D62370", Slot = "3")]
  public override string ToString() => (string) null;
}
