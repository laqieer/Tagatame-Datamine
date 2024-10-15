// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.CollectionFormatterBase`4
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200048C")]
  public abstract class CollectionFormatterBase<TElement, TIntermediate, TEnumerator, TCollection> : 
    IMessagePackFormatter<TCollection>,
    IMessagePackFormatter
    where TEnumerator : IEnumerator<TElement>
    where TCollection : IEnumerable<TElement>
  {
    [Token(Token = "0x600166C")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TCollection value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600166D")]
    public TCollection Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (TCollection) null;
    }

    [Token(Token = "0x600166E")]
    protected virtual int? GetCount(TCollection sequence) => new int?();

    [Token(Token = "0x600166F")]
    protected abstract TEnumerator GetSourceEnumerator(TCollection source);

    [Token(Token = "0x6001670")]
    protected abstract TIntermediate Create(int count);

    [Token(Token = "0x6001671")]
    protected abstract void Add(TIntermediate collection, int index, TElement value);

    [Token(Token = "0x6001672")]
    protected abstract TCollection Complete(TIntermediate intermediateCollection);

    [Token(Token = "0x6001673")]
    protected CollectionFormatterBase()
    {
    }
  }
}
