// Decompiled with JetBrains decompiler
// Type: SRPG.UnitSubSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C21")]
  public class UnitSubSetting
  {
    [Token(Token = "0x4001F94")]
    [FieldOffset(Offset = "0x8")]
    public eMapUnitCtCalcType startCtCalc;
    [Token(Token = "0x4001F95")]
    [FieldOffset(Offset = "0xC")]
    public OInt startCtVal;

    [Token(Token = "0x6003034")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitSubSetting()
    {
    }

    [Token(Token = "0x6003035")]
    [Address(RVA = "0xFEBDA0", Offset = "0xFEABA0", VA = "0x10FEBDA0")]
    public UnitSubSetting(JSON_MapPartySubCT json)
    {
    }
  }
}
