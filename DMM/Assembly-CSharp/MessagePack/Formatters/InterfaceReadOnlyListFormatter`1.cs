// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.InterfaceReadOnlyListFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004A2")]
  public sealed class InterfaceReadOnlyListFormatter<T> : 
    CollectionFormatterBase<T, T[], IReadOnlyList<T>>
  {
    [Token(Token = "0x60016C8")]
    protected override void Add(T[] collection, int index, T value)
    {
    }

    [Token(Token = "0x60016C9")]
    protected override T[] Create(int count) => (T[]) null;

    [Token(Token = "0x60016CA")]
    protected override IReadOnlyList<T> Complete(T[] intermediateCollection)
    {
      return (IReadOnlyList<T>) null;
    }

    [Token(Token = "0x60016CB")]
    public InterfaceReadOnlyListFormatter()
    {
    }
  }
}
