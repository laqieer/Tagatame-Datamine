// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ResetCostInfoParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000695")]
  public sealed class JSON_ResetCostInfoParamFormatter : 
    IMessagePackFormatter<JSON_ResetCostInfoParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011C2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011C3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D0D")]
    [Address(RVA = "0xC01ED0", Offset = "0xC00CD0", VA = "0x10C01ED0")]
    public JSON_ResetCostInfoParamFormatter()
    {
    }

    [Token(Token = "0x6001D0E")]
    [Address(RVA = "0xC01CB0", Offset = "0xC00AB0", VA = "0x10C01CB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ResetCostInfoParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D0F")]
    [Address(RVA = "0xC01930", Offset = "0xC00730", VA = "0x10C01930", Slot = "5")]
    public JSON_ResetCostInfoParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ResetCostInfoParam) null;
    }
  }
}
