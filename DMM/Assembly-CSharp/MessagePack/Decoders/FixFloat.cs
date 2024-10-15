// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixFloat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003D0")]
  internal sealed class FixFloat : ISingleDecoder
  {
    [Token(Token = "0x4000E2C")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly ISingleDecoder Instance;

    [Token(Token = "0x60013BF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixFloat()
    {
    }

    [Token(Token = "0x60013C0")]
    [Address(RVA = "0x5BFE80", Offset = "0x5BEC80", VA = "0x105BFE80", Slot = "4")]
    public float Read(byte[] bytes, int offset, out int readSize) => new float();

    [Token(Token = "0x60013C1")]
    [Address(RVA = "0x5BFF00", Offset = "0x5BED00", VA = "0x105BFF00")]
    static FixFloat()
    {
    }
  }
}
