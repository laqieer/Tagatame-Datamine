// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_BondGroupBuffParamDetailFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006B2")]
  public sealed class Json_BondGroupBuffParamDetailFormatter : 
    IMessagePackFormatter<Json_BondGroupBuffParamDetail>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011FC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011FD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D64")]
    [Address(RVA = "0xC1E8C0", Offset = "0xC1D6C0", VA = "0x10C1E8C0")]
    public Json_BondGroupBuffParamDetailFormatter()
    {
    }

    [Token(Token = "0x6001D65")]
    [Address(RVA = "0xC1E460", Offset = "0xC1D260", VA = "0x10C1E460", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_BondGroupBuffParamDetail value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D66")]
    [Address(RVA = "0xC1DE40", Offset = "0xC1CC40", VA = "0x10C1DE40", Slot = "5")]
    public Json_BondGroupBuffParamDetail Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_BondGroupBuffParamDetail) null;
    }
  }
}
