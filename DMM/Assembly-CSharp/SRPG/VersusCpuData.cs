// Decompiled with JetBrains decompiler
// Type: SRPG.VersusCpuData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011DF")]
  public class VersusCpuData : ICombatPowerContent
  {
    [Token(Token = "0x40040F9")]
    [FieldOffset(Offset = "0x8")]
    public string Name;
    [Token(Token = "0x40040FA")]
    [FieldOffset(Offset = "0xC")]
    public int Lv;
    [Token(Token = "0x40040FB")]
    [FieldOffset(Offset = "0x10")]
    public UnitData[] Units;
    [Token(Token = "0x40040FC")]
    [FieldOffset(Offset = "0x14")]
    public int[] Place;
    [Token(Token = "0x40040FD")]
    [FieldOffset(Offset = "0x18")]
    public int Score;
    [Token(Token = "0x40040FE")]
    [FieldOffset(Offset = "0x1C")]
    public int Deck;
    [Token(Token = "0x40040FF")]
    [FieldOffset(Offset = "0x20")]
    public int RankMatchNpcId;
    [Token(Token = "0x4004100")]
    [FieldOffset(Offset = "0x24")]
    public string AwardId;

    [Token(Token = "0x1700085F")]
    public long CombatPower
    {
      [Token(Token = "0x6004BC5"), Address(RVA = "0x1221AD0", Offset = "0x12208D0", VA = "0x11221AD0", Slot = "4")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x6004BC6")]
    [Address(RVA = "0x12218E0", Offset = "0x12206E0", VA = "0x112218E0")]
    public bool Deserialize(Json_VersusCpuData json, int idx) => new bool();

    [Token(Token = "0x6004BC7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusCpuData()
    {
    }
  }
}
