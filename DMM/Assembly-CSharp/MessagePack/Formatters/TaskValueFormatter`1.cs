// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.TaskValueFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Threading.Tasks;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000512")]
  public sealed class TaskValueFormatter<T> : IMessagePackFormatter<Task<T>>, IMessagePackFormatter
  {
    [Token(Token = "0x6001875")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Task<T> value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001876")]
    public Task<T> Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Task<T>) null;
    }

    [Token(Token = "0x6001877")]
    public TaskValueFormatter()
    {
    }
  }
}
