// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.EnumAsStringFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004B6")]
  public sealed class EnumAsStringFormatter<T> : IMessagePackFormatter<T>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F48")]
    [FieldOffset(Offset = "0x0")]
    private readonly Dictionary<string, T> nameValueMapping;
    [Token(Token = "0x4000F49")]
    [FieldOffset(Offset = "0x0")]
    private readonly Dictionary<T, string> valueNameMapping;

    [Token(Token = "0x6001715")]
    public EnumAsStringFormatter()
    {
    }

    [Token(Token = "0x6001716")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      T value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001717")]
    public T Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (T) null;
    }
  }
}
