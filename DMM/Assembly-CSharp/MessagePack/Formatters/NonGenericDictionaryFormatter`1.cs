// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NonGenericDictionaryFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200049E")]
  public sealed class NonGenericDictionaryFormatter<T> : 
    IMessagePackFormatter<T>,
    IMessagePackFormatter
    where T : class, IDictionary, new()
  {
    [Token(Token = "0x60016BA")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      T value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60016BB")]
    public T Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (T) null;
    }

    [Token(Token = "0x60016BC")]
    public NonGenericDictionaryFormatter()
    {
    }
  }
}
