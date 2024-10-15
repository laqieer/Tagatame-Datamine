// Decompiled with JetBrains decompiler
// Type: SRPG.DynamicTransformUnitParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DF7")]
  [MessagePackObject(true)]
  public class DynamicTransformUnitParam
  {
    [Token(Token = "0x40078ED")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40078EE")]
    [FieldOffset(Offset = "0xC")]
    private string mTrUnitId;
    [Token(Token = "0x40078EF")]
    [FieldOffset(Offset = "0x10")]
    private int mTurn;
    [Token(Token = "0x40078F0")]
    [FieldOffset(Offset = "0x14")]
    private string mUpperToAbId;
    [Token(Token = "0x40078F1")]
    [FieldOffset(Offset = "0x18")]
    private string mLowerToAbId;
    [Token(Token = "0x40078F2")]
    [FieldOffset(Offset = "0x1C")]
    private string mReactToAbId;
    [Token(Token = "0x40078F3")]
    [FieldOffset(Offset = "0x20")]
    private string mCancelEffect;
    [Token(Token = "0x40078F4")]
    [FieldOffset(Offset = "0x24")]
    private int mCancelDisMs;
    [Token(Token = "0x40078F5")]
    [FieldOffset(Offset = "0x28")]
    private int mCancelAppMs;
    [Token(Token = "0x40078F6")]
    [FieldOffset(Offset = "0x2C")]
    private DynamicTransformUnitParam.Flags mFlags;

    [Token(Token = "0x170010A5")]
    public string Iname
    {
      [Token(Token = "0x6007A89"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010A6")]
    public string TrUnitId
    {
      [Token(Token = "0x6007A8A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010A7")]
    public int Turn
    {
      [Token(Token = "0x6007A8B"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170010A8")]
    public string UpperToAbId
    {
      [Token(Token = "0x6007A8C"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010A9")]
    public string LowerToAbId
    {
      [Token(Token = "0x6007A8D"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010AA")]
    public string ReactToAbId
    {
      [Token(Token = "0x6007A8E"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010AB")]
    public string CancelEffect
    {
      [Token(Token = "0x6007A8F"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010AC")]
    public int CancelDisMs
    {
      [Token(Token = "0x6007A90"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170010AD")]
    public int CancelAppMs
    {
      [Token(Token = "0x6007A91"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170010AE")]
    public bool IsNoWeaponAbility
    {
      [Token(Token = "0x6007A92"), Address(RVA = "0x3C0000", Offset = "0x3BEE00", VA = "0x103C0000")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170010AF")]
    public bool IsNoVisionAbility
    {
      [Token(Token = "0x6007A93"), Address(RVA = "0x3BFFF0", Offset = "0x3BEDF0", VA = "0x103BFFF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170010B0")]
    public bool IsNoItems
    {
      [Token(Token = "0x6007A94"), Address(RVA = "0x3BFFC0", Offset = "0x3BEDC0", VA = "0x103BFFC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170010B1")]
    public bool IsTransHpFull
    {
      [Token(Token = "0x6007A95"), Address(RVA = "0x3C0010", Offset = "0x3BEE10", VA = "0x103C0010")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170010B2")]
    public bool IsCancelHpFull
    {
      [Token(Token = "0x6007A96"), Address(RVA = "0x3BFED0", Offset = "0x3BECD0", VA = "0x103BFED0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170010B3")]
    public bool IsInheritSkin
    {
      [Token(Token = "0x6007A97"), Address(RVA = "0x3BFF70", Offset = "0x3BED70", VA = "0x103BFF70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170010B4")]
    public bool IsCancelUnitBase
    {
      [Token(Token = "0x6007A98"), Address(RVA = "0x3BFEE0", Offset = "0x3BECE0", VA = "0x103BFEE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170010B5")]
    public bool IsCtNoChange
    {
      [Token(Token = "0x6007A99"), Address(RVA = "0x3BFEF0", Offset = "0x3BECF0", VA = "0x103BFEF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170010B6")]
    public bool IsMaintainMoved
    {
      [Token(Token = "0x6007A9A"), Address(RVA = "0x3BFF80", Offset = "0x3BED80", VA = "0x103BFF80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170010B7")]
    public bool IsNoTruthAbility
    {
      [Token(Token = "0x6007A9B"), Address(RVA = "0x3BFFD0", Offset = "0x3BEDD0", VA = "0x103BFFD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170010B8")]
    public bool IsExitTruthAbility
    {
      [Token(Token = "0x6007A9C"), Address(RVA = "0x3BFF50", Offset = "0x3BED50", VA = "0x103BFF50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170010B9")]
    public bool IsNoInspAbility
    {
      [Token(Token = "0x6007A9D"), Address(RVA = "0x3BFFA0", Offset = "0x3BEDA0", VA = "0x103BFFA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170010BA")]
    public bool IsExitInspAbility
    {
      [Token(Token = "0x6007A9E"), Address(RVA = "0x3BFF10", Offset = "0x3BED10", VA = "0x103BFF10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170010BB")]
    public bool IsExitStoneAbility
    {
      [Token(Token = "0x6007A9F"), Address(RVA = "0x3BFF30", Offset = "0x3BED30", VA = "0x103BFF30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007AA0")]
    [Address(RVA = "0x3BF140", Offset = "0x3BDF40", VA = "0x103BF140")]
    public void Deserialize(JSON_DynamicTransformUnitParam json)
    {
    }

    [Token(Token = "0x6007AA1")]
    [Address(RVA = "0x3BFBF0", Offset = "0x3BE9F0", VA = "0x103BFBF0")]
    public bool IsUseSkill(UnitData unit_data, SkillData skill_data) => new bool();

    [Token(Token = "0x6007AA2")]
    [Address(RVA = "0x3BF280", Offset = "0x3BE080", VA = "0x103BF280")]
    public bool IsAbilityListHide(UnitData unit_data, SkillData skill_data) => new bool();

    [Token(Token = "0x6007AA3")]
    [Address(RVA = "0x3BF810", Offset = "0x3BE610", VA = "0x103BF810")]
    private bool IsFindTruthEquipmentData(UnitData unit_data, SkillData skill_data) => new bool();

    [Token(Token = "0x6007AA4")]
    [Address(RVA = "0x3BF310", Offset = "0x3BE110", VA = "0x103BF310")]
    private bool IsFindInspEquipmentData(UnitData unit_data, SkillData skill_data) => new bool();

    [Token(Token = "0x6007AA5")]
    [Address(RVA = "0x3BF4B0", Offset = "0x3BE2B0", VA = "0x103BF4B0")]
    private bool IsFindStoneEquipmentData(UnitData unit_data, SkillData skill_data) => new bool();

    [Token(Token = "0x6007AA6")]
    [Address(RVA = "0x3BF8F0", Offset = "0x3BE6F0", VA = "0x103BF8F0")]
    public bool IsUseSkill_InvaludSkill(UnitData unit_data, SkillData skill_data) => new bool();

    [Token(Token = "0x6007AA7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DynamicTransformUnitParam()
    {
    }

    [Token(Token = "0x2001DF8")]
    public enum Flags
    {
      [Token(Token = "0x40078F8")] IsNoWeaponAbility = 1,
      [Token(Token = "0x40078F9")] IsNoVisionAbility = 2,
      [Token(Token = "0x40078FA")] IsNoItems = 4,
      [Token(Token = "0x40078FB")] IsTransHpFull = 8,
      [Token(Token = "0x40078FC")] IsCancelHpFull = 16, // 0x00000010
      [Token(Token = "0x40078FD")] IsInheritSkin = 32, // 0x00000020
      [Token(Token = "0x40078FE")] IsCancelUnitBase = 64, // 0x00000040
      [Token(Token = "0x40078FF")] IsCtNoChange = 128, // 0x00000080
      [Token(Token = "0x4007900")] IsMaintainMoved = 256, // 0x00000100
      [Token(Token = "0x4007901")] IsNoTruthAbility = 512, // 0x00000200
      [Token(Token = "0x4007902")] IsExitTruthAbility = 1024, // 0x00000400
      [Token(Token = "0x4007903")] IsNoInspAbility = 2048, // 0x00000800
      [Token(Token = "0x4007904")] IsExitInspAbility = 4096, // 0x00001000
      [Token(Token = "0x4007905")] IsExitStoneAbility = 8192, // 0x00002000
    }
  }
}
