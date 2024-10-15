// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eAbsorbAndGiveFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000550")]
  public sealed class eAbsorbAndGiveFormatter : 
    IMessagePackFormatter<eAbsorbAndGive>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600193E")]
    [Address(RVA = "0x6B1160", Offset = "0x6AFF60", VA = "0x106B1160", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eAbsorbAndGive value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600193F")]
    [Address(RVA = "0x6B1110", Offset = "0x6AFF10", VA = "0x106B1110", Slot = "5")]
    public eAbsorbAndGive Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eAbsorbAndGive();
    }

    [Token(Token = "0x6001940")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eAbsorbAndGiveFormatter()
    {
    }
  }
}
