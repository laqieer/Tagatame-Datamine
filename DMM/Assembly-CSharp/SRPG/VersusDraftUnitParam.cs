// Decompiled with JetBrains decompiler
// Type: SRPG.VersusDraftUnitParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EBA")]
  public class VersusDraftUnitParam
  {
    [Token(Token = "0x40080DB")]
    [FieldOffset(Offset = "0x10")]
    private long mId;
    [Token(Token = "0x40080DC")]
    [FieldOffset(Offset = "0x18")]
    private long mDraftUnitId;
    [Token(Token = "0x40080DD")]
    [FieldOffset(Offset = "0x20")]
    private int mWeight;
    [Token(Token = "0x40080DE")]
    [FieldOffset(Offset = "0x28")]
    private long mDummyIID;
    [Token(Token = "0x40080DF")]
    [FieldOffset(Offset = "0x30")]
    private string mUnitIName;
    [Token(Token = "0x40080E0")]
    [FieldOffset(Offset = "0x34")]
    private int mRare;
    [Token(Token = "0x40080E1")]
    [FieldOffset(Offset = "0x38")]
    private int mAwake;
    [Token(Token = "0x40080E2")]
    [FieldOffset(Offset = "0x3C")]
    private int mLevel;
    [Token(Token = "0x40080E3")]
    [FieldOffset(Offset = "0x40")]
    private int mSelectJobIndex;
    [Token(Token = "0x40080E4")]
    [FieldOffset(Offset = "0x44")]
    private List<VersusDraftUnitJob> mVersusDraftUnitJobs;
    [Token(Token = "0x40080E5")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<string, VersusDraftUnitAbility> mAbilities;
    [Token(Token = "0x40080E6")]
    [FieldOffset(Offset = "0x4C")]
    private List<VersusDraftUnitArtifact> mVersusDraftUnitArtifacts;
    [Token(Token = "0x40080E7")]
    [FieldOffset(Offset = "0x50")]
    private List<VersusDraftUnitConceptCard> mVersusDraftUnitConceptCards;
    [Token(Token = "0x40080E8")]
    [FieldOffset(Offset = "0x54")]
    private bool mIsSelectConceptCardLS;
    [Token(Token = "0x40080E9")]
    [FieldOffset(Offset = "0x58")]
    private List<VersusDraftUnitDoor> mVersusDraftUnitDoors;
    [Token(Token = "0x40080EA")]
    [FieldOffset(Offset = "0x5C")]
    private string mMasterAbilityIName;
    [Token(Token = "0x40080EB")]
    [FieldOffset(Offset = "0x60")]
    private string mSkinIName;
    [Token(Token = "0x40080EC")]
    [FieldOffset(Offset = "0x64")]
    private string[] mClearQuestIName;

    [Token(Token = "0x1700119B")]
    public bool IsSecret
    {
      [Token(Token = "0x6007DD8"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007DD9"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] set
      {
      }
    }

    [Token(Token = "0x1700119C")]
    public bool IsHidden
    {
      [Token(Token = "0x6007DDA"), Address(RVA = "0x34B080", Offset = "0x349E80", VA = "0x1034B080")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007DDB"), Address(RVA = "0x3FA400", Offset = "0x3F9200", VA = "0x103FA400")] set
      {
      }
    }

    [Token(Token = "0x1700119D")]
    public long Id
    {
      [Token(Token = "0x6007DDC"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x1700119E")]
    public long DraftUnitId
    {
      [Token(Token = "0x6007DDD"), Address(RVA = "0x34F480", Offset = "0x34E280", VA = "0x1034F480")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x1700119F")]
    public int Weight
    {
      [Token(Token = "0x6007DDE"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007DDF")]
    [Address(RVA = "0x3F80A0", Offset = "0x3F6EA0", VA = "0x103F80A0")]
    public bool Deserialize(long dummy_iid, JSON_VersusDraftUnitParam param) => new bool();

    [Token(Token = "0x6007DE0")]
    [Address(RVA = "0x3F8CC0", Offset = "0x3F7AC0", VA = "0x103F8CC0")]
    public Json_Unit GetJson_Unit(bool is_enable_concept_card_ls = false) => (Json_Unit) null;

    [Token(Token = "0x6007DE1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusDraftUnitParam()
    {
    }
  }
}
