// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt16Single
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003D6")]
  internal sealed class UInt16Single : ISingleDecoder
  {
    [Token(Token = "0x4000E32")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly ISingleDecoder Instance;

    [Token(Token = "0x60013D1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt16Single()
    {
    }

    [Token(Token = "0x60013D2")]
    [Address(RVA = "0x5CBB70", Offset = "0x5CA970", VA = "0x105CBB70", Slot = "4")]
    public float Read(byte[] bytes, int offset, out int readSize) => new float();

    [Token(Token = "0x60013D3")]
    [Address(RVA = "0x5CBBF0", Offset = "0x5CA9F0", VA = "0x105CBBF0")]
    static UInt16Single()
    {
    }
  }
}
