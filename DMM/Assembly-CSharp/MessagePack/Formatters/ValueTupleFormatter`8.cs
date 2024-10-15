// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ValueTupleFormatter`8
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000529")]
  public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5, T6, T7, TRest> : 
    IMessagePackFormatter<(T1, T2, T3, T4, T5, T6, T7, TRest)>,
    IMessagePackFormatter
    where TRest : struct
  {
    [Token(Token = "0x60018C7")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      (T1, T2, T3, T4, T5, T6, T7, TRest) value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018C8")]
    public (T1, T2, T3, T4, T5, T6, T7, TRest) Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      // ISSUE: unable to decompile the method.
    }

    [Token(Token = "0x60018C9")]
    public ValueTupleFormatter()
    {
    }
  }
}
