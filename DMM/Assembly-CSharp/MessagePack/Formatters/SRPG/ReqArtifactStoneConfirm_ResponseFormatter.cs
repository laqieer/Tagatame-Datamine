// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqArtifactStoneConfirm_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009B2")]
  public sealed class ReqArtifactStoneConfirm_ResponseFormatter : 
    IMessagePackFormatter<ReqArtifactStoneConfirm.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017F4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017F5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002664")]
    [Address(RVA = "0xE3EEB0", Offset = "0xE3DCB0", VA = "0x10E3EEB0")]
    public ReqArtifactStoneConfirm_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002665")]
    [Address(RVA = "0xE3EDB0", Offset = "0xE3DBB0", VA = "0x10E3EDB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqArtifactStoneConfirm.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002666")]
    [Address(RVA = "0xE3EAE0", Offset = "0xE3D8E0", VA = "0x10E3EAE0", Slot = "5")]
    public ReqArtifactStoneConfirm.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqArtifactStoneConfirm.Response) null;
    }
  }
}
