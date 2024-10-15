// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ArtifactSlots_MP_ArtifactSet_OverWriteResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007ED")]
  public sealed class ArtifactSlots_MP_ArtifactSet_OverWriteResponseFormatter : 
    IMessagePackFormatter<ArtifactSlots.MP_ArtifactSet_OverWriteResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400146A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400146B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002115")]
    [Address(RVA = "0xD28BF0", Offset = "0xD279F0", VA = "0x10D28BF0")]
    public ArtifactSlots_MP_ArtifactSet_OverWriteResponseFormatter()
    {
    }

    [Token(Token = "0x6002116")]
    [Address(RVA = "0xD28900", Offset = "0xD27700", VA = "0x10D28900", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ArtifactSlots.MP_ArtifactSet_OverWriteResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002117")]
    [Address(RVA = "0xD284D0", Offset = "0xD272D0", VA = "0x10D284D0", Slot = "5")]
    public ArtifactSlots.MP_ArtifactSet_OverWriteResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ArtifactSlots.MP_ArtifactSet_OverWriteResponse) null;
    }
  }
}
