// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000598")]
  public sealed class eTypeFormatter : IMessagePackFormatter<RewardIcon.eType>, IMessagePackFormatter
  {
    [Token(Token = "0x6001A16")]
    [Address(RVA = "0x7A5000", Offset = "0x7A3E00", VA = "0x107A5000", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RewardIcon.eType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A17")]
    [Address(RVA = "0x7A4FA0", Offset = "0x7A3DA0", VA = "0x107A4FA0", Slot = "5")]
    public RewardIcon.eType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new RewardIcon.eType();
    }

    [Token(Token = "0x6001A18")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eTypeFormatter()
    {
    }
  }
}
