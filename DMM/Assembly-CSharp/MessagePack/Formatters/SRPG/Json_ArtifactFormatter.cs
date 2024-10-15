// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_ArtifactFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005A8")]
  public sealed class Json_ArtifactFormatter : 
    IMessagePackFormatter<Json_Artifact>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FE8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FE9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A46")]
    [Address(RVA = "0x797510", Offset = "0x796310", VA = "0x10797510")]
    public Json_ArtifactFormatter()
    {
    }

    [Token(Token = "0x6001A47")]
    [Address(RVA = "0x797170", Offset = "0x795F70", VA = "0x10797170", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Artifact value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A48")]
    [Address(RVA = "0x796C90", Offset = "0x795A90", VA = "0x10796C90", Slot = "5")]
    public Json_Artifact Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Artifact) null;
    }
  }
}
