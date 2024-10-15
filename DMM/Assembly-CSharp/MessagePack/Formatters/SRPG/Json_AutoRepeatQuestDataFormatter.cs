// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_AutoRepeatQuestDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008EB")]
  public sealed class Json_AutoRepeatQuestDataFormatter : 
    IMessagePackFormatter<Json_AutoRepeatQuestData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001666")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001667")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600240F")]
    [Address(RVA = "0xDE7240", Offset = "0xDE6040", VA = "0x10DE7240")]
    public Json_AutoRepeatQuestDataFormatter()
    {
    }

    [Token(Token = "0x6002410")]
    [Address(RVA = "0xDE6DE0", Offset = "0xDE5BE0", VA = "0x10DE6DE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_AutoRepeatQuestData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002411")]
    [Address(RVA = "0xDE6820", Offset = "0xDE5620", VA = "0x10DE6820", Slot = "5")]
    public Json_AutoRepeatQuestData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_AutoRepeatQuestData) null;
    }
  }
}
