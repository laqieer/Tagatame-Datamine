// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EmbeddedTutorialMasterParams_JSON_EmbededQuestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000862")]
  public sealed class EmbeddedTutorialMasterParams_JSON_EmbededQuestParamFormatter : 
    IMessagePackFormatter<EmbeddedTutorialMasterParams.JSON_EmbededQuestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001554")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001555")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002274")]
    [Address(RVA = "0xD84360", Offset = "0xD83160", VA = "0x10D84360")]
    public EmbeddedTutorialMasterParams_JSON_EmbededQuestParamFormatter()
    {
    }

    [Token(Token = "0x6002275")]
    [Address(RVA = "0xD84050", Offset = "0xD82E50", VA = "0x10D84050", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EmbeddedTutorialMasterParams.JSON_EmbededQuestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002276")]
    [Address(RVA = "0xD83CA0", Offset = "0xD82AA0", VA = "0x10D83CA0", Slot = "5")]
    public EmbeddedTutorialMasterParams.JSON_EmbededQuestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (EmbeddedTutorialMasterParams.JSON_EmbededQuestParam) null;
    }
  }
}
