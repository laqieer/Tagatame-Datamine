// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestMissionDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200072A")]
  public sealed class JSON_PointQuestMissionDataFormatter : 
    IMessagePackFormatter<JSON_PointQuestMissionData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012EC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012ED")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001ECC")]
    [Address(RVA = "0xC56CE0", Offset = "0xC55AE0", VA = "0x10C56CE0")]
    public JSON_PointQuestMissionDataFormatter()
    {
    }

    [Token(Token = "0x6001ECD")]
    [Address(RVA = "0xC56B80", Offset = "0xC55980", VA = "0x10C56B80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestMissionData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001ECE")]
    [Address(RVA = "0xC56830", Offset = "0xC55630", VA = "0x10C56830", Slot = "5")]
    public JSON_PointQuestMissionData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestMissionData) null;
    }
  }
}
