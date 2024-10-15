// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ResonanceRecipeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006C5")]
  public sealed class JSON_ResonanceRecipeParamFormatter : 
    IMessagePackFormatter<JSON_ResonanceRecipeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001222")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001223")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D9D")]
    [Address(RVA = "0xC1A1F0", Offset = "0xC18FF0", VA = "0x10C1A1F0")]
    public JSON_ResonanceRecipeParamFormatter()
    {
    }

    [Token(Token = "0x6001D9E")]
    [Address(RVA = "0xC1A010", Offset = "0xC18E10", VA = "0x10C1A010", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ResonanceRecipeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D9F")]
    [Address(RVA = "0xC19CD0", Offset = "0xC18AD0", VA = "0x10C19CD0", Slot = "5")]
    public JSON_ResonanceRecipeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ResonanceRecipeParam) null;
    }
  }
}
