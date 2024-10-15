// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdventureCampaignParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A8E")]
  public sealed class JSON_AdventureCampaignParamFormatter : 
    IMessagePackFormatter<JSON_AdventureCampaignParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019AC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019AD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028F8")]
    [Address(RVA = "0xED74C0", Offset = "0xED62C0", VA = "0x10ED74C0")]
    public JSON_AdventureCampaignParamFormatter()
    {
    }

    [Token(Token = "0x60028F9")]
    [Address(RVA = "0xED7200", Offset = "0xED6000", VA = "0x10ED7200", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdventureCampaignParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028FA")]
    [Address(RVA = "0xED6D80", Offset = "0xED5B80", VA = "0x10ED6D80", Slot = "5")]
    public JSON_AdventureCampaignParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdventureCampaignParam) null;
    }
  }
}
