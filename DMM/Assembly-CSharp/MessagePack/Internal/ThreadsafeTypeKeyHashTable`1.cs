// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.ThreadsafeTypeKeyHashTable`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x200046E")]
  internal class ThreadsafeTypeKeyHashTable<TValue>
  {
    [Token(Token = "0x4000F18")]
    [FieldOffset(Offset = "0x0")]
    private ThreadsafeTypeKeyHashTable<TValue>.Entry[] buckets;
    [Token(Token = "0x4000F19")]
    [FieldOffset(Offset = "0x0")]
    private int size;
    [Token(Token = "0x4000F1A")]
    [FieldOffset(Offset = "0x0")]
    private readonly object writerLock;
    [Token(Token = "0x4000F1B")]
    [FieldOffset(Offset = "0x0")]
    private readonly float loadFactor;

    [Token(Token = "0x60015E7")]
    public ThreadsafeTypeKeyHashTable(int capacity = 4, float loadFactor = 0.75f)
    {
    }

    [Token(Token = "0x60015E8")]
    public bool TryAdd(Type key, TValue value) => new bool();

    [Token(Token = "0x60015E9")]
    public bool TryAdd(Type key, Func<Type, TValue> valueFactory) => new bool();

    [Token(Token = "0x60015EA")]
    private bool TryAddInternal(
      Type key,
      Func<Type, TValue> valueFactory,
      out TValue resultingValue)
    {
      return new bool();
    }

    [Token(Token = "0x60015EB")]
    private bool AddToBuckets(
      ThreadsafeTypeKeyHashTable<TValue>.Entry[] buckets,
      Type newKey,
      ThreadsafeTypeKeyHashTable<TValue>.Entry newEntryOrNull,
      Func<Type, TValue> valueFactory,
      out TValue resultingValue)
    {
      return new bool();
    }

    [Token(Token = "0x60015EC")]
    public bool TryGetValue(Type key, out TValue value) => new bool();

    [Token(Token = "0x60015ED")]
    public TValue GetOrAdd(Type key, Func<Type, TValue> valueFactory) => (TValue) null;

    [Token(Token = "0x60015EE")]
    private static int CalculateCapacity(int collectionSize, float loadFactor) => new int();

    [Token(Token = "0x60015EF")]
    private static void VolatileWrite(
      ref ThreadsafeTypeKeyHashTable<TValue>.Entry location,
      ThreadsafeTypeKeyHashTable<TValue>.Entry value)
    {
    }

    [Token(Token = "0x60015F0")]
    private static void VolatileWrite(
      ref ThreadsafeTypeKeyHashTable<TValue>.Entry[] location,
      ThreadsafeTypeKeyHashTable<TValue>.Entry[] value)
    {
    }

    [Token(Token = "0x200046F")]
    private class Entry
    {
      [Token(Token = "0x4000F1C")]
      [FieldOffset(Offset = "0x0")]
      public Type Key;
      [Token(Token = "0x4000F1D")]
      [FieldOffset(Offset = "0x0")]
      public TValue Value;
      [Token(Token = "0x4000F1E")]
      [FieldOffset(Offset = "0x0")]
      public int Hash;
      [Token(Token = "0x4000F1F")]
      [FieldOffset(Offset = "0x0")]
      public ThreadsafeTypeKeyHashTable<TValue>.Entry Next;

      [Token(Token = "0x60015F1")]
      public override string ToString() => (string) null;

      [Token(Token = "0x60015F2")]
      private int Count() => new int();

      [Token(Token = "0x60015F3")]
      public Entry()
      {
      }
    }
  }
}
