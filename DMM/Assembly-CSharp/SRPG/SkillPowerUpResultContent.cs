// Decompiled with JetBrains decompiler
// Type: SRPG.SkillPowerUpResultContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AC4")]
  [AddComponentMenu("UI/SkillPowerUpResultContent")]
  public class SkillPowerUpResultContent : MonoBehaviour
  {
    [Token(Token = "0x400D093")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SkillPowerUpResultContentStatus statusBase;
    [Token(Token = "0x400D094")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text skillNameText;
    [Token(Token = "0x400D095")]
    [FieldOffset(Offset = "0x14")]
    private List<SkillPowerUpResultContentStatus> contentsList;

    [Token(Token = "0x600C348")]
    [Address(RVA = "0x8CC240", Offset = "0x8CB040", VA = "0x108CC240")]
    public void Start()
    {
    }

    [Token(Token = "0x600C349")]
    [Address(RVA = "0x8CBBA0", Offset = "0x8CA9A0", VA = "0x108CBBA0")]
    public void SetData(
      SkillPowerUpResultContent.Param param,
      List<ParamTypes> dispTypeList,
      List<ParamTypes> dispTypeListMul)
    {
    }

    [Token(Token = "0x600C34A")]
    [Address(RVA = "0x8CC270", Offset = "0x8CB070", VA = "0x108CC270")]
    public SkillPowerUpResultContent()
    {
    }

    [Token(Token = "0x2002AC5")]
    public class DispType
    {
      [Token(Token = "0x400D096")]
      [FieldOffset(Offset = "0x8")]
      public bool isScale;
      [Token(Token = "0x400D097")]
      [FieldOffset(Offset = "0xA")]
      public ParamTypes type;

      [Token(Token = "0x600C34B")]
      [Address(RVA = "0x8C17D0", Offset = "0x8C05D0", VA = "0x108C17D0")]
      public DispType(ParamTypes inType, bool inIsScale)
      {
      }
    }

    [Token(Token = "0x2002AC6")]
    public class Param
    {
      [Token(Token = "0x400D099")]
      [FieldOffset(Offset = "0xC")]
      public BaseStatus prevParam;
      [Token(Token = "0x400D09A")]
      [FieldOffset(Offset = "0x10")]
      public BaseStatus prevParamMul;
      [Token(Token = "0x400D09B")]
      [FieldOffset(Offset = "0x14")]
      public BaseStatus currentParam;
      [Token(Token = "0x400D09C")]
      [FieldOffset(Offset = "0x18")]
      public BaseStatus currentParamMul;
      [Token(Token = "0x400D09D")]
      [FieldOffset(Offset = "0x1C")]
      public BaseStatus prevParamBonus;
      [Token(Token = "0x400D09E")]
      [FieldOffset(Offset = "0x20")]
      public BaseStatus prevParamBonusMul;
      [Token(Token = "0x400D09F")]
      [FieldOffset(Offset = "0x24")]
      public BaseStatus currentParamBonus;
      [Token(Token = "0x400D0A0")]
      [FieldOffset(Offset = "0x28")]
      public BaseStatus currentParamBonusMul;
      [Token(Token = "0x400D0A1")]
      [FieldOffset(Offset = "0x2C")]
      private List<ParamTypes> typeList;
      [Token(Token = "0x400D0A2")]
      [FieldOffset(Offset = "0x30")]
      private List<ParamTypes> typeListMul;

      [Token(Token = "0x170019FF")]
      public string skilName
      {
        [Token(Token = "0x600C34C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600C34D"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
        {
        }
      }

      [Token(Token = "0x600C34E")]
      [Address(RVA = "0x8C1E30", Offset = "0x8C0C30", VA = "0x108C1E30")]
      public Param(
        SkillData groupSkill,
        ConceptCardData currentCardData,
        int levelCap,
        int awakeCountCap,
        int prevLevel,
        int prevAwakeCount,
        bool includeMaxPowerUp)
      {
      }

      [Token(Token = "0x600C34F")]
      [Address(RVA = "0x8C1B30", Offset = "0x8C0930", VA = "0x108C1B30")]
      public int GetBonusChangeTypeNum(bool scalingStatus) => new int();

      [Token(Token = "0x600C350")]
      [Address(RVA = "0x8C1DE0", Offset = "0x8C0BE0", VA = "0x108C1DE0")]
      public bool IsBonusParamChanged() => new bool();

      [Token(Token = "0x600C351")]
      [Address(RVA = "0x8C1AC0", Offset = "0x8C08C0", VA = "0x108C1AC0")]
      public IEnumerable<SkillPowerUpResultContent.DispType> GetAllBonusChangeType()
      {
        return (IEnumerable<SkillPowerUpResultContent.DispType>) null;
      }

      [Token(Token = "0x600C352")]
      [Address(RVA = "0x8C1B70", Offset = "0x8C0970", VA = "0x108C1B70")]
      private static void GetBonusStatus(
        SkillData groupSkill,
        ConceptCardData currentCardData,
        int levelCap,
        int awakeCountCap,
        int level,
        int awakeCount,
        ref BaseStatus bonusAdd,
        ref BaseStatus bonusScale,
        bool includeMaxPowerUp)
      {
      }
    }
  }
}
