// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Int8Single
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003D1")]
  internal sealed class Int8Single : ISingleDecoder
  {
    [Token(Token = "0x4000E2D")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly ISingleDecoder Instance;

    [Token(Token = "0x60013C2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int8Single()
    {
    }

    [Token(Token = "0x60013C3")]
    [Address(RVA = "0x5C2B80", Offset = "0x5C1980", VA = "0x105C2B80", Slot = "4")]
    public float Read(byte[] bytes, int offset, out int readSize) => new float();

    [Token(Token = "0x60013C4")]
    [Address(RVA = "0x5C2C00", Offset = "0x5C1A00", VA = "0x105C2C00")]
    static Int8Single()
    {
    }
  }
}
