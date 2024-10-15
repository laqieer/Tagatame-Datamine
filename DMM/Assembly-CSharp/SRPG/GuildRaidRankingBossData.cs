// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidRankingBossData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002588")]
  [AddComponentMenu("UI/GuildRaid/GuildRaidRankingBossData")]
  public class GuildRaidRankingBossData : MonoBehaviour
  {
    [Token(Token = "0x400ADF8")]
    [FieldOffset(Offset = "0xC")]
    public GameObject templte;
    [Token(Token = "0x400ADF9")]
    [FieldOffset(Offset = "0x10")]
    public UnitIcon mIcon;
    [Token(Token = "0x400ADFA")]
    [FieldOffset(Offset = "0x14")]
    public Text mRank;

    [Token(Token = "0x600A6C5")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildRaidRankingBossData()
    {
    }
  }
}
