// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.CollectionFormatterBase`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200048E")]
  public abstract class CollectionFormatterBase<TElement, TCollection> : 
    CollectionFormatterBase<TElement, TCollection, TCollection>
    where TCollection : IEnumerable<TElement>
  {
    [Token(Token = "0x6001676")]
    protected override sealed TCollection Complete(TCollection intermediateCollection)
    {
      return (TCollection) null;
    }

    [Token(Token = "0x6001677")]
    protected CollectionFormatterBase()
    {
    }
  }
}
