// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eAIActionNoExecActFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000582")]
  public sealed class eAIActionNoExecActFormatter : 
    IMessagePackFormatter<eAIActionNoExecAct>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019D4")]
    [Address(RVA = "0x6B10C0", Offset = "0x6AFEC0", VA = "0x106B10C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eAIActionNoExecAct value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019D5")]
    [Address(RVA = "0x6B1070", Offset = "0x6AFE70", VA = "0x106B1070", Slot = "5")]
    public eAIActionNoExecAct Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eAIActionNoExecAct();
    }

    [Token(Token = "0x60019D6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eAIActionNoExecActFormatter()
    {
    }
  }
}
