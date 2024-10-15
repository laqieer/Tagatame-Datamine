// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AreaCombatPower
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A45")]
  [MessagePackObject(true)]
  public class JSON_AreaCombatPower
  {
    [Token(Token = "0x40060C3")]
    [FieldOffset(Offset = "0x8")]
    public string i;
    [Token(Token = "0x40060C4")]
    [FieldOffset(Offset = "0xC")]
    public int c_pow;

    [Token(Token = "0x6006C02")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AreaCombatPower()
    {
    }
  }
}
