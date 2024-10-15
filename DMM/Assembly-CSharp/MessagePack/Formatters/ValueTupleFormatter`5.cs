// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ValueTupleFormatter`5
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000526")]
  public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5> : 
    IMessagePackFormatter<(T1, T2, T3, T4, T5)>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60018BE")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      (T1, T2, T3, T4, T5) value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018BF")]
    public (T1, T2, T3, T4, T5) Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return ();
    }

    [Token(Token = "0x60018C0")]
    public ValueTupleFormatter()
    {
    }
  }
}
