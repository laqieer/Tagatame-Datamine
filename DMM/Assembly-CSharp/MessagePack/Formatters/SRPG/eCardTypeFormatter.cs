// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eCardTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200055D")]
  public sealed class eCardTypeFormatter : IMessagePackFormatter<eCardType>, IMessagePackFormatter
  {
    [Token(Token = "0x6001965")]
    [Address(RVA = "0x6B1340", Offset = "0x6B0140", VA = "0x106B1340", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eCardType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001966")]
    [Address(RVA = "0x6B12F0", Offset = "0x6B00F0", VA = "0x106B12F0", Slot = "5")]
    public eCardType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eCardType();
    }

    [Token(Token = "0x6001967")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eCardTypeFormatter()
    {
    }
  }
}
