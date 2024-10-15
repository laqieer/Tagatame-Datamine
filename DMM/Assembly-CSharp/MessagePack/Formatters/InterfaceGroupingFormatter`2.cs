// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.InterfaceGroupingFormatter`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Linq;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000498")]
  public sealed class InterfaceGroupingFormatter<TKey, TElement> : 
    IMessagePackFormatter<IGrouping<TKey, TElement>>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60016A2")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      IGrouping<TKey, TElement> value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60016A3")]
    public IGrouping<TKey, TElement> Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (IGrouping<TKey, TElement>) null;
    }

    [Token(Token = "0x60016A4")]
    public InterfaceGroupingFormatter()
    {
    }
  }
}
