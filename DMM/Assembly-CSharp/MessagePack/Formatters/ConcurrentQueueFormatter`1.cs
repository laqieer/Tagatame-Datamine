// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ConcurrentQueueFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Concurrent;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004A6")]
  public sealed class ConcurrentQueueFormatter<T> : CollectionFormatterBase<T, ConcurrentQueue<T>>
  {
    [Token(Token = "0x60016D8")]
    protected override int? GetCount(ConcurrentQueue<T> sequence) => new int?();

    [Token(Token = "0x60016D9")]
    protected override void Add(ConcurrentQueue<T> collection, int index, T value)
    {
    }

    [Token(Token = "0x60016DA")]
    protected override ConcurrentQueue<T> Create(int count) => (ConcurrentQueue<T>) null;

    [Token(Token = "0x60016DB")]
    public ConcurrentQueueFormatter()
    {
    }
  }
}
