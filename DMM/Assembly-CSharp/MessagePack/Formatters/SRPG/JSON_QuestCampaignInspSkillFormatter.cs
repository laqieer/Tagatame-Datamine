// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_QuestCampaignInspSkillFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007F1")]
  public sealed class JSON_QuestCampaignInspSkillFormatter : 
    IMessagePackFormatter<JSON_QuestCampaignInspSkill>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001472")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001473")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002121")]
    [Address(RVA = "0xD30290", Offset = "0xD2F090", VA = "0x10D30290")]
    public JSON_QuestCampaignInspSkillFormatter()
    {
    }

    [Token(Token = "0x6002122")]
    [Address(RVA = "0xD30100", Offset = "0xD2EF00", VA = "0x10D30100", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_QuestCampaignInspSkill value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002123")]
    [Address(RVA = "0xD2FD90", Offset = "0xD2EB90", VA = "0x10D2FD90", Slot = "5")]
    public JSON_QuestCampaignInspSkill Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_QuestCampaignInspSkill) null;
    }
  }
}
