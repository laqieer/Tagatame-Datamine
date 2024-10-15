// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.JSON_QuestLobbyNewsParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000537")]
  public sealed class JSON_QuestLobbyNewsParamFormatter : 
    IMessagePackFormatter<JSON_QuestLobbyNewsParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FCA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FCB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60018F3")]
    [Address(RVA = "0x6A0CA0", Offset = "0x69FAA0", VA = "0x106A0CA0")]
    public JSON_QuestLobbyNewsParamFormatter()
    {
    }

    [Token(Token = "0x60018F4")]
    [Address(RVA = "0x6A0AE0", Offset = "0x69F8E0", VA = "0x106A0AE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_QuestLobbyNewsParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018F5")]
    [Address(RVA = "0x6A0750", Offset = "0x69F550", VA = "0x106A0750", Slot = "5")]
    public JSON_QuestLobbyNewsParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_QuestLobbyNewsParam) null;
    }
  }
}
