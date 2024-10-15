// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqArtifactSet_OverWrite_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007EC")]
  public sealed class ReqArtifactSet_OverWrite_ResponseFormatter : 
    IMessagePackFormatter<ReqArtifactSet_OverWrite.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001468")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001469")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002112")]
    [Address(RVA = "0xD395B0", Offset = "0xD383B0", VA = "0x10D395B0")]
    public ReqArtifactSet_OverWrite_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002113")]
    [Address(RVA = "0xD393D0", Offset = "0xD381D0", VA = "0x10D393D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqArtifactSet_OverWrite.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002114")]
    [Address(RVA = "0xD39090", Offset = "0xD37E90", VA = "0x10D39090", Slot = "5")]
    public ReqArtifactSet_OverWrite.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqArtifactSet_OverWrite.Response) null;
    }
  }
}
