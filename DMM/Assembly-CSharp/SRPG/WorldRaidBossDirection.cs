// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidBossDirection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D49")]
  [AddComponentMenu("UI/WorldRaid/WorldRaidBossDirection")]
  public class WorldRaidBossDirection : MonoBehaviour
  {
    [Token(Token = "0x400E1C0")]
    [FieldOffset(Offset = "0xC")]
    private UnitParam mBossUnitParam;

    [Token(Token = "0x600D304")]
    [Address(RVA = "0x9E2310", Offset = "0x9E1110", VA = "0x109E2310")]
    private void Start()
    {
    }

    [Token(Token = "0x600D305")]
    [Address(RVA = "0x9E21D0", Offset = "0x9E0FD0", VA = "0x109E21D0")]
    private void SetUnitData(
      WorldRaidNoticeData _data,
      WorldRaidParam.BossInfo _boss_info,
      int _index)
    {
    }

    [Token(Token = "0x600D306")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public WorldRaidBossDirection()
    {
    }
  }
}
