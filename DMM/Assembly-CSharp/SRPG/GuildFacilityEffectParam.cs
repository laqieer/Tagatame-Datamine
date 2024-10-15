// Decompiled with JetBrains decompiler
// Type: SRPG.GuildFacilityEffectParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B43")]
  public class GuildFacilityEffectParam
  {
    [Token(Token = "0x40067EC")]
    [FieldOffset(Offset = "0x8")]
    public int lv;
    [Token(Token = "0x40067ED")]
    [FieldOffset(Offset = "0xC")]
    public int training_limit;
    [Token(Token = "0x40067EE")]
    [FieldOffset(Offset = "0x10")]
    public string[] buff_effect;
    [Token(Token = "0x40067EF")]
    [FieldOffset(Offset = "0x14")]
    public int member_count;
    [Token(Token = "0x40067F0")]
    [FieldOffset(Offset = "0x18")]
    public int sub_master;
    [Token(Token = "0x40067F1")]
    [FieldOffset(Offset = "0x1C")]
    public int shop_count;

    [Token(Token = "0x6007054")]
    [Address(RVA = "0x36EC70", Offset = "0x36DA70", VA = "0x1036EC70")]
    public bool Deserialize(JSON_GuildFacilityEffectParam json) => new bool();

    [Token(Token = "0x6007055")]
    [Address(RVA = "0x36ED90", Offset = "0x36DB90", VA = "0x1036ED90")]
    public int GetEffectCount() => new int();

    [Token(Token = "0x6007056")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildFacilityEffectParam()
    {
    }
  }
}
