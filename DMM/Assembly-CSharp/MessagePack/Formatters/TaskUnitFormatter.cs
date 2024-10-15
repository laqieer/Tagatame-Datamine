// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.TaskUnitFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Threading.Tasks;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000511")]
  public sealed class TaskUnitFormatter : IMessagePackFormatter<Task>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F9F")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IMessagePackFormatter<Task> Instance;
    [Token(Token = "0x4000FA0")]
    [FieldOffset(Offset = "0x4")]
    private static readonly Task CompletedTask;

    [Token(Token = "0x6001871")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private TaskUnitFormatter()
    {
    }

    [Token(Token = "0x6001872")]
    [Address(RVA = "0x6AB300", Offset = "0x6AA100", VA = "0x106AB300", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Task value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001873")]
    [Address(RVA = "0x6AB230", Offset = "0x6AA030", VA = "0x106AB230", Slot = "5")]
    public Task Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Task) null;
    }

    [Token(Token = "0x6001874")]
    [Address(RVA = "0x6AB360", Offset = "0x6AA160", VA = "0x106AB360")]
    static TaskUnitFormatter()
    {
    }
  }
}
