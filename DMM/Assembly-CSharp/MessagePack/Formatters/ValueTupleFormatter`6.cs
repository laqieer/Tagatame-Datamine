// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ValueTupleFormatter`6
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000527")]
  public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5, T6> : 
    IMessagePackFormatter<(T1, T2, T3, T4, T5, T6)>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60018C1")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      (T1, T2, T3, T4, T5, T6) value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018C2")]
    public (T1, T2, T3, T4, T5, T6) Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return ();
    }

    [Token(Token = "0x60018C3")]
    public ValueTupleFormatter()
    {
    }
  }
}
