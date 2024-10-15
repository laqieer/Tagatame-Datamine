// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ExtraQuestClearElementProgressFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200084A")]
  public sealed class JSON_ExtraQuestClearElementProgressFormatter : 
    IMessagePackFormatter<JSON_ExtraQuestClearElementProgress>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001524")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001525")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600222C")]
    [Address(RVA = "0xD6D4D0", Offset = "0xD6C2D0", VA = "0x10D6D4D0")]
    public JSON_ExtraQuestClearElementProgressFormatter()
    {
    }

    [Token(Token = "0x600222D")]
    [Address(RVA = "0xD6D2F0", Offset = "0xD6C0F0", VA = "0x10D6D2F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ExtraQuestClearElementProgress value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600222E")]
    [Address(RVA = "0xD6CFB0", Offset = "0xD6BDB0", VA = "0x10D6CFB0", Slot = "5")]
    public JSON_ExtraQuestClearElementProgress Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ExtraQuestClearElementProgress) null;
    }
  }
}
