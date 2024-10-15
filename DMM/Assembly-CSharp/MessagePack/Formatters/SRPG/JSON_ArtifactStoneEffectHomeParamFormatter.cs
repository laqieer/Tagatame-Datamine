// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ArtifactStoneEffectHomeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200088B")]
  public sealed class JSON_ArtifactStoneEffectHomeParamFormatter : 
    IMessagePackFormatter<JSON_ArtifactStoneEffectHomeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015A6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015A7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022EF")]
    [Address(RVA = "0xD9E3D0", Offset = "0xD9D1D0", VA = "0x10D9E3D0")]
    public JSON_ArtifactStoneEffectHomeParamFormatter()
    {
    }

    [Token(Token = "0x60022F0")]
    [Address(RVA = "0xD9E2A0", Offset = "0xD9D0A0", VA = "0x10D9E2A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ArtifactStoneEffectHomeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022F1")]
    [Address(RVA = "0xD9DF70", Offset = "0xD9CD70", VA = "0x10D9DF70", Slot = "5")]
    public JSON_ArtifactStoneEffectHomeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ArtifactStoneEffectHomeParam) null;
    }
  }
}
