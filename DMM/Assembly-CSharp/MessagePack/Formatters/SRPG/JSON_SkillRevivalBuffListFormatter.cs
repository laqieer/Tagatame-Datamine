// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillRevivalBuffListFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006A3")]
  public sealed class JSON_SkillRevivalBuffListFormatter : 
    IMessagePackFormatter<JSON_SkillRevivalBuffList>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011DE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011DF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D37")]
    [Address(RVA = "0xC07DE0", Offset = "0xC06BE0", VA = "0x10C07DE0")]
    public JSON_SkillRevivalBuffListFormatter()
    {
    }

    [Token(Token = "0x6001D38")]
    [Address(RVA = "0xC07CB0", Offset = "0xC06AB0", VA = "0x10C07CB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillRevivalBuffList value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D39")]
    [Address(RVA = "0xC079A0", Offset = "0xC067A0", VA = "0x10C079A0", Slot = "5")]
    public JSON_SkillRevivalBuffList Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillRevivalBuffList) null;
    }
  }
}
