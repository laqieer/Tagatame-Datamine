// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ValueTaskFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Threading.Tasks;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000513")]
  public sealed class ValueTaskFormatter<T> : 
    IMessagePackFormatter<ValueTask<T>>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001878")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ValueTask<T> value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001879")]
    public ValueTask<T> Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ValueTask<T>();
    }

    [Token(Token = "0x600187A")]
    public ValueTaskFormatter()
    {
    }
  }
}
