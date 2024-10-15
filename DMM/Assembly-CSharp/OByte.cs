// Decompiled with JetBrains decompiler
// Type: OByte
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using MessagePack;

#nullable disable
[Token(Token = "0x2000125")]
[MessagePackObject(true)]
public struct OByte
{
  [Token(Token = "0x400055D")]
  [FieldOffset(Offset = "0x0")]
  private ObscuredByte value;

  [Token(Token = "0x600073D")]
  [Address(RVA = "0xD61510", Offset = "0xD60310", VA = "0x10D61510")]
  public OByte(byte value)
  {
  }

  [Token(Token = "0x600073E")]
  [Address(RVA = "0xD615E0", Offset = "0xD603E0", VA = "0x10D615E0")]
  public static implicit operator OByte(byte value) => new OByte();

  [Token(Token = "0x600073F")]
  [Address(RVA = "0xD61650", Offset = "0xD60450", VA = "0x10D61650")]
  public static implicit operator byte(OByte value) => new byte();

  [Token(Token = "0x6000740")]
  [Address(RVA = "0xD616A0", Offset = "0xD604A0", VA = "0x10D616A0")]
  public static OByte operator ++(OByte value) => new OByte();

  [Token(Token = "0x6000741")]
  [Address(RVA = "0xD61570", Offset = "0xD60370", VA = "0x10D61570")]
  public static OByte operator --(OByte value) => new OByte();

  [Token(Token = "0x6000742")]
  [Address(RVA = "0xD614C0", Offset = "0xD602C0", VA = "0x10D614C0", Slot = "3")]
  public override string ToString() => (string) null;
}
