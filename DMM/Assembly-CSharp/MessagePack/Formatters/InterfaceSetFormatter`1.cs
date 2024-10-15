// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.InterfaceSetFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004A4")]
  public sealed class InterfaceSetFormatter<T> : CollectionFormatterBase<T, HashSet<T>, ISet<T>>
  {
    [Token(Token = "0x60016D0")]
    protected override void Add(HashSet<T> collection, int index, T value)
    {
    }

    [Token(Token = "0x60016D1")]
    protected override ISet<T> Complete(HashSet<T> intermediateCollection) => (ISet<T>) null;

    [Token(Token = "0x60016D2")]
    protected override HashSet<T> Create(int count) => (HashSet<T>) null;

    [Token(Token = "0x60016D3")]
    public InterfaceSetFormatter()
    {
    }
  }
}
