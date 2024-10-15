// Decompiled with JetBrains decompiler
// Type: MessagePack.Nil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x200036C")]
  public struct Nil : IEquatable<Nil>
  {
    [Token(Token = "0x4000DDF")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Nil Default;

    [Token(Token = "0x60012C4")]
    [Address(RVA = "0x4DCB90", Offset = "0x4DB990", VA = "0x104DCB90", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x60012C5")]
    [Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "4")]
    public bool Equals(Nil other) => new bool();

    [Token(Token = "0x60012C6")]
    [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x60012C7")]
    [Address(RVA = "0x4DCBD0", Offset = "0x4DB9D0", VA = "0x104DCBD0", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x60012C8")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    static Nil()
    {
    }
  }
}
