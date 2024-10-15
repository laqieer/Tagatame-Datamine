// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_InspirationSkillExtFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005AE")]
  public sealed class Json_InspirationSkillExtFormatter : 
    IMessagePackFormatter<Json_InspirationSkillExt>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FF4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FF5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A58")]
    [Address(RVA = "0x79A110", Offset = "0x798F10", VA = "0x1079A110")]
    public Json_InspirationSkillExtFormatter()
    {
    }

    [Token(Token = "0x6001A59")]
    [Address(RVA = "0x799F00", Offset = "0x798D00", VA = "0x10799F00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_InspirationSkillExt value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A5A")]
    [Address(RVA = "0x799AE0", Offset = "0x7988E0", VA = "0x10799AE0", Slot = "5")]
    public Json_InspirationSkillExt Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_InspirationSkillExt) null;
    }
  }
}
