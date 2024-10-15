// Decompiled with JetBrains decompiler
// Type: SRPG.BuffEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E75")]
  [MessagePackObject(true)]
  public class BuffEffect
  {
    [Token(Token = "0x4002C39")]
    [FieldOffset(Offset = "0x8")]
    public BuffEffectParam param;
    [Token(Token = "0x4002C3A")]
    [FieldOffset(Offset = "0xC")]
    public List<BuffEffect.BuffTarget> targets;
    [Token(Token = "0x4002C3B")]
    [FieldOffset(Offset = "0x10")]
    public bool isDeadRemove;

    [Token(Token = "0x1700047F")]
    [IgnoreMember]
    public BuffEffect.BuffTarget this[ParamTypes type]
    {
      [Token(Token = "0x6003BE9"), Address(RVA = "0x10E7970", Offset = "0x10E6770", VA = "0x110E7970")] get
      {
        return (BuffEffect.BuffTarget) null;
      }
    }

    [Token(Token = "0x6003BEA")]
    [Address(RVA = "0x10E2C00", Offset = "0x10E1A00", VA = "0x110E2C00")]
    public static BuffEffect CreateBuffEffect(
      BuffEffectParam param,
      int rank,
      int rankcap,
      bool isDeadRemove = false)
    {
      return (BuffEffect) null;
    }

    [Token(Token = "0x6003BEB")]
    [Address(RVA = "0x10E74A0", Offset = "0x10E62A0", VA = "0x110E74A0")]
    public void UpdateCurrentValues(int rank, int rankcap)
    {
    }

    [Token(Token = "0x6003BEC")]
    [Address(RVA = "0x36F540", Offset = "0x36E340", VA = "0x1036F540")]
    public static int GetRankValue(int rank, int rankcap, int ini, int max) => new int();

    [Token(Token = "0x6003BED")]
    [Address(RVA = "0xAFFC90", Offset = "0xAFEA90", VA = "0x10AFFC90")]
    private void Clear()
    {
    }

    [Token(Token = "0x6003BEE")]
    [Address(RVA = "0x10E2650", Offset = "0x10E1450", VA = "0x110E2650")]
    public bool CheckBuffCalcType(BuffTypes buff, SkillParamCalcTypes calc) => new bool();

    [Token(Token = "0x6003BEF")]
    [Address(RVA = "0x10E25B0", Offset = "0x10E13B0", VA = "0x110E25B0")]
    public bool CheckBuffCalcType(
      BuffTypes buff,
      SkillParamCalcTypes calc,
      bool is_negative_value_is_buff)
    {
      return new bool();
    }

    [Token(Token = "0x6003BF0")]
    [Address(RVA = "0x10E2700", Offset = "0x10E1500", VA = "0x110E2700")]
    public bool CheckEnableBuffTarget(Unit target, bool force_custom_targets_check = false)
    {
      return new bool();
    }

    [Token(Token = "0x6003BF1")]
    [Address(RVA = "0x10E2F70", Offset = "0x10E1D70", VA = "0x110E2F70")]
    private BuffMethodTypes GetBuffMethodType(BuffTypes buff, SkillParamCalcTypes calc)
    {
      return new BuffMethodTypes();
    }

    [Token(Token = "0x6003BF2")]
    [Address(RVA = "0x10E4E60", Offset = "0x10E3C60", VA = "0x110E4E60")]
    private static void SetBuffValue(BuffMethodTypes type, ref int param, int value)
    {
    }

    [Token(Token = "0x6003BF3")]
    [Address(RVA = "0x10E4EA0", Offset = "0x10E3CA0", VA = "0x110E4EA0")]
    private static void SetBuffValue(BuffMethodTypes type, ref OShort param, int value)
    {
    }

    [Token(Token = "0x6003BF4")]
    [Address(RVA = "0x10E4E10", Offset = "0x10E3C10", VA = "0x110E4E10")]
    private static void SetBuffValue(BuffMethodTypes type, ref short param, int value)
    {
    }

    [Token(Token = "0x6003BF5")]
    [Address(RVA = "0x10E4F80", Offset = "0x10E3D80", VA = "0x110E4F80")]
    private static void SetBuffValue(
      BuffMethodTypes type,
      ref TokkouParam param,
      int value,
      string tag)
    {
    }

    [Token(Token = "0x6003BF6")]
    [Address(RVA = "0x10E4D00", Offset = "0x10E3B00", VA = "0x110E4D00")]
    private static int GetTokkouBuffValue(TokkouParam param, string tag) => new int();

    [Token(Token = "0x6003BF7")]
    [Address(RVA = "0x10E7420", Offset = "0x10E6220", VA = "0x110E7420")]
    public static void SetDrawBuffValues(
      ParamTypes param_type,
      BuffMethodTypes method_type,
      ref DrawBaseStatus draw_status,
      int value)
    {
    }

    [Token(Token = "0x6003BF8")]
    [Address(RVA = "0x10E5070", Offset = "0x10E3E70", VA = "0x110E5070")]
    public static void SetBuffValues(
      ParamTypes param_type,
      BuffMethodTypes method_type,
      ref BaseStatus status,
      int value,
      string tag = null)
    {
    }

    [Token(Token = "0x6003BF9")]
    [Address(RVA = "0x10E2F90", Offset = "0x10E1D90", VA = "0x110E2F90")]
    public static int GetBuffValues(ParamTypes param_type, BaseStatus status, string tag = null)
    {
      return new int();
    }

    [Token(Token = "0x6003BFA")]
    [Address(RVA = "0x10E2300", Offset = "0x10E1100", VA = "0x110E2300")]
    public void CalcBuffStatus(
      ref BaseStatus status,
      EElement element,
      BuffTypes buffType,
      bool is_check_negative_value,
      bool is_negative_value_is_buff,
      SkillParamCalcTypes calcType,
      int up_count = 0,
      int coef = 10000,
      int coefDecreaseRate = 0)
    {
    }

    [Token(Token = "0x6003BFB")]
    [Address(RVA = "0x10E2CF0", Offset = "0x10E1AF0", VA = "0x110E2CF0")]
    public void GetBaseStatus(ref BaseStatus total_add, ref BaseStatus total_scale)
    {
    }

    [Token(Token = "0x6003BFC")]
    [Address(RVA = "0x10E4D40", Offset = "0x10E3B40", VA = "0x110E4D40")]
    public static bool IsElementBuff(ParamTypes paramType) => new bool();

    [Token(Token = "0x6003BFD")]
    [Address(RVA = "0x10E4D70", Offset = "0x10E3B70", VA = "0x110E4D70")]
    public static bool IsMatchElementBuff(EElement buffTargetElement, ParamTypes paramType)
    {
      return new bool();
    }

    [Token(Token = "0x6003BFE")]
    [Address(RVA = "0x10E2B20", Offset = "0x10E1920", VA = "0x110E2B20")]
    public static BaseStatus CreateBaseStatus(
      int value,
      ParamTypes paramType,
      BuffMethodTypes buffMethodType,
      EElement buffTargetElement = EElement.None,
      bool isDrawBaseStatus = false,
      string tag = null)
    {
      return (BaseStatus) null;
    }

    [Token(Token = "0x6003BFF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BuffEffect()
    {
    }

    [Token(Token = "0x2000E76")]
    [MessagePackObject(true)]
    public class BuffTarget
    {
      [Token(Token = "0x4002C3C")]
      [FieldOffset(Offset = "0x8")]
      public BuffTypes buffType;
      [Token(Token = "0x4002C3D")]
      [FieldOffset(Offset = "0x9")]
      public SkillParamCalcTypes calcType;
      [Token(Token = "0x4002C3E")]
      [FieldOffset(Offset = "0xA")]
      public ParamTypes paramType;
      [Token(Token = "0x4002C3F")]
      [FieldOffset(Offset = "0xC")]
      public OInt value;
      [Token(Token = "0x4002C40")]
      [FieldOffset(Offset = "0x20")]
      public OInt value_one;
      [Token(Token = "0x4002C41")]
      [FieldOffset(Offset = "0x34")]
      public OString tokkou;

      [Token(Token = "0x6003C00")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public BuffTarget()
      {
      }
    }

    [Token(Token = "0x2000E77")]
    [MessagePackObject(true)]
    public struct BuffValues
    {
      [Token(Token = "0x17000480")]
      public ParamTypes param_type
      {
        [Token(Token = "0x6003C01"), Address(RVA = "0x10E7A40", Offset = "0x10E6840", VA = "0x110E7A40")] readonly get
        {
          return new ParamTypes();
        }
        [Token(Token = "0x6003C02"), Address(RVA = "0x10E7A60", Offset = "0x10E6860", VA = "0x110E7A60")] set
        {
        }
      }

      [Token(Token = "0x17000481")]
      public BuffMethodTypes method_type
      {
        [Token(Token = "0x6003C03"), Address(RVA = "0x10E7A30", Offset = "0x10E6830", VA = "0x110E7A30")] readonly get
        {
          return new BuffMethodTypes();
        }
        [Token(Token = "0x6003C04"), Address(RVA = "0x10E7A50", Offset = "0x10E6850", VA = "0x110E7A50")] set
        {
        }
      }

      [Token(Token = "0x17000482")]
      public int value
      {
        [Token(Token = "0x6003C05"), Address(RVA = "0x28E4C0", Offset = "0x28D2C0", VA = "0x1028E4C0")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x6003C06"), Address(RVA = "0x2EC6B0", Offset = "0x2EB4B0", VA = "0x102EC6B0")] set
        {
        }
      }
    }
  }
}
