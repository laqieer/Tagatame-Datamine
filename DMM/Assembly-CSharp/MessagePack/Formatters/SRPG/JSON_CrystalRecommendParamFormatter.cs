// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalRecommendParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006DB")]
  public sealed class JSON_CrystalRecommendParamFormatter : 
    IMessagePackFormatter<JSON_CrystalRecommendParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400124E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400124F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DDF")]
    [Address(RVA = "0xC10DB0", Offset = "0xC0FBB0", VA = "0x10C10DB0")]
    public JSON_CrystalRecommendParamFormatter()
    {
    }

    [Token(Token = "0x6001DE0")]
    [Address(RVA = "0xC10AC0", Offset = "0xC0F8C0", VA = "0x10C10AC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalRecommendParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DE1")]
    [Address(RVA = "0xC10690", Offset = "0xC0F490", VA = "0x10C10690", Slot = "5")]
    public JSON_CrystalRecommendParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalRecommendParam) null;
    }
  }
}
