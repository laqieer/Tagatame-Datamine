// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.InvalidArrayHeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003B5")]
  internal sealed class InvalidArrayHeader : IArrayHeaderDecoder
  {
    [Token(Token = "0x4000E17")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IArrayHeaderDecoder Instance;

    [Token(Token = "0x600137A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private InvalidArrayHeader()
    {
    }

    [Token(Token = "0x600137B")]
    [Address(RVA = "0x5C2C60", Offset = "0x5C1A60", VA = "0x105C2C60", Slot = "4")]
    public uint Read(byte[] bytes, int offset, out int readSize) => new uint();

    [Token(Token = "0x600137C")]
    [Address(RVA = "0x5C2D20", Offset = "0x5C1B20", VA = "0x105C2D20")]
    static InvalidArrayHeader()
    {
    }
  }
}
