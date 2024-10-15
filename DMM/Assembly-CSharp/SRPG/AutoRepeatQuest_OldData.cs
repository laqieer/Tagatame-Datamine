// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRepeatQuest_OldData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001999")]
  public class AutoRepeatQuest_OldData
  {
    [Token(Token = "0x4005DCF")]
    [FieldOffset(Offset = "0x8")]
    public int player_lv;
    [Token(Token = "0x4005DD0")]
    [FieldOffset(Offset = "0xC")]
    public int player_exp;
    [Token(Token = "0x4005DD1")]
    [FieldOffset(Offset = "0x10")]
    public UnitData[] units;

    [Token(Token = "0x6006869")]
    [Address(RVA = "0x34B0A0", Offset = "0x349EA0", VA = "0x1034B0A0")]
    public void Init(Json_Unit[] json_units, int p_lv, int p_exp)
    {
    }

    [Token(Token = "0x600686A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AutoRepeatQuest_OldData()
    {
    }
  }
}
