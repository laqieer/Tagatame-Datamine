// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidDamageLotteryParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A2D")]
  public sealed class JSON_WorldRaidDamageLotteryParamFormatter : 
    IMessagePackFormatter<JSON_WorldRaidDamageLotteryParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018EA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018EB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027D5")]
    [Address(RVA = "0xEB3070", Offset = "0xEB1E70", VA = "0x10EB3070")]
    public JSON_WorldRaidDamageLotteryParamFormatter()
    {
    }

    [Token(Token = "0x60027D6")]
    [Address(RVA = "0xEB2E90", Offset = "0xEB1C90", VA = "0x10EB2E90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidDamageLotteryParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027D7")]
    [Address(RVA = "0xEB2B50", Offset = "0xEB1950", VA = "0x10EB2B50", Slot = "5")]
    public JSON_WorldRaidDamageLotteryParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidDamageLotteryParam) null;
    }
  }
}
