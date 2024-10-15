// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.KeyValuePairFormatter`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200050A")]
  public sealed class KeyValuePairFormatter<TKey, TValue> : 
    IMessagePackFormatter<KeyValuePair<TKey, TValue>>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001859")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      KeyValuePair<TKey, TValue> value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600185A")]
    public KeyValuePair<TKey, TValue> Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new KeyValuePair<TKey, TValue>();
    }

    [Token(Token = "0x600185B")]
    public KeyValuePairFormatter()
    {
    }
  }
}
