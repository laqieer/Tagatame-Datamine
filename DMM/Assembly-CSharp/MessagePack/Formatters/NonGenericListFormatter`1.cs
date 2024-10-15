// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NonGenericListFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200049C")]
  public sealed class NonGenericListFormatter<T> : IMessagePackFormatter<T>, IMessagePackFormatter where T : class, IList, new()
  {
    [Token(Token = "0x60016B3")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      T value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60016B4")]
    public T Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (T) null;
    }

    [Token(Token = "0x60016B5")]
    public NonGenericListFormatter()
    {
    }
  }
}
