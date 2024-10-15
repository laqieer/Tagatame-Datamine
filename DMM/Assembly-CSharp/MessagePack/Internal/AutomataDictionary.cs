// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.AutomataDictionary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x200045F")]
  public class AutomataDictionary : IEnumerable<KeyValuePair<string, int>>, IEnumerable
  {
    [Token(Token = "0x4000EDB")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary.AutomataNode root;

    [Token(Token = "0x6001575")]
    [Address(RVA = "0x5BB4F0", Offset = "0x5BA2F0", VA = "0x105BB4F0")]
    public AutomataDictionary()
    {
    }

    [Token(Token = "0x6001576")]
    [Address(RVA = "0x5BAD10", Offset = "0x5B9B10", VA = "0x105BAD10")]
    public void Add(string str, int value)
    {
    }

    [Token(Token = "0x6001577")]
    [Address(RVA = "0x5BB330", Offset = "0x5BA130", VA = "0x105BB330")]
    public bool TryGetValue(byte[] bytes, int offset, int count, out int value) => new bool();

    [Token(Token = "0x6001578")]
    [Address(RVA = "0x5BB1A0", Offset = "0x5B9FA0", VA = "0x105BB1A0")]
    public bool TryGetValueSafe(ArraySegment<byte> key, out int value) => new bool();

    [Token(Token = "0x6001579")]
    [Address(RVA = "0x5BB120", Offset = "0x5B9F20", VA = "0x105BB120", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600157A")]
    [Address(RVA = "0x5BAE50", Offset = "0x5B9C50", VA = "0x105BAE50")]
    private static void ToStringCore(
      IEnumerable<AutomataDictionary.AutomataNode> nexts,
      StringBuilder sb,
      int depth)
    {
    }

    [Token(Token = "0x600157B")]
    [Address(RVA = "0x5BADF0", Offset = "0x5B9BF0", VA = "0x105BADF0", Slot = "5")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600157C")]
    [Address(RVA = "0x5BADF0", Offset = "0x5B9BF0", VA = "0x105BADF0", Slot = "4")]
    public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
    {
      return (IEnumerator<KeyValuePair<string, int>>) null;
    }

    [Token(Token = "0x600157D")]
    [Address(RVA = "0x5BB480", Offset = "0x5BA280", VA = "0x105BB480")]
    private static IEnumerable<KeyValuePair<string, int>> YieldCore(
      IEnumerable<AutomataDictionary.AutomataNode> nexts)
    {
      return (IEnumerable<KeyValuePair<string, int>>) null;
    }

    [Token(Token = "0x2000460")]
    private class AutomataNode : IComparable<AutomataDictionary.AutomataNode>
    {
      [Token(Token = "0x4000EDC")]
      [FieldOffset(Offset = "0x0")]
      private static readonly AutomataDictionary.AutomataNode[] emptyNodes;
      [Token(Token = "0x4000EDD")]
      [FieldOffset(Offset = "0x4")]
      private static readonly ulong[] emptyKeys;
      [Token(Token = "0x4000EDE")]
      [FieldOffset(Offset = "0x8")]
      public ulong Key;
      [Token(Token = "0x4000EDF")]
      [FieldOffset(Offset = "0x10")]
      public int Value;
      [Token(Token = "0x4000EE0")]
      [FieldOffset(Offset = "0x14")]
      public string originalKey;
      [Token(Token = "0x4000EE1")]
      [FieldOffset(Offset = "0x18")]
      private AutomataDictionary.AutomataNode[] nexts;
      [Token(Token = "0x4000EE2")]
      [FieldOffset(Offset = "0x1C")]
      private ulong[] nextKeys;
      [Token(Token = "0x4000EE3")]
      [FieldOffset(Offset = "0x20")]
      private int count;

      [Token(Token = "0x17000208")]
      public bool HasChildren
      {
        [Token(Token = "0x600157E"), Address(RVA = "0x5BCAC0", Offset = "0x5BB8C0", VA = "0x105BCAC0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600157F")]
      [Address(RVA = "0x5BCA10", Offset = "0x5BB810", VA = "0x105BCA10")]
      public AutomataNode(ulong key)
      {
      }

      [Token(Token = "0x6001580")]
      [Address(RVA = "0x5BC490", Offset = "0x5BB290", VA = "0x105BC490")]
      public AutomataDictionary.AutomataNode Add(ulong key)
      {
        return (AutomataDictionary.AutomataNode) null;
      }

      [Token(Token = "0x6001581")]
      [Address(RVA = "0x5BC450", Offset = "0x5BB250", VA = "0x105BC450")]
      public AutomataDictionary.AutomataNode Add(ulong key, int value, string originalKey)
      {
        return (AutomataDictionary.AutomataNode) null;
      }

      [Token(Token = "0x6001582")]
      [Address(RVA = "0x5BC810", Offset = "0x5BB610", VA = "0x105BC810")]
      public AutomataDictionary.AutomataNode SearchNext(ref byte* p, ref int rest)
      {
        return (AutomataDictionary.AutomataNode) null;
      }

      [Token(Token = "0x6001583")]
      [Address(RVA = "0x5BC700", Offset = "0x5BB500", VA = "0x105BC700")]
      public AutomataDictionary.AutomataNode SearchNextSafe(byte[] p, ref int offset, ref int rest)
      {
        return (AutomataDictionary.AutomataNode) null;
      }

      [Token(Token = "0x6001584")]
      [Address(RVA = "0x5BC650", Offset = "0x5BB450", VA = "0x105BC650")]
      internal static int BinarySearch(ulong[] array, int index, int length, ulong value)
      {
        return new int();
      }

      [Token(Token = "0x6001585")]
      [Address(RVA = "0x5BC6D0", Offset = "0x5BB4D0", VA = "0x105BC6D0", Slot = "4")]
      public int CompareTo(AutomataDictionary.AutomataNode other) => new int();

      [Token(Token = "0x6001586")]
      [Address(RVA = "0x5BC910", Offset = "0x5BB710", VA = "0x105BC910")]
      public IEnumerable<AutomataDictionary.AutomataNode> YieldChildren()
      {
        return (IEnumerable<AutomataDictionary.AutomataNode>) null;
      }

      [Token(Token = "0x6001587")]
      [Address(RVA = "0x5BC980", Offset = "0x5BB780", VA = "0x105BC980")]
      static AutomataNode()
      {
      }
    }
  }
}
