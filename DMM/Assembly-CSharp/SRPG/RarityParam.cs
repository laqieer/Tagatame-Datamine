// Decompiled with JetBrains decompiler
// Type: SRPG.RarityParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E1A")]
  [MessagePackObject(true)]
  public class RarityParam
  {
    [Token(Token = "0x4007A7B")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int MAX_RARITY;
    [Token(Token = "0x4007A7C")]
    [FieldOffset(Offset = "0x8")]
    public OInt UnitLvCap;
    [Token(Token = "0x4007A7D")]
    [FieldOffset(Offset = "0x1C")]
    public OInt UnitJobLvCap;
    [Token(Token = "0x4007A7E")]
    [FieldOffset(Offset = "0x30")]
    public OInt UnitAwakeLvCap;
    [Token(Token = "0x4007A7F")]
    [FieldOffset(Offset = "0x44")]
    public OInt UnitUnlockPieceNum;
    [Token(Token = "0x4007A80")]
    [FieldOffset(Offset = "0x58")]
    public OInt UnitChangePieceNum;
    [Token(Token = "0x4007A81")]
    [FieldOffset(Offset = "0x6C")]
    public OInt UnitSelectChangePieceNum;
    [Token(Token = "0x4007A82")]
    [FieldOffset(Offset = "0x80")]
    public OInt UnitRarityUpCost;
    [Token(Token = "0x4007A83")]
    [FieldOffset(Offset = "0x94")]
    public OInt PieceToPoint;
    [Token(Token = "0x4007A84")]
    [FieldOffset(Offset = "0xA8")]
    public string DropSE;
    [Token(Token = "0x4007A85")]
    [FieldOffset(Offset = "0xAC")]
    public RarityEquipEnhanceParam EquipEnhanceParam;
    [Token(Token = "0x4007A86")]
    [FieldOffset(Offset = "0xB0")]
    public OInt ArtifactLvCap;
    [Token(Token = "0x4007A87")]
    [FieldOffset(Offset = "0xC4")]
    public OInt ArtifactCostRate;
    [Token(Token = "0x4007A88")]
    [FieldOffset(Offset = "0xD8")]
    public OInt ArtifactCreatePieceNum;
    [Token(Token = "0x4007A89")]
    [FieldOffset(Offset = "0xEC")]
    public OInt ArtifactGouseiPieceNum;
    [Token(Token = "0x4007A8A")]
    [FieldOffset(Offset = "0x100")]
    public OInt ArtifactChangePieceNum;
    [Token(Token = "0x4007A8B")]
    [FieldOffset(Offset = "0x114")]
    public OInt ArtifactCreateCost;
    [Token(Token = "0x4007A8C")]
    [FieldOffset(Offset = "0x128")]
    public OInt ArtifactRarityUpCost;
    [Token(Token = "0x4007A8D")]
    [FieldOffset(Offset = "0x13C")]
    public OInt ArtifactChangeCost;
    [Token(Token = "0x4007A8E")]
    [FieldOffset(Offset = "0x150")]
    public OInt ConceptCardLvCap;
    [Token(Token = "0x4007A8F")]
    [FieldOffset(Offset = "0x164")]
    public OInt ConceptCardAwakeCountMax;
    [Token(Token = "0x4007A90")]
    [FieldOffset(Offset = "0x178")]
    public OInt GachaChangePieceCoinNum;
    [Token(Token = "0x4007A91")]
    [FieldOffset(Offset = "0x18C")]
    public OInt CrystalPlusCap;
    [Token(Token = "0x4007A92")]
    [FieldOffset(Offset = "0x1A0")]
    public string CrystalRank;
    [Token(Token = "0x4007A93")]
    [FieldOffset(Offset = "0x1A4")]
    public OInt CardExtraRarityLvCap;
    [Token(Token = "0x4007A94")]
    [FieldOffset(Offset = "0x1B8")]
    public StatusParam GrowStatus;

    [Token(Token = "0x6007B8B")]
    [Address(RVA = "0x3E24B0", Offset = "0x3E12B0", VA = "0x103E24B0")]
    public bool Deserialize(JSON_RarityParam json) => new bool();

    [Token(Token = "0x6007B8C")]
    [Address(RVA = "0x3E2F70", Offset = "0x3E1D70", VA = "0x103E2F70")]
    public RarityParam()
    {
    }

    [Token(Token = "0x6007B8D")]
    [Address(RVA = "0x3E2F40", Offset = "0x3E1D40", VA = "0x103E2F40")]
    static RarityParam()
    {
    }
  }
}
