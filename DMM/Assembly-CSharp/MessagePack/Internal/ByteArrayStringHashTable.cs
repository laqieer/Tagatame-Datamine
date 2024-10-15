// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.ByteArrayStringHashTable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x2000466")]
  public class ByteArrayStringHashTable : IEnumerable<KeyValuePair<string, int>>, IEnumerable
  {
    [Token(Token = "0x4000EF2")]
    [FieldOffset(Offset = "0x8")]
    private readonly ByteArrayStringHashTable.Entry[][] buckets;
    [Token(Token = "0x4000EF3")]
    [FieldOffset(Offset = "0x10")]
    private readonly ulong indexFor;
    [Token(Token = "0x4000EF4")]
    [FieldOffset(Offset = "0x0")]
    private static readonly bool Is32Bit;

    [Token(Token = "0x60015A3")]
    [Address(RVA = "0x5BDB10", Offset = "0x5BC910", VA = "0x105BDB10")]
    public ByteArrayStringHashTable(int capacity)
    {
    }

    [Token(Token = "0x60015A4")]
    [Address(RVA = "0x5BDA50", Offset = "0x5BC850", VA = "0x105BDA50")]
    public ByteArrayStringHashTable(int capacity, float loadFactor)
    {
    }

    [Token(Token = "0x60015A5")]
    [Address(RVA = "0x5BD320", Offset = "0x5BC120", VA = "0x105BD320")]
    public void Add(string key, int value)
    {
    }

    [Token(Token = "0x60015A6")]
    [Address(RVA = "0x5BD280", Offset = "0x5BC080", VA = "0x105BD280")]
    public void Add(byte[] key, int value)
    {
    }

    [Token(Token = "0x60015A7")]
    [Address(RVA = "0x5BD520", Offset = "0x5BC320", VA = "0x105BD520")]
    private bool TryAddInternal(byte[] key, int value) => new bool();

    [Token(Token = "0x60015A8")]
    [Address(RVA = "0x5BD7D0", Offset = "0x5BC5D0", VA = "0x105BD7D0")]
    public bool TryGetValue(ArraySegment<byte> key, out int value) => new bool();

    [Token(Token = "0x60015A9")]
    [Address(RVA = "0x5BD3C0", Offset = "0x5BC1C0", VA = "0x105BD3C0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ulong ByteArrayGetHashCode(byte[] x, int offset, int count) => new ulong();

    [Token(Token = "0x60015AA")]
    [Address(RVA = "0x5BD470", Offset = "0x5BC270", VA = "0x105BD470")]
    private static int CalculateCapacity(int collectionSize, float loadFactor) => new int();

    [Token(Token = "0x60015AB")]
    [Address(RVA = "0x5BD4B0", Offset = "0x5BC2B0", VA = "0x105BD4B0", Slot = "4")]
    public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
    {
      return (IEnumerator<KeyValuePair<string, int>>) null;
    }

    [Token(Token = "0x60015AC")]
    [Address(RVA = "0x5BD4B0", Offset = "0x5BC2B0", VA = "0x105BD4B0", Slot = "5")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60015AD")]
    [Address(RVA = "0x5BDA10", Offset = "0x5BC810", VA = "0x105BDA10")]
    static ByteArrayStringHashTable()
    {
    }

    [Token(Token = "0x2000467")]
    private struct Entry
    {
      [Token(Token = "0x4000EF5")]
      [FieldOffset(Offset = "0x0")]
      public byte[] Key;
      [Token(Token = "0x4000EF6")]
      [FieldOffset(Offset = "0x4")]
      public int Value;

      [Token(Token = "0x60015AE")]
      [Address(RVA = "0x5BDBD0", Offset = "0x5BC9D0", VA = "0x105BDBD0", Slot = "3")]
      public override string ToString() => (string) null;
    }
  }
}
