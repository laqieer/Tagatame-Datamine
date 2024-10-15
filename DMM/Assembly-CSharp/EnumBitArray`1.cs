// Decompiled with JetBrains decompiler
// Type: EnumBitArray`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections;

#nullable disable
[Token(Token = "0x20000D9")]
public class EnumBitArray<EnumType>
{
  [Token(Token = "0x40003BC")]
  [FieldOffset(Offset = "0x0")]
  private BitArray mBitArray;

  [Token(Token = "0x600052B")]
  private int ToIndex(EnumType type) => new int();

  [Token(Token = "0x600052C")]
  public EnumBitArray()
  {
  }

  [Token(Token = "0x170000D6")]
  [IgnoreMember]
  public bool this[EnumType type]
  {
    [Token(Token = "0x600052D")] get => new bool();
    [Token(Token = "0x600052E")] set
    {
    }
  }

  [Token(Token = "0x600052F")]
  public bool Get(EnumType type) => new bool();

  [Token(Token = "0x6000530")]
  public void Set(EnumType type, bool value)
  {
  }

  [Token(Token = "0x6000531")]
  public void SetAll(bool value)
  {
  }

  [Token(Token = "0x6000532")]
  public bool Any() => new bool();
}
