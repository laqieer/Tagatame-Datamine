// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_QuestCampaignParentParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007EE")]
  public sealed class JSON_QuestCampaignParentParamFormatter : 
    IMessagePackFormatter<JSON_QuestCampaignParentParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400146C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400146D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002118")]
    [Address(RVA = "0xD30A80", Offset = "0xD2F880", VA = "0x10D30A80")]
    public JSON_QuestCampaignParentParamFormatter()
    {
    }

    [Token(Token = "0x6002119")]
    [Address(RVA = "0xD30860", Offset = "0xD2F660", VA = "0x10D30860", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_QuestCampaignParentParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600211A")]
    [Address(RVA = "0xD30480", Offset = "0xD2F280", VA = "0x10D30480", Slot = "5")]
    public JSON_QuestCampaignParentParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_QuestCampaignParentParam) null;
    }
  }
}
