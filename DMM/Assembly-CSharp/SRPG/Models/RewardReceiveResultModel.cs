// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RewardReceiveResultModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003389")]
  public class RewardReceiveResultModel
  {
    [Token(Token = "0x400F3D0")]
    [FieldOffset(Offset = "0x8")]
    private RaidRewardType _raidRewardType;
    [Token(Token = "0x400F3D1")]
    [FieldOffset(Offset = "0xC")]
    private string _iname;
    [Token(Token = "0x400F3D2")]
    [FieldOffset(Offset = "0x10")]
    private int _num;
    [Token(Token = "0x400F3D3")]
    [FieldOffset(Offset = "0x14")]
    private string _name;
    [Token(Token = "0x400F3D4")]
    [FieldOffset(Offset = "0x18")]
    private Sprite _frameSprite;
    [Token(Token = "0x400F3D5")]
    [FieldOffset(Offset = "0x1C")]
    private ItemParam _itemParam;
    [Token(Token = "0x400F3D6")]
    [FieldOffset(Offset = "0x20")]
    private ArtifactParam _artifactParam;
    [Token(Token = "0x400F3D7")]
    [FieldOffset(Offset = "0x24")]
    private UnitData _unitData;
    [Token(Token = "0x400F3D8")]
    [FieldOffset(Offset = "0x28")]
    private ConceptCardData _conceptCardData;

    [Token(Token = "0x17001FCA")]
    public RaidRewardType Type
    {
      [Token(Token = "0x600E559"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new RaidRewardType();
      }
    }

    [Token(Token = "0x17001FCB")]
    public string Iname
    {
      [Token(Token = "0x600E55A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FCC")]
    public int Num
    {
      [Token(Token = "0x600E55B"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001FCD")]
    public string Name
    {
      [Token(Token = "0x600E55C"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FCE")]
    public Sprite FrameSprite
    {
      [Token(Token = "0x600E55D"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17001FCF")]
    public ItemParam ItemParam
    {
      [Token(Token = "0x600E55E"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (ItemParam) null;
      }
    }

    [Token(Token = "0x17001FD0")]
    public ArtifactParam ArtifactParam
    {
      [Token(Token = "0x600E55F"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (ArtifactParam) null;
      }
    }

    [Token(Token = "0x17001FD1")]
    public UnitData UnitData
    {
      [Token(Token = "0x600E560"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001FD2")]
    public ConceptCardData ConceptCardData
    {
      [Token(Token = "0x600E561"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (ConceptCardData) null;
      }
    }

    [Token(Token = "0x600E562")]
    [Address(RVA = "0xAC01B0", Offset = "0xABEFB0", VA = "0x10AC01B0")]
    public void Initialize(RewardReceiveResult.ReceiveData reward_data)
    {
    }

    [Token(Token = "0x600E563")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RewardReceiveResultModel()
    {
    }
  }
}
