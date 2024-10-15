// Decompiled with JetBrains decompiler
// Type: SRPG.SupportRankingUnitList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B0F")]
  [AddComponentMenu("UI/SupportRankingUnitList")]
  public class SupportRankingUnitList : MonoBehaviour
  {
    [Token(Token = "0x400D21B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ImageArray mRankImage;
    [Token(Token = "0x400D21C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mRankText;
    [Token(Token = "0x400D21D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mName;
    [Token(Token = "0x400D21E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mScore;
    [Token(Token = "0x400D21F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RawImage_Transparent mJobIcon;
    [Token(Token = "0x400D220")]
    private const int DEFAULT_RANKING_NOTEXT = 3;

    [Token(Token = "0x600C515")]
    [Address(RVA = "0x8DAEF0", Offset = "0x8D9CF0", VA = "0x108DAEF0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C516")]
    [Address(RVA = "0x8DAF00", Offset = "0x8D9D00", VA = "0x108DAF00")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C517")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public SupportRankingUnitList()
    {
    }
  }
}
