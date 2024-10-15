// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.GuildEmblemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B0F")]
  public sealed class GuildEmblemParamFormatter : 
    IMessagePackFormatter<GuildEmblemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AAE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AAF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A7B")]
    [Address(RVA = "0xF3CC30", Offset = "0xF3BA30", VA = "0x10F3CC30")]
    public GuildEmblemParamFormatter()
    {
    }

    [Token(Token = "0x6002A7C")]
    [Address(RVA = "0xF3C940", Offset = "0xF3B740", VA = "0x10F3C940", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      GuildEmblemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A7D")]
    [Address(RVA = "0xF3C600", Offset = "0xF3B400", VA = "0x10F3C600", Slot = "5")]
    public GuildEmblemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (GuildEmblemParam) null;
    }
  }
}
