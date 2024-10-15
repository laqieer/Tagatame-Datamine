// Decompiled with JetBrains decompiler
// Type: SRPG.UsageRateRankingItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D31")]
  [AddComponentMenu("UI/UsageRateRankingItem")]
  public class UsageRateRankingItem : MonoBehaviour
  {
    [Token(Token = "0x400E143")]
    [FieldOffset(Offset = "0xC")]
    public Text rank;
    [Token(Token = "0x400E144")]
    [FieldOffset(Offset = "0x10")]
    public Text unit_name;
    [Token(Token = "0x400E145")]
    [FieldOffset(Offset = "0x14")]
    public ImageArray RankIconArray;
    [Token(Token = "0x400E146")]
    [FieldOffset(Offset = "0x18")]
    public RawImage_Transparent JobIcon;

    [Token(Token = "0x600D292")]
    [Address(RVA = "0x9DA140", Offset = "0x9D8F40", VA = "0x109DA140")]
    public void Refresh(int rank_num, RankingUnitData data)
    {
    }

    [Token(Token = "0x600D293")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UsageRateRankingItem()
    {
    }
  }
}
