// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixArrayHeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003B2")]
  internal sealed class FixArrayHeader : IArrayHeaderDecoder
  {
    [Token(Token = "0x4000E14")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IArrayHeaderDecoder Instance;

    [Token(Token = "0x6001371")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixArrayHeader()
    {
    }

    [Token(Token = "0x6001372")]
    [Address(RVA = "0x5BEC10", Offset = "0x5BDA10", VA = "0x105BEC10", Slot = "4")]
    public uint Read(byte[] bytes, int offset, out int readSize) => new uint();

    [Token(Token = "0x6001373")]
    [Address(RVA = "0x5BEC40", Offset = "0x5BDA40", VA = "0x105BEC40")]
    static FixArrayHeader()
    {
    }
  }
}
