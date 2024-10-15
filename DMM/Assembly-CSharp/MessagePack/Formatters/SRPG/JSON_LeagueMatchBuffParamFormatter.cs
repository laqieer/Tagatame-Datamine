// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchBuffParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006F1")]
  public sealed class JSON_LeagueMatchBuffParamFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchBuffParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400127A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400127B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E21")]
    [Address(RVA = "0xC28A60", Offset = "0xC27860", VA = "0x10C28A60")]
    public JSON_LeagueMatchBuffParamFormatter()
    {
    }

    [Token(Token = "0x6001E22")]
    [Address(RVA = "0xC28880", Offset = "0xC27680", VA = "0x10C28880", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchBuffParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E23")]
    [Address(RVA = "0xC28540", Offset = "0xC27340", VA = "0x10C28540", Slot = "5")]
    public JSON_LeagueMatchBuffParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchBuffParam) null;
    }
  }
}
