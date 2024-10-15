// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004D4")]
  public sealed class NullableFormatter<T> : IMessagePackFormatter<T?>, IMessagePackFormatter where T : struct
  {
    [Token(Token = "0x6001782")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      T? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001783")]
    public T? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new T?();
    }

    [Token(Token = "0x6001784")]
    public NullableFormatter()
    {
    }
  }
}
