// Decompiled with JetBrains decompiler
// Type: SRPG.TruthEquipmentData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001179")]
  [MessagePackObject(true)]
  public class TruthEquipmentData
  {
    [Token(Token = "0x4003F4C")]
    [FieldOffset(Offset = "0x8")]
    private int m_Lv;
    [Token(Token = "0x4003F4D")]
    [FieldOffset(Offset = "0xC")]
    private BaseStatus m_AddStatus;
    [Token(Token = "0x4003F4E")]
    [FieldOffset(Offset = "0x10")]
    private BaseStatus m_ScaleStatus;
    [Token(Token = "0x4003F4F")]
    [FieldOffset(Offset = "0x14")]
    private List<AbilityData> m_LearnedAbility;
    [Token(Token = "0x4003F50")]
    [FieldOffset(Offset = "0x18")]
    private TruthEquipmentParam m_TruthEquipmentParam;

    [Token(Token = "0x17000824")]
    [IgnoreMember]
    public int Lv
    {
      [Token(Token = "0x6004A86"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000825")]
    [IgnoreMember]
    public List<AbilityData> LearnedAbility
    {
      [Token(Token = "0x6004A87"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<AbilityData>) null;
      }
    }

    [Token(Token = "0x17000826")]
    [IgnoreMember]
    public TruthEquipmentParam Param
    {
      [Token(Token = "0x6004A88"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (TruthEquipmentParam) null;
      }
    }

    [Token(Token = "0x17000827")]
    [IgnoreMember]
    public bool IsLvMax
    {
      [Token(Token = "0x6004A89"), Address(RVA = "0x1212BC0", Offset = "0x12119C0", VA = "0x11212BC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000828")]
    [IgnoreMember]
    public bool IsEnable
    {
      [Token(Token = "0x6004A8A"), Address(RVA = "0x1212BA0", Offset = "0x12119A0", VA = "0x11212BA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004A8B")]
    [Address(RVA = "0x1212A80", Offset = "0x1211880", VA = "0x11212A80")]
    public void Setup(string unitIname, int lv)
    {
    }

    [Token(Token = "0x6004A8C")]
    [Address(RVA = "0x12126A0", Offset = "0x12114A0", VA = "0x112126A0")]
    public void AddBaseStatus(ref BaseStatus add, ref BaseStatus scale)
    {
    }

    [Token(Token = "0x6004A8D")]
    [Address(RVA = "0x12129F0", Offset = "0x12117F0", VA = "0x112129F0")]
    public void GetNextLvRecipe(
      ref int totalZenny,
      ref Dictionary<string, int> totalItems,
      int _add_level)
    {
    }

    [Token(Token = "0x6004A8E")]
    [Address(RVA = "0x1212A20", Offset = "0x1211820", VA = "0x11212A20")]
    public string Serialize() => (string) null;

    [Token(Token = "0x6004A8F")]
    [Address(RVA = "0x12126E0", Offset = "0x12114E0", VA = "0x112126E0")]
    public bool CanLvup(int _add_level = 1) => new bool();

    [Token(Token = "0x6004A90")]
    [Address(RVA = "0x1212710", Offset = "0x1211510", VA = "0x11212710")]
    public bool CanLvup(ref eTruthEquipmentCanLvupError errors, int _add_level) => new bool();

    [Token(Token = "0x6004A91")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TruthEquipmentData()
    {
    }
  }
}
