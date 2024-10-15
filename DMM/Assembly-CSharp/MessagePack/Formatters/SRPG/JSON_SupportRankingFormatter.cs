// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SupportRankingFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008AF")]
  public sealed class JSON_SupportRankingFormatter : 
    IMessagePackFormatter<JSON_SupportRanking>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015EE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015EF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600235B")]
    [Address(RVA = "0xDB7450", Offset = "0xDB6250", VA = "0x10DB7450")]
    public JSON_SupportRankingFormatter()
    {
    }

    [Token(Token = "0x600235C")]
    [Address(RVA = "0xDB70A0", Offset = "0xDB5EA0", VA = "0x10DB70A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SupportRanking value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600235D")]
    [Address(RVA = "0xDB6BB0", Offset = "0xDB59B0", VA = "0x10DB6BB0", Slot = "5")]
    public JSON_SupportRanking Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SupportRanking) null;
    }
  }
}
