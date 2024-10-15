// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ListFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200048B")]
  public sealed class ListFormatter<T> : IMessagePackFormatter<List<T>>, IMessagePackFormatter
  {
    [Token(Token = "0x6001669")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      List<T> value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600166A")]
    public List<T> Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (List<T>) null;
    }

    [Token(Token = "0x600166B")]
    public ListFormatter()
    {
    }
  }
}
