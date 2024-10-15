// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_QuestCampaignTrustFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007F0")]
  public sealed class JSON_QuestCampaignTrustFormatter : 
    IMessagePackFormatter<JSON_QuestCampaignTrust>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001470")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001471")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600211E")]
    [Address(RVA = "0xD31230", Offset = "0xD30030", VA = "0x10D31230")]
    public JSON_QuestCampaignTrustFormatter()
    {
    }

    [Token(Token = "0x600211F")]
    [Address(RVA = "0xD31070", Offset = "0xD2FE70", VA = "0x10D31070", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_QuestCampaignTrust value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002120")]
    [Address(RVA = "0xD30CE0", Offset = "0xD2FAE0", VA = "0x10D30CE0", Slot = "5")]
    public JSON_QuestCampaignTrust Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_QuestCampaignTrust) null;
    }
  }
}
