// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.AsymmetricKeyHashTable`3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x200045C")]
  internal sealed class AsymmetricKeyHashTable<TKey1, TKey2, TValue>
  {
    [Token(Token = "0x4000ED1")]
    [FieldOffset(Offset = "0x0")]
    private AsymmetricKeyHashTable<TKey1, TKey2, TValue>.Entry[] buckets;
    [Token(Token = "0x4000ED2")]
    [FieldOffset(Offset = "0x0")]
    private int size;
    [Token(Token = "0x4000ED3")]
    [FieldOffset(Offset = "0x0")]
    private readonly object writerLock;
    [Token(Token = "0x4000ED4")]
    [FieldOffset(Offset = "0x0")]
    private readonly float loadFactor;
    [Token(Token = "0x4000ED5")]
    [FieldOffset(Offset = "0x0")]
    private readonly IAsymmetricEqualityComparer<TKey1, TKey2> comparer;

    [Token(Token = "0x6001565")]
    public AsymmetricKeyHashTable(IAsymmetricEqualityComparer<TKey1, TKey2> comparer)
    {
    }

    [Token(Token = "0x6001566")]
    public AsymmetricKeyHashTable(
      int capacity,
      float loadFactor,
      IAsymmetricEqualityComparer<TKey1, TKey2> comparer)
    {
    }

    [Token(Token = "0x6001567")]
    public TValue AddOrGet(TKey1 key1, Func<TKey1, TValue> valueFactory) => (TValue) null;

    [Token(Token = "0x6001568")]
    public bool TryAdd(TKey1 key, TValue value) => new bool();

    [Token(Token = "0x6001569")]
    public bool TryAdd(TKey1 key, Func<TKey1, TValue> valueFactory) => new bool();

    [Token(Token = "0x600156A")]
    private bool TryAddInternal(
      TKey1 key,
      Func<TKey1, TValue> valueFactory,
      out TValue resultingValue)
    {
      return new bool();
    }

    [Token(Token = "0x600156B")]
    private bool AddToBuckets(
      AsymmetricKeyHashTable<TKey1, TKey2, TValue>.Entry[] buckets,
      TKey1 newKey,
      AsymmetricKeyHashTable<TKey1, TKey2, TValue>.Entry newEntryOrNull,
      Func<TKey1, TValue> valueFactory,
      out TValue resultingValue)
    {
      return new bool();
    }

    [Token(Token = "0x600156C")]
    public bool TryGetValue(TKey2 key, out TValue value) => new bool();

    [Token(Token = "0x600156D")]
    private static int CalculateCapacity(int collectionSize, float loadFactor) => new int();

    [Token(Token = "0x600156E")]
    private static void VolatileWrite(
      ref AsymmetricKeyHashTable<TKey1, TKey2, TValue>.Entry location,
      AsymmetricKeyHashTable<TKey1, TKey2, TValue>.Entry value)
    {
    }

    [Token(Token = "0x600156F")]
    private static void VolatileWrite(
      ref AsymmetricKeyHashTable<TKey1, TKey2, TValue>.Entry[] location,
      AsymmetricKeyHashTable<TKey1, TKey2, TValue>.Entry[] value)
    {
    }

    [Token(Token = "0x200045D")]
    private class Entry
    {
      [Token(Token = "0x4000ED6")]
      [FieldOffset(Offset = "0x0")]
      public TKey1 Key;
      [Token(Token = "0x4000ED7")]
      [FieldOffset(Offset = "0x0")]
      public TValue Value;
      [Token(Token = "0x4000ED8")]
      [FieldOffset(Offset = "0x0")]
      public int Hash;
      [Token(Token = "0x4000ED9")]
      [FieldOffset(Offset = "0x0")]
      public AsymmetricKeyHashTable<TKey1, TKey2, TValue>.Entry Next;

      [Token(Token = "0x6001570")]
      public override string ToString() => (string) null;

      [Token(Token = "0x17000207")]
      internal int Count
      {
        [Token(Token = "0x6001571")] get => new int();
      }

      [Token(Token = "0x6001572")]
      public Entry()
      {
      }
    }
  }
}
