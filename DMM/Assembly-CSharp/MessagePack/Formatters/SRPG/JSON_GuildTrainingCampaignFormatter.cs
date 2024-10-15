// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildTrainingCampaignFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000639")]
  public sealed class JSON_GuildTrainingCampaignFormatter : 
    IMessagePackFormatter<JSON_GuildTrainingCampaign>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400110A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400110B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BF9")]
    [Address(RVA = "0xBD6840", Offset = "0xBD5640", VA = "0x10BD6840")]
    public JSON_GuildTrainingCampaignFormatter()
    {
    }

    [Token(Token = "0x6001BFA")]
    [Address(RVA = "0xBD6580", Offset = "0xBD5380", VA = "0x10BD6580", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildTrainingCampaign value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BFB")]
    [Address(RVA = "0xBD6100", Offset = "0xBD4F00", VA = "0x10BD6100", Slot = "5")]
    public JSON_GuildTrainingCampaign Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildTrainingCampaign) null;
    }
  }
}
