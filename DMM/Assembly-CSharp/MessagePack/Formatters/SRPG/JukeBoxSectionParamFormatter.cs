// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JukeBoxSectionParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AC2")]
  public sealed class JukeBoxSectionParamFormatter : 
    IMessagePackFormatter<JukeBoxSectionParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A14")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A15")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002994")]
    [Address(RVA = "0xF0F5D0", Offset = "0xF0E3D0", VA = "0x10F0F5D0")]
    public JukeBoxSectionParamFormatter()
    {
    }

    [Token(Token = "0x6002995")]
    [Address(RVA = "0xF0F480", Offset = "0xF0E280", VA = "0x10F0F480", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JukeBoxSectionParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002996")]
    [Address(RVA = "0xF0F1C0", Offset = "0xF0DFC0", VA = "0x10F0F1C0", Slot = "5")]
    public JukeBoxSectionParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JukeBoxSectionParam) null;
    }
  }
}
