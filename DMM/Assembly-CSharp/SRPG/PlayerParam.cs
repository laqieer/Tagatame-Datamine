// Decompiled with JetBrains decompiler
// Type: SRPG.PlayerParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BFC")]
  public class PlayerParam
  {
    [Token(Token = "0x4006C52")]
    [FieldOffset(Offset = "0x8")]
    public OInt pt;
    [Token(Token = "0x4006C53")]
    [FieldOffset(Offset = "0x1C")]
    public OInt ucap;
    [Token(Token = "0x4006C54")]
    [FieldOffset(Offset = "0x30")]
    public OInt icap;
    [Token(Token = "0x4006C55")]
    [FieldOffset(Offset = "0x44")]
    public OInt ecap;
    [Token(Token = "0x4006C56")]
    [FieldOffset(Offset = "0x58")]
    public OInt fcap;

    [Token(Token = "0x600733E")]
    [Address(RVA = "0x37D020", Offset = "0x37BE20", VA = "0x1037D020")]
    public bool Deserialize(JSON_PlayerParam json) => new bool();

    [Token(Token = "0x600733F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PlayerParam()
    {
    }
  }
}
