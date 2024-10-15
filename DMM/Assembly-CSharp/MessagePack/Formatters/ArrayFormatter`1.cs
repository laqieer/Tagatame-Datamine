// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ArrayFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000488")]
  public sealed class ArrayFormatter<T> : IMessagePackFormatter<T[]>, IMessagePackFormatter
  {
    [Token(Token = "0x600165F")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      T[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001660")]
    public T[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (T[]) null;
    }

    [Token(Token = "0x6001661")]
    public ArrayFormatter()
    {
    }
  }
}
