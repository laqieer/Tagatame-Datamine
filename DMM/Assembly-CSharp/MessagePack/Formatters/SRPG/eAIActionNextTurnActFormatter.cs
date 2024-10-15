// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eAIActionNextTurnActFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000583")]
  public sealed class eAIActionNextTurnActFormatter : 
    IMessagePackFormatter<eAIActionNextTurnAct>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019D7")]
    [Address(RVA = "0x6B1020", Offset = "0x6AFE20", VA = "0x106B1020", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eAIActionNextTurnAct value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019D8")]
    [Address(RVA = "0x6B0FD0", Offset = "0x6AFDD0", VA = "0x106B0FD0", Slot = "5")]
    public eAIActionNextTurnAct Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eAIActionNextTurnAct();
    }

    [Token(Token = "0x60019D9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eAIActionNextTurnActFormatter()
    {
    }
  }
}
