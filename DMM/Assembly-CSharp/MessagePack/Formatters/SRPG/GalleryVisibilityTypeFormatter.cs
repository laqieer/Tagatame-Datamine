// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.GalleryVisibilityTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200055A")]
  public sealed class GalleryVisibilityTypeFormatter : 
    IMessagePackFormatter<GalleryVisibilityType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600195C")]
    [Address(RVA = "0x69EBD0", Offset = "0x69D9D0", VA = "0x1069EBD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      GalleryVisibilityType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600195D")]
    [Address(RVA = "0x69EB80", Offset = "0x69D980", VA = "0x1069EB80", Slot = "5")]
    public GalleryVisibilityType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new GalleryVisibilityType();
    }

    [Token(Token = "0x600195E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GalleryVisibilityTypeFormatter()
    {
    }
  }
}
