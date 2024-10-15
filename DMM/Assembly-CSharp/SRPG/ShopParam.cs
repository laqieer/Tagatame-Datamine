// Decompiled with JetBrains decompiler
// Type: SRPG.ShopParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D1C")]
  public class ShopParam
  {
    [Token(Token = "0x400722F")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007230")]
    [FieldOffset(Offset = "0xC")]
    public ESaleType UpdateCostType;
    [Token(Token = "0x4007231")]
    [FieldOffset(Offset = "0x10")]
    public int[] UpdateCosts;

    [Token(Token = "0x6007778")]
    [Address(RVA = "0x39F610", Offset = "0x39E410", VA = "0x1039F610")]
    public bool Deserialize(JSON_ShopParam json) => new bool();

    [Token(Token = "0x6007779")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ShopParam()
    {
    }
  }
}
