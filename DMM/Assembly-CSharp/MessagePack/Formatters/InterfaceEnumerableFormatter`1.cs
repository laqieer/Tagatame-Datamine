// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.InterfaceEnumerableFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000497")]
  public sealed class InterfaceEnumerableFormatter<T> : 
    CollectionFormatterBase<T, T[], IEnumerable<T>>
  {
    [Token(Token = "0x600169E")]
    protected override void Add(T[] collection, int index, T value)
    {
    }

    [Token(Token = "0x600169F")]
    protected override T[] Create(int count) => (T[]) null;

    [Token(Token = "0x60016A0")]
    protected override IEnumerable<T> Complete(T[] intermediateCollection) => (IEnumerable<T>) null;

    [Token(Token = "0x60016A1")]
    public InterfaceEnumerableFormatter()
    {
    }
  }
}
