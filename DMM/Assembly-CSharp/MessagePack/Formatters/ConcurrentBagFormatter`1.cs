// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ConcurrentBagFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Concurrent;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004A5")]
  public sealed class ConcurrentBagFormatter<T> : CollectionFormatterBase<T, ConcurrentBag<T>>
  {
    [Token(Token = "0x60016D4")]
    protected override int? GetCount(ConcurrentBag<T> sequence) => new int?();

    [Token(Token = "0x60016D5")]
    protected override void Add(ConcurrentBag<T> collection, int index, T value)
    {
    }

    [Token(Token = "0x60016D6")]
    protected override ConcurrentBag<T> Create(int count) => (ConcurrentBag<T>) null;

    [Token(Token = "0x60016D7")]
    public ConcurrentBagFormatter()
    {
    }
  }
}
