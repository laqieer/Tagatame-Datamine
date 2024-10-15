// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestMissionParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200072B")]
  public sealed class JSON_PointQuestMissionParamFormatter : 
    IMessagePackFormatter<JSON_PointQuestMissionParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012EE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012EF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001ECF")]
    [Address(RVA = "0xC573F0", Offset = "0xC561F0", VA = "0x10C573F0")]
    public JSON_PointQuestMissionParamFormatter()
    {
    }

    [Token(Token = "0x6001ED0")]
    [Address(RVA = "0xC57210", Offset = "0xC56010", VA = "0x10C57210", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestMissionParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001ED1")]
    [Address(RVA = "0xC56ED0", Offset = "0xC55CD0", VA = "0x10C56ED0", Slot = "5")]
    public JSON_PointQuestMissionParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestMissionParam) null;
    }
  }
}
