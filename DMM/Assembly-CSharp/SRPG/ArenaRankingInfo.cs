// Decompiled with JetBrains decompiler
// Type: SRPG.ArenaRankingInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FDA")]
  [AddComponentMenu("UI/ArenaRankingInfo")]
  public class ArenaRankingInfo : MonoBehaviour
  {
    [Token(Token = "0x400870B")]
    [FieldOffset(Offset = "0xC")]
    [Space(10f)]
    public Text Ranking;
    [Token(Token = "0x400870C")]
    [FieldOffset(Offset = "0x10")]
    public Text PlayerName;
    [Token(Token = "0x400870D")]
    [FieldOffset(Offset = "0x14")]
    public Text PlayerKOs;
    [Token(Token = "0x400870E")]
    [FieldOffset(Offset = "0x18")]
    public ImageArray ranking_image;

    [Token(Token = "0x600832D")]
    [Address(RVA = "0x439D00", Offset = "0x438B00", VA = "0x10439D00")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600832E")]
    [Address(RVA = "0x439D10", Offset = "0x438B10", VA = "0x10439D10")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600832F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArenaRankingInfo()
    {
    }
  }
}
