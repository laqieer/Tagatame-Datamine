// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.InterfaceListFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000495")]
  public sealed class InterfaceListFormatter<T> : CollectionFormatterBase<T, T[], IList<T>>
  {
    [Token(Token = "0x6001696")]
    protected override void Add(T[] collection, int index, T value)
    {
    }

    [Token(Token = "0x6001697")]
    protected override T[] Create(int count) => (T[]) null;

    [Token(Token = "0x6001698")]
    protected override IList<T> Complete(T[] intermediateCollection) => (IList<T>) null;

    [Token(Token = "0x6001699")]
    public InterfaceListFormatter()
    {
    }
  }
}
