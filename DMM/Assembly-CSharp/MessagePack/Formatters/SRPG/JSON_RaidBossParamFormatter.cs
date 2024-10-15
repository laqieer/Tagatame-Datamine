// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidBossParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000621")]
  public sealed class JSON_RaidBossParamFormatter : 
    IMessagePackFormatter<JSON_RaidBossParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010DA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010DB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BB1")]
    [Address(RVA = "0xBC1260", Offset = "0xBC0060", VA = "0x10BC1260")]
    public JSON_RaidBossParamFormatter()
    {
    }

    [Token(Token = "0x6001BB2")]
    [Address(RVA = "0xBC0D40", Offset = "0xBBFB40", VA = "0x10BC0D40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidBossParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BB3")]
    [Address(RVA = "0xBC0690", Offset = "0xBBF490", VA = "0x10BC0690", Slot = "5")]
    public JSON_RaidBossParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidBossParam) null;
    }
  }
}
