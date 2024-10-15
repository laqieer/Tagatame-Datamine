// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneStateDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000785")]
  public sealed class RuneStateDataFormatter : 
    IMessagePackFormatter<RuneStateData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013A2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013A3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FDD")]
    [Address(RVA = "0xCD3840", Offset = "0xCD2640", VA = "0x10CD3840")]
    public RuneStateDataFormatter()
    {
    }

    [Token(Token = "0x6001FDE")]
    [Address(RVA = "0xCD35C0", Offset = "0xCD23C0", VA = "0x10CD35C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneStateData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FDF")]
    [Address(RVA = "0xCD3250", Offset = "0xCD2050", VA = "0x10CD3250", Slot = "5")]
    public RuneStateData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RuneStateData) null;
    }
  }
}
