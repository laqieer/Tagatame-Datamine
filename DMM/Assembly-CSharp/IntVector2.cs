// Decompiled with JetBrains decompiler
// Type: IntVector2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x2000105")]
[Serializable]
public struct IntVector2
{
  [Token(Token = "0x40004D7")]
  [FieldOffset(Offset = "0x0")]
  public int x;
  [Token(Token = "0x40004D8")]
  [FieldOffset(Offset = "0x4")]
  public int y;

  [Token(Token = "0x60006B7")]
  [Address(RVA = "0x290D40", Offset = "0x28FB40", VA = "0x10290D40")]
  public IntVector2(int a, int b)
  {
  }

  [Token(Token = "0x60006B8")]
  [Address(RVA = "0xD5A6C0", Offset = "0xD594C0", VA = "0x10D5A6C0", Slot = "3")]
  public override string ToString() => (string) null;

  [Token(Token = "0x60006B9")]
  [Address(RVA = "0xD5A740", Offset = "0xD59540", VA = "0x10D5A740")]
  public static bool operator ==(IntVector2 a, IntVector2 b) => new bool();

  [Token(Token = "0x60006BA")]
  [Address(RVA = "0xD5A760", Offset = "0xD59560", VA = "0x10D5A760")]
  public static bool operator !=(IntVector2 a, IntVector2 b) => new bool();

  [Token(Token = "0x60006BB")]
  [Address(RVA = "0xD5A5F0", Offset = "0xD593F0", VA = "0x10D5A5F0", Slot = "0")]
  public override bool Equals(object obj) => new bool();

  [Token(Token = "0x60006BC")]
  [Address(RVA = "0xD5A670", Offset = "0xD59470", VA = "0x10D5A670", Slot = "2")]
  public override int GetHashCode() => new int();
}
