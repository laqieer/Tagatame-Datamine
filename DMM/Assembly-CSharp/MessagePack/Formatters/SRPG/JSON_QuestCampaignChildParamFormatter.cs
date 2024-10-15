// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_QuestCampaignChildParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007EF")]
  public sealed class JSON_QuestCampaignChildParamFormatter : 
    IMessagePackFormatter<JSON_QuestCampaignChildParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400146E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400146F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600211B")]
    [Address(RVA = "0xD2F7D0", Offset = "0xD2E5D0", VA = "0x10D2F7D0")]
    public JSON_QuestCampaignChildParamFormatter()
    {
    }

    [Token(Token = "0x600211C")]
    [Address(RVA = "0xD2F430", Offset = "0xD2E230", VA = "0x10D2F430", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_QuestCampaignChildParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600211D")]
    [Address(RVA = "0xD2EEB0", Offset = "0xD2DCB0", VA = "0x10D2EEB0", Slot = "5")]
    public JSON_QuestCampaignChildParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_QuestCampaignChildParam) null;
    }
  }
}
