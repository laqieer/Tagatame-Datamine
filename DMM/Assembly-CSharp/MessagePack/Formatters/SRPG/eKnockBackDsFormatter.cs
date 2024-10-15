// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eKnockBackDsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200054C")]
  public sealed class eKnockBackDsFormatter : 
    IMessagePackFormatter<eKnockBackDs>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001932")]
    [Address(RVA = "0x6B1660", Offset = "0x6B0460", VA = "0x106B1660", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eKnockBackDs value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001933")]
    [Address(RVA = "0x6B1610", Offset = "0x6B0410", VA = "0x106B1610", Slot = "5")]
    public eKnockBackDs Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eKnockBackDs();
    }

    [Token(Token = "0x6001934")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eKnockBackDsFormatter()
    {
    }
  }
}
