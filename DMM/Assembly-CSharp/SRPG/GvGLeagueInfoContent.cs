// Decompiled with JetBrains decompiler
// Type: SRPG.GvGLeagueInfoContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025D5")]
  [AddComponentMenu("UI/GvG/GvGLeagueInfoContent")]
  public class GvGLeagueInfoContent : MonoBehaviour
  {
    [Token(Token = "0x400AFA4")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Image mRankIcon;
    [Token(Token = "0x400AFA5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Image mRankName;
    [Token(Token = "0x400AFA6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Image mRankBG;
    [Token(Token = "0x400AFA7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mMinRateText;
    [Token(Token = "0x400AFA8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mMaxRateText;
    [Token(Token = "0x400AFA9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mSelfLeague;
    [Token(Token = "0x400AFAA")]
    [FieldOffset(Offset = "0x24")]
    private GvGLeagueParam mGvGLeagueParam;

    [Token(Token = "0x600A82A")]
    [Address(RVA = "0x6B5460", Offset = "0x6B4260", VA = "0x106B5460")]
    public bool Setup(GvGLeagueParam param) => new bool();

    [Token(Token = "0x600A82B")]
    [Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")]
    public GvGLeagueParam GetGvGLeagueParam() => (GvGLeagueParam) null;

    [Token(Token = "0x600A82C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GvGLeagueInfoContent()
    {
    }
  }
}
