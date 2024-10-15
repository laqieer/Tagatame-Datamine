// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_StoryExChallengeCountFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007E6")]
  public sealed class JSON_StoryExChallengeCountFormatter : 
    IMessagePackFormatter<JSON_StoryExChallengeCount>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400145C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400145D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002100")]
    [Address(RVA = "0xD31870", Offset = "0xD30670", VA = "0x10D31870")]
    public JSON_StoryExChallengeCountFormatter()
    {
    }

    [Token(Token = "0x6002101")]
    [Address(RVA = "0xD31770", Offset = "0xD30570", VA = "0x10D31770", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_StoryExChallengeCount value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002102")]
    [Address(RVA = "0xD31490", Offset = "0xD30290", VA = "0x10D31490", Slot = "5")]
    public JSON_StoryExChallengeCount Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_StoryExChallengeCount) null;
    }
  }
}
