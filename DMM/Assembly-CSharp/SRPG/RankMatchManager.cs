// Decompiled with JetBrains decompiler
// Type: SRPG.RankMatchManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002919")]
  public class RankMatchManager : MonoBehaviour
  {
    [Token(Token = "0x400C5F3")]
    [FieldOffset(Offset = "0x0")]
    private static RankMatchManager mInstance;

    [Token(Token = "0x17001966")]
    public static RankMatchManager Instance
    {
      [Token(Token = "0x600B9FE"), Address(RVA = "0x810680", Offset = "0x80F480", VA = "0x10810680")] get
      {
        return (RankMatchManager) null;
      }
    }

    [Token(Token = "0x600B9FF")]
    [Address(RVA = "0x80F8E0", Offset = "0x80E6E0", VA = "0x1080F8E0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BA00")]
    [Address(RVA = "0x810640", Offset = "0x80F440", VA = "0x10810640")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BA01")]
    [Address(RVA = "0x810460", Offset = "0x80F260", VA = "0x10810460")]
    public string GetUnitCond() => (string) null;

    [Token(Token = "0x600BA02")]
    [Address(RVA = "0x810440", Offset = "0x80F240", VA = "0x10810440")]
    public VersusEnableTimeScheduleParam GetNowSchedule() => (VersusEnableTimeScheduleParam) null;

    [Token(Token = "0x600BA03")]
    [Address(RVA = "0x80F920", Offset = "0x80E720", VA = "0x1080F920")]
    public VersusEnableTimeScheduleParam GetNowSchedule(out bool IsNextDay)
    {
      return (VersusEnableTimeScheduleParam) null;
    }

    [Token(Token = "0x600BA04")]
    [Address(RVA = "0x8105F0", Offset = "0x80F3F0", VA = "0x108105F0")]
    public bool IsUnitCond(UnitData unit) => new bool();

    [Token(Token = "0x600BA05")]
    [Address(RVA = "0x810620", Offset = "0x80F420", VA = "0x10810620")]
    public bool IsUnitLimit() => new bool();

    [Token(Token = "0x600BA06")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RankMatchManager()
    {
    }
  }
}
