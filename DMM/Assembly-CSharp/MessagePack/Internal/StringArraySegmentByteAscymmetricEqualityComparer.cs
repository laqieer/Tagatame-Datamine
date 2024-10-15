// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.StringArraySegmentByteAscymmetricEqualityComparer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x200045B")]
  internal class StringArraySegmentByteAscymmetricEqualityComparer : 
    IAsymmetricEqualityComparer<byte[], ArraySegment<byte>>
  {
    [Token(Token = "0x4000ED0")]
    [FieldOffset(Offset = "0x0")]
    private static readonly bool Is32Bit;

    [Token(Token = "0x600155F")]
    [Address(RVA = "0x5CA8B0", Offset = "0x5C96B0", VA = "0x105CA8B0", Slot = "6")]
    public bool Equals(byte[] x, byte[] y) => new bool();

    [Token(Token = "0x6001560")]
    [Address(RVA = "0x5CA920", Offset = "0x5C9720", VA = "0x105CA920", Slot = "7")]
    public bool Equals(byte[] x, ArraySegment<byte> y) => new bool();

    [Token(Token = "0x6001561")]
    [Address(RVA = "0x5CA9D0", Offset = "0x5C97D0", VA = "0x105CA9D0", Slot = "4")]
    public int GetHashCode(byte[] key1) => new int();

    [Token(Token = "0x6001562")]
    [Address(RVA = "0x5CAB30", Offset = "0x5C9930", VA = "0x105CAB30", Slot = "5")]
    public int GetHashCode(ArraySegment<byte> key2) => new int();

    [Token(Token = "0x6001563")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public StringArraySegmentByteAscymmetricEqualityComparer()
    {
    }

    [Token(Token = "0x6001564")]
    [Address(RVA = "0x5CAC30", Offset = "0x5C9A30", VA = "0x105CAC30")]
    static StringArraySegmentByteAscymmetricEqualityComparer()
    {
    }
  }
}
