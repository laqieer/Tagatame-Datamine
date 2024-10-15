// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqArtifactStoneOpen_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009B0")]
  public sealed class ReqArtifactStoneOpen_ResponseFormatter : 
    IMessagePackFormatter<ReqArtifactStoneOpen.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017F0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017F1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600265E")]
    [Address(RVA = "0xE3FBE0", Offset = "0xE3E9E0", VA = "0x10E3FBE0")]
    public ReqArtifactStoneOpen_ResponseFormatter()
    {
    }

    [Token(Token = "0x600265F")]
    [Address(RVA = "0xE3FA80", Offset = "0xE3E880", VA = "0x10E3FA80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqArtifactStoneOpen.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002660")]
    [Address(RVA = "0xE3F740", Offset = "0xE3E540", VA = "0x10E3F740", Slot = "5")]
    public ReqArtifactStoneOpen.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqArtifactStoneOpen.Response) null;
    }
  }
}
