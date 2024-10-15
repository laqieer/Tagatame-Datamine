// Decompiled with JetBrains decompiler
// Type: SRPG.InspirationSkillData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FC7")]
  [MessagePackObject(true)]
  public class InspirationSkillData
  {
    [Token(Token = "0x40037B6")]
    [FieldOffset(Offset = "0x8")]
    private OLong mUniqueID;
    [Token(Token = "0x40037B7")]
    [FieldOffset(Offset = "0x30")]
    private OInt mSlot;
    [Token(Token = "0x40037B8")]
    [FieldOffset(Offset = "0x44")]
    private InspSkillParam mInspSkillParam;
    [Token(Token = "0x40037B9")]
    [FieldOffset(Offset = "0x48")]
    private OInt mLv;
    [Token(Token = "0x40037BA")]
    [FieldOffset(Offset = "0x5C")]
    private OBool mIsSet;
    [Token(Token = "0x40037BB")]
    [FieldOffset(Offset = "0x68")]
    private AbilityData mAbilityData;

    [Token(Token = "0x170005DB")]
    public OLong UniqueID
    {
      [Token(Token = "0x60041A3"), Address(RVA = "0x305BB0", Offset = "0x3049B0", VA = "0x10305BB0")] get
      {
        return new OLong();
      }
    }

    [Token(Token = "0x170005DC")]
    public OInt Slot
    {
      [Token(Token = "0x60041A4"), Address(RVA = "0x4791D0", Offset = "0x477FD0", VA = "0x104791D0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170005DD")]
    public InspSkillParam InspSkillParam
    {
      [Token(Token = "0x60041A5"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return (InspSkillParam) null;
      }
    }

    [Token(Token = "0x170005DE")]
    public OInt Lv
    {
      [Token(Token = "0x60041A6"), Address(RVA = "0x1196310", Offset = "0x1195110", VA = "0x11196310")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170005DF")]
    public OBool IsSet
    {
      [Token(Token = "0x60041A7"), Address(RVA = "0x11962F0", Offset = "0x11950F0", VA = "0x111962F0")] get
      {
        return new OBool();
      }
    }

    [Token(Token = "0x170005E0")]
    public AbilityData AbilityData
    {
      [Token(Token = "0x60041A8"), Address(RVA = "0x349350", Offset = "0x348150", VA = "0x10349350")] get
      {
        return (AbilityData) null;
      }
    }

    [Token(Token = "0x60041A9")]
    [Address(RVA = "0x1195E80", Offset = "0x1194C80", VA = "0x11195E80")]
    public bool Deserialize(Json_InspirationSkill json) => new bool();

    [Token(Token = "0x60041AA")]
    [Address(RVA = "0x11961C0", Offset = "0x1194FC0", VA = "0x111961C0")]
    private int LevelToAbilityExp(int lv) => new int();

    [Token(Token = "0x60041AB")]
    [Address(RVA = "0x11961E0", Offset = "0x1194FE0", VA = "0x111961E0")]
    public Json_InspirationSkill ToJson() => (Json_InspirationSkill) null;

    [Token(Token = "0x60041AC")]
    [Address(RVA = "0x11960A0", Offset = "0x1194EA0", VA = "0x111960A0")]
    public bool IsIncludeSkill(SkillData skill) => new bool();

    [Token(Token = "0x60041AD")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public InspirationSkillData()
    {
    }
  }
}
