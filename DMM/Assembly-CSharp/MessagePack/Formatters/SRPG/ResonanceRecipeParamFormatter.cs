// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ResonanceRecipeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000848")]
  public sealed class ResonanceRecipeParamFormatter : 
    IMessagePackFormatter<ResonanceRecipeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001520")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001521")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002226")]
    [Address(RVA = "0xD7F370", Offset = "0xD7E170", VA = "0x10D7F370")]
    public ResonanceRecipeParamFormatter()
    {
    }

    [Token(Token = "0x6002227")]
    [Address(RVA = "0xD7F190", Offset = "0xD7DF90", VA = "0x10D7F190", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ResonanceRecipeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002228")]
    [Address(RVA = "0xD7EE80", Offset = "0xD7DC80", VA = "0x10D7EE80", Slot = "5")]
    public ResonanceRecipeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ResonanceRecipeParam) null;
    }
  }
}
