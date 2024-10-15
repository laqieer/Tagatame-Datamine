// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.CollectionFormatterBase`3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200048D")]
  public abstract class CollectionFormatterBase<TElement, TIntermediate, TCollection> : 
    CollectionFormatterBase<TElement, TIntermediate, IEnumerator<TElement>, TCollection>
    where TCollection : IEnumerable<TElement>
  {
    [Token(Token = "0x6001674")]
    protected override IEnumerator<TElement> GetSourceEnumerator(TCollection source)
    {
      return (IEnumerator<TElement>) null;
    }

    [Token(Token = "0x6001675")]
    protected CollectionFormatterBase()
    {
    }
  }
}
