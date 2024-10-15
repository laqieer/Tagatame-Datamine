// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReplacePeriodFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AEA")]
  public sealed class ReplacePeriodFormatter : 
    IMessagePackFormatter<ReplacePeriod>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A64")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A65")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A0C")]
    [Address(RVA = "0xF25580", Offset = "0xF24380", VA = "0x10F25580")]
    public ReplacePeriodFormatter()
    {
    }

    [Token(Token = "0x6002A0D")]
    [Address(RVA = "0xF253D0", Offset = "0xF241D0", VA = "0x10F253D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReplacePeriod value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A0E")]
    [Address(RVA = "0xF25040", Offset = "0xF23E40", VA = "0x10F25040", Slot = "5")]
    public ReplacePeriod Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReplacePeriod) null;
    }
  }
}
